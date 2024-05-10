using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// Элемент управления для работы с прямоугольниками.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Список всех прямоугольников.
        /// </summary>
        private List<Rectangle> _rectangles = new List<Rectangle>();
        /// <summary>
        /// Выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RectanglesControl"/>.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();
            CustomMethods.TextBoxClassesRectangles = new TextBox[6] {   TextBoxRectanglesId,
                                                                        TextBoxRectanglesColor,
                                                                        TextBoxRectanglesWidth,
                                                                        TextBoxRectanglesLength,
                                                                        TextBoxRectanglesCoordinateX,
                                                                        TextBoxRectanglesCoordinateY };
        }

        /// <summary>
        /// Обработчик изменения выбранного элемента в списке прямоугольников.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события изменения выбранного элемента.</param>
        private void ListBoxClassesRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    if (ListBoxClassesRectangles.SelectedItem == null) return;
            //    _currentRectangle = (Rectangle)ListBoxClassesRectangles.SelectedItem;
            //    UpdateRectangleInfo(_currentRectangle, ListBoxClassesRectangles.SelectedIndex);
        }

        /// <summary>
        /// Обработчик изменения текста в поле цвета прямоугольника.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события изменения текста.</param>
        private void TextBoxClassesRectanglesColor_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;
            if (CustomMethods.TryGetEnumValue<Color>(TextBoxRectanglesColor.Text, out Color value))
            {
                _currentRectangle.Color = value;
                TextBoxRectanglesColor.BackColor = AppColors.Default;
            }
            else
            {
                TextBoxRectanglesColor.BackColor = AppColors.Invalid;
            }
        }
        /// <summary>
        /// Обработчик изменения текста в поле длины прямоугольника.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события изменения текста.</param>
        private void TextBoxClassesRectanglesLength_TextChanged(object sender, EventArgs e)
        {
            //TextBoxSizeRectangleHandler(TextBoxClassesRectanglesLength, "length");
        }
        /// <summary>
        /// Обработчик изменения текста в поле ширины прямоугольника.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события изменения текста.</param>
        private void TextBoxClassesRectanglesWidth_TextChanged(object sender, EventArgs e)
        {
            //TextBoxSizeRectangleHandler(TextBoxClassesRectanglesWidth, "width");
        }

        /// <summary>
        /// Обработчик нажатия кнопки для поиска прямоугольника с максимальной шириной.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события изменения текста.</param>
        private void ButtonFindRectangleWithMaxWidth_Click(object sender, EventArgs e)
        {
            ListBoxRectangles.SelectedIndex = FindItemWithMaxValue(_rectangles, (rectangle) => rectangle.Width);
        }

        /// <summary>
        /// Находит индекс элемента с максимальным значением в списке.
        /// </summary>
        /// <typeparam name="T">Тип элемента в списке.</typeparam>
        /// <param name="classList">Список элементов.</param>
        /// <param name="getValue">Функция получения значения элемента.</param>
        /// <returns>Индекс элемента с максимальным значением.</returns>
        private int FindItemWithMaxValue<T>(List<T> classList, Func<T, double> getValue) where T : class
        {
            if (classList.Count < 1) return -1;

            int index = 0;
            double maxValue = getValue(classList[0]);
            for (int i = 0; i < classList.Count; i++)
            {
                if (getValue(classList[i]) > maxValue)
                {
                    maxValue = getValue(classList[i]);
                    index = i;
                }
            }
            return index;
        }

        /// <summary>
        /// Обработчик события нажатия клавиши для отключения ввода в текстовом поле.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события нажатия клавиши.</param>
        private void TextBoxDisable(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
