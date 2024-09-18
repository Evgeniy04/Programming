using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Представляет пользовательский элемент управления для работы с корзиной и клиентами.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Список доступных товаров.
        /// </summary>
        List<Item> _items;
        /// <summary>
        /// Список клиентов.
        /// </summary>
        List<Customer> _customers;

        /// <summary>
        /// Возвращает текущего выбранного клиента из CustomerComboBox.
        /// Возвращает null, если клиент не выбран.
        /// </summary>
        private Customer? CurrentCustomer
        {
            get
            {
                if (CustomerComboBox.SelectedIndex == -1 || CustomerComboBox.SelectedItem == null) return null;
                return (Customer)CustomerComboBox.SelectedItem;
            }
        }
        /// <summary>
        /// Возвращает текущий выбранный товар в корзине клиента.
        /// Возвращает null, если товар не выбран.
        /// </summary>
        private Item? CurrentCartItem
        {
            get
            {
                if (CartItemsListBox.SelectedIndex == -1 || CartItemsListBox.SelectedItem == null) return null;
                return (Item)CartItemsListBox.SelectedItem;
            }
        }
        /// <summary>
        /// Возвращает текущий выбранный товар из списка доступных товаров.
        /// Возвращает null, если товар не выбран.
        /// </summary>
        private Item? CurrentItem
        {
            get
            {
                if (ItemsListBox.SelectedIndex == -1 || ItemsListBox.SelectedItem == null) return null;
                return (Item)ItemsListBox.SelectedItem;
            }
        }

        /// <summary>
        /// Возвращает или задает список доступных товаров.
        /// При установке обновляет ItemsListBox новыми товарами.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                if (value == null) return;
                _items = value;
                ItemsListBox.Items.AddRange(value.ToArray());
            }
        }

        /// <summary>
        /// Возвращает или задает список клиентов.
        /// При установке обновляет CustomerComboBox новыми клиентами.
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                if (value == null) return;
                _customers = value;
                CustomerComboBox.Items.AddRange(value.ToArray());
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса CartsTab.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Добавить в корзину".
        /// Добавляет выбранный товар в корзину текущего клиента и обновляет список корзины.
        /// </summary>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer != null && CurrentItem != null)
            {
                CurrentCustomer.Cart.Items.Add(CurrentItem);
                CartItemsListBox.Items.Add(CurrentItem);
            }
            UpdateAmount();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Удалить товар".
        /// Удаляет выбранный товар из корзины текущего клиента и обновляет список корзины.
        /// </summary>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer != null && CurrentCartItem != null)
            {
                CurrentCustomer.Cart.Items.Remove(CurrentCartItem);
                CartItemsListBox.Items.Remove(CurrentCartItem);
            }
            UpdateAmount();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Очистить корзину".
        /// Очищает все товары в корзине текущего клиента.
        /// </summary>
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            ClearCart();
            UpdateAmount();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Создать заказ".
        /// Создает новый заказ для текущего клиента на основе товаров в его корзине.
        /// </summary>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CurrentCustomer == null) return;
            if (CurrentCustomer.Cart.Items.Count < 1) return;

            Order order = new(Guid.NewGuid(), new Dictionary<DateTime, OrderStatus>(), OrderStatus.New, CurrentCustomer.Address, CurrentCustomer.Cart.Items);
            PriorityOrder priorityOrder = new(Guid.NewGuid(), new Dictionary<DateTime, OrderStatus>(), OrderStatus.New, CurrentCustomer.Address, CurrentCustomer.Cart.Items, DateTime.Now.AddDays(7), DeliveryTimeRange.Range9To11);
            CurrentCustomer.Orders.Add(CurrentCustomer.IsPriority ? priorityOrder : order);

            ClearCart();
            UpdateAmount();
        }

        /// <summary>
        /// Обрабатывает событие изменения выбранного клиента в CustomerComboBox.
        /// Обновляет список товаров в корзине для выбранного клиента.
        /// </summary>
        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CartItemsListBox.Items.Clear();
            if (CurrentCustomer == null)
            {
                UpdateAmount();
                return;
            };
            CartItemsListBox.Items.AddRange(CurrentCustomer.Cart.Items.ToArray());
            UpdateAmount();
        }

        /// <summary>
        /// Очищает все товары в корзине текущего клиента и CartItemsListBox.
        /// </summary>
        private void ClearCart()
        {
            if (CurrentCustomer != null)
            {
                CurrentCustomer.Cart.Items.Clear();
                CartItemsListBox.Items.Clear();
            }
        }

        /// <summary>
        /// Обновляет информацию о сумме товаров в корзине и отображает ее в AmountLabel.
        /// </summary>
        private void UpdateAmount()
        {
            if (CurrentCustomer == null)
            {
                AmountLabel.Text = "0";
                return;
            };
            AmountLabel.Text = CurrentCustomer.Cart.Amount.ToString();
        }

        /// <summary>
        /// Обновление данных на вкладке.
        /// </summary>
        public void RefreshData()
        {
            if (Items != null)
            {
                ItemsListBox.Items.Clear();
                ItemsListBox.Items.AddRange(Items.ToArray());
            }
            if (Customers != null)
            {
                CustomerComboBox.Items.Clear();
                CustomerComboBox.Items.AddRange(Customers.ToArray());
            }
            CustomerComboBox.SelectedItem = null;
            CartItemsListBox.Items.Clear();
            UpdateAmount();
        }
    }
}
