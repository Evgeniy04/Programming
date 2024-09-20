using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Фабрика для создания объектов типа Address.
    /// </summary>
    internal class AddressFactory
    {
        /// <summary>
        /// Список городов.
        /// </summary>
        static string[] _cities = new string[12]
        {
            "Москва", "Санкт-Петербург", "Новосибирск",
            "Екатеринбург", "Казань", "Нижний Новгород",
            "Самара", "Омск",  "Челябинск", 
            "Ростов-на-Дону", "Уфа", "Воронеж"
        };
        /// <summary>
        /// Список улиц.
        /// </summary>
        static string[] _streets = new string[12] 
        {
            "Арбат", "Невский проспект", "Красная площадь",
            "Тверская улица", "Бродвей", "Кузнецкий мост",
            "Лубянка", "Петровка", "Крещатик",
            "Большая Морская", "Ленинский проспект", "Мира"
        };
        /// <summary>
        /// Список построек.
        /// </summary>
        static string[] _buildings = new string[12]
        {
            "118/1", "10", "85",
            "29А", "166/8", "79",
            "56Б", "8с13", "2Ас18",
            "5/1с1", "23", "163",
        };
        /// <summary>
        /// Список построек.
        /// </summary>
        static string[] _apartments = new string[12]
        {
            "118", "1", "85",
            "29", "8", "79",
            "56", "813", "218",
            "51", "23", "163",
        };

        /// <summary>
        /// Создаёт объект Address с случайными значениями.
        /// </summary>
        /// <returns>Возвращает объект типа Address со случайным адресом.</returns>
        public static Address Randomize()
        {
            Random random = new Random();
            string city = _cities[random.Next(_cities.Length)];
            string street = _streets[random.Next(_streets.Length)];
            string building = _buildings[random.Next(_buildings.Length)];
            string apartment = _apartments[random.Next(_apartments.Length)];
            Address address = new Address(random.Next(100000, 1000000), "Россия", city, street, building, apartment);
            return address;
        }
    }
}
