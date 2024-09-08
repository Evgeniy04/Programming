using Model;
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

namespace ObjectOrientedPractics.View.Tabs
{

    /// <summary>
    /// Класс управления вкладкой товаров (CustomersTab).
    /// Позволяет добавлять, удалять и редактировать список клиентов.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Текущий выбранный клиент.
        /// </summary>
        Customer _currentCustomer;
        /// <summary>
        /// Флаг, указывающий на системные изменения, чтобы избежать лишних действий при обновлении UI.
        /// </summary>
        bool isSystemChanged = false;

        /// <summary>
        /// Инициализирует новый экземпляр <c>CustomersTab</c>.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            Provider.Customers.Add(new Customer("Аврамов Евгений Владимирович", "Деревня Гадюкино"));
            CustomersListBox.Items.AddRange(Provider.Customers.ToArray());
        }

        /// <summary>
        /// Обработчик события нажатия кнопки добавления нового клиента.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            Provider.Customers.Add(new Customer());
            CustomersListBox.Items.Add(Provider.Customers[Provider.Customers.Count - 1]);
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
                Provider.Customers.Remove(_currentCustomer);
                CustomersListBox.Items.Remove(_currentCustomer);
                SelectedItemEvent(true);
            }
        }

        /// <summary>
        /// Обработчик изменения текста в поле имени клиента.
        /// Обновляет информацию о клиенте и обрабатывает ошибки ввода.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentCustomer == null || isSystemChanged) return;

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
        /// Обработчик изменения текста в поле адреса клиента.
        /// Обновляет информацию о клиенте и обрабатывает ошибки ввода.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Данные события.</param>
        private void AddressRichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentCustomer == null || isSystemChanged) return;

            try
            {
                AddressRichTextBox.BackColor = Color.White;
                _currentCustomer.Address = AddressRichTextBox.Text;
            }
            catch (ArgumentException error)
            {
                CreateTooltip(AddressRichTextBox, error.Message);
                AddressRichTextBox.BackColor = Color.Pink;
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
            if (CustomersListBox.SelectedIndex != -1 && CustomersListBox.SelectedItem != null)
            {
                _currentCustomer = (Customer)CustomersListBox.SelectedItem;
                isSystemChanged = true;
                SelectedItemEvent();
                isSystemChanged = false;
            }
        }

        /// <summary>
        /// Обновляет список клиентов в <c>CustomersListBox</c> и выделяет текущего клиента.
        /// </summary>
        private void UpdateCustomersListBox()
        {
            CustomersListBox.Items.Clear();
            CustomersListBox.Items.AddRange(Provider.Customers.ToArray());
            CustomersListBox.SelectedItem = _currentCustomer;
        }

        /// <summary>
        /// Обновляет текстовые поля в зависимости от выбранного клиента.
        /// </summary>
        /// <param name="isEmpty">Указывает, отображать ли заглушку.</param>
        private void SelectedItemEvent(bool isEmpty = false)
        {
            IdTextBox.BackColor = FullnameTextBox.BackColor = AddressRichTextBox.BackColor = Color.White;
            IdTextBox.Text = isEmpty ? "Ничего не выбрано" : _currentCustomer.Id.ToString();
            FullnameTextBox.Text = isEmpty ? "" : _currentCustomer.Fullname.ToString();
            AddressRichTextBox.Text = isEmpty ? "" : _currentCustomer.Address.ToString();
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
        /// Создает подсказку с сообщением об ошибке для текстового поля с форматированным текстом.
        /// </summary>
        /// <param name="richTextBox">Поле с форматированным текстом, для которого создается подсказка.</param>
        /// <param name="errorMessage">Сообщение об ошибке.</param>
        private void CreateTooltip(RichTextBox richTextBox, string errorMessage)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.AutomaticDelay = 500;
            toolTip.SetToolTip(richTextBox, errorMessage);
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
