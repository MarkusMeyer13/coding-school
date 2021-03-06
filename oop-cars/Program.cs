﻿using System;
using System.Collections.Generic;

namespace oop_cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start your engines!");
            //List<Car> cars = new List<Car>();
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            Manufacturer bmw = new Manufacturer("BMW");

            Car fiveTwenty = bmw.BuildCar("520", 190, 21, CarType.Coupe);
            cars.Add(fiveTwenty.SerialNumber, fiveTwenty);

            Car threeTwentyFive = bmw.BuildCar("325", 210, 19, CarType.Limousine);
            cars.Add(threeTwentyFive.SerialNumber, threeTwentyFive);

            Manufacturer audi = new Manufacturer("Audi");

            Car aFour = audi.BuildCar("A4", 150, 19, CarType.Limousine);
            cars.Add(aFour.SerialNumber, aFour);

            Car aSix = audi.BuildCar("A6", 190, 21, CarType.Coupe);
            cars.Add(aSix.SerialNumber, aSix);

            Console.WriteLine("CarType.Coupe:");
            var carsEnumerator = cars.GetEnumerator();
            while (carsEnumerator.MoveNext())
            {
                if (carsEnumerator.Current.Value.CarType.Equals(CarType.Coupe))
                {
                    carsEnumerator.Current.Value.Drive();
                }
            }
            Console.WriteLine();

            carsEnumerator = cars.GetEnumerator();
            Console.WriteLine("CarType.Limousine:");
            while (carsEnumerator.MoveNext())
            {
                if (carsEnumerator.Current.Value.CarType.Equals(CarType.Limousine))
                {
                    carsEnumerator.Current.Value.Drive();
                }
            }
            Console.WriteLine();


            Console.WriteLine("Car.NumberOfCars: " + Car.NumberOfCars);
            //Console.ReadLine();

            Manufacturer mercedesBenz = new Manufacturer("Mercedes-Benz");
            Truck actros = mercedesBenz.BuildTruck("Actros", 440, 23);

            actros.Drive();

            Dictionary<string, Vehicle> vehicles = new Dictionary<string, Vehicle>
            {
                { actros.SerialNumber, actros },
                { aSix.SerialNumber, aSix },
                { aFour.SerialNumber, aFour },
                { fiveTwenty.SerialNumber, fiveTwenty },
                { threeTwentyFive.SerialNumber, threeTwentyFive },
            };

            Console.WriteLine();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            var vehiclesEnumerator = vehicles.GetEnumerator();
            Console.WriteLine("All:");
            while (vehiclesEnumerator.MoveNext())
            {
                vehiclesEnumerator.Current.Value.Drive();
            }
            Console.WriteLine();

            Console.ReadLine();

        }

    }
}
