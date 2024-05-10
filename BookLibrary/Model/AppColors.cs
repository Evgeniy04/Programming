/// <summary>
/// Константы цветов.
/// </summary>
static class AppColors
{
    /// <summary>
    /// Цвет по умолчанию.
    /// </summary>
    public static readonly Color Default = Color.White;
    /// <summary>
    /// Цвет для недопустимых значений.
    /// </summary>
    public static readonly Color Invalid = Color.LightPink;
    /// <summary>
    /// Цвет для опасных ситуаций.
    /// </summary>
    public static readonly Color Danger = Color.FromArgb(127, 255, 127, 127);
    /// <summary>
    /// Цвет для успешных событий или операций.
    /// </summary>
    public static readonly Color Success = Color.FromArgb(127, 127, 255, 127);
    /// <summary>
    /// Осенний цвет.
    /// </summary>
    public static readonly Color Autumn = ColorTranslator.FromHtml("#e29c45");
    /// <summary>
    /// Весенний цвет.
    /// </summary>
    public static readonly Color Spring = ColorTranslator.FromHtml("#559c45");
}