using System;
using System.Collections.Generic;
using System.Text;

namespace HW1
{ // Класс Услуги
    class Services
    {
        // Свойсвтва
        public string TypeService { get; set; }

        // Конструкор 
        public Services(string typeService)
        {
            // Проверка
            if (string.IsNullOrEmpty(typeService))
            {
                throw new ArgumentNullException(nameof(typeService));
            }
            else
            {
                TypeService = typeService;
            }
        }
       
       

       
    }
}
