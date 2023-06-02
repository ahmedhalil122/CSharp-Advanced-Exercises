using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
	internal class Car
	{
		private string model;
		private double fuelAmount;
		private double fuelConsumptionPerKilometer;
		private double travelledDistance;


        public Car(string model,double fuelAmount,double fuelConsumptionPerKm)
        {
            this.model = model;
			this.fuelAmount = fuelAmount;
			this.fuelConsumptionPerKilometer = fuelConsumptionPerKm;
        }
        public string Model
		{
			get { return this.model; }
			set { model = value; }
		}


        public double FuelAmount

		{
			get { return this.fuelAmount; }
			set { fuelAmount = value; }
		}

		public double FuelConsumptionPerKilometer
		{
			get { return this.fuelConsumptionPerKilometer; }
			set { fuelConsumptionPerKilometer = value; }

		}

		public double TravelledDistance
		{
			get { return this.travelledDistance; }
			set { travelledDistance = value; }
		}

		public void DriveCar(double travelledDistance)
		{
			if (travelledDistance*FuelConsumptionPerKilometer>FuelAmount)
			{
                Console.WriteLine("Insufficient fuel for the drive");
            }
			else
			{
                FuelAmount -= travelledDistance * FuelConsumptionPerKilometer;
                TravelledDistance += travelledDistance;
            }
		}
	}
}
