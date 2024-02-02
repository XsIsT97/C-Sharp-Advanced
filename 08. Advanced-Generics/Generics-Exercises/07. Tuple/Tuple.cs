﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._Tuple
{
    public class Tuple<T1, T2>
    {
        public Tuple(T1 item1, T2 item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }
        public object Item1 { get; set; }

        public object Item2 { get; set; }


        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }
    }
}
