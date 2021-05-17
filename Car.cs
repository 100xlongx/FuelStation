namespace FuelStation
{
    public class Car : IFuelStrategy {
        public int maxFuel { get {return 12;} set {maxFuel = value;} }

        public decimal fuelCar(int currentFuel) {
            return (maxFuel - currentFuel) * this.getPrice();
        }

        public decimal getPrice() {
            return 3.00M;
        }
    }
}