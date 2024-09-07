using System;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// Панель проверки введённого текста на соответствие дню недели.
    /// </summary>
    public partial class WeekdayParsingPanel : UserControl
    {
        /// <summary>
        /// Цвет панели.
        /// </summary>
        private System.Drawing.Color _color;

        /// <summary>
        /// Возвращает и задаёт цвет панели.
        /// </summary>
        public System.Drawing.Color Color
        {
            get { return _color; }
            set
            {
                _color = value;
                this.BackColor = _color;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="WeekdayParsingPanel"/>.
        /// </summary>
        public WeekdayParsingPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия кнопки разбора дня недели.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события нажатия кнопки.</param>
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
