namespace View.Model.Services
{
    /// <summary>
    /// Валидация значений.
    /// </summary>
    internal static class ValueValidator
    {
        /// <summary>
        /// Проверяет длину строки на допустимые пределы.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxLength">Максимальная допустимая длина строки.</param>
        /// <param name="propertyName">Имя свойства, к которому относится данная строка.</param>
        /// <exception cref="ArgumentException">Выбрасывается,
        /// если длина строка выходит за допустимые пределы.</exception>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length < 0 || value.Length >= maxLength) throw new ArgumentException
                    ($"{propertyName} должен быть меньше {maxLength} символов.");
        }

        /// <summary>
        /// Проверка на положительное значение для целочисленного типа.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если значение отрицательное.</exception>
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value < 0) throw new ArgumentException($"{propertyName} должен быть положительным.");
        }

        /// <summary>
        /// Проверка на положительное значение для вещественного типа.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если значение отрицательное.</exception>
        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value < 0) throw new ArgumentException($"{propertyName} должен быть положительным.");
        }

        /// <summary>
        /// Проверка значения на принадлежность заданному диапазону для целочисленного типа.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальное значение в диапазоне (включительно).</param>
        /// <param name="max">Максимальное значение в диапазоне (исключительно).</param>
        /// <exception cref="ArgumentException">Выбрасывается,
        /// если значение находится вне заданного диапазона.</exception>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value >= max) throw new ArgumentException
                    ($"{propertyName} должен быть больше {min}, но меньше {max}.");
        }

        /// <summary>
        /// Проверка значения на принадлежность заданному диапазону для вещественного типа.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальное значение в диапазоне (включительно).</param>
        /// <param name="max">Максимальное значение в диапазоне (исключительно).</param>
        /// <exception cref="ArgumentException">Выбрасывается,
        /// если значение находится вне заданного диапазона.</exception>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value >= max) throw new ArgumentException
                    ($"{propertyName} должен быть больше {min}, но меньше {max}.");
        }
    }
}
