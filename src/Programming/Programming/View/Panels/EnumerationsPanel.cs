using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    /// <summary>
    /// 
    /// </summary>
    public partial class EnumerationsPanel : UserControl
    {
        /// <summary>
        /// Цвет элемента управления.
        /// </summary>
        private System.Drawing.Color _color;

        /// <summary>
        /// Свойство для установки цвета элемента управления.
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
        /// Создаёт экземпляр класса <see cref="EnumerationsPanel"/>.
        /// </summary>
        public EnumerationsPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события выбора элемента из списка перечислений.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события изменения текста.</param>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnumsListBox.SelectedIndex == -1) return;
            int selectedIndex = EnumsListBox.SelectedIndex;
            object[] values = Enum.GetValues(CustomMethods.TypeModel[selectedIndex]).Cast<object>().ToArray();
            TextBoxEnumsEnumerationsIntValue.Text = "";
            ValuesListBox.Items.Clear();
            ValuesListBox.Items.AddRange(values);
        }

        /// <summary>
        /// Обработчик события выбора элемента из списка значений перечисления.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события изменения текста.</param>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem == null) return;
            TextBoxEnumsEnumerationsIntValue.Text = ((int)ValuesListBox.SelectedItem).ToString();
        }

        /// <summary>
        /// Запрещает ввода текста в текстовые поля.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события нажатия клавиши.</param>
        private void TextBoxDisable(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
