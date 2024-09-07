using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// Событие изменения сезона.
    /// </summary>
    public class SeasonChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Текущий сезон.
        /// </summary>
        public Season Season { get; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="SeasonChangedEventArgs"/>.
        /// </summary>
        /// <param name="season">Текущий сезон.</param>
        public SeasonChangedEventArgs(Season season)
        {
            Season = season;
        }
    }

    /// <summary>
    /// Панель выбора сезона.
    /// </summary>
    public partial class SeasonsHandlePanel : UserControl
    {
        /// <summary>
        /// Событие, возникающее при изменении сезона.
        /// </summary>
        public event EventHandler<SeasonChangedEventArgs> SeasonChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="SeasonsHandlePanel"/>.
        /// </summary>
        public SeasonsHandlePanel()
        {
            InitializeComponent();
            object[] values = Enum.GetValues(typeof(Season)).Cast<object>().ToArray();
            ComboBoxSeasons.Items.AddRange(values);
        }

        /// <summary>
        /// Обработчик нажатия кнопки управления сезоном.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события нажатия кнопки.</param>
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
