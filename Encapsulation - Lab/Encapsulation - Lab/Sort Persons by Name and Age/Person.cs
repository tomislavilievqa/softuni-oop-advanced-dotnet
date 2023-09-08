using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Persons_by_Name_and_Age
{
    internal class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public decimal Salary { get; private set; }

        public Person(string firstName, string lastName, int age)
        {
            this.LastName = lastName;
            this.FirstName = firstName;
            this.Age = age;
        }   

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old";
        }
    }
}
