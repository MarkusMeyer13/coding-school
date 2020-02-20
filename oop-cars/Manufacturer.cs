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

        /// <summary>
        /// Builds the car.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="ps">The ps.</param>
        /// <returns>Car.</returns>
        public Car BuildCar(string model, int ps)
        {
            Engine engine = new Engine() { PS = ps };
            Car car = new Car() { Manufacturer = this, Model = model, Engine=engine };
            return car;
        }
    }
}
