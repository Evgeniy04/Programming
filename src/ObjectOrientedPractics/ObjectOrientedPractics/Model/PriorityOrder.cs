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
        /// <param name="order">Экземпляр основного заказа.</param>
        /// <param name="desiredDeliveryDate">Желаемая дата доставки.</param>
        /// <param name="desiredDeliveryTimeRange">Желаемый диапазон времени доставки.</param>
        public PriorityOrder(Order order, DateTime desiredDeliveryDate, DeliveryTimeRange desiredDeliveryTimeRange)
            : base(order.Id, order.StatusHistory, order.Status, order.Address, order.Items)
        {
            DesiredDeliveryDate = desiredDeliveryDate;
            DesiredDeliveryTimeRange = desiredDeliveryTimeRange;
        }
    }
}
