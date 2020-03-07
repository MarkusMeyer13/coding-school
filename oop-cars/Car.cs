using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace oop_cars
{
    class Car
    {
        private Manufacturer _manufacturer;

        public Manufacturer Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }

        private Engine _engine;

        public Engine Engine
        {
            get { return _engine; }
            set { _engine = value; }
        }

        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public CarType CarType { get; set; }

        public List<Tire> Tires { get; set; }
        public List<Door> Doors { get; set; }

        public string SerialNumber { get; set; } = Guid.NewGuid().ToString();

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

        public void Drive()
        {
            Console.WriteLine($"Engage: '{this.Manufacturer.Name}'\t- {this.Model}\t Doors: {this.Doors.Count}\t{this.SerialNumber}");
        }
    }
}
