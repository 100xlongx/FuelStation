namespace FuelStation {
    public interface IFuelStrategy {
        decimal getPrice();
        decimal getFuel(int currentFuel);
    }
}
