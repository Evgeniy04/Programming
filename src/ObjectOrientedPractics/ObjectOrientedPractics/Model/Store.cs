using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет собой контекст приложения.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        List<Item> _items;
        /// <summary>
        /// Список клиентов.
        /// </summary>
        List<Customer> _customer;

        /// <summary>
        /// Получает или задает список товаров.
        /// </summary>
        /// <value>Список объектов <see cref="Item"/>, представляющий товары.</value>
        public List<Item> Items { get { return _items; } set { _items = value; } }
        /// <summary>
        /// Получает или задает список клиентов.
        /// </summary>
        /// <value>Список объектов <see cref="Customer"/>, представляющий клиентов.</value>
        public List<Customer> Customers { get { return _customer; } set {  _customer = value; } }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Store"/>.
        /// Конструктор создает пустые списки для товаров и клиентов.
        /// </summary>
        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();
        }
    }
}
