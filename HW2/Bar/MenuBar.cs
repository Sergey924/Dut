using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    // Класс Меню Бар наследует итерфейс Меню Бар
    class MenuBar : IMenuBar
    {
        // Поле
        private string Title = "MenuBar";
        
        // Лист в котором хранятся напитки
        List<Beverage> menubar = new List<Beverage>();

        // Метод добавления напитка
        public void AddBeverageInMenu(Beverage beverage)
        {
            menubar.Add(beverage);
        }

        // Метод удаления напитка
        public void DeletBeverageInMenu(Beverage beverage)
        {
            menubar.Remove(beverage);
        }
    }
}
