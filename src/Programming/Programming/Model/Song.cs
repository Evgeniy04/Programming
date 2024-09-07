using System;

/// <summary>
/// Представление песни.
/// </summary>
class Song
{
    /// <summary>
    /// Название песни.
    /// </summary>
    string _title;
    /// <summary>
    /// Автор песни.
    /// </summary>
    string _author;
    /// <summary>
    /// Продолжительность песни.
    /// </summary>
    TimeSpan Duration { get; set; }
    /// <summary>
    /// Год выпуска песни.
    /// </summary>
    int _releaseYear;

    /// <summary>
    /// Возвращает и изменяет название песни. Количество символов должно быть больше нуля.
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
    /// Возвращает и изменяет автора песни. Количество символов должно быть больше нуля.
    /// </summary>
    public string Author
    {
        get { return _author; }
        set
        {
            if (value.Length == 0) throw new ArgumentException("Incorrect author.");
            _author = value;
        }
    }
    /// <summary>
    /// Возвращает и изменяет год выпуска песни. Значение не должно быть выше, чем текущий год.
    /// </summary>
    public int ReleaseYear
    {
        get { return _releaseYear; }
        set
        {
            if (value > DateTime.Now.Year) throw new ArgumentException("Incorrect year of release.");
            _releaseYear = value;
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Song"/>.
    /// </summary>
    public Song()
    {
        Title = "DefaultTitle";
        Author = "DefaultAuthor";
        Duration = new TimeSpan(0, 0, 15);
        ReleaseYear = DateTime.Now.Year;
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Song"/>.
    /// </summary>
    /// <param name="title">Название песни.</param>
    /// <param name="author">Автор песни.</param>
    /// <param name="duration">Продолжительность песни.</param>
    /// <param name="releaseYear">Год выпуска песни.</param>
    public Song(string title, string author, TimeSpan duration, int releaseYear)
    {
        Title = title;
        Author = author;
        Duration = duration;
        ReleaseYear = releaseYear;
    }
}