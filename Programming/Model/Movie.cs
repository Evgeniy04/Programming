using System;

/// <summary>
/// ������������� ������.
/// </summary>
class Movie
{
    /// <summary>
    /// �������� ������.
    /// </summary>
    string _title;
    /// <summary>
    /// ����������������� ������ � �������.
    /// </summary>
    int _durationMinutes;
    /// <summary>
    /// ��� ������� ������.
    /// </summary>
    int _releaseYear;
    /// <summary>
    /// ���� ������.
    /// </summary>
    Genre _genre;
    /// <summary>
    /// ������� ������.
    /// </summary>
    double _rating;

    /// <summary>
    /// ���������� � �������� �������� ������. ���������� �������� ������ ����.
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
    /// ���������� � �������� ����������������� ������ � �������. ������ ������������� �����.
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
    /// ���������� � �������� ��� ������� ������. �� 1850 �� �.� (������������).
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
    /// ���������� � �������� ���� ������.
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
    /// ���������� � �������� ������� ������. �������� �� ���� �� ������ (������������).
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
    /// ������ ��������� ������ <see cref="Movie"/>.
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
    /// ������ ��������� ������ <see cref="Movie"/>.
    /// </summary>
    /// <param name="title">�������� ������.</param>
    /// <param name="durationMinutes">����������������� ������ � �������.</param>
    /// <param name="releaseYear">��� ������� ������.</param>
    /// <param name="genre">���� ������.</param>
    /// <param name="rating">������� ������.</param>
    public Movie(string title, int durationMinutes, int releaseYear, Genre genre, double rating)
    {
        Title = title;
        DurationMinutes = durationMinutes;
        ReleaseYear = releaseYear;
        Genre = genre;
        Rating = rating;
    }
}