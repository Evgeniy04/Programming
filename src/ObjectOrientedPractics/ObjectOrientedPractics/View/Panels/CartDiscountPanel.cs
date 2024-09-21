using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Panels
{
    /// <summary>
    /// Панель применения скидок к заказу в корзине.
    /// </summary>
    public partial class CartDiscountPanel : UserControl
    {
        /// <summary>
        /// Клиент, к которому применяются скидки.
        /// </summary>
        Customer? _customer;

        /// <summary>
        /// Получает или устанавливает клиента. При установке обновляются скидки в списке.
        /// </summary>
        public Customer? Customer
        {
            get
            {
                return _customer;
            }
            set
            {
                _customer = value;
                UpdateDiscountsCheckedListBox();
            }
        }
        /// <summary>
        /// Метка для отображения итоговой суммы.
        /// </summary>
        public Label TotalLabel { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр панели скидок.
        /// </summary>
        public CartDiscountPanel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик события изменения выбранного элемента в списке скидок.
        /// Обновляет скидку и общую сумму.
        /// </summary>
        private void DiscountsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDiscountAndTotalAmount();
        }

        /// <summary>
        /// Обновляет список доступных скидок в CheckedListBox.
        /// Устанавливает флажки для всех скидок.
        /// </summary>
        private void UpdateDiscountsCheckedListBox()
        {
            DiscountsCheckedListBox.Items.Clear();
            if (Customer == null) return;
            DiscountsCheckedListBox.Items.AddRange(Customer.Discounts.ToArray());
            CheckAllItems();
            UpdateDiscountAndTotalAmount();
        }

        /// <summary>
        /// Устанавливает флажки для всех элементов в списке скидок.
        /// </summary>
        private void CheckAllItems()
        {
            for (int i = 0; i < DiscountsCheckedListBox.Items.Count; i++)
            {
                DiscountsCheckedListBox.SetItemChecked(i, true);
            }
        }

        /// <summary>
        /// Обновляет сумму скидки и итоговую сумму заказа.
        /// </summary>
        private void UpdateDiscountAndTotalAmount()
        {
            int discountAmount = 0;
            DiscountAmountLabel.Text = "0";
            TotalLabel.Text = "0";
            if (Customer == null) return;
            foreach (IDiscount discount in DiscountsCheckedListBox.CheckedItems)
            {
                discountAmount += (int)discount.Calculate(Customer.Cart.Items);
            }
            DiscountAmountLabel.Text = discountAmount.ToString();
            TotalLabel.Text = (Customer.Cart.Amount - discountAmount).ToString();
        }

        /// <summary>
        /// Создает заказ, применяя выбранные скидки.
        /// Обновляет информацию о скидках и возвращает общую сумму скидки.
        /// </summary>
        /// <returns>Сумма примененных скидок.</returns>
        public int CreateOrder()
        {
            int discountAmount = 0;
            DiscountAmountLabel.Text = "0";
            TotalLabel.Text = "0";
            if (Customer == null) return 0;
            foreach (IDiscount discount in DiscountsCheckedListBox.CheckedItems)
            {
                discountAmount += (int)discount.Apply(Customer.Cart.Items);
            }

            foreach (IDiscount discount in Customer.Discounts)
            {
                discount.Update(Customer.Cart.Items);
            }
            UpdateDiscountsCheckedListBox();
            return discountAmount;
        }
    }
}
