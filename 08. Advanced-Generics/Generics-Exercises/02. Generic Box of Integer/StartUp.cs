using System;

namespace _02._Generic_Box_of_Integer
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>();
                box.Value = num;
                Console.WriteLine(box.ToString());
            }
        }
    }
}
