using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class SeasonsHandlePanel : UserControl
    {
        public SeasonsHandlePanel()
        {
            InitializeComponent();
            object[] values = Enum.GetValues(typeof(Season)).Cast<object>().ToArray();
            ComboBoxSeasons.Items.AddRange(values);
        }
        private void ButtonSeasonHandleGo_Click(object sender, EventArgs e)
        {
            if (ComboBoxSeasons.SelectedItem == null)
            {
                ComboBoxSeasons.BackColor = System.Drawing.Color.LightPink;
                return;
            }

            ComboBoxSeasons.BackColor = System.Drawing.Color.White;
            switch (ComboBoxSeasons.SelectedItem)
            {
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    MessageBox.Show("Чёто сложно как-то");
                    //SetBackColor(ColorTranslator.FromHtml("#e29c45"));
                    break;
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Spring:
                    MessageBox.Show("Чёто сложно как-то");
                    //SetBackColor(ColorTranslator.FromHtml("#559c45"));
                    break;
            }
        }
    }
}
