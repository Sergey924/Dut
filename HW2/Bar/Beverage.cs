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
            // Проверки
            if (string.IsNullOrEmpty(nameBeverage))
            {
                throw new ArgumentNullException(nameof(nameBeverage));
            }
            else
            {
                NameBeverage = nameBeverage;
            }

            if (weightBeverage <= 0)
            {
                throw new ArgumentNullException(nameof(weightBeverage));
            }
            else
            { 
            WeightBeverage = weightBeverage;
            }

            if(priceBeverage <= 0)
            {
                throw new ArgumentNullException(nameof(priceBeverage));
            }
            else
            { 
            PriceBeverage = priceBeverage;
            }
        }
    }
}
