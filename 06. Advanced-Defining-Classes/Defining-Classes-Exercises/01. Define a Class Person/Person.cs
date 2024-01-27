﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get => name;
            set { this.name = value; }
        }
        
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
    }
}
