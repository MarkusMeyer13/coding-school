using System;
using System.Collections.Generic;

namespace oop_cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start your engines!");
            List<Car> cars = new List<Car>();

            Manufacturer bmw = new Manufacturer("BMW");

            Car fiveTwenty = bmw.BuildCar("520", 190, 21);
            cars.Add(fiveTwenty);

            Car threeTwentyFive = bmw.BuildCar("325", 210, 19);
            cars.Add(threeTwentyFive);

            Manufacturer audi = new Manufacturer("Audi");

            Car aFour = audi.BuildCar("A4", 150, 19);
            cars.Add(aFour);

            Car aSix = audi.BuildCar("A6", 190, 21);
            cars.Add(aSix);

            var carsEnumerator = cars.GetEnumerator();
            while (carsEnumerator.MoveNext())
            {
                carsEnumerator.Current.Drive();
            }
            Console.ReadLine();
        }
    }
}
