using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SeasonsHandlePanel_SeasonChanged(object sender, View.Panels.SeasonChangedEventArgs e)
        {
            SetBackColor(e.Season == Season.Autumn ? AppColors.Autumn : AppColors.Spring);
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
