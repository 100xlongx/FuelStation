using System;
using System.Collections.Generic;

namespace FuelStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            var eCar = new ElectricCar();
            var truck = new DieselTruck();
            var jet = new Jet();
            var fuelStation = new FuelStation();

            Console.WriteLine($"Total Price for Car:\t\t ${fuelStation.getFuel(9, car)}");
            Console.WriteLine($"Total Price for Electric Car:\t ${fuelStation.getFuel(9, eCar)}");
            Console.WriteLine($"Total Price for Diesel Truck:\t ${fuelStation.getFuel(9, truck)}");
            Console.WriteLine($"Total Price for Jet:\t\t ${fuelStation.getFuel(9, jet)}");
        }
    }
}
