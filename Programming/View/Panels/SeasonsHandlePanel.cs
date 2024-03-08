using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public class SeasonChangedEventArgs : EventArgs
    {
        public Season Season { get; }

        public SeasonChangedEventArgs(Season season)
        {
            Season = season;
        }
    }

    public partial class SeasonsHandlePanel : UserControl
    {
        public event EventHandler<SeasonChangedEventArgs> SeasonChanged;
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
                ComboBoxSeasons.BackColor = AppColors.Invalid;
                return;
            }

            ComboBoxSeasons.BackColor = AppColors.Default;
            switch (ComboBoxSeasons.SelectedItem)
            {
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    SeasonChanged.Invoke(this, new SeasonChangedEventArgs(Season.Autumn));
                    //MessageBox.Show("Чёто сложно как-то");
                    //SetBackColor(AppColors.Autumn);
                    break;
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Spring:
                    //MessageBox.Show("Чёто сложно как-то");
                    SeasonChanged.Invoke(this, new SeasonChangedEventArgs(Season.Spring));
                    //SetBackColor(AppColors.Spring);
                    break;
            }
        }
    }
}
