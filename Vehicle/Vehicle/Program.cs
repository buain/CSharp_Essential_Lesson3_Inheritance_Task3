using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mashina = new Car();  // экземпляр класса Car
            mashina.Color = "red";    // задаем цвет автомобиля
            mashina.Price = 10000;    // задаем цену автомобиля
            mashina.Type = "sedan";   // задаем тип автомобиля
            mashina.Prodyear = 2017;  // задаем год производства автомобиля
            mashina.Speed = 80;       // задаем скорость автомобиля
            mashina.DisplayCar();     // выводим данные автомобиля
            mashina.DisplayVehicle(); // выводим данные автомобиля общих параметров

            Console.WriteLine();

            Ship korablik = new Ship();    // экземпляр класса Ship
            korablik.speed = 20;           // задаем скорость корабля
            korablik.prodyear = 1995;      // задаем год производства корабля
            korablik.price = 50000;        // задаем цену корабля
            korablik.DisplayShip();        // выводим данные корабля
            korablik.DisplayVehicle();     // выводим данные корабля общих параметров

            Console.WriteLine();

            Plane samolet = new Plane();   // экземпляр класса Plane
            samolet.speed = 600;           // задаем скорость самолета
            samolet.prodyear = 2001;       // задаем год производства самолета
            samolet.price = 80000;         // задаем цену самолета
            samolet.DisplayPlane();        // выводим данные самолета
            samolet.DisplayVehicle();      // выводим данные самолета общих параметров

            Console.ReadKey();
        }
    }
}
