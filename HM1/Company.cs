using System;
using System.Collections.Generic;
using System.Text;

namespace HM1
{
 // Класс Компания
    public  class Company : Description // Наследует класс Description
    {
       // Свойства класса
        public string NameCompany { get; set; }
        Address Address { get; set; }

        // Конструктор
        public Company(string nameCompany, Address address )
        {
            NameCompany = nameCompany;
            Address = address;
            
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

        // Переопределённый метод ToString
        public override string  ToString()
        {
            return String.Format($"Name Company: {NameCompany}\n \nAddress: city. { Address.City} str. {Address.Street} ind. {Address.Index} \n \nDecription: {DescriptCompany}");
        }
    }

    

}
