using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._Generic_Swap_Method_Strings
{
    internal class Box<T>
    {
        public T Value { get; set; }

        public Box(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value.GetType()}: {Value}";
        }
    }
}

