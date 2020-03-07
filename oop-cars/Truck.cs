﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace oop_cars
{
    class Truck
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
        public List<Door> Doors { get; set; }

        public string SerialNumber { get; set; } = Guid.NewGuid().ToString();

        public static int NumberOfType = 0;

        public Truck(string model, Engine engine, Manufacturer manufacturer, List<Tire> tires, List<Door> doors)
        {
            this.Model = model;
            this.Engine = engine;
            this.Manufacturer = manufacturer;
            this.Tires = tires;
            this.Doors = doors;
            NumberOfType++;
        }

        public void Drive()
        {
            Console.WriteLine($"Engage: '{this.Manufacturer.Name}'\t- {this.Model}\t Doors: {this.Doors.Count}\t{this.SerialNumber}");
        }
    }
}
