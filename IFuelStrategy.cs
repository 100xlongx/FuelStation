namespace FuelStation {
    public interface IFuelStrategy {
        decimal getPrice();
        decimal fuelCar(int currentFuel);
    }
}
