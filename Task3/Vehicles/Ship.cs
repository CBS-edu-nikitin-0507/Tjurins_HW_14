using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Vehicles
{
    class Ship : Vehicle
    {
        private string port;
        private int passengersAmount;

        public string Port
        {
            get { return port; }
            set { port = value; }
        }

        public int PassengersAmount
        {
            get { return passengersAmount; }
            set { passengersAmount = value; }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Ship info: ");
            Console.WriteLine($"  Port: {port}");
            Console.WriteLine($"  Passengers amount: {passengersAmount}");

            Vehicle v1 = new Vehicle();
            v1.maxSpeed = 80;
            v1.price = 750000;
            v1.releaseYear = 2015;
            v1.PrintInfo();
        }
    }
}
