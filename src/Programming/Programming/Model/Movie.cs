using System;

/// <summary>
/// Представление фильма.
/// </summary>
class Movie
{
    /// <summary>
    /// Название фильма.
    /// </summary>
    string _title;
    /// <summary>
    /// Продолжительность фильма в минутах.
    /// </summary>
    int _durationMinutes;
    /// <summary>
    /// Год выпуска фильма.
    /// </summary>
    int _releaseYear;
    /// <summary>
    /// Жанр фильма.
    /// </summary>
    Genre _genre;
    /// <summary>
    /// Рейтинг фильма.
    /// </summary>
    double _rating;

    /// <summary>
    /// Возвращает и изменяет название фильма. Количество символов больше нуля.
    /// </summary>
    public string Title
    {
        get { return _title; }
        set
        {
            if (value.Length == 0) throw new ArgumentException("Incorrect title.");
            _title = value;
        }
    }
    /// <summary>
    /// Возвращает и изменяет продолжительность фильма в минутах. Только положительные числа.
    /// </summary>
    public int DurationMinutes
    {
        get { return _durationMinutes; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _durationMinutes = value;
        }
    }
    /// <summary>
    /// Возвращает и изменяет год выпуска фильма. От 1850 до н.в (включительно).
    /// </summary>
    public int ReleaseYear
    {
        get { return _releaseYear; }
        set
        {
            Validator.AssertValueInRange(value, 1850, DateTime.Now.Year + 1);
            _releaseYear = value;
        }
    }
    /// <summary>
    /// Возвращает и изменяет жанр фильма.
    /// </summary>
    public Genre Genre
    {
        get { return _genre; }
        set
        {
            _genre = value;
        }
    }
    /// <summary>
    /// Возвращает и изменяет рейтинг фильма. Значение от нуля до десяти (включительно).
    /// </summary>
    public double Rating
    {
        get { return _rating; }
        set
        {
            Validator.AssertValueInRange(value, 0, 11);
            _rating = value;
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Movie"/>.
    /// </summary>
    public Movie()
    {
        Title = "New Movie";
        DurationMinutes = 15;
        ReleaseYear = DateTime.Now.Year;
        Genre = Genre.Comedy;
        Rating = 10;
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Movie"/>.
    /// </summary>
    /// <param name="title">Название фильма.</param>
    /// <param name="durationMinutes">Продолжительность фильма в минутах.</param>
    /// <param name="releaseYear">Год выпуска фильма.</param>
    /// <param name="genre">Жанр фильма.</param>
    /// <param name="rating">Рейтинг фильма.</param>
    public Movie(string title, int durationMinutes, int releaseYear, Genre genre, double rating)
    {
        Title = title;
        DurationMinutes = durationMinutes;
        ReleaseYear = releaseYear;
        Genre = genre;
        Rating = rating;
    }
}