using Programming.Model;
using System;

class Movie
{
    string _title;
    int _durationMinutes;
    int _releaseYear;
    Genre _genre;
    double _rating;
    readonly CustomMethods _customMethods = new CustomMethods();

    public string Title
    {
        get { return _title; }
        set
        {
            if (value.Length == 0) throw new ArgumentException();
            _title = value;
        }
    }
    public int DurationMinutes
    {
        get { return _durationMinutes; }
        set
        {
            if (value < 0) throw new ArgumentException();
            _durationMinutes = value;
        }
    }
    public int ReleaseYear
    {
        get { return _releaseYear; }
        set
        {
            if (value < 1850 || value > DateTime.Now.Year) throw new ArgumentException();
            _releaseYear = value;
        }
    }
    public Genre Genre
    {
        get { return _genre; }
        set
        {
             _genre = value;
        }
    }
    public double Rating
    {
        get { return _rating; }
        set
        {
            if (value < 0 || value > 10) throw new ArgumentException();
            _rating = value;
        }
    }

    public Movie()
    {
        Title = "New Movie";
        DurationMinutes = 15;
        ReleaseYear = DateTime.Now.Year;
        Genre = Genre.Comedy;
        Rating = 10;
    }

    public Movie(string title, int durationMinutes, int releaseYear, Genre genre, double rating)
    {
        Title = title;
        DurationMinutes = durationMinutes;
        ReleaseYear = releaseYear;
        Genre = genre;
        Rating = rating;
    }
}