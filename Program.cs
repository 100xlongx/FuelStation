using System;

namespace FuelStation
{
    class Program
    {
        static void Main(string[] args)
        {
            var fuelStation = new FuelStation();
            var carStrat = new Car();

            Console.WriteLine(fuelStation.getFuel(9, carStrat));
        }
    }
}
