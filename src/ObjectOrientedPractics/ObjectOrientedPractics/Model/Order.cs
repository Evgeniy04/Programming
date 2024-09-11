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
        /// Статус заказа.
        /// </summary>
        OrderStatus _status;
        /// <summary>
        /// Уникальный идентификатор заказа.
        /// </summary>
        Guid _id;
        /// <summary>
        /// Дата и время создания заказа.
        /// </summary>
        DateTime _createdAt;
        /// <summary>
        /// Адрес доставки заказа.
        /// </summary>
        Address _address;
        /// <summary>
        /// Список товаров в заказе.
        /// </summary>
        List<Item> _items;

        /// <summary>
        /// Получает или задает статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }
        /// <summary>
        /// Получает уникальный идентификатор заказа.
        /// </summary>
        public Guid Id
        {
            get { return _id; }
            private set { _id = value; }
        }
        /// <summary>
        /// Получает дату и время создания заказа.
        /// </summary>
        public DateTime CreatedAt
        {
            get { return _createdAt; }
            private set { _createdAt = value; }
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
        /// <param name="status">Статус заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров в заказе.</param>
        public Order(OrderStatus status, Address address, List<Item> items)
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            Status = status;
            Address = address;
            Items = new List<Item>(items);
        }
    }
}
