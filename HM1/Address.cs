using System;
using System.Collections.Generic;
using System.Text;

namespace HM1
{
    // Класс Адрес
   public class Address
    {
        // Свойства класса
        public string City { get; set; }

        public string Street { get; set; }
        public string Index { get; set;  }

        // Конструктор
        public Address(string city, string street, string index)
        {
            City = city;
            Street = street;
            Index = index;
        }
    }
}
