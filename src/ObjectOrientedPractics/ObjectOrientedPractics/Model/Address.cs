using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Представляет адрес с почтовым индексом, страной, городом, улицей, номером дома и квартирой.
    /// </summary>
    public class Address: ICloneable, IEquatable<Address>
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
                if (_index == value) return;
                ValueValidator.AssertValueInRange(value, 100000, 1000000, nameof(Index));
                _index = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
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
                if (_country == value) return;
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
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
                if (_city == value) return;
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
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
                if (_street == value) return;
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
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
                if (_building == value) return;
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
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
                if (_apartment == value) return;
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        /// <summary>
        /// Событие изменения адреса.
        /// </summary>
        public event EventHandler<EventArgs> AddressChanged;

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

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Index}, {Country}, {City}, {Street}, {Building}, {Apartment}";
        }

        /// <inheritdoc/>
        public object Clone()
        {
            return new Address(Index, Country, City, Street, Building, Apartment);
        }

        /// <inheritdoc/>
        public bool Equals(Address? address2)
        {
            if (address2 == null)
                return false;
            if (object.ReferenceEquals(this, address2))
                return true;

            PropertyInfo[] properties = typeof(Address).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                var value1 = property.GetValue(this);
                var value2 = property.GetValue(address2);

                if (value1 == null && value2 == null)
                    continue;
                if (value1 == null || value2 == null || value1 != value2)
                    return false; // Если одно из значений null или они не равны
            }

            return true;
        }
    }
}
