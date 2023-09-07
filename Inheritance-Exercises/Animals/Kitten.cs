﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Kitten : Cat
    {
        public const string Gender = "Female";
        public Kitten(string name, int age) : base(name, Gender, age)
        {

        }
        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
