using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace oop_cars
{
    public class Car: Vehicle
    {
        public CarType CarType { get; set; }

        public static int NumberOfCars = 0;

        private Car() { }

        public Car(string model, Engine engine, Manufacturer manufacturer, List<Tire> tires, List<Door> doors, CarType carType)
        {
            this.Model = model;
            this.Engine = engine;
            this.Manufacturer = manufacturer;
            this.Tires = tires;
            this.Doors = doors;
            this.CarType = carType;
            NumberOfCars++;
        }

        public new void Drive()
        {
            Console.WriteLine($"Car Engage: '{this.Manufacturer.Name}'\t- {this.Model}\t Doors: {this.Doors.Count}\t{this.SerialNumber}");
        }

    }
}
