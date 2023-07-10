using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Models.Interfaces;

namespace Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        public double increasedConsumption;
        protected Vehicle(double fuelQuantiy, double fuelConsumption, double increasedConsumption)
        {
            FuelQuantiy = fuelQuantiy;
            FuelConsumption = fuelConsumption;
            this.increasedConsumption = increasedConsumption;
        }

        public double FuelQuantiy { get; set; }
        public double FuelConsumption { get; set; }

        public string Drive(double distance)
        {
            double consumption = (FuelConsumption+increasedConsumption)*distance;
            if (FuelQuantiy<consumption)
            {
                throw new ArgumentException($"{GetType().Name} needs refueling");
            }
            FuelQuantiy-= consumption;
            return $"{GetType().Name} travelled {distance} km";
        }

        public virtual void Refuel(double liters)
        {
            FuelQuantiy += liters; 
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {FuelQuantiy:f2}";
        }
    }
}
