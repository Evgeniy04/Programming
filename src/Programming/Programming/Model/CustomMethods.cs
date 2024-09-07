using Programming;
using System;
using System.Linq;
using System.Windows.Forms;

/// <summary>
/// Содержит методы и свойства для пользовательского управления.
/// </summary>
static class CustomMethods
{
    /// <summary>
    /// Модель типов, используемых для списка перечислений.
    /// </summary>
    static public readonly Type[] TypeModel = new Type[6] { typeof(Color), typeof(EducationForm),
                                            typeof(Genre), typeof(PhoneManufactures),
                                            typeof(Season), typeof(Weekday) };

    /// <summary>
    /// Свойство, содержащее массив текстовых полей для панели управления пересечениями прямоугольников.
    /// </summary>
    static public TextBox[] TextBoxClassesRectangles { get; set; }
    /// <summary>
    /// Свойство, содержащее массив текстовых полей для прямоугольников.
    /// </summary>
    static public TextBox[] TextBoxRectangles { get; set; }

    /// <summary>
    /// Пытается получить значение перечисления <typeparamref name="T"/> из его строкового представления.
    /// </summary>
    /// <typeparam name="T">Тип перечисления.</typeparam>
    /// <param name="itemName">Строковое представление элемента перечисления.</param>
    /// <param name="value">Результат - значение перечисления.</param>
    /// <returns><see langword="true"/>, если удалось получить значение перечисления, в противном случае - <see langword="false"/>.</returns>
    static public bool TryGetEnumValue<T>(string itemName, out T value) where T : struct
    {
        if (Enum.TryParse<T>(itemName, true, out value))
        {
            return true;
        }
        value = default;
        return false;
    }
}
