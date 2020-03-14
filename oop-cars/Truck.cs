using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace oop_cars
{
    public class Truck: Vehicle
    {
        public Truck(string model, Engine engine, Manufacturer manufacturer, List<Tire> tires, List<Door> doors)
        {
            this.Model = model;
            this.Engine = engine;
            this.Manufacturer = manufacturer;
            this.Tires = tires;
            this.Doors = doors;
            NumberOfType++;
        }

        public override void Drive()
        {
            Console.WriteLine($"Truck Engage: '{this.Manufacturer.Name}'\t- {this.Model}\t Doors: {this.Doors.Count}\t{this.SerialNumber}");
        }

    }
}
