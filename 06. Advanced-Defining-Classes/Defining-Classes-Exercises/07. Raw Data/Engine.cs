using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Raw_Data
{
    internal class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            Speed = engineSpeed;
            Power = enginePower;
        }

        //•	Engine: a class with two properties – speed and power,
        public int Speed { get; set; }
        public int Power { get; set; }
    }
}
