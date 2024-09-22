using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Методы обработки данных.
    /// </summary>
    static class DataTools
    {
        /// <summary>
        /// Фильтрует список элементов на основе заданного условия.
        /// </summary>
        /// <param name="items">Список элементов для фильтрации.</param>
        /// <param name="compare">Функция сравнения, возвращающая true для включаемых элементов.</param>
        /// <returns>Отфильтрованный список элементов.</returns>
        static public List<Item> Filter(List<Item> items, Func<Item, bool> compare)
        {
            List<Item> filteredItems = [];

            foreach (Item item in  items)
            {
                if (compare(item))
                {
                    filteredItems.Add(item);
                }
            }

            return filteredItems;
        }

        /// <summary>
        /// Сортирует список элементов на основе заданного условия.
        /// </summary>
        /// <param name="items">Список элементов для сортировки.</param>
        /// <param name="compare">Функция сравнения для сортировки.</param>
        /// <returns>Отсортированный список элементов.</returns>
        static public List<Item> Sort(List<Item> items, Func<Item, Item, bool> compare)
        {
            List<Item> sortedItems = [..items];
            int count = items.Count;
            while (count-- != 0)
            {
                bool swapped = false;

                for (int i = 0; i < count; i++)
                {
                    if (compare(sortedItems[i], sortedItems[i + 1]))
                    {
                        Item temp = sortedItems[i];
                        sortedItems[i] = sortedItems[i + 1];
                        sortedItems[i + 1] = temp;
                        swapped = true;
                    }
                }

                if (!swapped) break;
            }

            return sortedItems;
        }
    }
}
