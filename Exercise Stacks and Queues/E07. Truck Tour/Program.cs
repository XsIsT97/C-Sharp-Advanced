using System;
using System.Collections.Generic;
using System.Linq;

namespace E07._Truck_Tour
{
    class Pump
    {
        //полета -> характеристики -> помпа
        private int number;//номер
        public int amount;
        public int distance;

        public Pump (int number, int amount, int distance)
        {
            this.number = number;
            this.amount = amount;
            this.distance = distance;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());// брой бензинови помпи

            Queue<Pump> pumpsQueue = new Queue<Pump>();

            for (int i = 0; i <= n - 1; i++)
            {
                string data = Console.ReadLine();

                int amaount = int.Parse(data.Split(' ')[0]);
                int distance = int.Parse(data.Split(' ')[1]);

                Pump pump = new Pump(i, amaount, distance);

                pumpsQueue.Enqueue(pump);
            }

            int totalDistance = pumpsQueue.Sum(pump => pump.distance);
            int truckDistance = 0;
            int truckFuel = 0;

            while (truckDistance < totalDistance)
            {
                Pump currentPump = pumpsQueue.Peek();
                truckFuel += currentPump.amount;
                truckDistance += currentPump.distance;

                pumpsQueue.Dequeue();
            }
        }
    }
}
