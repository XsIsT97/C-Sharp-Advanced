using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._Generic_Box_of_String
{
    internal class Box<T>
    {
        public string Value { get; set; }

        public override string ToString()
        {
            return $"{Value.GetType()}: {Value}";
        }
    }
}
