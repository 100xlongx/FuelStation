using System;

namespace FuelStation
{
    class FuelStation {
        public decimal fuelCar(int currentFuel, IFuelStrategy strategy) {
            return strategy.fuelCar(currentFuel);
        }
    }

    public interface IFuelStrategy {
        decimal getPrice();
        decimal fuelCar(int currentFuel);
    }

    public class Car : IFuelStrategy {
        public int maxFuel { get {return 12;} set {maxFuel = value;} }

        public decimal fuelCar(int currentFuel) {
            return (maxFuel - currentFuel) * this.getPrice();
        }

        public decimal getPrice() {
            return 3.00M;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var fuelStation = new FuelStation();
            var carStrat = new Car();

            Console.WriteLine(fuelStation.fuelCar(9, carStrat));
        }
    }
}
