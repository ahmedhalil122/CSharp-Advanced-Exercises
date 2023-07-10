using Vehicles.Factories.Interfaces;
using Vehicles.Models;
using Vehicles.Models.Interfaces;

namespace Vehicles.Factories
{
    public class VehicleFactory : IVehicleFactory
    {
        IVehicle vehicle;
        public IVehicle CreateVehicle(string type, double fuelQuantity, double fuelConsumption)
        {
           if (type == "Car")
            {
                vehicle = new Car(fuelQuantity, fuelConsumption);
            }
            else if (type=="Truck")
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption);
            }
            else
            {
                throw new ArgumentException("Invalid vehicle type");
            }

            return vehicle;
        }
    }
}
