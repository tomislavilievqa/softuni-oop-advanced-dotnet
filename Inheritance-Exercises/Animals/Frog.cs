using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Frog : Animal
    {
        public Frog(string name, string gender, int age) : base(name, gender, age)
        {
        }

        public override string ProduceSound()
        {
            return "Ribbit";
        }
    }
}
