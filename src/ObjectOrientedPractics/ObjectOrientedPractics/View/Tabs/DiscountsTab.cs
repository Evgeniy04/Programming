using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.View.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Вкладка управления скидками.
    /// </summary>
    public partial class DiscountsTab : UserControl
    {
        /// <summary>
        /// Список скидок, доступных клиенту.
        /// </summary>
        List<IDiscount>? _discounts;

        /// <summary>
        /// Получает или задает список скидок. При установке обновляет отображение скидок.
        /// </summary>
        public List<IDiscount>? Discounts
        {
            get
            {
                return _discounts;
            }
            set
            {
                _discounts = value;
                UpdateDiscounts();
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса DiscountsTab.
        /// </summary>
        public DiscountsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки добавления скидки.
        /// Открывает форму для добавления новой скидки.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Discounts == null) return;
            using (AddDiscountForm addDiscountForm = new AddDiscountForm())
            {
                if (addDiscountForm.ShowDialog() == DialogResult.OK)
                {
                    Discounts.Add(addDiscountForm.PercentDiscount);
                    DiscountsListBox.Items.Add(addDiscountForm.PercentDiscount);
                }
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки удаления скидки.
        /// Удаляет выбранную скидку из списка, если она не является накопительной.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (Discounts == null || DiscountsListBox.SelectedItem == null) return;
            if (DiscountsListBox.SelectedItem is PointsDiscount)
            {
                MessageBox.Show("Нельзя удалить накопительную скидку!");
                return;
            }
            Discounts.Remove((IDiscount)DiscountsListBox.SelectedItem);
            DiscountsListBox.Items.Remove(DiscountsListBox.SelectedItem);
        }

        /// <summary>
        /// Обновляет список скидок в интерфейсе.
        /// Если список пуст, добавляет накопительную скидку по умолчанию.
        /// </summary>
        private void UpdateDiscounts()
        {
            DiscountsListBox.Items.Clear();
            if (Discounts == null) return;
            if (Discounts.Count == 0)
            {
                Discounts.Add(new PointsDiscount(0));
            }
            DiscountsListBox.Items.AddRange(Discounts.ToArray());
        }
    }
}
