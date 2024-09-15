using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
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
                if ((_status != value && _status != OrderStatus.New && StatusHistory.Count > 0) || (value == OrderStatus.New && StatusHistory.Count <= 1))
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
                return Math.Round(sum, 2); ;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр заказа.
        /// </summary>
        /// <param name="id">Идентификатор заказа.</param>
        /// <param name="createdAt">Дата создания.</param>
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
    public class OrderWithCustomerFullname : Order
    {
        public string CustomerFullname { get; private set; }
        public string ChangedAt { get; private set; }

        public OrderWithCustomerFullname(Order order, string customerFullname)
            : base(order.Id, order.StatusHistory, order.Status, order.Address, order.Items)
        {
            CustomerFullname = customerFullname;
            ChangedAt = order.StatusHistory.Aggregate((l, r) => l.Key > r.Key ? l : r).Key.ToString();
        }
    }
}
