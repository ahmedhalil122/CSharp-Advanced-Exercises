using RawData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

int count = int.Parse(Console.ReadLine());

List<Car> cars = new List<Car>();

//"{model} 0
//{engineSpeed} 1 
//{enginePower} 2 
//{cargoWeight} 3
//{cargoType} 4
//{tire1Pressure} 5 
//{ tire1Age} 6
//{ tire2Pressure} 7 
//{ tire2Age} 8 
//{ tire3Pressure} 9
//{ tire3Age} 10
//{ tire4Pressure} 11
//{ tire4Age} 12

for (int i = 0; i < count; i++)
{
    string[] carProperties = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    Car car = new Car
        (
        carProperties[0],
        int.Parse(carProperties[1]),
        int.Parse(carProperties[2]),
        int.Parse(carProperties[3]),
        carProperties[4],
        double.Parse(carProperties[5]),
        int.Parse(carProperties[6]),
        double.Parse(carProperties[7]),
        int.Parse(carProperties[8]),
        double.Parse(carProperties[9]),
        int.Parse(carProperties[10]),
        double.Parse(carProperties[11]),
        int.Parse(carProperties[12])
        );

    cars.Add(car);
}

string cmd = Console.ReadLine();
string[] selectedCars = null;

if (cmd== "fragile")
{
    selectedCars = cars
                .Where(c => c.Cargo.Type == "fragile" && c.Tyres.Any(t => t.Pressure < 1))
                .Select(c => c.Model).ToArray();
}
else if (cmd== "flammable")
{
    selectedCars = cars
                .Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250)
                .Select(c => c.Model)
                .ToArray();
}

Console.WriteLine(String.Join(Environment.NewLine, selectedCars));
