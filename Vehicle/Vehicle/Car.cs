using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Car : Vehicle
    {
        
        private string color;     // Цвет автомобиля
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private string type;       // Тип автомобиля
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public void DisplayCar()
        {
            Console.WriteLine("Параметры Car: Цвет - {0}, Тип - {1}", color, type);
        }
    }
}
