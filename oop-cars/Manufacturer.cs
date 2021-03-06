﻿using System;
using System.Collections.Generic;
using System.Text;

namespace oop_cars
{
   public class Manufacturer
    {
        /// <summary>
        /// The name
        /// </summary>
        private string _name;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private Manufacturer() { }

        public Manufacturer(string name)
        {
            this._name = name;
        }

        /// <summary>
        /// Builds the car.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="ps">The ps.</param>
        /// <param name="tireSize">Size of the tire.</param>
        /// <param name="carType">Type of the car.</param>
        /// <returns>
        /// Car.
        /// </returns>
        public Car BuildCar(string model, int ps, int tireSize, CarType carType)
        {
            Engine engine = new Engine(ps);
            List<Tire> tires = new List<Tire>();
            for (int i = 0; i < 4; i++)
            {
                tires.Add(new Tire(tireSize));
            }

            int doorCount = 0;
            switch (carType)
            {
                case CarType.Coupe:
                    doorCount = 2;
                    break;
                case CarType.Limousine:
                    doorCount = 4;
                    break;
                default:
                    break;
            }
            List<Door> doors = new List<Door>();
            for (int i = 0; i < doorCount; i++)
            {
                doors.Add(new Door());
            }

            Car car = new Car(model, engine, this, tires, doors, carType);
            return car;
        }

        /// <summary>
        /// Builds the truck.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="ps">The ps.</param>
        /// <param name="tireSize">Size of the tire.</param>
        /// <returns></returns>
        public Truck BuildTruck(string model, int ps, int tireSize)
        {
            Engine engine = new Engine(ps);
            List<Tire> tires = new List<Tire>();
            for (int i = 0; i < 6; i++)
            {
                tires.Add(new Tire(tireSize));
            }

            int doorCount = 2;
            List<Door> doors = new List<Door>();
            for (int i = 0; i < doorCount; i++)
            {
                doors.Add(new Door());
            }

            Truck truck = new Truck(model, engine, this, tires, doors);
            return truck;
        }

    }
}
