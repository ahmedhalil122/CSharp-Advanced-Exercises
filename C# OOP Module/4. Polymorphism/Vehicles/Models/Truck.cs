namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double IncreasedConsumption = 1.6;
        public Truck(double fuelQuantiy, double fuelConsumption) 
            : base(fuelQuantiy, fuelConsumption, IncreasedConsumption)
        {

        }

       public override void Refuel(double liters)
        {
            base.Refuel(liters*0.95);
        }
    }
}
