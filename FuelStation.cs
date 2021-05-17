namespace FuelStation
{
    class FuelStation {
        public decimal fuelCar(int currentFuel, IFuelStrategy strategy) {
            return strategy.fuelCar(currentFuel);
        }
    }
}