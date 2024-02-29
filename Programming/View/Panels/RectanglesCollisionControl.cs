using Programming.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class RectanglesCollisionControl : UserControl
    {
        bool _isProgrammaticChange = false;
        List<Rectangle> _intersecting = new List<Rectangle>();
        List<Rectangle> _rectangles;
        Rectangle _currentRectangle;
        List<Panel> _rectanglePanels;

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

        void TextBoxRectanglesX_TextChanged(object sender, EventArgs e)
        {
            TextBoxCoordinatesHandler(TextBoxRectanglesX, "x");
        }
        void TextBoxRectanglesY_TextChanged(object sender, EventArgs e)
        {
            TextBoxCoordinatesHandler(TextBoxRectanglesY, "y");
        }
        void TextBoxRectanglesWidth_TextChanged(object sender, EventArgs e)
        {
            TextBoxSizeRectangleHandler(TextBoxRectanglesWidth, "width");
        }
        void TextBoxRectanglesHeight_TextChanged(object sender, EventArgs e)
        {
            TextBoxSizeRectangleHandler(TextBoxRectanglesHeight, "length");
        }

        void ButtonAddRectangle_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = RectangleFactory.Randomize(PanelRectangles, 150, 150);
            _rectangles.Add(rectangle);
            ListBoxRectangles.Items.Add(rectangle);
            Panel panel = InitialPanel(rectangle);
            panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            _rectanglePanels.Add(panel);
            PanelRectangles.Controls.Add(panel);
            FindCollisions(rectangle);
        }
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
        void ListBoxRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxRectangles.SelectedItem == null) return;
            _currentRectangle = (Rectangle)ListBoxRectangles.SelectedItem;
            UpdateRectangleInfo(_currentRectangle, ListBoxRectangles.SelectedIndex);
        }
        void TextBoxDisable(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Resizing a rectangle
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="dimensionType">"width" or "length"</param>
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

                textBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        /// <summary>
        /// Moving a rectangle
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="coordinateType">"x" or "y"</param>
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
                textBox.BackColor = System.Drawing.Color.White;
            }
            catch (Exception)
            {
                textBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
        void ListBoxSelectedRectangleUpdate()
        {
            int indexRectangles = ListBoxRectangles.Items.IndexOf(_currentRectangle);
            ListBoxRectangles.Items.RemoveAt(indexRectangles);
            ListBoxRectangles.Items.Insert(indexRectangles, _currentRectangle);
            ListBoxRectangles.SelectedIndex = indexRectangles;
            Panel panel = InitialPanel(_currentRectangle);
            panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            _rectanglePanels[indexRectangles] = panel;
            PanelRectangles.Controls.Clear();
            PanelRectangles.Controls.AddRange(_rectanglePanels.ToArray());
            FindCollisions(_currentRectangle);
        }
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
                    _rectanglePanels[ListBoxRectangles.Items.IndexOf(e)].BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
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
                    _rectanglePanels[ListBoxRectangles.Items.IndexOf(r)].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                    flag = true;
                }
            }
            if (flag)
            {
                _intersecting.Add(rectangle);
                _rectanglePanels[ListBoxRectangles.Items.IndexOf(rectangle)].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
            }
        }
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
        void ClearRectangleInfo()
        {
            foreach (TextBox tb in CustomMethods.TextBoxRectangles)
            {
                tb.Clear();
                tb.BackColor = System.Drawing.Color.White;
            }
            foreach (TextBox tb in CustomMethods.TextBoxClassesRectangles)
            {
                tb.Clear();
                tb.BackColor = System.Drawing.Color.White;
            }
        }
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