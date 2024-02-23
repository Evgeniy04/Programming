using Programming.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

// With 30 point 5 lab, question
namespace Programming
{
    public partial class MainForm : Form
    {
        private bool _isProgrammaticChange = false;
        List<int> _intersectingRectangleIndices = new List<int>();
        private List<Rectangle> _rectangles;
        private Rectangle _currentRectangle;
        private List<Panel> _rectanglePanels;
        private Movie[] _movies;
        private Movie _currentMovie;
        private Random _random;

        public MainForm()
        {
            InitializeComponent();
            CustomMethods.TextBoxClassesRectangles = new TextBox[6] {   TextBoxClassesRectanglesId, 
                                                                        TextBoxClassesRectanglesColor,
                                                                        TextBoxClassesRectanglesWidth,
                                                                        TextBoxClassesRectanglesLength,
                                                                        TextBoxClassesRectanglesCoordinateX, 
                                                                        TextBoxClassesRectanglesCoordinateY };
            CustomMethods.TextBoxRectangles = new TextBox[5] {  TextBoxRectanglesId,
                                                                TextBoxRectanglesWidth,
                                                                TextBoxRectanglesHeight,
                                                                TextBoxRectanglesX,
                                                                TextBoxRectanglesY };

            _rectangles = new List<Rectangle>();
            _rectanglePanels = new List<Panel>();
            _random = new Random();

            // 
            // Initialize ComboBoxSeasons
            // 
            object[] values = Enum.GetValues(typeof(Season)).Cast<object>().ToArray();
            ComboBoxSeasons.Items.AddRange(values);

            // 
            // Initialize _movies
            //
            _movies = new Movie[5];
            string[] listBoxMoviesItems = new string[5];
            string[] movieTitles = new string[5] { "Первый", "Второй", "Третий", "Четвёртый", "Пятый" };
            for (int i = 0; i < 5; i++)
            {
                int durationMinutes = _random.Next(1, 280);
                int releaseYear = _random.Next(1950, DateTime.Now.Year + 1);
                double rating = Math.Round(_random.NextDouble() * 10, 1);
                Movie movie = new Movie(movieTitles[i], durationMinutes, releaseYear, Genre.Comedy, rating);
                _movies[i] = movie;
                listBoxMoviesItems[i] = ($"Movie {i + 1}");
            }
            //
            // Initialize ListBoxMovies
            //
            ListBoxMovies.Items.AddRange(listBoxMoviesItems);
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnumsListBox.SelectedIndex == -1) return;
            int selectedIndex = EnumsListBox.SelectedIndex;
            object[] values = Enum.GetValues(CustomMethods.TypeModel[selectedIndex]).Cast<object>().ToArray();
            TextBoxEnumsEnumerationsIntValue.Text = "";
            ValuesListBox.Items.Clear();
            ValuesListBox.Items.AddRange(values);
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem == null) return;
            TextBoxEnumsEnumerationsIntValue.Text = ((int)ValuesListBox.SelectedItem).ToString();
        }

        private void ButtonWeekdayParsing_Click(object sender, EventArgs e)
        {
            string selectedItemName = TextBoxDayInput.Text;
            if (!int.TryParse(selectedItemName, out _) &&
                CustomMethods.TryGetEnumValue<Weekday>(selectedItemName, out Weekday value))
            {
                LabelResultWeekdayParsing.Text = $"Это день недели ({value} = {(int)value})";
            } else
            {
                LabelResultWeekdayParsing.Text = $"Это не день недели";
            }
        }

        private void ButtonSeasonHandleGo_Click(object sender, EventArgs e)
        {
            if (ComboBoxSeasons.SelectedItem == null)
            {
                ComboBoxSeasons.BackColor = System.Drawing.Color.LightPink;
                return;
            }

            ComboBoxSeasons.BackColor = System.Drawing.Color.White;
            switch (ComboBoxSeasons.SelectedItem)
            {
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    SetBackColor(ColorTranslator.FromHtml("#e29c45"));
                    break;
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Spring:
                    SetBackColor(ColorTranslator.FromHtml("#559c45"));
                    break;
            }
        }

        private void ListBoxClassesRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxClassesRectangles.SelectedItem == null) return;
            _currentRectangle = (Rectangle)ListBoxClassesRectangles.SelectedItem;
            UpdateRectangleInfo(_currentRectangle, ListBoxClassesRectangles.SelectedIndex);
        }

        private void TextBoxClassesRectanglesColor_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;
            if (CustomMethods.TryGetEnumValue<Color>(TextBoxClassesRectanglesColor.Text, out Color value))
            {
                _currentRectangle.Color = value;
                TextBoxClassesRectanglesColor.BackColor = System.Drawing.Color.White;
            }
            else
            {
                TextBoxClassesRectanglesColor.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void TextBoxClassesRectanglesLength_TextChanged(object sender, EventArgs e)
        {
            TextBoxSizeRectangleHandler(TextBoxClassesRectanglesLength, "length");
        }
        private void TextBoxClassesRectanglesWidth_TextChanged(object sender, EventArgs e)
        {
            TextBoxSizeRectangleHandler(TextBoxClassesRectanglesWidth, "width");
        }
        private void TextBoxRectanglesX_TextChanged(object sender, EventArgs e)
        {
            TextBoxCoordinatesHandler(TextBoxRectanglesX, "x");
        }
        private void TextBoxRectanglesY_TextChanged(object sender, EventArgs e)
        {
            TextBoxCoordinatesHandler(TextBoxRectanglesY, "y");
        }
        private void TextBoxRectanglesWidth_TextChanged(object sender, EventArgs e)
        {
            TextBoxSizeRectangleHandler(TextBoxRectanglesWidth, "width");
        }
        private void TextBoxRectanglesHeight_TextChanged(object sender, EventArgs e)
        {
            TextBoxSizeRectangleHandler(TextBoxRectanglesHeight, "length");
        }

        private void ButtonFindRectangleWithMaxWidth_Click(object sender, EventArgs e)
        {
            ListBoxClassesRectangles.SelectedIndex = FindItemWithMaxValue(_rectangles, (rectangle) => rectangle.Width);
        }

        private void ListBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxMovies.SelectedIndex == -1) return;
            _currentMovie = _movies[ListBoxMovies.SelectedIndex];

            TextBoxTitleMovie.Text = _currentMovie.Title;
            TextBoxDurationMinutesMovie.Text = _currentMovie.DurationMinutes.ToString();
            TextBoxReleaseYearMovie.Text = _currentMovie.ReleaseYear.ToString();
            TextBoxGenreMovie.Text = _currentMovie.Genre.ToString();
            TextBoxRatingMovie.Text = _currentMovie.Rating.ToString();
        }
        private void TextBoxTitleMovie_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            try
            {
                _currentMovie.Title = TextBoxTitleMovie.Text;
                TextBoxTitleMovie.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                TextBoxTitleMovie.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void TextBoxDurationMinutesMovie_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            try
            {
                int durationMinutes = int.Parse(TextBoxDurationMinutesMovie.Text);
                _currentMovie.DurationMinutes = durationMinutes;
                TextBoxDurationMinutesMovie.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                TextBoxDurationMinutesMovie.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void TextBoxReleaseYearMovie_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            try
            {
                int releaseYear = int.Parse(TextBoxReleaseYearMovie.Text);
                _currentMovie.ReleaseYear = releaseYear;
                TextBoxReleaseYearMovie.BackColor = System.Drawing.Color.White;
            } catch (Exception)
            {
                TextBoxReleaseYearMovie.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void TextBoxGenreMovie_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            string genre = TextBoxGenreMovie.Text;
            if (CustomMethods.TryGetEnumValue<Genre>(genre, out Genre value))
            {
                _currentMovie.Genre = value;
                TextBoxGenreMovie.BackColor = System.Drawing.Color.White;
            }
            else
            {
                TextBoxGenreMovie.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void TextBoxRatingMovie_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            try
            {
                double rating = double.Parse(TextBoxRatingMovie.Text);
                _currentMovie.Rating = rating;
                TextBoxRatingMovie.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                TextBoxRatingMovie.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void ButtonFindMovieWithMaxRating_Click(object sender, EventArgs e)
        {
            ListBoxMovies.SelectedIndex = FindItemWithMaxValue(_movies, (movie) => movie.Rating);
        }

        private void ButtonAddRectangle_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = RectangleFactory.Randomize(PanelRectangles, 150, 150);
            _rectangles.Add(rectangle);
            ListBoxClassesRectangles.Items.Add(rectangle);
            ListBoxRectangles.Items.Add(rectangle);
            Panel panel = InitialPanel(rectangle);
            panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            _rectanglePanels.Add(panel);
            PanelRectangles.Controls.Add(panel);
            FindCollisions(rectangle);
        }

        private void ButtonRemoveRectangle_Click(object sender, EventArgs e)
        {
            if (ListBoxRectangles.SelectedItem == null && ListBoxRectangles.SelectedIndex == -1) return;
            Rectangle rectangle = (Rectangle)ListBoxRectangles.SelectedItem;
            int selectedIndex = ListBoxRectangles.SelectedIndex;
            _rectangles.Remove(rectangle);
            ListBoxClassesRectangles.Items.Remove(rectangle);
            ListBoxRectangles.Items.Remove(rectangle);
            ClearRectangleInfo();
            _rectanglePanels.RemoveAt(selectedIndex);
            PanelRectangles.Controls.RemoveAt(selectedIndex);
            FindCollisions(rectangle);
        }
        private void ListBoxRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxRectangles.SelectedItem == null) return;
            _currentRectangle = (Rectangle)ListBoxRectangles.SelectedItem;
            UpdateRectangleInfo(_currentRectangle, ListBoxRectangles.SelectedIndex);
        }
        private void TextBoxDisable(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void SetBackColor(System.Drawing.Color color)
        {
            GroupBoxEnumerations.BackColor = color;
            GroupBoxWeekdayParsing.BackColor = color;
            GroupBoxSeasonHandle.BackColor = color;
            this.BackColor = color;
        }
        private int FindItemWithMaxValue<T>(List<T> classList, Func<T, double> getValue) where T : class
        {
            if (classList.Count < 1) return -1;

            int index = 0;
            double maxValue = getValue(classList[0]);
            for (int i = 0; i < classList.Count; i++)
            {
                if (getValue(classList[i]) > maxValue)
                {
                    maxValue = getValue(classList[i]);
                    index = i;
                }
            }
            return index;
        }
        private int FindItemWithMaxValue<T>(T[] classArray, Func<T, double> getValue) where T : class
        {
            if (classArray.Length < 1) return -1;

            int index = 0;
            double maxValue = getValue(classArray[0]);
            for (int i = 0; i < classArray.Length; i++)
            {
                if (getValue(classArray[i]) > maxValue)
                {
                    maxValue = getValue(classArray[i]);
                    index = i;
                }
            }
            return index;
        }

        /// <summary>
        /// Resizing a rectangle
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="dimensionType">"width" or "length"</param>
        private void TextBoxSizeRectangleHandler(TextBox textBox, string dimensionType)
        {
            if (_currentRectangle == null || _isProgrammaticChange) return;
            try
            {
                int value = int.Parse(textBox.Text);
                switch (dimensionType)
                {
                    case "width":
                        _currentRectangle.Width = value;
                        break;
                    case "length":
                        _currentRectangle.Height = value;
                        break;
                    default: throw new ArgumentException("Non-existent argument value.");
                }
                ListBoxSelectedRectangleUpdate();

                textBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        /// <summary>
        /// Moving a rectangle
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="coordinateType">"x" or "y"</param>
        private void TextBoxCoordinatesHandler(TextBox textBox, string coordinateType)
        {
            if (_currentRectangle == null || _isProgrammaticChange) return;
            try
            {
                int coordinate = int.Parse(textBox.Text);
                switch (coordinateType)
                {
                    case "x":
                        _currentRectangle.Coordinates = new Point2D(coordinate, _currentRectangle.Coordinates.Y);
                        break;
                    case "y":
                        _currentRectangle.Coordinates = new Point2D(_currentRectangle.Coordinates.X, coordinate);
                        break;
                    default: throw new ArgumentException("Non-existent argument value.");
                }
                ListBoxSelectedRectangleUpdate();
                textBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
}
        private void ListBoxSelectedRectangleUpdate()
        {
            int indexClassesRectangles = ListBoxClassesRectangles.Items.IndexOf(_currentRectangle);
            int indexRectangles = ListBoxRectangles.Items.IndexOf(_currentRectangle);
            ListBoxClassesRectangles.Items.RemoveAt(indexClassesRectangles);
            ListBoxClassesRectangles.Items.Insert(indexClassesRectangles, _currentRectangle);
            ListBoxClassesRectangles.SelectedIndex = indexClassesRectangles;
            ListBoxRectangles.Items.RemoveAt(indexRectangles);
            ListBoxRectangles.Items.Insert(indexRectangles, _currentRectangle);
            ListBoxRectangles.SelectedIndex = indexRectangles;
            Panel panel = InitialPanel(_currentRectangle);
            panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            _rectanglePanels[indexRectangles] = panel;
            PanelRectangles.Controls.Clear();
            PanelRectangles.Controls.AddRange(_rectanglePanels.ToArray());
            FindCollisions(_currentRectangle);
        }
        private void FindCollisions(Rectangle rectangle)
        {
            int[] intersectingRectangleIndices = _intersectingRectangleIndices.ToArray();
            // Проверяет, пересекаются ли ранее пересекающиеся прямоугольники, если нет - то делает их зелёными
            foreach (int j in intersectingRectangleIndices)
            {
                Rectangle thisRectangle = _rectangles[j];
                bool isRemove = true;
                for (int i = 0; i < _rectanglePanels.Count; i++)
                {
                    if (j != i && CollisionManager.IsCollision(thisRectangle, _rectangles[i]))
                    {
                        isRemove = false;
                    }
                }
                if (isRemove)
                {
                    _intersectingRectangleIndices.Remove(j);
                    _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
                }
            }
            int currentPanelId = -1;
            bool isCollision = false;
            // Проверяет, пересекается ли обновлённый прямоугольник с каким-либо другим
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                if (rectangle.Id == _rectangles[i].Id)
                {
                    currentPanelId = i;
                    continue;
                }
                if (CollisionManager.IsCollision(rectangle, _rectangles[i]))
                {
                    _intersectingRectangleIndices.Add(i);
                    _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                    isCollision = true;
                }
            }
            if (isCollision && currentPanelId != -1) _rectanglePanels[currentPanelId].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
        }
        private void UpdateRectangleInfo(Rectangle rectangle, int selectedIndex)
        {
            _isProgrammaticChange = true;
            TextBoxClassesRectanglesLength.Text = rectangle.Height.ToString();
            TextBoxClassesRectanglesWidth.Text = rectangle.Width.ToString();
            TextBoxClassesRectanglesColor.Text = rectangle.Color.ToString();
            TextBoxClassesRectanglesCoordinateX.Text = rectangle.Center.X.ToString();
            TextBoxClassesRectanglesCoordinateY.Text = rectangle.Center.Y.ToString();
            TextBoxClassesRectanglesId.Text = rectangle.Id.ToString();
            TextBoxRectanglesId.Text = rectangle.Id.ToString();
            TextBoxRectanglesX.Text = rectangle.Coordinates.X.ToString();
            TextBoxRectanglesY.Text = rectangle.Coordinates.Y.ToString();
            TextBoxRectanglesWidth.Text = rectangle.Width.ToString();
            TextBoxRectanglesHeight.Text = rectangle.Height.ToString();
            ListBoxClassesRectangles.SelectedIndex = selectedIndex;
            ListBoxRectangles.SelectedIndex = selectedIndex;
            _isProgrammaticChange = false;
        }
        private void ClearRectangleInfo()
        {
            foreach (TextBox tb in CustomMethods.TextBoxRectangles)
            {
                tb.Clear();
                tb.BackColor = System.Drawing.Color.White;
            }
            foreach (TextBox tb in CustomMethods.TextBoxClassesRectangles)
            {
                tb.Clear();
                tb.BackColor = System.Drawing.Color.White;
            }
        }
        private Panel InitialPanel(Rectangle rectangle)
        {
            Panel panel = new Panel();
            panel.Location = new Point((int)rectangle.Coordinates.X, (int)rectangle.Coordinates.Y);
            panel.Width = rectangle.Width;
            panel.Height = rectangle.Height;
            return panel;
        }
    }
}
