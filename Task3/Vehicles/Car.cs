using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Vehicles
{
    class Car : Vehicle
    {
        public void PrintInfo()
        {
            Console.WriteLine("Car info:");
            Vehicle v1 = new Vehicle();
            v1.maxSpeed = 280;
            v1.price = 40000;
            v1.releaseYear = 2019;
            v1.PrintInfo();
        }
    }
}
