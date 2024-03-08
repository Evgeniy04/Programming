using System;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class MoviesControl : UserControl
    {
        private Movie[] _movies;
        private Movie _currentMovie;
        private Random _random = new Random();
        public MoviesControl()
        {
            InitializeComponent();
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
                TextBoxTitleMovie.BackColor = AppColors.Default;
            }
            catch (Exception)
            {
                TextBoxTitleMovie.BackColor = AppColors.Invalid;
            }
        }
        private void TextBoxDurationMinutesMovie_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            try
            {
                int durationMinutes = int.Parse(TextBoxDurationMinutesMovie.Text);
                _currentMovie.DurationMinutes = durationMinutes;
                TextBoxDurationMinutesMovie.BackColor = AppColors.Default;
            }
            catch (Exception)
            {
                TextBoxDurationMinutesMovie.BackColor = AppColors.Invalid;
            }
        }
        private void TextBoxReleaseYearMovie_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            try
            {
                int releaseYear = int.Parse(TextBoxReleaseYearMovie.Text);
                _currentMovie.ReleaseYear = releaseYear;
                TextBoxReleaseYearMovie.BackColor = AppColors.Default;
            }
            catch (Exception)
            {
                TextBoxReleaseYearMovie.BackColor = AppColors.Invalid;
            }
        }
        private void TextBoxGenreMovie_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            string genre = TextBoxGenreMovie.Text;
            if (CustomMethods.TryGetEnumValue<Genre>(genre, out Genre value))
            {
                _currentMovie.Genre = value;
                TextBoxGenreMovie.BackColor = AppColors.Default;
            }
            else
            {
                TextBoxGenreMovie.BackColor = AppColors.Invalid;
            }
        }
        private void TextBoxRatingMovie_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie == null) return;
            try
            {
                double rating = double.Parse(TextBoxRatingMovie.Text);
                _currentMovie.Rating = rating;
                TextBoxRatingMovie.BackColor = AppColors.Default;
            }
            catch (Exception)
            {
                TextBoxRatingMovie.BackColor = AppColors.Invalid;
            }
        }
        private void ButtonFindMovieWithMaxRating_Click(object sender, EventArgs e)
        {
            ListBoxMovies.SelectedIndex = FindItemWithMaxValue(_movies, (movie) => movie.Rating);
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
        private void TextBoxDisable(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
