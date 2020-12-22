using System;
using System.Collections.Generic;
using System.Text;

namespace HM1
{
    // Класс Сотрудники
    public class Employee
    {
        // Автосвойства 
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FullName { get; set; }

        //Конструктор
        public Employee(string firstName, string secondName)
        {
            FirstName = firstName;
            SecondName = secondName;
            FullName = FirstName + SecondName;
        }

        // Переопределённый метод ToString
        public override string ToString()
        {
            return String.Format($"Employee Name: {FullName}");
        }
    }
}
