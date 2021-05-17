namespace FuelStation
{
    public class ElectricCar : IFuelStrategy
    {
        public int maxFuel { get {return 20;} set {maxFuel = value;} }

        public decimal getFuel(int currentFuel) {
            return (maxFuel - currentFuel) * this.getPrice();
        }

        public decimal getPrice() {
            return 0.28M;
        }
    }
}