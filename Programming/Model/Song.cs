using System;

class Song
{
    string _title;
    string _author;
    TimeSpan Duration { get; set; }
    int _releaseYear;

    public string Title
    {
        get { return _title; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _title = value;
        }
    }
    public string Author
    {
        get { return _author; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _author = value;
        }
    }
    public int ReleaseYear
    {
        get { return _releaseYear; }
        set
        {
            if (value > DateTime.Now.Year) throw new ArgumentException();
            _releaseYear = value;
        }
    }

    public Song()
    {
        Title = "DefaultTitle";
        Author = "DefaultAuthor";
        Duration = new TimeSpan(0, 0, 15);
        ReleaseYear = DateTime.Now.Year;
    }

    public Song(string title, string author, TimeSpan duration, int releaseYear)
    {
        Title = title;
        Author = author;
        Duration = duration;
        ReleaseYear = releaseYear;
    }
}