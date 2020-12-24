﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HW1
{
    // Класс Адрес
   public class Address
    {
        // Свойства класса
        public string City { get; set; }
        public string Street { get; set; }

        // Конструктор
        public Address(string city, string street)
        {
            City = city;
            Street = street;
        }
    }
}
