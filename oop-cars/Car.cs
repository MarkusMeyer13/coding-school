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

        public List<Tire> Tires { get; set; }

        public string SerialNumber { get; set; } = Guid.NewGuid().ToString();

        private Car() { }

        public Car(string model, Engine engine, Manufacturer manufacturer, List<Tire> tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Manufacturer = manufacturer;
            this.Tires = tires;
        }

        public void Drive()
        {
            string msg = string.Format(CultureInfo.InvariantCulture, "Engage '{0}'\t {1}", this.Manufacturer.Name, this.Model);
            Console.WriteLine($"Engage: '{this.Manufacturer.Name}'\t- {this.Model}\t{this.SerialNumber}");
        }

    }
}
