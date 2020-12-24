using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    // Класс Ресторан наследует класс Описание
    class Restaurant : Description
    {
        // Автосвойства
        public string NameRestaraunt { get; set; }
        Address Address { get; set; }

        // Конструктор
        public Restaurant(string nameRestaraunt, Address address)
        {
            NameRestaraunt = nameRestaraunt;
            Address = address;
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

        // Переопределённый метод ToString
        public override string ToString()
        {
            return String.Format($"Name Restaraunt: {NameRestaraunt} \nDecription: {DescriptRestoraunt} \nAddress: city. { Address.City} str. {Address.Street} ind. {Address.Index} \n ");
        }
    }
}
