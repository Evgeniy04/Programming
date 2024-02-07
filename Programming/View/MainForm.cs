using Programming.Model;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        private readonly Type[] typeModel = new Type[] { typeof(Model.Color), typeof(EducationForm),
                                                typeof(Genre), typeof(Manufactures),
                                                typeof(Season), typeof(Weekday) };
        public MainForm()
        {
            InitializeComponent();

            // 
            // Initialize ComboBoxSeasons
            // 
            object[] values = Enum.GetValues(typeof(Season)).Cast<object>().ToArray();
            ComboBoxSeasons.Items.AddRange(values);
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = EnumsListBox.SelectedIndex;
            object[] values = Enum.GetValues(typeModel[selectedIndex]).Cast<object>().ToArray();
            IntValue.Text = "";
            ValuesListBox.Items.Clear();
            ValuesListBox.Items.AddRange(values);
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type selectedItemType = ValuesListBox.SelectedItem.GetType();
            string selectedItemName = ValuesListBox.SelectedItem.ToString();
            if (TryGetEnumValue(selectedItemType, selectedItemName, out object value))
            {
                IntValue.Text = Convert.ToInt32(value).ToString();
            }
        }

        private void ButtonWeekdayParsing_Click(object sender, EventArgs e)
        {
            string selectedItemName = TextBoxDayInput.Text;
            if (TryGetEnumValue<Weekday>(selectedItemName, out Weekday value))
            {
                LabelResultWeekdayParsing.Text = $"Это день недели ({value} = {Convert.ToInt32(value)})";
            } else
            {
                LabelResultWeekdayParsing.Text = $"Это не день недели";
            }
        }

        private void ButtonSeasonHandleGo_Click(object sender, EventArgs e)
        {
            switch (ComboBoxSeasons.SelectedItem.ToString())
            {
                case "Summer":
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Autumn":
                    SetBackColor(GroupBoxSeasonHandle.BackColor = ColorTranslator.FromHtml("#e29c45"));
                    break;
                case "Winter":
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case "Spring":
                    SetBackColor(GroupBoxSeasonHandle.BackColor = ColorTranslator.FromHtml("#559c45"));
                    break;
            }
        }

        private bool TryGetEnumValue(Type itemType, string itemName, out object value)
        {
            if (itemType != null && typeModel.Contains(itemType))
            {
                value = Enum.Parse(itemType, itemName);
                return true;
            }
            value = null;
            return false;
        }

        private bool TryGetEnumValue<T>(string itemName, out T value) where T : struct
        {
            if (Enum.TryParse<T>(itemName, true, out value))
            {
                return true;
            }
            value = default;
            return false;
        }

        private void SetBackColor(System.Drawing.Color color)
        {
            GroupBoxEnumerations.BackColor = color;
            GroupBoxWeekdayParsing.BackColor = color;
            GroupBoxSeasonHandle.BackColor = color;
            this.BackColor = color;
        }
    }
}
