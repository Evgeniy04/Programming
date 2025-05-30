﻿using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс Customer представляет данные клиента.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Идентификатор клиента.
        /// </summary>
        readonly int _id;
        /// <summary>
        /// Полное имя клиента.
        /// </summary>
        string _fullname;
        /// <summary>
        /// Адрес клиента.
        /// </summary>
        Address _address;
        /// <summary>
        /// Корзина товаров.
        /// </summary>
        Cart _cart;
        /// <summary>
        /// Список заказов.
        /// </summary>
        List<Order> _orders;

        /// <summary>
        /// Получает идентификатор клиента.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }
        /// <summary>
        /// Возвращает или меняет полное имя клиента.
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
                _fullname = value;
            }
        }
        /// <summary>
        /// Возвращает или меняет адрес клиента.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }
        /// <summary>
        /// Возвращает или меняет содержимое корзины товаров.
        /// </summary>
        public Cart Cart
        {
            get
            {
                return _cart;
            }
            set
            {
                _cart = value;
            }
        }
        /// <summary>
        /// Возвращает или меняет список заказов.
        /// </summary>
        public List<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }
        /// <summary>
        /// Возвращает или меняет приоритет клиента.
        /// </summary>
        public bool IsPriority { get; set; }
        /// <summary>
        /// Список возможных скидок.
        /// </summary>
        public List<IDiscount> Discounts { get; set; }

        /// <summary>
        /// Конструктор класса Customer.
        /// </summary>
        public Customer()
        {
            _id = IdGenerator.GetNextId();
            Fullname = Id.ToString();
            Address = new Address();
            Cart = new Cart();
            Orders = new List<Order>();
            Discounts = new List<IDiscount>();
        }

        /// <summary>
        /// Конструктор класса Customer.
        /// </summary>
        /// <param name="fullname">Полное имя клиента.</param>
        /// <param name="address">Адрес клиента.</param>
        public Customer(string fullname, Address address)
        {
            Fullname = fullname;
            Address = address;
            _id = IdGenerator.GetNextId();
            Cart = new Cart();
            Orders = new List<Order>();
            Discounts = new List<IDiscount>();
        }

        public override string ToString()
        {
            return Fullname;
        }
    }
}
