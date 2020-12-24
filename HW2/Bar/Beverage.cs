using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    // Класс Напитки
    class Beverage
    {
        // Автосвойста
        public string NameBeverage { get; set; }
        public double WeightBeverage { get; set; }
        public decimal PriceBeverage { get; set; }

        // Конструктор
        public Beverage(string nameBeverage, double weightBeverage, decimal priceBeverage)
        {
            NameBeverage = nameBeverage;
            WeightBeverage = weightBeverage;
            PriceBeverage = priceBeverage;
        }
    }
}
