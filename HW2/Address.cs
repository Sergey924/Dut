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

        // Конструктор
        public Address(string city, string street)
        {
            // Проверки
            if (string.IsNullOrEmpty(city))
            {
                throw new ArgumentNullException(nameof(city));
            }
            else
            {
                City = city;
            }

            if (string.IsNullOrEmpty(street))
            {
                throw new ArgumentNullException(nameof(street));
            }
            else
            {
                Street = street;
            }
        }
    }
}
