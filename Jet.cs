namespace FuelStation
{
    public class Jet : IFuelStrategy
    {
        public int maxFuel { get {return 320;} set {maxFuel = value;} }

        public decimal getFuel(int currentFuel) {
            return (maxFuel - currentFuel) * this.getPrice();
        }

        public decimal getPrice() {
            return 10.00M;
        }
    }
}