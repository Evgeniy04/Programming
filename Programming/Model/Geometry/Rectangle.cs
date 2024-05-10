using System.Drawing;

/// <summary>
/// ������������� ��������������.
/// </summary>
class Rectangle
{
    /// <summary>
    /// ������ ��������������.
    /// </summary>
    int _height;
    /// <summary>
    /// ������ ��������������.
    /// </summary>
    int _width;
    /// <summary>
    /// ���������� ��������������.
    /// </summary>
    public Point2D Coordinates {  get; set; }

    /// <summary>
    /// ���� ��������������.
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// ����������� ���������������.
    /// </summary>
    static int _allRectanglesCount;
    /// <summary>
    /// ������������� ��������������.
    /// </summary>
    readonly int _id;

    /// <summary>
    /// ���������� � �������� ������ ��������������. ������������� ��������.
    /// </summary>
    public int Height
    {
        get { return _height; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _height = value;
        }
    }
    /// <summary>
    /// ���������� � �������� ������ ��������������. ������������� ��������.
    /// </summary>
    public int Width
    {
        get { return _width; }
        set
        {
            Validator.AssertOnPositiveValue(value);
            _width = value;
        }
    }
    /// <summary>
    /// ���������� ������ ��������������.
    /// </summary>
    public Point2D Center => new Point2D(Coordinates.X + Width / 2, Coordinates.Y + Height / 2);

    /// <summary>
    /// ���������� ����������� ���� ���������������. 
    /// </summary>
    public static int AllRectanglesCount
    {
        get { return _allRectanglesCount; }
    }
    /// <summary>
    /// ���������� Id ���������������.
    /// </summary>
    public int Id
    {
        get { return _id; }
    }

    /// <summary>
    /// ������ ��������� ������ <see cref="Rectangle"/>.
    /// </summary>
    public Rectangle()
    {
        Height = 15;
        Width = 30;
        Color = Color.Green;
        Coordinates = new Point2D(10, 10);
        _id = ++_allRectanglesCount;
    }

    /// <summary>
    /// ������ ��������� ������ <see cref="Rectangle"/>.
    /// </summary>
    /// <param name="height">������ ��������������.</param>
    /// <param name="width">������ ��������������.</param>
    /// <param name="color">���� ��������������.</param>
    /// <param name="coordinates">���������� ��������������.</param>
    public Rectangle(int height, int width, Color color, Point2D coordinates)
    {
        Height = height;
        Width = width;
        Color = color;
        Coordinates = coordinates;
        _id = ++_allRectanglesCount;
    }

    /// <summary>
    /// ������������� �������������� � ���� ������.
    /// </summary>
    /// <returns>������, �������������� �������������.</returns>
    public override string ToString()
    {
        return $"{Id}: (X={Center.X}; Y={Center.Y}; W={Width}; H={Height})";
    }
}
