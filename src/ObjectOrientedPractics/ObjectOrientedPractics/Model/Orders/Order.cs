using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Класс, представляющий заказ.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        Guid _id;
        /// <summary>
        /// Статус заказа.
        /// </summary>
        OrderStatus _status;
        /// <summary>
        /// Дата и время изменения статуса заказа.
        /// </summary>
        Dictionary<DateTime, OrderStatus> _statusHistory;
        /// <summary>
        /// Адрес доставки заказа.
        /// </summary>
        Address _address;
        /// <summary>
        /// Список товаров в заказе.
        /// </summary>
        List<Item> _items;
        /// <summary>
        /// Размер скидки.
        /// </summary>
        double _discountAmount;

        /// <summary>
        /// Получает уникальный идентификатор заказа.
        /// </summary>
        public Guid Id
        {
            get { return _id; }
            private set { _id = value; }
        }
        /// <summary>
        /// Получает или задает статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get { return _status; }
            set
            {
                if (_status != value && _status != OrderStatus.New && StatusHistory.Count > 0 || value == OrderStatus.New && StatusHistory.Count <= 1)
                {
                    StatusHistory.Add(DateTime.Now, value);
                }
                _status = value;
            }
        }
        /// <summary>
        /// Получает дату и время создания заказа.
        /// </summary>
        public Dictionary<DateTime, OrderStatus> StatusHistory
        {
            get { return _statusHistory; }
            private set { _statusHistory = value; }
        }
        /// <summary>
        /// Получает или задает адрес доставки заказа.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }
        /// <summary>
        /// Получает или задает список товаров в заказе.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        /// <summary>
        /// Получает общую сумму заказа.
        /// </summary>
        public double Amount
        {
            get
            {
                double sum = 0;
                Items.ForEach(x => { sum += x.Cost; });
                return Math.Round(sum, 2);
            }
        }
        /// <summary>
        /// Получает или задаёт размер скидки.
        /// </summary>
        public double DiscountAmount
        {
            get
            {
                return _discountAmount;
            }
            set
            {
                ValueValidator.AssertOnPositiveValue(value, nameof(DiscountAmount));
                _discountAmount = value;
            }
        }
        /// <summary>
        /// Получает стоимость заказа с применённой скидкой.
        /// </summary>
        public double Total
        {
            get
            {
                double total = Amount - DiscountAmount;
                ValueValidator.AssertOnPositiveValue(total, nameof(Total));
                return Amount - DiscountAmount;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр заказа.
        /// </summary>
        /// <param name="id">Идентификатор заказа.</param>
        /// <param name="statusHistory">Словарь Текущее время: статус заказа.</param>
        /// <param name="status">Статус заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров в заказе.</param>
        public Order(Guid id, Dictionary<DateTime, OrderStatus> statusHistory, OrderStatus status, Address address, List<Item> items)
        {
            Id = id;
            StatusHistory = statusHistory;
            Status = status;
            Address = address;
            Items = new List<Item>(items);
        }
    }
    /// <summary>
    /// Вспомогательный класс, представляющий заказ с полным именем клиента.
    /// </summary>
    public class OrderForDataGridView : Order
    {
        /// <summary>
        /// Иконка заказа в таблице.
        /// </summary>
        public Image Image { get; private set; }
        /// <summary>
        /// Приоритетный ли заказ.
        /// </summary>
        public bool IsPriority { get; set; }
        /// <summary>
        /// ФИО клиента.
        /// </summary>
        public string CustomerFullname { get; private set; }
        /// <summary>
        /// Последнее изменение.
        /// </summary>
        public string ChangedAt { get; private set; }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="order">Объект заказа.</param>
        /// <param name="isPriorityOrder">Является ли заказ приоритетным.</param>
        /// <param name="customerFullname">ФИО клиента.</param>
        public OrderForDataGridView(Order order, bool isPriorityOrder, string customerFullname)
            : base(order.Id, order.StatusHistory, order.Status, order.Address, order.Items)
        {
            IsPriority = isPriorityOrder;
            CustomerFullname = customerFullname;
            ChangedAt = order.StatusHistory.Aggregate((l, r) => l.Key > r.Key ? l : r).Key.ToString();

            if (IsPriority)
            {
                byte[] imageData = (byte[])Properties.Resources.ResourceManager.GetObject("Star")!;
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image = Image.FromStream(ms);
                }
            }
            else
            {
                byte[] imageData = (byte[])Properties.Resources.ResourceManager.GetObject("Snowflake")!;
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    Image = Image.FromStream(ms);
                }
            }
        }
    }
}
