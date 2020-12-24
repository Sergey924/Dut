using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    // Класс Бар
    class Bar
    {
        // Автосвойства
        Employee Employee { get; set; }

        // Конструктор
        public Bar(Employee employee)
        {
            Employee = employee;
        }
    }
}
