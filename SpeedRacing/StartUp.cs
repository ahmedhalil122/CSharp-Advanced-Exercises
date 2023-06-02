using SpeedRacing;
using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> allCars = new Dictionary <string, Car>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                //AudiA4 23 0.3
                //"{model} {fuelAmount} {fuelConsumptionFor1km}

                string[] carProps = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                Car car = new(carProps[0], double.Parse(carProps[1]), double.Parse(carProps[2]));

                allCars.Add(car.Model, car);
            }

            //"Drive {carModel} {amountOfKm}
            string[] cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (cmd[0]!="End")
            {
                string carModel = cmd[1];
                double travelledDistance = double.Parse(cmd[2]);

                Car car = allCars[carModel];

                cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                car.DriveCar(travelledDistance);
            }

            foreach (var car in allCars.Values)
            {
                //{model} {fuelAmount} {distanceTraveled
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }

        }
    }
}