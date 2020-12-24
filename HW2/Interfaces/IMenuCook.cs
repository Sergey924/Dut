using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    // Интерфейс Меню Блюда
    interface IMenuCook
    {
        // Методы
        public void AddDishInMenu(Dish dish);

        public void DeletDishInMenu(Dish dish);
    }
}
