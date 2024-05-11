/// <summary>
/// Представление книги.
/// </summary>
class Book
{
    /// <summary>
    /// Название книги.
    /// </summary>
    string _title;

    /// <summary>
    /// Год выпуска книги.
    /// </summary>
    int _releaseYear;
    /// <summary>
    /// Автор книги.
    /// </summary>
    string _author;
    /// <summary>
    /// Количество страниц в книге.
    /// </summary>
    int _pageCount;
    /// <summary>
    /// Возвращает и изменяет жанр книги.
    /// </summary>
    public Genres Genre { get; set; }

    /// <summary>
    /// Возвращает и изменяет название книги. Не более ста и не менее одного символов.
    /// </summary>
    public string Title
    {
        get { return _title; }
        set
        {
            Validator.AssertValueInRange(value.Length, 1, 101);
            _title = value;
        }
    }

    /// <summary>
    /// Возвращает и изменяет год выпуска книги. Не более текущего года.
    /// </summary>
    public int ReleaseYear
    {
        get { return _releaseYear; }
        set
        {
            Validator.AssertValueInRange(value, int.MinValue, DateTime.Now.Year + 1);
            _releaseYear = value;
        }
    }

    /// <summary>
    /// Возвращает и изменяет автора книги.
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
    /// Возвращает и изменяет количество страниц в книге.
    /// </summary>
    public int PageCount
    {
        get { return _pageCount; }
        set
        {
            Validator.AssertValueInRange(value, 1, int.MaxValue);
            _pageCount = value;
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Book"/>.
    /// </summary>
    public Book()
    {
        Title = "Default";
        ReleaseYear = DateTime.Now.Year;
        Author = "Default";
        PageCount = 1;
        Genre = Genres.Biography;
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Book"/>.
    /// </summary>
    /// <param name="title">Название книги.</param>
    /// <param name="releaseYear">Год выпуска книги.</param>
    /// <param name="author">Автор книги.</param>
    /// <param name="pageCount">Количество страниц в книге.</param>
    /// <param name="genre">Возвращает и изменяет жанр книги.</param>
    public Book(string title, int releaseYear, string author, int pageCount, Genres genre)
    {
        Title = title;
        ReleaseYear = releaseYear;
        Author = author;
        PageCount = pageCount;
        Genre = genre;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"{Title} / {Author} / {Genre}";
    }
}


