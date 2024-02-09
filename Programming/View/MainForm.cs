using Programming.Model;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// With 15 point
namespace Programming
{
    public partial class MainForm : Form
    {
        private readonly Type[] _typeModel = new Type[] { typeof(Model.Color), typeof(EducationForm),
                                                typeof(Genre), typeof(Manufactures),
                                                typeof(Season), typeof(Weekday) };
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle;
        private Movie[] _movies;
        private Movie _currentMovie;
        private readonly CustomMethods _customMethods = new CustomMethods();

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
                Rectangle rectangle = new Rectangle(length, width, Model.Color.Orange);
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
            int selectedIndex = EnumsListBox.SelectedIndex;
            object[] values = Enum.GetValues(_typeModel[selectedIndex]).Cast<object>().ToArray();
            IntValue.Text = "";
            ValuesListBox.Items.Clear();
            ValuesListBox.Items.AddRange(values);
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type selectedItemType = ValuesListBox.SelectedItem.GetType();
            string selectedItemName = ValuesListBox.SelectedItem.ToString();
            if (_customMethods.TryGetEnumValue(selectedItemType, selectedItemName, out object value))
            {
                IntValue.Text = Convert.ToInt32(value).ToString();
            }
        }

        private void ButtonWeekdayParsing_Click(object sender, EventArgs e)
        {
            string selectedItemName = TextBoxDayInput.Text;
            if (_customMethods.TryGetEnumValue<Weekday>(selectedItemName, out Weekday value))
            {
                LabelResultWeekdayParsing.Text = $"Это день недели ({value} = {Convert.ToInt32(value)})";
            } else
            {
                LabelResultWeekdayParsing.Text = $"Это не день недели";
            }
        }

        private void ButtonSeasonHandleGo_Click(object sender, EventArgs e)
        {
            
            if (ComboBoxSeasons.SelectedItem != null)
            {
                ComboBoxSeasons.BackColor = System.Drawing.Color.White;
                switch (ComboBoxSeasons.SelectedItem.ToString())
                {
                    case "Summer":
                        MessageBox.Show("Ура! Солнце!");
                        break;
                    case "Autumn":
                        SetBackColor(GroupBoxSeasonHandle.BackColor = ColorTranslator.FromHtml("#e29c45"));
                        break;
                    case "Winter":
                        MessageBox.Show("Бррр! Холодно!");
                        break;
                    case "Spring":
                        SetBackColor(GroupBoxSeasonHandle.BackColor = ColorTranslator.FromHtml("#559c45"));
                        break;
                }
            } else
            {
                ComboBoxSeasons.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ListBoxRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[ListBoxRectangles.SelectedIndex];

            TextBoxLengthRectangle.Text = _currentRectangle.Length.ToString();
            TextBoxWidthRectangle.Text = _currentRectangle.Width.ToString();
            TextBoxColorRectangle.Text = _currentRectangle.Color.ToString();
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
            if (_customMethods.TryGetEnumValue<Model.Color>(TextBoxColorRectangle.Text, out Model.Color value))
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
            ListBoxRectangles.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void ListBoxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            if (_customMethods.TryGetEnumValue<Genre>(genre, out Genre value))
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
            ListBoxMovies.SelectedIndex = FindMovieWithMaxRating(_movies);
        }

        private void SetBackColor(System.Drawing.Color color)
        {
            GroupBoxEnumerations.BackColor = color;
            GroupBoxWeekdayParsing.BackColor = color;
            GroupBoxSeasonHandle.BackColor = color;
            this.BackColor = color;
        }

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            if (rectangles.Length < 1) throw new ArgumentException("The array must contain at least one element.");

            int index = 0;
            double maxWidth = rectangles[0].Width;
            for (int i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    index = i;
                }
            }
            return index;
        }
        private int FindMovieWithMaxRating(Movie[] movies)
        {
            if (movies.Length < 1) throw new ArgumentException("The array must contain at least one element.");

            int index = 0;
            double maxRating = movies[0].Rating;
            for (int i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rating > maxRating)
                {
                    maxRating = movies[i].Rating;
                    index = i;
                }
            }
            return index;
        }
    }
}
