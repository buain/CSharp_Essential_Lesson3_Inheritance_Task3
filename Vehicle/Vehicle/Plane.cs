using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Plane : Vehicle 
    {
        public int height = 1000;      // Высота полета самолета
        public int passengers = 200;    // Количество пассажиров на самолете
        public void DisplayPlane()   // Конструтор вывода данных о самолете на экран
        {
            Console.WriteLine("Параметры Plane: Кол-во пассажиров - {0}, Высота - {1}", passengers, height);
        }
    }
}
