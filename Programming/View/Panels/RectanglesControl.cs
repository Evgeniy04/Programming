using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class RectanglesControl : UserControl
    {
        private List<Rectangle> _rectangles = new List<Rectangle>();
        private Rectangle _currentRectangle;
        public RectanglesControl()
        {
            InitializeComponent();
            CustomMethods.TextBoxClassesRectangles = new TextBox[6] {   TextBoxClassesRectanglesId,
                                                                        TextBoxClassesRectanglesColor,
                                                                        TextBoxClassesRectanglesWidth,
                                                                        TextBoxClassesRectanglesLength,
                                                                        TextBoxClassesRectanglesCoordinateX,
                                                                        TextBoxClassesRectanglesCoordinateY };
        }

        private void ListBoxClassesRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    if (ListBoxClassesRectangles.SelectedItem == null) return;
            //    _currentRectangle = (Rectangle)ListBoxClassesRectangles.SelectedItem;
            //    UpdateRectangleInfo(_currentRectangle, ListBoxClassesRectangles.SelectedIndex);
        }

        private void TextBoxClassesRectanglesColor_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null) return;
            if (CustomMethods.TryGetEnumValue<Color>(TextBoxClassesRectanglesColor.Text, out Color value))
            {
                _currentRectangle.Color = value;
                TextBoxClassesRectanglesColor.BackColor = System.Drawing.Color.White;
            }
            else
            {
                TextBoxClassesRectanglesColor.BackColor = System.Drawing.Color.LightPink;
            }
        }
        private void TextBoxClassesRectanglesLength_TextChanged(object sender, EventArgs e)
        {
            //TextBoxSizeRectangleHandler(TextBoxClassesRectanglesLength, "length");
        }
        private void TextBoxClassesRectanglesWidth_TextChanged(object sender, EventArgs e)
        {
            //TextBoxSizeRectangleHandler(TextBoxClassesRectanglesWidth, "width");
        }
        private void ButtonFindRectangleWithMaxWidth_Click(object sender, EventArgs e)
        {
            ListBoxClassesRectangles.SelectedIndex = FindItemWithMaxValue(_rectangles, (rectangle) => rectangle.Width);
        }
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
        private void TextBoxDisable(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
