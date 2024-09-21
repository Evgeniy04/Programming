using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, представляющий корзину покупок.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Список товаров в корзине.
        /// </summary>
        List<Item> _items = [];

        /// <summary>
        /// Получает или задает список товаров в корзине.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Рассчитывает и возвращает общую сумму всех товаров в корзине.
        /// </summary>
        /// <returns>Суммарная стоимость товаров в корзине.</returns>
        public double Amount
        {
            get
            {
                double sum = 0;
                Items.ForEach(x => { sum += x.Cost; });
                return Math.Round(sum, 2);
            }
        }
    }
}
