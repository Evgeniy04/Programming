/// <summary>
/// Представление точки с двумя координатами.
/// </summary>
class Point2D
{
    /// <summary>
    /// Координата X точки.
    /// </summary>
    double _x;
    /// <summary>
    /// Координата Y точки.
    /// </summary>
    double _y;

    /// <summary>
    /// Возвращает и изменяет координату X точки. Положительное значение.
    /// </summary>
    public double X
    {
        get { return _x; }
        private set
        {
            Validator.AssertOnPositiveValue(value);
            _x = value;
        }
    }

    /// <summary>
    /// Возвращает и изменяет координату Y точки. Положительное значение.
    /// </summary>
    public double Y
    {
        get { return _y; }
        private set
        {
            Validator.AssertOnPositiveValue(value);
            _y = value;
        }
    }
    /// <summary>
    /// Создаёт экземпляр класса <see cref="Point2D"/>.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
    }
}