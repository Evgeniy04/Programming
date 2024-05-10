using System;
using System.Diagnostics;

/// <summary>
/// Валидация значений.
/// </summary>
static class Validator
{
    /// <summary>
    /// Проверка на положительное значение для целочисленного типа.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <exception cref="ArgumentException">Выбрасывается, если значение отрицательное.</exception>
    public static void AssertOnPositiveValue(int value)
    {
        if (value < 0) throw new ArgumentException($"The property cannot be negative.");
    }
    /// <summary>
    /// Проверка на положительное значение для вещественного типа.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <exception cref="ArgumentException">Выбрасывается, если значение отрицательное.</exception>
    public static void AssertOnPositiveValue(double value)
    {
        if (value < 0) throw new ArgumentException($"The property cannot be negative.");
    }

    /// <summary>
    /// Проверка значения на принадлежность заданному диапазону для целочисленного типа.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="min">Минимальное значение в диапазоне (включительно).</param>
    /// <param name="max">Максимальное значение в диапазоне (исключительно).</param>
    /// <exception cref="ArgumentException">Выбрасывается, если значение находится вне заданного диапазона.</exception>
    public static void AssertValueInRange(int value, int min, int max)
    {
        if (value < min || value >= max) throw new ArgumentException($"The property cannot be negative.");
    }
    /// <summary>
    /// Проверка значения на принадлежность заданному диапазону для вещественного типа.
    /// </summary>
    /// <param name="value">Проверяемое значение.</param>
    /// <param name="min">Минимальное значение в диапазоне (включительно).</param>
    /// <param name="max">Максимальное значение в диапазоне (включительно).</param>
    /// <exception cref="ArgumentException">Выбрасывается, если значение находится вне заданного диапазона.</exception>
    public static void AssertValueInRange(double value, double min, double max)
    {
        if (value < min || value >= max) throw new ArgumentException($"The property cannot be negative.");
    }
}
