using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    public class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tires[] Tyres { get; set; }

        public Car
            (
            string model,
            int speed,
            int power,
            int weight,
            string type,
            double tire1pressure,
            int tire1Age,
            double tire2pressure,
            int tire2Age,
            double tire3pressure,
            int tire3Age,
            double tire4pressure,
            int tire4Age
            )
        {
            this.Model = model;
            this.Engine = new(speed, power);
            this.Cargo = new Cargo(weight, type);
            this.Tyres = new Tires[4];
            this.Tyres[0] = new(tire1pressure, tire1Age);
            this.Tyres[1] = new(tire2pressure, tire2Age);
            this.Tyres[2] = new(tire3pressure, tire3Age);
            this.Tyres[3] = new(tire4pressure, tire4Age);
        }
    }
}
