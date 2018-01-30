using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Ship : Vehicle 
    {
        public int passengers = 500;    // Количество пассажиров на корабле
        public string port = "San Francisco";   // Порт корабля
        public void DisplayShip()    // Конструктор вывода данных корабля на экран
        {
            Console.WriteLine("Параметры Ship: Кол-во пассажиров - {0}, Порт - {1}", passengers, port);
        }
    }
}
