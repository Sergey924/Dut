using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    // Класс Блюда
    class Dish
    {
        // Автосвойства
        public string NameDish { get; set; }
        public decimal  PriceDish { get; set; }
        public double WeightDish { get; set; }

        // Конструктор
        public Dish(string nameDish, double weightDish, decimal priceDish)
        {
            // Проверки
            if (string.IsNullOrWhiteSpace(nameDish))
            {
                throw new ArgumentNullException(nameof(nameDish));
            }
            else
            {
                NameDish = nameDish;
            }

            if(priceDish <= 0)
            {
                throw new ArgumentNullException(nameof(priceDish));
            }
            else
            { 
            PriceDish = priceDish;
            }

            if (weightDish <= 0)
            {
                throw new ArgumentNullException(nameof(weightDish));
            }
            else
            {
                WeightDish = weightDish;
            }
        }
    }
}
