using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

// With 15 point
namespace Programming
{
    public partial class MainForm : Form
    {
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle;
        private Movie[] _movies;
        private Movie _currentMovie;

        public MainForm()
        {
            InitializeComponent();

            Random random = new Random();

            // 
            // Initialize ComboBoxSeasons
            // 
            object[] values = Enum.GetValues(typeof(Season)).Cast<object>().ToArray();
            ComboBoxSeasons.Items.AddRange(values);

            // 
            // Initialize _rectangles
            //
            _rectangles = new Rectangle[5];
            string[] listBoxRectanglesItems = new string[5];
            for (int i = 0; i < 5; i++)
            {
                double length = Math.Ceiling(random.NextDouble() * 100);
                double width = Math.Ceiling(random.NextDouble() * 100);
                Rectangle rectangle = new Rectangle(length, width, Color.Orange);
                _rectangles[i] = rectangle;
                listBoxRectanglesItems[i] = ($"Rectangle {i + 1}");
            }
            //
            // Initialize ListBoxRectangles
            //
            ListBoxRectangles.Items.AddRange(listBoxRectanglesItems);

            // 
            // Initialize _movies
            //
            _movies = new Movie[5];
            string[] listBoxMoviesItems = new string[5];
            string[] movieTitles = new string[5] { "Первый", "Второй", "Третий", "Четвёртый", "Пятый" };
            for (int i = 0; i < 5; i++)
            {
                int durationMinutes = random.Next(1, 280);
                int releaseYear = random.Next(1950, DateTime.Now.Year + 1);
                double rating = Math.Round(random.NextDouble() * 10, 1);
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
                    SetBackColor(GroupBoxSeasonHandle.BackColor = ColorTranslator.FromHtml("#e29c45"));
                    break;
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Spring:
                    SetBackColor(GroupBoxSeasonHandle.BackColor = ColorTranslator.FromHtml("#559c45"));
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
            if (_currentRectangle == null) return; 
            try
            {
                double length = double.Parse(TextBoxLengthRectangle.Text);
                _currentRectangle.Length = length;
                TextBoxLengthRectangle.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                TextBoxLengthRectangle.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void TextBoxWidthRectangle_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;
            try
            {
                double width = double.Parse(TextBoxWidthRectangle.Text);
                _currentRectangle.Width = width;
                TextBoxWidthRectangle.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                TextBoxWidthRectangle.BackColor = System.Drawing.Color.LightPink;
            }
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

        private void SetBackColor(System.Drawing.Color color)
        {
            GroupBoxEnumerations.BackColor = color;
            GroupBoxWeekdayParsing.BackColor = color;
            GroupBoxSeasonHandle.BackColor = color;
            this.BackColor = color;
        }

        private int FindItemWithMaxValue<T>(T[] classArray, Func<T, double> getValue) where T : class
        {
            if (classArray.Length < 1) throw new ArgumentException("The array must contain at least one element.");

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
    }
}
