using System.Drawing;
using System;
using Programming;
using System.Windows.Forms;

/// <summary>
/// Создание прямоугольников.
/// </summary>
static class RectangleFactory
{
    /// <summary>
    /// Генератор случайных чисел.
    /// </summary>
    static Random _random = new Random();

    /// <summary>
    /// Создает прямоугольник с случайными параметрами.
    /// </summary>
    /// <param name="PanelRectangles">Панель, на которой будет отображаться прямоугольник.</param>
    /// <param name="maxHeight">Максимальная высота прямоугольника.</param>
    /// <param name="maxWidth">Максимальная ширина прямоугольника.</param>
    /// <returns>Созданный прямоугольник.</returns>
    static public Rectangle Randomize(Panel PanelRectangles, int maxHeight, int maxWidth)
    {
        int height = _random.Next(15, maxHeight);
        int width = _random.Next(15, maxWidth);
        return new Rectangle(height, width, Color.Orange, new Point2D(_random.Next(16, PanelRectangles.Size.Width - 16 - maxWidth), _random.Next(16, PanelRectangles.Size.Height - 16 - maxHeight)));
    }
}