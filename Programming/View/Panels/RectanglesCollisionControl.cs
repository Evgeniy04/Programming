﻿using Programming.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// Управления пересечениями прямоугольников.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Флаг, указывающий, что изменения производятся программно.
        /// </summary>
        bool _isProgrammaticChange = false;
        /// <summary>
        /// Список пересекающихся прямоугольников.
        /// </summary>
        List<Rectangle> _intersecting = new List<Rectangle>();
        /// <summary>
        /// Список всех прямоугольников.
        /// </summary>
        List<Rectangle> _rectangles;
        /// <summary>
        /// Текущий выбранный прямоугольник.
        /// </summary>
        Rectangle _currentRectangle;
        /// <summary>
        /// Список панелей, соответствующих прямоугольникам.
        /// </summary>
        List<Panel> _rectanglePanels;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RectanglesCollisionControl"/>.
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();
            CustomMethods.TextBoxRectangles = new TextBox[5] {  TextBoxRectanglesId,
                                                                TextBoxRectanglesWidth,
                                                                TextBoxRectanglesHeight,
                                                                TextBoxRectanglesX,
                                                                TextBoxRectanglesY };
            _rectangles = new List<Rectangle>();
            _rectanglePanels = new List<Panel>();
        }

        /// <summary>
        /// Обработчик изменения координаты прямоугольника.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события изменения текста.</param>
        void TextBoxRectanglesX_TextChanged(object sender, EventArgs e)
        {
            TextBoxCoordinatesHandler(TextBoxRectanglesX, "x");
        }
        /// <summary>
        /// Обработчик изменения координаты прямоугольника.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события изменения текста.</param>
        void TextBoxRectanglesY_TextChanged(object sender, EventArgs e)
        {
            TextBoxCoordinatesHandler(TextBoxRectanglesY, "y");
        }
        /// <summary>
        /// Обработчик изменения текста в поле ширины прямоугольника.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события изменения текста.</param>
        void TextBoxRectanglesWidth_TextChanged(object sender, EventArgs e)
        {
            TextBoxSizeRectangleHandler(TextBoxRectanglesWidth, "width");
        }
        /// <summary>
        /// Обработчик изменения текста в поле длины прямоугольника.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события изменения текста.</param>
        void TextBoxRectanglesHeight_TextChanged(object sender, EventArgs e)
        {
            TextBoxSizeRectangleHandler(TextBoxRectanglesHeight, "length");
        }

        /// <summary>
        /// Обработчик нажатия кнопки для создания нового прямоугольника.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события изменения текста.</param>
        void ButtonAddRectangle_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = RectangleFactory.Randomize(PanelRectangles, 150, 150);
            _rectangles.Add(rectangle);
            ListBoxRectangles.Items.Add(rectangle);
            Panel panel = InitialPanel(rectangle);
            panel.BackColor = AppColors.Success;
            _rectanglePanels.Add(panel);
            PanelRectangles.Controls.Add(panel);
            FindCollisions(rectangle);
        }
        /// <summary>
        /// Обработчик нажатия кнопки для удаления существующего прямоугольника.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события изменения текста.</param>
        void ButtonRemoveRectangle_Click(object sender, EventArgs e)
        {
            if (ListBoxRectangles.SelectedItem == null && ListBoxRectangles.SelectedIndex == -1) return;
            Rectangle rectangle = (Rectangle)ListBoxRectangles.SelectedItem;
            int selectedIndex = ListBoxRectangles.SelectedIndex;
            _rectangles.Remove(rectangle);
            ListBoxRectangles.Items.Remove(rectangle);
            ClearRectangleInfo();
            _rectanglePanels.RemoveAt(selectedIndex);
            PanelRectangles.Controls.RemoveAt(selectedIndex);
            FindCollisions(rectangle);
        }
        /// <summary>
        /// Обработчик изменения выбранного элемента в списке прямоугольников.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события изменения текста.</param>
        void ListBoxRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxRectangles.SelectedItem == null) return;
            _currentRectangle = (Rectangle)ListBoxRectangles.SelectedItem;
            UpdateRectangleInfo(_currentRectangle, ListBoxRectangles.SelectedIndex);
        }
        /// <summary>
        /// Обработчик события нажатия клавиши для отключения ввода в текстовом поле.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события нажатия клавиши.</param>
        void TextBoxDisable(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Обработчик изменения ширины прямоугольника.
        /// </summary>
        /// <param name="textBox">Текстовое поле с новым значением ширины.</param>
        /// <param name="dimensionType">Тип изменяемого параметра ("width" или "length").</param>
        void TextBoxSizeRectangleHandler(TextBox textBox, string dimensionType)
        {
            if (_currentRectangle == null || _isProgrammaticChange) return;
            try
            {
                int value = int.Parse(textBox.Text);
                switch (dimensionType)
                {
                    case "width":
                        _currentRectangle.Width = value;
                        break;
                    case "length":
                        _currentRectangle.Height = value;
                        break;
                    default: throw new ArgumentException("Non-existent argument value.");
                }
                ListBoxSelectedRectangleUpdate();

                textBox.BackColor = AppColors.Default;
            }
            catch (Exception)
            {
                textBox.BackColor = AppColors.Invalid;
            }
        }
        /// <summary>
        /// Обработчик изменения координаты прямоугольника.
        /// </summary>
        /// <param name="textBox">Текстовое поле с новым значением координаты.</param>
        /// <param name="coordinateType">Тип изменяемой координаты ("x" или "y").</param>
        void TextBoxCoordinatesHandler(TextBox textBox, string coordinateType)
        {
            if (_currentRectangle == null || _isProgrammaticChange) return;
            try
            {
                int coordinate = int.Parse(textBox.Text);
                switch (coordinateType)
                {
                    case "x":
                        _currentRectangle.Coordinates = new Point2D(coordinate, _currentRectangle.Coordinates.Y);
                        break;
                    case "y":
                        _currentRectangle.Coordinates = new Point2D(_currentRectangle.Coordinates.X, coordinate);
                        break;
                    default: throw new ArgumentException("Non-existent argument value.");
                }
                ListBoxSelectedRectangleUpdate();
                textBox.BackColor = AppColors.Default;
            }
            catch (Exception)
            {
                textBox.BackColor = AppColors.Invalid;
            }
        }
        /// <summary>
        /// Метод обновления информации о выбранном прямоугольнике в списке.
        /// </summary>
        void ListBoxSelectedRectangleUpdate()
        {
            int indexRectangles = ListBoxRectangles.Items.IndexOf(_currentRectangle);
            ListBoxRectangles.Items.RemoveAt(indexRectangles);
            ListBoxRectangles.Items.Insert(indexRectangles, _currentRectangle);
            ListBoxRectangles.SelectedIndex = indexRectangles;
            Panel panel = InitialPanel(_currentRectangle);
            panel.BackColor = AppColors.Success;
            _rectanglePanels[indexRectangles] = panel;
            PanelRectangles.Controls.Clear();
            PanelRectangles.Controls.AddRange(_rectanglePanels.ToArray());
            FindCollisions(_currentRectangle);
        }

        /// <summary>
        /// Метод поиска пересечений для указанного прямоугольника.
        /// </summary>
        /// <param name="rectangle">Прямоугольник для проверки на пересечения.</param>
        void FindCollisions(Rectangle rectangle)
        {
            // Создаём копию списка, чтобы из-за изменения во время выполнения цикла, не появлялась ошибка
            List<Rectangle> intersecting = new List<Rectangle>(_intersecting);
            // Перебираем ранее пересекающиеся прямоугольники со всеми прямоугольниками,
            // если он ни с чем не пересекается, делаем его зелёным
            foreach (Rectangle e in intersecting)
            {
                if (ListBoxRectangles.Items.IndexOf(e) == -1) continue;
                bool isRemove = true;
                foreach (Rectangle r in _rectangles)
                {
                    if (e != r && CollisionManager.IsCollision(e, r))
                    {
                        isRemove = false;
                        break;
                    }
                }
                if (isRemove)
                {
                    _intersecting.Remove(e);
                    _rectanglePanels[ListBoxRectangles.Items.IndexOf(e)].BackColor = AppColors.Success;
                }
            }
            // Удаляем из списка пересекающих изменённый прямоугольник
            if (_intersecting.Contains(rectangle)) _intersecting.Remove(rectangle);
            // Если прямоугольник был удалён, завершаем выполнение метода
            if (!_rectangles.Contains(rectangle)) return;

            bool flag = false;
            foreach (Rectangle r in _rectangles)
            {
                if (rectangle != r && CollisionManager.IsCollision(rectangle, r))
                {
                    if (!_intersecting.Contains(r)) _intersecting.Add(r);
                    _rectanglePanels[ListBoxRectangles.Items.IndexOf(r)].BackColor = AppColors.Danger;
                    flag = true;
                }
            }
            if (flag)
            {
                _intersecting.Add(rectangle);
                _rectanglePanels[ListBoxRectangles.Items.IndexOf(rectangle)].BackColor = AppColors.Danger;
            }
        }

        /// <summary>
        /// Обновление информации о прямоугольнике.
        /// </summary>
        /// <param name="rectangle">Обновляемый прямоугольник.</param>
        /// <param name="selectedIndex">Индекс выбранного прямоугольника в списке.</param>
        void UpdateRectangleInfo(Rectangle rectangle, int selectedIndex)
        {
            _isProgrammaticChange = true;
            TextBoxRectanglesId.Text = rectangle.Id.ToString();
            TextBoxRectanglesX.Text = rectangle.Coordinates.X.ToString();
            TextBoxRectanglesY.Text = rectangle.Coordinates.Y.ToString();
            TextBoxRectanglesWidth.Text = rectangle.Width.ToString();
            TextBoxRectanglesHeight.Text = rectangle.Height.ToString();
            ListBoxRectangles.SelectedIndex = selectedIndex;
            _isProgrammaticChange = false;
        }
        /// <summary>
        /// Очистка информации о прямоугольниках.
        /// </summary>
        void ClearRectangleInfo()
        {
            foreach (TextBox tb in CustomMethods.TextBoxRectangles)
            {
                tb.Clear();
                tb.BackColor = AppColors.Default;
            }
            foreach (TextBox tb in CustomMethods.TextBoxClassesRectangles)
            {
                tb.Clear();
                tb.BackColor = AppColors.Default;
            }
        }

        /// <summary>
        /// Создание панели для отображения прямоугольника.
        /// </summary>
        /// <param name="rectangle">Прямоугольник для отображения.</param>
        /// <returns>Созданная панель.</returns>
        Panel InitialPanel(Rectangle rectangle)
        {
            Panel panel = new Panel();
            panel.Location = new Point((int)rectangle.Coordinates.X, (int)rectangle.Coordinates.Y);
            panel.Width = rectangle.Width;
            panel.Height = rectangle.Height;
            return panel;
        }
    }
}