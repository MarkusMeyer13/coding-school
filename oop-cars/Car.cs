using System;
using System.Collections.Generic;
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

        public string SerialNumber { get; set; } = Guid.NewGuid().ToString();

        private Car() { }

        public Car(string model, Engine engine, Manufacturer manufacturer)
        {
            this.Model = model;
            this.Engine = engine;
            this.Manufacturer = manufacturer;
        }

        public void Drive()
        {
            Console.WriteLine($"Engage: '{this.Manufacturer.Name}'\t- {this.Model}\t{this.SerialNumber}");
        }

    }
}
