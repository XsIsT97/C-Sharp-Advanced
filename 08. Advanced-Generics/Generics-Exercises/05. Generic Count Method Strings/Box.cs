using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Generic_Count_Method_Strings
{
    internal class Box<T> where T : IComparable<T>
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

        public int CompareTo(T other)
        {
            return Value.CompareTo(other);
        }
    }
}
