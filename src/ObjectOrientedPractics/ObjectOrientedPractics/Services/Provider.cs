using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс Provider используется для хранения данных, связанных с элементами и клиентами приложения,
    /// а также для предоставления элементов управления, таких как списки элементов и клиентов.
    /// </summary>
    internal static class Provider
    {
        /// <summary>
        /// Список элементов (товаров) приложения.
        /// </summary>
        public static List<Item> Items = [];
        /// <summary>
        /// Список клиентов приложения.
        /// </summary>
        public static List<Customer> Customers = [];
    }
}
