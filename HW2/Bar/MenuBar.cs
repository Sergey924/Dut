using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    class MenuBar : IMenuBar
    {
        private string Title = "MenuBar";
        

       

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
