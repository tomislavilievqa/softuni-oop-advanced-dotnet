﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Tomcat : Cat
    {
        public const string Gender = "Male";

        public Tomcat(string name, int age) : base(name, Gender, age)
        {

        }
        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
