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
    public partial class EnumerationsPanel : UserControl
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
        public EnumerationsPanel()
        {
            InitializeComponent();
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnumsListBox.SelectedIndex == -1) return;
            int selectedIndex = EnumsListBox.SelectedIndex;
            object[] values = Enum.GetValues(CustomMethods.TypeModel[selectedIndex]).Cast<object>().ToArray();
            TextBoxEnumsEnumerationsIntValue.Text = "";
            ValuesListBox.Items.Clear();
            ValuesListBox.Items.AddRange(values);
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem == null) return;
            TextBoxEnumsEnumerationsIntValue.Text = ((int)ValuesListBox.SelectedItem).ToString();
        }

        private void TextBoxDisable(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
