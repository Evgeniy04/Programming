using System;

class Time
{
    int _hours;
    int _minutes;
    int _seconds;

    public int Hours
    {
        get { return _hours; }
        set
        {
            if (value < 0 || value > 23) throw new ArgumentException();
            _hours = value;
        }
    }
    public int Minutes
    {
        get { return _minutes; }
        set
        {
            if (value < 0 ||  value > 60) throw new ArgumentException();
            _minutes = value;
        }
    }
    public int Seconds
    {
        get { return _seconds; }
        set
        {
            if (value < 0 || value > 60) throw new ArgumentException();
            _seconds = value;
        }
    }

    public Time()
    {
        Hours = DateTime.Now.Hour;
        Minutes = DateTime.Now.Minute;
        Seconds = DateTime.Now.Second;
    }

    public Time(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }
}