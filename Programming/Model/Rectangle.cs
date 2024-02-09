using Programming.Model;
using System;

class Rectangle
{
    double _length;
    double _width;

    public Color Color { get; set; }
    public double Length
    {
        get { return _length; }
        set
        {
            if (value < 0) throw new ArgumentException();
            _length = value;
        }
    }
    public double Width
    {
        get { return _width; }
        set
        {
            if (value < 0) throw new ArgumentException();
            _width = value;
        }
    }

    public Rectangle()
    {
        Length = 15;
        Width = 30;
        Color = Color.Green;
    }

    public Rectangle(double lingth, double width, Color color)
    {
        Length = lingth;
        Width = width;
        Color = color;
    }
}