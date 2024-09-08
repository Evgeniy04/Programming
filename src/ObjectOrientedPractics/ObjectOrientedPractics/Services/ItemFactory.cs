using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Фабрика для создания случайных товаров.
    /// </summary>
    internal static class ItemFactory
    {
        /// <summary>
        /// Список доступных наименований товаров.
        /// </summary>
        static List<string> _names = new List<string>() {"Ноутбук Lenovo ThinkPad X1 Carbon", "Смартфон Apple iPhone 15 Pro", "Беспроводные наушники Sony WH-1000XM5",
                                                        "Телевизор Samsung QLED 4K", "Планшет Microsoft Surface Pro 9", "Игровая консоль Sony PlayStation 5",
                                                        "Умные часы Apple Watch Series 9", "Кофемашина DeLonghi Magnifica S", "Фотоаппарат Canon EOS R6",
                                                        "Робот-пылесос Xiaomi Roborock S7", "Электросамокат Segway Ninebot Max", "Внешний жесткий диск Seagate 2TB" };
        /// <summary>
        /// Список доступных описаний товаров.
        /// </summary>
        static List<string> _descriptions = new List<string>()
        {
            "Ноутбук Lenovo ThinkPad X1 Carbon – ультратонкий бизнес-ноутбук с процессором Intel i7, 16 ГБ RAM",
            "Смартфон Apple iPhone 15 Pro – новейшая модель с A17 Bionic, 6.1-дюймовый дисплей, 128 ГБ памяти",
            "Беспроводные наушники Sony WH-1000XM5 – активное шумоподавление, до 30 часов работы",

            "Телевизор Samsung QLED 4K – диагональ 55 дюймов, поддержка HDR10+, технология Quantum Dot",
            "Планшет Microsoft Surface Pro 9 – процессор Intel Core i5, 8 ГБ RAM, 256 ГБ SSD, съемная клавиатура",
            "Игровая консоль Sony PlayStation 5 – поддержка 4K-гейминга, контроллер DualSense, объем 825 ГБ SSD",

            "Умные часы Apple Watch Series 9 – пульсометр, мониторинг сна, GPS, водонепроницаемость до 50 метров",
            "Кофемашина DeLonghi Magnifica S – автоматическое приготовление эспрессо, капучинатор, 13 настроек помола",
            "Фотоаппарат Canon EOS R6 – беззеркальная камера с матрицей 20 МП, поддержка 4K-видео, стабилизация изображения",

            "Робот-пылесос Xiaomi Roborock S7 – функция влажной уборки, лазерная навигация, до 180 минут работы",
            "Электросамокат Segway Ninebot Max – дальность до 65 км, мощность 350 Вт, складывающийся дизайн",
            "Внешний жесткий диск Seagate 2TB – USB 3.0, поддержка Plug-and-Play, компактный форм-фактор"
        };
        /// <summary>
        /// Список цен для товаров.
        /// </summary>
        static List<double> _prices = new List<double>() {   1499.99, 999.99, 349.99,
                                                            799.99, 1199.99, 499.99,
                                                            399.99, 599.99, 1899.99,
                                                            499.99, 749.99, 129.99 };

        /// <summary>
        /// Создает случайный товар из списка доступных наименований, описаний и цен.
        /// </summary>
        /// <returns>Случайный объект Item с заполненными полями названия, описания и стоимости.</returns>
        public static Item Randomize()
        {
            Random random = new Random();
            string name = _names[random.Next(_names.Count)];
            string description = _descriptions[random.Next(_descriptions.Count)];
            double cost = _prices[random.Next(_prices.Count)];
            Item item = new Item(name, description, cost);
            return item;
        }
    }
}
