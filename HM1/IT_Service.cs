using System;
using System.Collections.Generic;
using System.Text;

namespace HW1
{
 // Класс IT_Servise, наследует абстрактный класс Компания
    public  class IT_Service : Company
    {
     
        // Конструктор
        public IT_Service(string nameCompany, string descriptCompany, Address address) : base(nameCompany, descriptCompany, address)
        {
        }

        // Лист в котором хранятся данные о сотрудниках

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
