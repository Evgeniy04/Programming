using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using System.Collections;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Представляет вкладку управления заказами.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        OrderWithCustomerFullname? _currentOrder;
        /// <summary>
        /// Список клиентов.
        /// </summary>
        List<Customer> _customers;
        /// <summary>
        /// Словарь для привязки заказа к клиенту.
        /// </summary>
        Dictionary<OrderWithCustomerFullname, Customer> _data = [];
        /// <summary>
        /// Источник привязки данных для заказов.
        /// </summary>
        BindingSource _bindingSource = [];

        /// <summary>
        /// Список заказов с полными именами клиентов.
        /// </summary>
        BindingList<OrderWithCustomerFullname> OrdersWithCustomerFullname { get; set; }
        /// <summary>
        /// Получает или задает список клиентов.
        /// При установке значения вызывает метод обновления заказов.
        /// </summary>
        /// <value>Список объектов <see cref="Customer"/>, представляющий клиентов.</value>
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
                UpdateOrders();
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="OrdersTab"/>.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
            OrdersWithCustomerFullname = [];
            StatusComboBox.Items.AddRange(Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray());
        }

        /// <summary>
        /// Обрабатывает событие клика на ячейке DataGridView для отображения данных заказа.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void OrdersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OrdersDataGridView.CurrentRow != null)
            {
                OrderItemsListBox.Items.Clear();
                _currentOrder = (OrderWithCustomerFullname)OrdersDataGridView.CurrentRow.DataBoundItem;
                IdTextBox.Text = _currentOrder.Id.ToString();
                ChangedAtTextBox.Text = _currentOrder.StatusHistory.Aggregate((l, r) => l.Key > r.Key ? l : r).Key.ToString();
                StatusComboBox.SelectedItem = _currentOrder.Status;
                OrderItemsListBox.Items.AddRange(_currentOrder.Items.ToArray());
                AddressControl.Address = _currentOrder.Address;
                UpdateAmount();
            }
        }

        /// <summary>
        /// Обрабатывает изменение выбранного элемента в ComboBox для статуса заказа.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentOrder != null && StatusComboBox.SelectedItem != null)
            {
                _data[_currentOrder].Orders.Find((order) => order.Id == _currentOrder.Id)!.Status = (OrderStatus)StatusComboBox.SelectedItem;
                OrdersDataGridView.CurrentRow.Cells["Status"].Value = (OrderStatus)StatusComboBox.SelectedItem;
                ChangedAtTextBox.Text = _currentOrder.StatusHistory.Aggregate((l, r) => l.Key > r.Key ? l : r).Key.ToString();
            }
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FindTextBox.Text.Length == 0 || OrdersWithCustomerFullname.Count == 0)
            {
                _bindingSource.DataSource = OrdersWithCustomerFullname;
                if (OrdersDataGridView.Columns.Contains("StatusHistory")) OrdersDataGridView.Columns.Remove("StatusHistory");
                return;
            };
            OrdersDataGridView.ClearSelection();
            _currentOrder = null;
            OrderItemsListBox.Items.Clear();
            IdTextBox.Text = "";
            ChangedAtTextBox.Text = "";
            StatusComboBox.SelectedItem = null;
            AddressControl.Address = new Address();
            string search = FindTextBox.Text.ToLower();

            // Фильтрация данных
            List<OrderWithCustomerFullname>? filteredOrders = OrdersWithCustomerFullname
                .Where(order =>
                {
                    List<bool> flags = [];
                    foreach (var prop in typeof(OrderWithCustomerFullname).GetProperties())
                    {
                        flags.Add(prop.GetValue(order)!.ToString()!.ToLower().Contains(search));
                    }
                    return flags.Any(b => b);
                })
                .ToList();

            // Обновляем BindingSource с отфильтрованными данными
            _bindingSource.DataSource = filteredOrders;
            if (OrdersDataGridView.Columns.Contains("StatusHistory")) OrdersDataGridView.Columns.Remove("StatusHistory");
        }

        /// <summary>
        /// Обновляет информацию о сумме товаров в корзине и отображает ее в AmountLabel.
        /// </summary>
        private void UpdateAmount()
        {
            if (_currentOrder == null)
            {
                AmountLabel.Text = "0";
                return;
            };
            AmountLabel.Text = _currentOrder.Amount.ToString();
        }

        /// <summary>
        /// Обновляет список заказов, привязанный к клиентам.
        /// </summary>
        public void UpdateOrders()
        {
            Customers.ForEach((customer) =>
            {
                if (customer.Orders.Count == 0) return;
                foreach (Order order in customer.Orders)
                {
                    OrderWithCustomerFullname orderWithCustomerFullname = new OrderWithCustomerFullname(order, customer.Fullname);
                    OrdersWithCustomerFullname.Add(orderWithCustomerFullname);
                    _data.Add(orderWithCustomerFullname, customer);
                }
            });
            _bindingSource.DataSource = OrdersWithCustomerFullname;
            OrdersDataGridView.DataSource = _bindingSource;
            if (OrdersDataGridView.Columns.Contains("StatusHistory")) OrdersDataGridView.Columns.Remove("StatusHistory");
        }

        /// <summary>
        /// Отключает ввод данных в текстовое поле при нажатии клавиши.
        /// </summary>
        private void DisableTextBox(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Обновление данных на вкладке.
        /// </summary>
        public void RefreshData()
        {
            _currentOrder = null;
            _data.Clear();
            OrderItemsListBox.Items.Clear();
            OrdersWithCustomerFullname.Clear();
            OrdersDataGridView.ClearSelection();
            IdTextBox.Text = "";
            ChangedAtTextBox.Text = "";
            StatusComboBox.SelectedItem = null;
            AddressControl.Address = new Address();
            UpdateAmount();
            UpdateOrders();
        }
    }
}
