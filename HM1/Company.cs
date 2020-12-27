using System;
using System.Collections.Generic;
using System.Text;

namespace HW1
{
    // Абстрактный класс Комания, создан для наследования
   public abstract class Company
    {
        // Автосвойста
        public string NameCompany { get; set; }

        public string DescriptCompany { get; set; }
        Address Address { get; set; }

        // Конструктор
        protected Company(string nameCompany, string descriptCompany, Address address)
        {
            // Проверки
            if (string.IsNullOrEmpty(nameCompany))
            {
                throw new ArgumentNullException(nameof(nameCompany));
            }
            else
            { 
            NameCompany = nameCompany;
            }

            if (string.IsNullOrEmpty(descriptCompany))
            {
                throw new ArgumentNullException(nameof(descriptCompany));
            }
            else
            {
                DescriptCompany = descriptCompany;
            }
            Address = address;
        }



        // Переопределённый метод ToString
        public override string ToString()
        {
            return String.Format($"Name Company: {NameCompany} \nDecription: {DescriptCompany} \nAddress: city. { Address.City} str. {Address.Street} ");
        }
    }
}
