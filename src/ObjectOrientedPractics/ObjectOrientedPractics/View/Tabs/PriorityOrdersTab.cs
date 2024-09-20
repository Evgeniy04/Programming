using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Services;
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
    /// Класс для вкладки с приоритетными заказами.
    /// </summary>
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Поле приоритетного заказа.
        /// </summary>
        PriorityOrder _priorityOrder;
        /// <summary>
        /// Список доступных товаров.
        /// </summary>
        List<Item> _items;


        /// <summary>
        /// Получает и задаёт значение свойства приоритетного заказа.
        /// </summary>
        PriorityOrder PriorityOrder
        {
            get
            {
                return _priorityOrder;
            }
            set
            {
                _priorityOrder = value;
            }
        }
        /// <summary>
        /// Возвращает или задает список доступных товаров.
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
            }
        }
        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        int Id { get; set; }
        /// <summary>
        /// Дата и время создания заказа.
        /// </summary>
        DateTime CreatedAt { get; set; }

        /// <summary>
        /// Конструктор по умолчанию, инициализирующий компоненты и устанавливающий параметры вкладки.
        /// </summary>
        public PriorityOrdersTab()
        {
            InitializeComponent();
            Id = 5000;
            CreatedAt = DateTime.Now;
            UpdateTab();

            StatusComboBox.Items.AddRange(Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray());
            DeliveryTimeComboBox.DataSource = Enum.GetValues(typeof(DeliveryTimeRange))
            .Cast<DeliveryTimeRange>()
            .Select(range => new { Value = range, Display = GetDisplayName(range) })
            .ToList();
            DeliveryTimeComboBox.DisplayMember = "Display";
            DeliveryTimeComboBox.ValueMember = "Value";
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Добавить в заказ".
        /// Добавляет выбранный товар в заказ обновляет список товаров заказа.
        /// </summary>
        private void AddToOrderButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Item item = Items[random.Next(Items.Count)];
            PriorityOrder.Items.Add(item);
            OrderItemsListBox.Items.Add(item);
            UpdateAmount();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Удалить товар".
        /// Удаляет выбранный товар из заказа обновляет список заказа.
        /// </summary>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.SelectedIndex == -1 || OrderItemsListBox.SelectedItem == null) return;
            int index = OrderItemsListBox.SelectedIndex;
            Object item = OrderItemsListBox.SelectedItem;
            PriorityOrder.Items.Remove((Item)item);
            OrderItemsListBox.Items.RemoveAt(index);
            if (OrderItemsListBox.Items.Count - index <= 1)
            {
                OrderItemsListBox.SelectedIndex = OrderItemsListBox.Items.Count - 1;
            }
            else
            {
                OrderItemsListBox.SelectedIndex = index;
            }
            UpdateAmount();
        }

        /// <summary>
        /// Обрабатывает изменение выбора статуса заказа.
        /// Обновляет статус приоритетного заказа и дату последнего изменения статуса.
        /// </summary>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusComboBox.SelectedItem != null)
            {
                PriorityOrder.Status = (OrderStatus)StatusComboBox.SelectedItem;
                ChangedAtTextBox.Text = PriorityOrder.StatusHistory.Aggregate((l, r) => l.Key > r.Key ? l : r).Key.ToString();
            }
        }

        /// <summary>
        /// Обрабатывает изменение диапазона времени доставки.
        /// Обновляет желаемое время доставки для приоритетного заказа.
        /// </summary>
        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeliveryTimeComboBox.SelectedValue == null) return;
            PriorityOrder.DesiredDeliveryTimeRange = (DeliveryTimeRange)DeliveryTimeComboBox.SelectedValue;
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Очистить корзину".
        /// Очищает все товары в заказе.
        /// </summary>
        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            PriorityOrder.Items = new List<Item>();
            ClearOrder();
            UpdateAmount();
        }

        /// <summary>
        /// Очищает все товары в заказе и OrderItemsListBox.
        /// </summary>
        private void ClearOrder()
        {
            UpdateTab();
            PriorityOrder.Items.Clear();
            OrderItemsListBox.Items.Clear();
        }

        /// <summary>
        /// Обновляет информацию о сумме товаров в заказе и отображает ее в AmountLabel.
        /// </summary>
        private void UpdateAmount()
        {
            AmountLabel.Text = PriorityOrder.Amount.ToString();
        }

        /// <summary>
        /// Обновляет данные во вкладке, создавая новый приоритетный заказ с предустановленными параметрами.
        /// </summary>
        private void UpdateTab()
        {
            Order order = new(Guid.NewGuid(), new Dictionary<DateTime, OrderStatus>(), OrderStatus.New, AddressFactory.Randomize(), new List<Item>());
            PriorityOrder = new PriorityOrder(Guid.NewGuid(), new Dictionary<DateTime, OrderStatus>(), OrderStatus.New, AddressFactory.Randomize(), new List<Item>(), DateTime.Now.AddDays(7), DeliveryTimeRange.Range9To11);
            IdTextBox.Text = PriorityOrder.Id.ToString();
            ChangedAtTextBox.Text = PriorityOrder.StatusHistory.Aggregate((l, r) => l.Key > r.Key ? l : r).Key.ToString();
            AddressControl.Address = PriorityOrder.Address;
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
    }
}
