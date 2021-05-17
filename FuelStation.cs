namespace FuelStation
{
    class FuelStation {
        public decimal getFuel(int currentFuel, IFuelStrategy strategy) {
            return strategy.getFuel(currentFuel);
        }
    }
}