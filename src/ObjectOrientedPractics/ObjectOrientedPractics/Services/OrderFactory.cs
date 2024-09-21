using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Фабрика для создания объектов типа Order.
    /// </summary>
    internal class OrderFactory
    {
        /// <summary>
        /// Создаёт объект Order с случайными значениями.
        /// </summary>
        /// <returns>Возвращает объект типа Order со случайными товарами.</returns>
        public Order Randomize(Address address, List<Item> items)
        {
            Random random = new Random();
            List<Item> cart = new List<Item>();
            items.ForEach(item => {
                cart.AddRange(Enumerable.Repeat(item, random.Next(5) * random.Next(2)));
            });
            if (cart.Count == 0 && items.Count > 0) cart.Add(items[0]);
            Order order = new(Guid.NewGuid(), new Dictionary<DateTime, OrderStatus>(), OrderStatus.New, address, cart, 0);
            return order;
        }
    }
}
