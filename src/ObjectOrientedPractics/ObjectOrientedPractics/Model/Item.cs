using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Класс Item представляет объект товара.
    /// </summary>
    internal class Item
    {
        /// <summary>
        /// Идентификатор товара.
        /// </summary>
        readonly int _id;
        /// <summary>
        /// Наименование товара.
        /// </summary>
        string _name;
        /// <summary>
        /// Подробная информация о товаре.
        /// </summary>
        string _info;
        /// <summary>
        /// Стоимость товара.
        /// </summary>
        double _cost;

        /// <summary>
        /// Возвращает идентификатор товара.
        /// </summary>
        public int Id
        {
            get 
            {
                return _id; 
            }
        }
        /// <summary>
        /// Возвращает или меняет наименование товара.
        /// </summary>
        public string Name 
        { 
            get 
            { 
                return _name; 
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }
        /// <summary>
        /// Возвращает или меняет информацию о товаре.
        /// </summary>
        public string Info 
        { 
            get 
            { 
                return _info; 
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 2000, nameof(Info));
                _info = value;
            }
        }
        /// <summary>
        /// Возвращает или меняет стоимость товара.
        /// </summary>
        public double Cost 
        { 
            get 
            { 
                return _cost; 
            }
            set
            {
                ValueValidator.AssertValueInRange(value, 0, 100000, nameof(Cost));
                _cost = value;
            }
        }
        /// <summary>
        /// Конструктор класса Item.
        /// </summary>
        /// <param name="name">Наименование товара.</param>
        /// <param name="info">Подробная информация о товаре.</param>
        /// <param name="cost">Стоимость товара.</param>
        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = IdGenerator.GetNextId();
        }
    }
}
