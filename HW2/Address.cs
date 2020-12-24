using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    // Класс Адрес
    class Address
    {
        // Автосвойства 
        public string City { get; set; }
        public string Street { get; set; }
        public string Index { get; set; }

        // Конструктор
        public Address(string city, string street)
        {
            City = city;
            Street = street;
        }
    }
}
