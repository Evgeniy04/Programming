using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Фабрика для создания объектов типа Customer.
    /// </summary>
    internal class CustomerFactory
    {
        /// <summary>
        /// Список полных имён клиентов.
        /// </summary>
        static string[] _fullnames = new string[12] {   "Фомичёва Нонна Максимовна", "Юшков Петр Иванович", "Балабанов Павел Васильевич",
                                                                "Кулдошина Милана Тарасовна", "Сухорукова Галина Захаровна", "Крестьянинов Виталий Петрович",
                                                                "Близнюк Мила Ивановна", "Сиянцева Наталия Иннокентьевна", "Ярцова Светлана Лльвона",
                                                                "Ягужинская Инна Петровна", "Яхин Егор Егорович", "Шипицын Ефим Захарович"  };
        /// <summary>
        /// Создаёт объект Customer с случайными значениями из списков имён и адресов.
        /// </summary>
        /// <returns>Возвращает объект типа Customer с случайным именем и адресом.</returns>
        public static Customer Randomize()
        {
            Random random = new Random();
            string fullname = _fullnames[random.Next(_fullnames.Length)];
            Address address = AddressFactory.Randomize();
            Customer customer = new Customer(fullname, address);
            return customer;
        }
    }
}
