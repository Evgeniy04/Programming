using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Представляет скидку в процентах, основанную на общей сумме покупок в определенной категории.
    /// </summary>
    public class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        /// <summary>
        /// Категория товаров, на которые распространяется скидка.
        /// </summary>
        public Category Category { get; set; }
        /// <summary>
        /// Общая сумма, на которую покупатель уже совершил покупки в данной категории.
        /// </summary>
        public double TotalSpent { get; private set; }

        /// <summary>
        /// Процент скидки, рассчитываемый на основе потраченной суммы.
        /// Скидка увеличивается на 1% за каждые 1000 потраченных единиц и ограничена максимумом в 10%.
        /// </summary>
        public int DiscountPercentage
        {
            get
            {
                int discountPercentage = (int)Math.Floor(TotalSpent / 1000);
                if (discountPercentage > 9) discountPercentage = 9;
                return discountPercentage + 1;
            }
        }
        /// <summary>
        /// Возвращает информацию о процентной скидке в формате строки.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная «{Category}» - {DiscountPercentage}%";
            }
        }

        /// <summary>
        /// Рассчитывает сумму скидки для списка товаров, соответствующих категории.
        /// </summary>
        /// <param name="items">Список товаров для расчета скидки.</param>
        /// <returns>Сумма скидки, рассчитанная на основе процента скидки и суммы товаров.</returns>
        public double Calculate(List<Item> items)
        {
            double amount = GetAmount(items);
            double discountAmount = amount * ((double)DiscountPercentage) / 100;
            return discountAmount;
        }

        /// <summary>
        /// Применяет рассчитанную скидку к списку товаров и возвращает сумму скидки.
        /// </summary>
        /// <param name="items">Список товаров для применения скидки.</param>
        /// <returns>Сумма скидки, которая была применена к товарам.</returns>
        public double Apply(List<Item> items)
        {
            double discountAmount = Calculate(items);
            return discountAmount;
        }

        /// <summary>
        /// Обновляет общую сумму потраченных средств в категории на основании переданных товаров.
        /// </summary>
        /// <param name="items">Список товаров для обновления потраченной суммы.</param>
        public void Update(List<Item> items)
        {
            double amount = GetAmount(items);
            TotalSpent += amount;
        }

        /// <summary>
        /// Возвращает сумму товаров заказа соответствующих категории.
        /// </summary>
        public double GetAmount(List<Item> items)
        {
            double sum = 0;
            items.ForEach(x =>
                {
                    if (x.Category == Category)
                    {
                        sum += x.Cost;
                    }
                }
            );
            return Math.Round(sum, 2);
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="category">Категория товаров, на которую распространяется скидка.</param>
        /// <param name="totalSpent">Сумма покупок по этой категории.</param>
        public PercentDiscount(Category category, double totalSpent)
        {
            Category = category;
            TotalSpent = totalSpent;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return Info;
        }


        /// <inheritdoc/>
        public int CompareTo(PercentDiscount? percentDiscount2)
        {
            if (percentDiscount2 == null)
                return 1;
            if (object.ReferenceEquals(this, percentDiscount2))
                return 0;

            if (DiscountPercentage < percentDiscount2.DiscountPercentage)
            {
                return -1;
            }
            else if (DiscountPercentage == percentDiscount2.DiscountPercentage)
            {
                return 0;
            }
            return 1;
        }
    }
}
