namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double IncreasedConsumption = 0.9;
        public Car(double fuelQuantiy, double fuelConsumption)
            : base(fuelQuantiy, fuelConsumption, IncreasedConsumption)
        {
            
        }

    }
}
