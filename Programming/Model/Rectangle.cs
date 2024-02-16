class Rectangle
{
    double _length;
    double _width;
    public Color Color { get; set; }
    static int _allRectanglesCount;
    readonly int _id;

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
    public Point2D Center => new Point2D(Width / 2, Length / 2);
    public static int AllRectanglesCount
    {
        get { return _allRectanglesCount; }
    }
    public int Id
    {
        get { return _id; }
    }

    public Rectangle()
    {
        Length = 15;
        Width = 30;
        Color = Color.Green;
        _id = ++_allRectanglesCount;
    }

    public Rectangle(double length, double width, Color color)
    {
        Length = length;
        Width = width;
        Color = color;
        _id = ++_allRectanglesCount;
    }
}
