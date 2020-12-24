using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    // Интерфейс Меню Напитки
    interface IMenuBar
    {
        // Методы
         public void AddBeverageInMenu(Beverage beverage);

         public void DeletBeverageInMenu(Beverage beverage);
    }
}
