using Vehicles.Core.Interfaces;
using Vehicles.Factories.Interfaces;
using Vehicles.Models;
using Vehicles.Models.Interfaces;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {
        private readonly List<IVehicle> vehicles;
        private IVehicleFactory vehicleFactory;
        
        public Engine(IVehicleFactory vehicleFactory)
        {
            vehicles = new List<IVehicle>();
            this.vehicleFactory = vehicleFactory;
        }

        public void Run()
        {
            vehicles.Add(Create());
            vehicles.Add(Create());


            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                try
                {
                    ProcessCommand();
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }

        
        
        private IVehicle Create()
        {
            string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string type = cmdArgs[0];
            double fuelQuantity = double.Parse(cmdArgs[1]);
            double fuelConsumption = double.Parse(cmdArgs[2]);

            return vehicleFactory.CreateVehicle(type, fuelQuantity, fuelConsumption);
            
        }

        private void ProcessCommand()
        {


            string[] cmd = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            string command = cmd[0];
            string vehicleType = cmd[1];

            IVehicle vehicle = vehicles.FirstOrDefault(v=>v.GetType().Name == vehicleType);

            if (command=="Drive")
            {
                Console.WriteLine(vehicle.Drive(double.Parse(cmd[2])));
            }
            else if (command == "Refuel")
            {
                double liters = double.Parse(cmd[2]);
                vehicle.Refuel(liters);
            }

        }
        
    }
}
