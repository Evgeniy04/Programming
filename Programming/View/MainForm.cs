using System.Windows.Forms;

namespace Programming
{
    /// <summary>
    /// Главная форма приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик изменения сезона панели SeasonsHandlePanel.
        /// </summary>
        /// <param name="sender">Объект-отправитель.</param>
        /// <param name="e">Аргументы события изменения сезона.</param>
        private void SeasonsHandlePanel_SeasonChanged(object sender, View.Panels.SeasonChangedEventArgs e)
        {
            SetBackColor(e.Season == Season.Autumn ? AppColors.Autumn : AppColors.Spring);
        }

        /// <summary>
        /// Устанавливает цвет фона.
        /// </summary>
        /// <param name="color">Цвет фона.</param>
        private void SetBackColor(System.Drawing.Color color)
        {
            GroupBoxEnumerations.BackColor = color;
            GroupBoxWeekdayParsing.BackColor = color;
            GroupBoxSeasonHandle.BackColor = color;
            this.BackColor = color;
        }
    }
}
