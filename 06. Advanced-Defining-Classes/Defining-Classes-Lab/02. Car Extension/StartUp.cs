using System;

namespace CarManufacturer
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "VW";
            car.Model = "Golf";
            car.Year = 1992;
            car.FuelQuantity = 200;
            car.FuelConsumption = 10;

            car.Drive(20);

            Console.WriteLine(car.WhoAmI());
        }
    }
}
