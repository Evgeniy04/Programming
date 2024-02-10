using Programming.Model;
using System;

class Rectangle
{
    double _length;
    double _width;
    public Point2D Center { get; }


    public Color Color { get; set; }
    public double Length
    {
        get { return _length; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _length = value;
        }
    }
    public double Width
    {
        get { return _width; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _width = value;
        }
    }

    public Rectangle()
    {
        Length = 15;
        Width = 30;
        Color = Color.Green;
    }

    public Rectangle(double length, double width, Color color)
    {
        Length = length;
        Width = width;
        Color = color;
        Center = new Point2D(Length / 2, Width / 2);
    }
}