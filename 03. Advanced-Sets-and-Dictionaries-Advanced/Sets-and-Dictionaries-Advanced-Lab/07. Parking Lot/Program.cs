using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            HashSet<string> parking = new HashSet<string>();

            while (command != "END")
            {
                string[] listOfCars = command.Split(", ");
                string action = listOfCars[0];
                string carNumber = listOfCars[1];

                if (action == "IN")
                {
                    parking.Add(listOfCars[1]);
                }
                else
                {
                    parking.Remove(listOfCars[1]);
                }

                command = Console.ReadLine();
            }

            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
