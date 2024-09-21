using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет адрес с почтовым индексом, страной, городом, улицей, номером дома и квартирой.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        int _index;
        /// <summary>
        /// Страна/регион.
        /// </summary>
        string _country;
        /// <summary>
        /// Город.
        /// </summary>
        string _city;
        /// <summary>
        /// Улица.
        /// </summary>
        string _street;
        /// <summary>
        /// Номер дома.
        /// </summary>
        string _building;
        /// <summary>
        /// Номер квартиры/помещения.
        /// </summary>
        string _apartment;

        /// <summary>
        /// Получает или задает почтовый индекс.
        /// </summary>
        /// <remarks>
        /// Почтовый индекс должен находиться в диапазоне от 100000 до 999999.
        /// </remarks>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                ValueValidator.AssertValueInRange(value, 100000, 1000000, nameof(Index));
                _index = value;
            }
        }

        /// <summary>
        /// Получает или задает страну.
        /// </summary>
        /// <remarks>
        /// Название страны должно быть не длиннее 50 символов.
        /// </remarks>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Получает или задает город.
        /// </summary>
        /// <remarks>
        /// Название города должно быть не длиннее 50 символов.
        /// </remarks>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
            }
        }

        /// <summary>
        /// Получает или задает улицу.
        /// </summary>
        /// <remarks>
        /// Название улицы должно быть не длиннее 100 символов.
        /// </remarks>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Получает или задает номер здания.
        /// </summary>
        /// <remarks>
        /// Номер здания должен быть не длиннее 10 символов.
        /// </remarks>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// Получает или задает номер квартиры.
        /// </summary>
        /// <remarks>
        /// Номер квартиры должен быть не длиннее 10 символов.
        /// </remarks>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Address"/> со значениями по умолчанию.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = "";
            City = "";
            Street = "";
            Building = "";
            Apartment = "";
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Address"/> с заданными значениями.
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна.</param>
        /// <param name="city">Город.</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер здания.</param>
        /// <param name="apartment">Квартира.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Представление класса в виде строки.
        /// </summary>
        /// <returns>Строка.</returns>
        public override string ToString()
        {
            return $"{Index}, {Country}, {City}, {Street}, {Building}, {Apartment}";
        }
    }
}
