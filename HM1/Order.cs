﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HW1
{
    // Класс Заказы
    class Order
    {
        // Свойства
        public int ID_Order { get; set; }
        public string TypeOrder { get; set; }
        Client Client { get; set; }

        // Создание генератора случайных чисел

        Random rnd = new Random();

        // Конструктор 
        public Order(string typeOrder, Client client)
        {
            ID_Order = rnd.Next(0_10000);

            // Проверка
            if (string.IsNullOrEmpty(typeOrder))
            {
                throw new ArgumentNullException(nameof(typeOrder));
            }
            else
            { 
            TypeOrder = typeOrder;
            }

            Client = client;
        }

        // Лист в котором хранятся заказы

        List<Order> orders = new List<Order>();

        // Метод добавления заказа
        public List<Order> AddOrder(Order order)
        {
            orders.Add(order);
            return orders;
        }

        // Метод удаления заказа
        public void DeletOrder(Order order)
        {
            orders.Remove(order);
        }
    }
}
