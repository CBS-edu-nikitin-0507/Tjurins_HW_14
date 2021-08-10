using System;
using Task3.Vehicles;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            Car c1 = new Car();
            c1.PrintInfo();

            Console.WriteLine("");
            Plane p1 = new Plane();
            p1.FlightHeight = 6300;
            p1.PassengersAmount = 20;
            p1.PrintInfo();

            Console.WriteLine("");
            Ship s1 = new Ship();
            s1.Port = "SomePORT";
            s1.PassengersAmount = 700;
            s1.PrintInfo();

        }
    }
}
