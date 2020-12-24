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
            NameDish = nameDish;
            PriceDish = priceDish;
        }
    }
}
