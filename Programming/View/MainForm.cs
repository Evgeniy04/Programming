using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

// With 10 point 5 lab
namespace Programming
{
    public partial class MainForm : Form
    {
        private List<Rectangle> _rectangles;
        private Rectangle _currentRectangle;
        private Movie[] _movies;
        private Movie _currentMovie;
        private Random _random;

        public MainForm()
        {
            InitializeComponent();
            _rectangles = new List<Rectangle>();
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
            IntValue.Text = "";
            ValuesListBox.Items.Clear();
            ValuesListBox.Items.AddRange(values);
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem == null) return;
            IntValue.Text = ((int)ValuesListBox.SelectedItem).ToString();
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

        private void ListBoxRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxRectangles.SelectedItem == null) return;
            _currentRectangle = _rectangles[ListBoxRectangles.SelectedIndex];

            TextBoxLengthRectangle.Text = _currentRectangle.Length.ToString();
            TextBoxWidthRectangle.Text = _currentRectangle.Width.ToString();
            TextBoxColorRectangle.Text = _currentRectangle.Color.ToString();
            TextBoxCenterCoordinateXRectangle.Text = _currentRectangle.Center.X.ToString();
            TextBoxCenterCoordinateYRectangle.Text = _currentRectangle.Center.Y.ToString();
            TextBoxIdRectangle.Text = _currentRectangle.Id.ToString();
        }
        private void TextBoxLengthRectangle_TextChanged(object sender, EventArgs e)
        {
            TextBoxLengthRectangleHandler(TextBoxLengthRectangle);
        }
        private void TextBoxWidthRectangle_TextChanged(object sender, EventArgs e)
        {
            TextBoxWidthRectangleHandler(TextBoxWidthRectangle);
        }

        private void TextBoxHeightSelectedRectangle_TextChanged(object sender, EventArgs e)
        {
            TextBoxLengthRectangleHandler(TextBoxHeightSelectedRectangle);
        }
        private void TextBoxWidthSelectedRectangle_TextChanged(object sender, EventArgs e)
        {
            TextBoxWidthRectangleHandler(TextBoxWidthSelectedRectangle);
        }

        private void TextBoxColorRectangle_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return; 
            if (CustomMethods.TryGetEnumValue<Color>(TextBoxColorRectangle.Text, out Color value))
            {
                _currentRectangle.Color = value;
                TextBoxColorRectangle.BackColor = System.Drawing.Color.White;
            }
            else
            {
                TextBoxColorRectangle.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void ButtonFindRectangleWithMaxWidth_Click(object sender, EventArgs e)
        {
            ListBoxRectangles.SelectedIndex = FindItemWithMaxValue(_rectangles, (rectangle) => rectangle.Width);
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
            Rectangle rectangle;
            double length = Math.Ceiling(_random.NextDouble() * 100);
            double width = Math.Ceiling(_random.NextDouble() * 100);
            rectangle = new Rectangle(length, width, Color.Orange, new Point2D(_random.Next(0, 200), _random.Next(0, 200)));
            UpdateRectangles(rectangle);
        }
        private void ButtonRemoveRectangle_Click(object sender, EventArgs e)
        {
            if (ListBoxRectanglesCollision.SelectedItem == null) return;
            Match match = Regex.Match(ListBoxRectanglesCollision.SelectedItem.ToString(), @"^(\d+):");
            if (match.Success)
            {
                string numberString = match.Groups[1].Value;
                int id = int.Parse(numberString);
                Rectangle rectangle = _rectangles.Find((a) => a.Id == id);
                UpdateRectangles(ListBoxRectanglesCollision.SelectedItem.ToString(), rectangle);

                TextBoxIdSelectedRectangle.Clear();
                TextBoxXSelectedRectangle.Clear();
                TextBoxYSelectedRectangle.Clear();
                TextBoxWidthSelectedRectangle.Clear();
                TextBoxHeightSelectedRectangle.Clear();
            }
            else
            {
                MessageBox.Show("Прямоугольник не найден!");
            }
        }
        private void ListBoxRectanglesCollision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxRectanglesCollision.SelectedItem == null) return;
            Match match = Regex.Match(ListBoxRectanglesCollision.SelectedItem.ToString(), @"^(\d+):");
            if (match.Success)
            {
                string numberString = match.Groups[1].Value;
                int id = int.Parse(numberString);
                Rectangle rectangle = _rectangles.Find((a) => a.Id == id);
                _currentRectangle = rectangle;
                TextBoxIdSelectedRectangle.Text = _currentRectangle.Id.ToString();
                TextBoxXSelectedRectangle.Text = _currentRectangle.Center.X.ToString();
                TextBoxYSelectedRectangle.Text = _currentRectangle.Center.Y.ToString();
                TextBoxWidthSelectedRectangle.Text = _currentRectangle.Width.ToString();
                TextBoxHeightSelectedRectangle.Text = _currentRectangle.Length.ToString();
            }
            else
            {
                MessageBox.Show("Прямоугольник не найден!");
            }
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

        // Prevent characters from being typed into the control.
        private void TextBoxCenterCoordinateXRectangle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void TextBoxCenterCoordinateYRectangle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= true;
        }
        private void IntValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void TextBoxIdRectangle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void TextBoxIdSelectedRectangle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Add rectangle
        /// </summary>
        /// <param name="rectangle">Instance rectangle</param>
        private void UpdateRectangles(Rectangle rectangle)
        {
            _rectangles.Add(rectangle);
            ListBoxRectangles.Items.Add(rectangle);
            ListBoxRectanglesCollision.Items.Add($"{rectangle.Id}: (X={rectangle.Center.X}; Y={rectangle.Center.Y}; W={rectangle.Width}; H={rectangle.Length})");
        }
        /// <summary>
        /// Remove rectangle
        /// </summary>
        /// <param name="selectedItem">String with coordinates</param>
        /// <param name="rectangle">Instance rectangle</param>
        private void UpdateRectangles(string selectedItem, Rectangle rectangle)
        {
            _rectangles.Remove(rectangle);
            ListBoxRectangles.Items.Remove(rectangle);
            ListBoxRectanglesCollision.Items.Remove(selectedItem);
        }
        private void TextBoxLengthRectangleHandler(TextBox textBox)
        {
            if (_currentRectangle == null) return;
            try
            {
                double length = double.Parse(textBox.Text);
                _currentRectangle.Length = length;
                textBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void TextBoxWidthRectangleHandler(TextBox textBox)
        {
            if (_currentRectangle == null) return;
            try
            {
                double width = double.Parse(textBox.Text);
                _currentRectangle.Width = width;
                textBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void TextBoxXSelectedRectangle_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;
            try
            {
                double x = double.Parse(TextBoxXSelectedRectangle.Text);
                _currentRectangle.Center = new Point2D(x, _currentRectangle.Center.Y);
                TextBoxXSelectedRectangle.BackColor = System.Drawing.Color.White;
            } catch (Exception)
            {
                TextBoxXSelectedRectangle.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void TextBoxYSelectedRectangle_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;
            try
            {
                double y = double.Parse(TextBoxYSelectedRectangle.Text);
                _currentRectangle.Center = new Point2D(_currentRectangle.Center.X, y);
                TextBoxYSelectedRectangle.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                TextBoxYSelectedRectangle.BackColor = System.Drawing.Color.LightPink;
            }
        }
    }
}
