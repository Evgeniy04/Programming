using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Forms
{
    /// <summary>
    /// Форма для добавления новой процентной скидки.
    /// </summary>
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Получает или задает процентную скидку, которая будет добавлена.
        /// </summary>
        public PercentDiscount PercentDiscount { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр формы AddDiscountForm и заполняет список категорий.
        /// </summary>
        public AddDiscountForm()
        {
            InitializeComponent();
            PercentDiscount = new PercentDiscount();
            CategoryComboBox.Items.AddRange(Enum.GetValues(typeof(Category)).Cast<object>().ToArray());
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки ОК.
        /// Проверяет, выбрана ли категория, и закрывает форму, возвращая результат ОК.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("Вы не выбрали категорию!");
                return;
            }
            PercentDiscount.Category = (Category)CategoryComboBox.SelectedItem;
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки Отмена.
        /// Закрывает форму с результатом Cancel.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
