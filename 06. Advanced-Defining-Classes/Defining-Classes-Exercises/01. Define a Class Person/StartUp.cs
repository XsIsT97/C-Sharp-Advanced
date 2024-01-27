using System;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            Person persone1 = new Person()
            {
                Name = "Peter",
                Age = 20
            };

            Console.WriteLine(persone1.Name+ " " +persone1.Age);
        }
    }
}
