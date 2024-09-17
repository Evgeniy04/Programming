using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Представляет приоритетный заказ с желаемой датой и диапазоном времени доставки.
    /// </summary>
    internal class PriorityOrder: Order
    {
        /// <summary>
        /// Желаемая дата доставки.
        /// </summary>
        public DateTime DesiredDeliveryDate { get; set; }
        /// <summary>
        /// Желаемый диапазон времени доставки.
        /// </summary>
        public DeliveryTimeRange DesiredDeliveryTimeRange { get; set; }

        /// <summary>
        /// Создает новый экземпляр приоритетного заказа с указанной датой и временем доставки.
        /// </summary>
        /// <param name="id">Идентификатор заказа.</param>
        /// <param name="statusHistory">Словарь Текущее время: статус заказа.</param>
        /// <param name="status">Статус заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров в заказе.</param>
        /// <param name="desiredDeliveryDate">Желаемая дата доставки.</param>
        /// <param name="desiredDeliveryTimeRange">Желаемый диапазон времени доставки.</param>
        public PriorityOrder(Guid id, Dictionary<DateTime, OrderStatus> statusHistory, OrderStatus status, Address address, List<Item> items, DateTime desiredDeliveryDate, DeliveryTimeRange desiredDeliveryTimeRange)
            : base(id, statusHistory, status, address, items)
        {
            DesiredDeliveryDate = desiredDeliveryDate;
            DesiredDeliveryTimeRange = desiredDeliveryTimeRange;
        }
    }
}
