using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.Vehicles
{
    class Plane : Vehicle
    {
        private decimal flightHeight;
        private int passengersAmount;

        public decimal FlightHeight
        { 
            get {return flightHeight;} 
            set {flightHeight = value;} 
        }

        public int PassengersAmount 
        {
            get {return passengersAmount;}
            set {passengersAmount = value;}
        }

        public void PrintInfo()
        {
            Console.WriteLine("Plane info: ");
            Console.WriteLine($"  Flight height: {flightHeight}");
            Console.WriteLine($"  Passengers amount: {passengersAmount}");

            Vehicle v1 = new Vehicle();
            v1.maxSpeed = 780;
            v1.price = 100000;
            v1.releaseYear = 2016;
            v1.PrintInfo();
        }
    }
}
