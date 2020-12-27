using System;
using System.Collections.Generic;
using System.Text;
using HW1;

namespace HW2
{
    // Класс Ресторан наследует абстрактный класс Компания
    class Restaurant : Company
    {
        // Конструктор
        public Restaurant(string nameCompany, string descriptCompany, HW1.Address address) : base(nameCompany, descriptCompany, address)
        {
        }

        // Лист в котором хранятся данные о работниках

        List<Employee> employees = new List<Employee>();

       

        // Метод добавления сотрудника
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        // Метод удаления сотрудника
        public void DeletEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

     
    }
}
