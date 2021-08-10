using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Vehicle
    {
        public decimal price;
        public decimal maxSpeed;
        public int releaseYear;

        public void PrintInfo()
        {
            Console.WriteLine($"  Price: {price}");
            Console.WriteLine($"  Max speed: {maxSpeed}");
            Console.WriteLine($"  Year: {releaseYear}");
        }
    }
}
