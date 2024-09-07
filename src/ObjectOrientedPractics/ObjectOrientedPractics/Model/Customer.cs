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
    internal class Customer
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
        string _address;

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
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Конструктор класса Customer.
        /// </summary>
        /// <param name="fullname">Полное имя клиента.</param>
        /// <param name="address">Адрес клиента.</param>
        public Customer(string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
            _id = IdGenerator.GetNextId();
        }
    }
}
