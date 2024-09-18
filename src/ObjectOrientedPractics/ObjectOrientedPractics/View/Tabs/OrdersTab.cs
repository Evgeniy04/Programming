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
using Newtonsoft.Json.Linq;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Представляет вкладку управления заказами.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Флаг, указывающий на системные изменения, чтобы избежать лишних действий при обновлении UI.
        /// </summary>
        bool _isSystemChanged = false;
        /// <summary>
        /// Выбранный заказ.
        /// </summary>
        Order? _selectedOrder;
        /// <summary>
        /// Список клиентов.
        /// </summary>
        List<Customer> _customers;
        /// <summary>
        /// Словарь для привязки заказа для таблицы к заказу клиента.
        /// </summary>
        Dictionary<OrderForDataGridView, Order> _data = [];
        /// <summary>
        /// Источник привязки данных для заказов.
        /// </summary>
        BindingSource _bindingSource = [];

        /// <summary>
        /// Список заказов с полными именами клиентов.
        /// </summary>
        BindingList<OrderForDataGridView> OrdersWithCustomerFullname { get; set; }
        /// <summary>
        /// Выбранный приоритетный заказ.
        /// </summary>
        PriorityOrder? SelectedPriorityOrder { get; set; }

        Order? SelectedOrder
        {
            get
            {
                return _selectedOrder;
            }
            set
            {
                if (value is PriorityOrder priority)
                {
                    SelectedPriorityOrder = priority;
                    PriorityOptionsPanel.Visible = true;
                    DeliveryTimeComboBox.SelectedValue = priority.DesiredDeliveryTimeRange;
                }
                _selectedOrder = value;
            }
        }

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
            DeliveryTimeComboBox.DataSource = Enum.GetValues(typeof(DeliveryTimeRange))
            .Cast<DeliveryTimeRange>()
            .Select(range => new { Value = range, Display = GetDisplayName(range) })
            .ToList();
            DeliveryTimeComboBox.DisplayMember = "Display";
            DeliveryTimeComboBox.ValueMember = "Value";
            PriorityOptionsPanel.Visible = false;
        }

        /// <summary>
        /// Обрабатывает событие клика на ячейке DataGridView для отображения данных заказа.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void OrdersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PriorityOptionsPanel.Visible = false;
            SelectedOrder = null;
            SelectedPriorityOrder = null;
            if (OrdersDataGridView.CurrentRow == null) return;
            OrderItemsListBox.Items.Clear();
            OrderForDataGridView order = (OrderForDataGridView)OrdersDataGridView.CurrentRow.DataBoundItem;
            SelectedOrder = _data[order];
            IdTextBox.Text = SelectedOrder.Id.ToString();
            ChangedAtTextBox.Text = SelectedOrder.StatusHistory.Aggregate((l, r) => l.Key > r.Key ? l : r).Key.ToString();
            StatusComboBox.SelectedItem = SelectedOrder.Status;
            OrderItemsListBox.Items.AddRange(SelectedOrder.Items.ToArray());
            AddressControl.Address = SelectedOrder.Address;
            UpdateAmount();
        }

        /// <summary>
        /// Обрабатывает изменение выбранного элемента в ComboBox для статуса заказа.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedOrder != null && StatusComboBox.SelectedItem != null && !_isSystemChanged)
            {
                SelectedOrder.Status = (OrderStatus)StatusComboBox.SelectedItem;
                OrdersDataGridView.CurrentRow.Cells["Status"].Value = (OrderStatus)StatusComboBox.SelectedItem;
                ChangedAtTextBox.Text = SelectedOrder.StatusHistory.Aggregate((l, r) => l.Key > r.Key ? l : r).Key.ToString();
            }
        }

        /// <summary>
        /// Обрабатывает изменение выбранного элемента в ComboBox для времени доставки заказа.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Аргументы события.</param>
        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedPriorityOrder == null || DeliveryTimeComboBox.SelectedValue == null || _isSystemChanged) return;
            SelectedPriorityOrder.DesiredDeliveryTimeRange = (DeliveryTimeRange)DeliveryTimeComboBox.SelectedValue;
        }

        /// <summary>
        /// Обрабатывает событие изменения текста в поле поиска FindTextBox. 
        /// Фильтрует заказы в зависимости от введенного текста и обновляет таблицу с заказами.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Параметры события изменения текста.</param>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_isSystemChanged) return;
            _isSystemChanged = true;
            Reset();
            if (FindTextBox.Text.Length == 0 || OrdersWithCustomerFullname.Count == 0)
            {
                _bindingSource.DataSource = OrdersWithCustomerFullname;
                if (OrdersDataGridView.Columns.Contains("StatusHistory")) OrdersDataGridView.Columns.Remove("StatusHistory");
                if (OrdersDataGridView.Columns.Contains("DeliveryTimeComboBox")) OrdersDataGridView.Columns.Remove("DeliveryTimeComboBox");
                _isSystemChanged = false;
                return;
            };

            string search = FindTextBox.Text.ToLower();
            // Фильтрация данных
            List<OrderForDataGridView>? filteredOrders = OrdersWithCustomerFullname
                .Where(order =>
                {
                    List<bool> flags = [];
                    foreach (var prop in typeof(OrderForDataGridView).GetProperties())
                    {
                        flags.Add(prop.GetValue(order)!.ToString()!.ToLower().Contains(search));
                    }
                    return flags.Any(b => b);
                })
                .ToList();

            // Обновляем BindingSource с отфильтрованными данными
            _bindingSource.DataSource = filteredOrders;
            if (OrdersDataGridView.Columns.Contains("StatusHistory")) OrdersDataGridView.Columns.Remove("StatusHistory");
            if (OrdersDataGridView.Columns.Contains("DeliveryTimeComboBox")) OrdersDataGridView.Columns.Remove("DeliveryTimeComboBox");
            _isSystemChanged = false;
        }

        /// <summary>
        /// Отображение только приоритетных заказов.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Параметры события изменения текста.</param>
        private void ShowOnlyPriorityOrdersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_isSystemChanged) return;
            _isSystemChanged = true;
            Reset();
            if (!ShowOnlyPriorityOrdersCheckBox.Checked || OrdersWithCustomerFullname.Count == 0)
            {
                _bindingSource.DataSource = OrdersWithCustomerFullname;
                if (OrdersDataGridView.Columns.Contains("StatusHistory")) OrdersDataGridView.Columns.Remove("StatusHistory");
                if (OrdersDataGridView.Columns.Contains("DeliveryTimeComboBox")) OrdersDataGridView.Columns.Remove("DeliveryTimeComboBox");
                _isSystemChanged = false;
                return;
            };

            // Фильтрация данных
            List<OrderForDataGridView>? filteredOrders = OrdersWithCustomerFullname
                .Where(order =>
                {
                    return order.IsPriority;
                })
                .ToList();

            // Обновляем BindingSource с отфильтрованными данными
            _bindingSource.DataSource = filteredOrders;
            if (OrdersDataGridView.Columns.Contains("StatusHistory")) OrdersDataGridView.Columns.Remove("StatusHistory");
            if (OrdersDataGridView.Columns.Contains("DeliveryTimeComboBox")) OrdersDataGridView.Columns.Remove("DeliveryTimeComboBox");
            _isSystemChanged = false;
        }

        /// <summary>
        /// Сброс всех элементов.
        /// </summary>
        private void Reset()
        {
            // Очистка выделения и сброс текущей позиции
            OrdersDataGridView.ClearSelection();
            SelectedOrder = null;
            OrderItemsListBox.Items.Clear();
            IdTextBox.Text = "";
            ChangedAtTextBox.Text = "";
            StatusComboBox.SelectedItem = null;
            DeliveryTimeComboBox.SelectedValue = DeliveryTimeRange.Range9To11;
            AddressControl.Address = new Address();
        }

        /// <summary>
        /// Обновляет информацию о сумме товаров в корзине и отображает ее в AmountLabel.
        /// </summary>
        private void UpdateAmount()
        {
            if (SelectedOrder == null)
            {
                AmountLabel.Text = "0";
                return;
            };
            AmountLabel.Text = SelectedOrder.Amount.ToString();
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
                    OrderForDataGridView orderForDataGridView = new OrderForDataGridView(order, order is PriorityOrder, customer.Fullname);
                    OrdersWithCustomerFullname.Add(orderForDataGridView);
                    _data.Add(orderForDataGridView, order);
                }
            });
            _bindingSource.DataSource = OrdersWithCustomerFullname;
            OrdersDataGridView.DataSource = _bindingSource;
            if (OrdersDataGridView.Columns.Contains("StatusHistory")) OrdersDataGridView.Columns.Remove("StatusHistory");
            if (OrdersDataGridView.Columns.Contains("IsPriority")) OrdersDataGridView.Columns.Remove("IsPriority");
        }

        /// <summary>
        /// Получить выбранный диапазон в удобном формате.
        /// </summary>
        /// <param name="range">Выбранный диапазон.</param>
        /// <returns>Строка в которой написаны диапазоны в удобном формате.</returns>
        private string GetDisplayName(DeliveryTimeRange range)
        {
            switch (range)
            {
                case DeliveryTimeRange.Range9To11:
                    return "9:00 – 11:00";
                case DeliveryTimeRange.Range11To13:
                    return "11:00 – 13:00";
                case DeliveryTimeRange.Range13To15:
                    return "13:00 – 15:00";
                case DeliveryTimeRange.Range15To17:
                    return "15:00 – 17:00";
                case DeliveryTimeRange.Range17To19:
                    return "17:00 – 19:00";
                case DeliveryTimeRange.Range19To21:
                    return "19:00 – 21:00";
                default:
                    return string.Empty;
            }
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
            SelectedOrder = null;
            SelectedPriorityOrder = null;
            _data.Clear();
            OrderItemsListBox.Items.Clear();
            OrdersWithCustomerFullname.Clear();
            OrdersDataGridView.ClearSelection();
            IdTextBox.Text = "";
            ChangedAtTextBox.Text = "";
            StatusComboBox.SelectedItem = null;
            DeliveryTimeComboBox.SelectedValue = DeliveryTimeRange.Range9To11;
            AddressControl.Address = new Address();
            UpdateAmount();
            UpdateOrders();
        }
    }
}
