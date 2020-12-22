using System;
using System.Collections.Generic;
using System.Text;

namespace HM1
{
    // Класс Клиенты
    public class Client 
    {
        // Свойства класса
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string FullName { get; set; }
        Address Address { get; set; }
        
        // Конструктор
        public Client(string firstName, string secondName, Address address)
        {
            FirstName = firstName;
            SecondName = secondName;
            FullName = FirstName +  SecondName;
            Address = address;
        }

        // Метод совершения заказа
        public void MakeOrder()
        {
            Console.WriteLine("Введите тип заказа, адрес доставки и индекс");

            
            Order order = new Order(Console.ReadLine(),new Client(FirstName, SecondName,(new Address(Console.ReadLine(), Console.ReadLine(), Console.ReadLine()))));
            order.AddOrder(order);
            
        }
    }
}
