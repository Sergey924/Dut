using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class Beverage
    {
        public string NameBeverage { get; set; }
        public double WeightBeverage { get; set; }
        public decimal PriceBeverage { get; set; }

        public Beverage(string nameBeverage, double weightBeverage, decimal priceBeverage)
        {
            NameBeverage = nameBeverage;
            WeightBeverage = weightBeverage;
            PriceBeverage = priceBeverage;
        }
    }
}
