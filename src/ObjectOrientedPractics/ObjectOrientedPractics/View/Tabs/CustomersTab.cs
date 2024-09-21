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
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{

    /// <summary>
    /// Класс управления вкладкой товаров (CustomersTab).
    /// Позволяет добавлять, удалять и редактировать список клиентов.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список клиентов.
        /// </summary>
        List<Customer> _customers;
        /// <summary>
        /// Текущий выбранный клиент.
        /// </summary>
        Customer _currentCustomer;
        /// <summary>
        /// Флаг, указывающий на системные изменения, чтобы избежать лишних действий при обновлении UI.
        /// </summary>
        bool _isSystemChanged = false;

        /// <summary>
        /// Получает или задает список клиентов.
        /// При установке значения добавляет клиентов в ListBox и вызывает событие сброса выбранного элемента.
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
                CustomersListBox.Items.AddRange(value.ToArray());
                SelectedCustomerEvent(true);
            }
        }
        /// <summary>
        /// Получает или задает список товаров.
        /// </summary>
        /// <value>Список объектов <see cref="Item"/>, представляющий товары.</value>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр <c>CustomersTab</c>.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            SelectedCustomerEvent(true);
        }

        /// <summary>
        /// Обработчик события нажатия кнопки добавления нового клиента.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Customers.Add(new Customer());
            CustomersListBox.Items.Add(Customers[Customers.Count - 1]);
        }

        /// <summary>
        /// Обработчик события нажатия кнопки удаления текущего клиента.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer != null)
            {
                Customers.Remove(_currentCustomer);
                CustomersListBox.Items.Remove(_currentCustomer);
                SelectedCustomerEvent(true);
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки для генерации случайных данных клиента.
        /// </summary>
        /// <param name="sender">Источник события, кнопка.</param>
        /// <param name="e">Аргументы события клика.</param>
        private void CustomerDataGenerateButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || CustomersListBox.SelectedItems == null || !int.TryParse(IdTextBox.Text, out int _)) return;
            Customer customer = CustomerFactory.Randomize();
            _currentCustomer.Fullname = customer.Fullname;
            _currentCustomer.Address = customer.Address;
            SelectedCustomerEvent();
            UpdateCustomersListBox();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки для генерации случайных заказов клиента.
        /// </summary>
        /// <param name="sender">Источник события, кнопка.</param>
        /// <param name="e">Аргументы события клика.</param>
        private void AddOrderGenerateButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || CustomersListBox.SelectedItems == null || !int.TryParse(IdTextBox.Text, out int _)) return;

            Order order = new OrderFactory().Randomize(_currentCustomer.Address, Items);
            PriorityOrder priorityOrder = new(order.Id, order.StatusHistory, order.Status, order.Address, order.Items, DateTime.Now.AddDays(7), DeliveryTimeRange.Range9To11);
            _currentCustomer.Orders.Add(_currentCustomer.IsPriority ? priorityOrder : order);
        }

        /// <summary>
        /// Обрабатывает изменение приоритета клиента.
        /// </summary>
        /// <param name="sender">Источник события, кнопка.</param>
        /// <param name="e">Аргументы события клика.</param>
        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_currentCustomer == null || _isSystemChanged) return;

            _currentCustomer.IsPriority = IsPriorityCheckBox.Checked;
        }

        /// <summary>
        /// Обработчик изменения текста в поле имени клиента.
        /// Обновляет информацию о клиенте и обрабатывает ошибки ввода.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentCustomer == null || _isSystemChanged) return;

            try
            {
                FullnameTextBox.BackColor = Color.White;
                _currentCustomer.Fullname = FullnameTextBox.Text;
                UpdateCustomersListBox();
            }
            catch (ArgumentException error)
            {
                CreateTooltip(FullnameTextBox, error.Message);
                FullnameTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Обработчик выбора клиента в списке.
        /// Обновляет текущего клиента и отображает его данные.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null)
            {
                _currentCustomer = (Customer)CustomersListBox.SelectedItem;
                _isSystemChanged = true;
                SelectedCustomerEvent();
                _isSystemChanged = false;
            }
        }

        /// <summary>
        /// Обновляет список клиентов в <c>CustomersListBox</c> и выделяет текущего клиента.
        /// </summary>
        private void UpdateCustomersListBox()
        {
            CustomersListBox.Items.Clear();
            CustomersListBox.Items.AddRange(Customers.ToArray());
            CustomersListBox.SelectedItem = _currentCustomer;
        }

        /// <summary>
        /// Обновляет текстовые поля в зависимости от выбранного клиента.
        /// </summary>
        /// <param name="isEmpty">Указывает, отображать ли заглушку.</param>
        private void SelectedCustomerEvent(bool isEmpty = false)
        {
            IdTextBox.BackColor = FullnameTextBox.BackColor = Color.White;
            IdTextBox.Text = isEmpty ? "Ничего не выбрано" : _currentCustomer.Id.ToString();
            FullnameTextBox.Text = isEmpty ? "" : _currentCustomer.Fullname.ToString();
            IsPriorityCheckBox.Checked = isEmpty ? false : _currentCustomer.IsPriority;
            AddressControl.Address = isEmpty ? new Address() : _currentCustomer.Address;
            DiscountsTab.Discounts = isEmpty ? null : _currentCustomer.Discounts;
        }

        /// <summary>
        /// Создает подсказку с сообщением об ошибке для текстового поля.
        /// </summary>
        /// <param name="textBox">Текстовое поле, для которого создается подсказка.</param>
        /// <param name="errorMessage">Сообщение об ошибке.</param>
        private void CreateTooltip(TextBox textBox, string errorMessage)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutomaticDelay = 500;
            toolTip.SetToolTip(textBox, errorMessage);
        }

        /// <summary>
        /// Отключает ввод текста в текстовое поле.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void DisableTextBox(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
