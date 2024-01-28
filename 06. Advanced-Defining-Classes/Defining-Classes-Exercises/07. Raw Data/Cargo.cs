using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Raw_Data
{
    internal class Cargo
    {
        public Cargo(int weight, string type)
        {
            Type = type;
            Weight = weight;
        }

        //Cargo: a class with two properties – type and weight 
        public string Type { get; set; }
        public int Weight { get; set; }
    }
}
