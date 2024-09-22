using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс Item представляет объект товара.
    /// </summary>
    public class Item: ICloneable, IEquatable<Item>, IComparable<Item>
    {
        /// <summary>
        /// Категория товара.
        /// </summary>
        public Category Category { get; set; }
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
                if (_name == value) return;
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
                NameChanged?.Invoke(this, EventArgs.Empty);
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
                if (_info == value) return;
                ValueValidator.AssertStringOnLength(value, 2000, nameof(Info));
                _info = value;
                InfoChanged?.Invoke(this, EventArgs.Empty);
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
                if (_cost == value) return;
                ValueValidator.AssertValueInRange(value, 0, 100000, nameof(Cost));
                _cost = value;
                CostChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        /// <summary>
        /// Событие изменения названия товара.
        /// </summary>
        public event EventHandler<EventArgs> NameChanged;
        /// <summary>
        /// Событие изменения описания товара.
        /// </summary>
        public event EventHandler<EventArgs> InfoChanged;
        /// <summary>
        /// Событие изменения стоимости товара.
        /// </summary>
        public event EventHandler<EventArgs> CostChanged;

        /// <summary>
        /// Конструктор класса Item.
        /// </summary>
        public Item()
        {
            _id = IdGenerator.GetNextId();
            Name = Id.ToString();
            Info = "";
            Cost = 0;
            Category = Category.Electronics;
        }

        /// <summary>
        /// Конструктор класса Item.
        /// </summary>
        /// <param name="name">Наименование товара.</param>
        /// <param name="info">Подробная информация о товаре.</param>
        /// <param name="cost">Стоимость товара.</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, double cost, Category category)
        {
            _id = IdGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return Name;
        }

        /// <inheritdoc/>
        public object Clone()
        {
            return new Item(Name, Info, Cost, Category);
        }

        /// <inheritdoc/>
        public bool Equals(Item? item2)
        {
            if (item2 == null)
                return false;
            if (object.ReferenceEquals(this, item2))
                return true;
            return (Id == item2.Id);
        }

        /// <inheritdoc/>
        public int CompareTo(Item? item2)
        {
            if (item2 == null)
                return 1;
            if (object.ReferenceEquals(this, item2))
                return 0;

            if (Cost < item2.Cost)
            {
                return -1;
            }
            else if (Cost == item2.Cost)
            {
                return 0;
            }
            return 1;
        }
    }
}
