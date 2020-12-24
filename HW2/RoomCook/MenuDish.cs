using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    // Класс Меню Блюда, наследует интерфейс Меню Блюда
    class MenuDish : IMenuCook
    {
        // Поле
        public string Title = "Menu";

        // Лист в котором хранятся все блюда

        List<Dish> menucook = new List<Dish>();

        // Метод добавления блюда
        public void AddDishInMenu(Dish dish)
        {
            menucook.Add(dish);
        }

        // Метод удаления блюда
        public void DeletDishInMenu(Dish dish)
        {
            menucook.Remove(dish);
        }
    }
}
