using System;
using System.Collections.Generic;
using System.Text;

namespace HW1
{ 
    // Класс Сервисный Центр
    class ServiceCentr 
    {
        // Свойства
        public string NameCentr { get; set; }
        Address Address { get; set; }
        
        // Конструктор
        public ServiceCentr(string nameCentr, Address address) 
        {
            NameCentr = nameCentr;
            Address = address;
        }

        // Лист в котором хранятся услуги центра

        List<Services> services = new List<Services>();

        // Метод добавления услуги
        public void AddService(Services service)
        {
            services.Add(service);
            
        }

        // Метод удаления услуги
        public void DeletService(Services service)
        {
            services.Remove(service);
        }

        // Метод замены услуги
        public void ReplaceService(Services service)
        {
            Console.WriteLine("Enter replacement index");
            services.Insert(Convert.ToInt32(Console.ReadLine()), service);
        }
    }
}
