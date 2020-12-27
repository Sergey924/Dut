using System;
using System.Collections.Generic;
using System.Text;

namespace HW1
{
    // Интерфейс Сервис Центр
   public interface IService_Center
    {
        // Автосвойства
        public string NameCentr { get; set; }
        public Address Address { get; set; }


        // Метод добавления услуги
        public void AddService(Services service);

        // Метод удаления услуги
        public void DeletService(Services service);


        // Метод замены услуги
        public void ReplaceService(Services service);
    }
}
