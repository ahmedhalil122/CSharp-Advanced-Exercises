
using Vehicles.Core;
using Vehicles.Core.Interfaces;
using Vehicles.Factories;
using Vehicles.Factories.Interfaces;
using Vehicles.Models.Interfaces;

IVehicleFactory vehicleFactory = new VehicleFactory();
IEngine engine = new Engine(vehicleFactory);

engine.Run();











