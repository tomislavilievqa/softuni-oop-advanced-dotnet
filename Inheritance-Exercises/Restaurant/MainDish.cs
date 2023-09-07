using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
     class MainDish : Food
    {
        private const double Grams = 22;
        public MainDish(string name, decimal price, double grams) : base(name, price, Grams)
        {
           
        }
    }
}
