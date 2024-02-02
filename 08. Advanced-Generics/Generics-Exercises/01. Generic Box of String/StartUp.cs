using System;

namespace _01._Generic_Box_of_String
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                Box<string> box = new Box<string>();
                box.Value = s;
                Console.WriteLine(box.ToString());
            }
        }
    }
}
