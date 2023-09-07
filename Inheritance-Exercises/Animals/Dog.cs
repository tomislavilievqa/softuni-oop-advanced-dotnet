using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog : Animal
    {
        public Dog(string name, string gender, int age) : base(name, gender, age)
        {
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
