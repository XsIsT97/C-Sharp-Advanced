using System;

namespace CarManufacturer
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var make = Console.ReadLine();
            var model = Console.ReadLine();
            var year = int.Parse(Console.ReadLine());
            var fuelQuantity = double.Parse(Console.ReadLine());
            var fuelConsumption = double.Parse(Console.ReadLine());

            Car car = new Car();
            car.Make = "BMW";
            car.Model = "X5";
            car.Year = 2006;
            car.FuelQuantity = 80;
            car.FuelConsumption = fuelConsumption;
            Console.WriteLine(car.WhoAmI());
            Car firstCar = new Car();

            Console.WriteLine(firstCar.WhoAmI());

            Car secondCar = new Car(make, "Yaris", year);
            Console.WriteLine(secondCar.WhoAmI());

            Car thirdCar = new Car("Opel", model, 2016, 300, fuelConsumption);

            thirdCar.Drive(200);
            Console.WriteLine(thirdCar.WhoAmI());
        }
    }
}
