namespace Vehicles.Models.Interfaces
{
    public interface IVehicle
    {
        public double FuelQuantiy { get;}

        public double FuelConsumption { get;}

        public string Drive(double distance);

        public void Refuel(double liters);
    }
}
