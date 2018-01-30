using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        

        public int price;        // Цена средства передвижения
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public int speed;        // Скорость средства передвижения
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int prodyear;      // Год производства средства передвижения
        public int Prodyear
        {
            get { return prodyear; }
            set { prodyear = value; }
        }
        public void DisplayVehicle()  // Конструктор вывода данных на экран
        {
            Console.WriteLine("Цена: " + price + ", Скорость: " + speed + ", Год производства: " + prodyear + " ");
        }
    }
}
