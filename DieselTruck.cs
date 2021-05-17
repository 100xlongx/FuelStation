namespace FuelStation
{
    public class DieselTruck : IFuelStrategy
    {
        public int maxFuel { get {return 32;} set {maxFuel = value;} }

        public decimal getFuel(int currentFuel) {
            return (maxFuel - currentFuel) * this.getPrice();
        }

        public decimal getPrice() {
            return 5.00M;
        }
    }
}