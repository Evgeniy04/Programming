using System;

/// <summary>
/// 
/// </summary>
class Time
{
    /// <summary>
    /// 
    /// </summary>
    int _hours;
    /// <summary>
    /// 
    /// </summary>
    int _minutes;
    /// <summary>
    /// 
    /// </summary>
    int _seconds;

    /// <summary>
    /// 
    /// </summary>
    public int Hours
    {
        get { return _hours; }
        set
        {
            Validator.AssertValueInRange(value, 0, 24);
            _hours = value;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public int Minutes
    {
        get { return _minutes; }
        set
        {
            Validator.AssertValueInRange(value, 0, 61);
            _minutes = value;
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public int Seconds
    {
        get { return _seconds; }
        set
        {
            Validator.AssertValueInRange(value, 0, 61);
            _seconds = value;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public Time()
    {
        Hours = DateTime.Now.Hour;
        Minutes = DateTime.Now.Minute;
        Seconds = DateTime.Now.Second;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="hours"></param>
    /// <param name="minutes"></param>
    /// <param name="seconds"></param>
    public Time(int hours, int minutes, int seconds)
    {
        Hours = hours;
        Minutes = minutes;
        Seconds = seconds;
    }
}
