using System;
using System.Collections.Generic;
using System.Text;

namespace oop_cars
{
    class Manufacturer
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
        /// <returns>Car.</returns>
        public Car BuildCar(string model, int ps, int tireSize)
        {
            Engine engine = new Engine(ps);
            List<Tire> tires = new List<Tire>();
            for (int i = 0; i < 4; i++)
            {
                tires.Add(new Tire(tireSize));
            }

            Car car = new Car(model, engine, this, tires);
            return car;
        }
    }
}
