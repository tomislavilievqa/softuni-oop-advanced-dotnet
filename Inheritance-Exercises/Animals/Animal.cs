using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        private string _name;

        private string _gender;

        private int _age;
        public Animal(string name, string gender, int age)
        {
            Name = name;
            Gender = gender;
            Age = age;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Invalid input!");
                }
                _name = value;
            }
        }
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                if (value.ToLower() == "male" || value.ToLower() == "female")
                {
                    _gender = value;
                }
                else
                {
                    throw new Exception("Invalid input!");
                }
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Invalid input!");
                }

                _age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append($"{this.Name} {this.Age} {this.Gender}");
            return stringBuilder.ToString();

        }
        public virtual string ProduceSound()
        {
            return string.Empty;
        }
    }

}
