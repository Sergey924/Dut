using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    // Класс Сотрудники
    class Employee
    {
        // Автосвойства 
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FullName { get; set; }

        // Конструктор
        public Employee(string firstName, string secondName)
        {
            // Проверки
            if (string.IsNullOrEmpty(firstName) || firstName.Length < 1)
            {
                throw new ArgumentNullException(nameof(firstName));
            }
            else
            {
                FirstName = firstName;
            }

            if (string.IsNullOrEmpty(secondName) || secondName.Length <1)
            {
                throw new ArgumentNullException(nameof(secondName));
            }
            else
            { 
            SecondName = secondName;
            }

            FullName = FirstName + SecondName;
        }

        // Переопределённый метод ToString
        public override string ToString()
        {
            return String.Format($"Employee Name: {FullName}");
        }
    }
}
