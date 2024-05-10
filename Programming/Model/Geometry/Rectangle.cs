using System.Drawing;

/// <summary>
/// Представление прямоугольника.
/// </summary>
class Rectangle
{
    /// <summary>
    /// Высота прямоугольника.
    /// </summary>
    int _height;
    /// <summary>
    /// Ширина прямоугольника.
    /// </summary>
    int _width;
    /// <summary>
    /// Координаты прямоугольника.
    /// </summary>
    public Point2D Coordinates {  get; set; }

    /// <summary>
    /// Цвет прямоугольника.
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Колличество прямоугольников.
    /// </summary>
    static int _allRectanglesCount;
    /// <summary>
    /// Идентификатор прямоугольника.
    /// </summary>
    readonly int _id;

    /// <summary>
    /// Возвращает и изменяет высоту прямоугольника. Положительное значение.
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
    /// Возвращает и изменяет ширину прямоугольника. Положительное значение.
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
    /// Координаты центра прямоугольника.
    /// </summary>
    public Point2D Center => new Point2D(Coordinates.X + Width / 2, Coordinates.Y + Height / 2);

    /// <summary>
    /// Возвращает колличество всех прямоугольников. 
    /// </summary>
    public static int AllRectanglesCount
    {
        get { return _allRectanglesCount; }
    }
    /// <summary>
    /// Возвращает Id прямоугольников.
    /// </summary>
    public int Id
    {
        get { return _id; }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Rectangle"/>.
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
    /// Создаёт экземпляр класса <see cref="Rectangle"/>.
    /// </summary>
    /// <param name="height">Высота прямоугольника.</param>
    /// <param name="width">Ширина прямоугольника.</param>
    /// <param name="color">Цвет прямоугольника.</param>
    /// <param name="coordinates">Координаты прямоугольника.</param>
    public Rectangle(int height, int width, Color color, Point2D coordinates)
    {
        Height = height;
        Width = width;
        Color = color;
        Coordinates = coordinates;
        _id = ++_allRectanglesCount;
    }

    /// <summary>
    /// Представление прямоугольника в виде строки.
    /// </summary>
    /// <returns>Строка, представляющая прямоугольник.</returns>
    public override string ToString()
    {
        return $"{Id}: (X={Center.X}; Y={Center.Y}; W={Width}; H={Height})";
    }
}
