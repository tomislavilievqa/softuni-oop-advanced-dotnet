using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Person
{
    public class Person
    {
        private string Name;
        private int Age;

        public Person(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}"; 
        }



    }
}
