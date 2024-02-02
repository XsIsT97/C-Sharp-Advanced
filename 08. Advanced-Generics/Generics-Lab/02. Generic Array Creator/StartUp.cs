using System;
using System.Linq;

namespace _02._Generic_Array_Creator
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create<string>(5, "Pesho");
            int[] integers = ArrayCreator.Create<int>(10, 33);
    }
}
