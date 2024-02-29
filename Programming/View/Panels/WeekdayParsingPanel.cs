using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class WeekdayParsingPanel : UserControl
    {
        private System.Drawing.Color _color;

        public System.Drawing.Color Color
        {
            get { return _color; }
            set
            {
                _color = value;
                this.BackColor = _color;
            }
        }

        public WeekdayParsingPanel()
        {
            InitializeComponent();
        }
        private void ButtonWeekdayParsing_Click(object sender, EventArgs e)
        {
            string selectedItemName = TextBoxDayInput.Text;
            if (!int.TryParse(selectedItemName, out _) &&
                CustomMethods.TryGetEnumValue<Weekday>(selectedItemName, out Weekday value))
            {
                LabelResultWeekdayParsing.Text = $"Это день недели ({value} = {(int)value})";
            }
            else
            {
                LabelResultWeekdayParsing.Text = $"Это не день недели";
            }
        }
    }
}
