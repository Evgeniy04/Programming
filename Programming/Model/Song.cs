using System;

/// <summary>
/// ������������� �����.
/// </summary>
class Song
{
    /// <summary>
    /// �������� �����.
    /// </summary>
    string _title;
    /// <summary>
    /// ����� �����.
    /// </summary>
    string _author;
    /// <summary>
    /// ����������������� �����.
    /// </summary>
    TimeSpan Duration { get; set; }
    /// <summary>
    /// ��� ������� �����.
    /// </summary>
    int _releaseYear;

    /// <summary>
    /// ���������� � �������� �������� �����. ���������� �������� ������ ���� ������ ����.
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
    /// ���������� � �������� ������ �����. ���������� �������� ������ ���� ������ ����.
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
    /// ���������� � �������� ��� ������� �����. �������� �� ������ ���� ����, ��� ������� ���.
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
    /// ������ ��������� ������ <see cref="Song"/>.
    /// </summary>
    public Song()
    {
        Title = "DefaultTitle";
        Author = "DefaultAuthor";
        Duration = new TimeSpan(0, 0, 15);
        ReleaseYear = DateTime.Now.Year;
    }

    /// <summary>
    /// ������ ��������� ������ <see cref="Song"/>.
    /// </summary>
    /// <param name="title">�������� �����.</param>
    /// <param name="author">����� �����.</param>
    /// <param name="duration">����������������� �����.</param>
    /// <param name="releaseYear">��� ������� �����.</param>
    public Song(string title, string author, TimeSpan duration, int releaseYear)
    {
        Title = title;
        Author = author;
        Duration = duration;
        ReleaseYear = releaseYear;
    }
}