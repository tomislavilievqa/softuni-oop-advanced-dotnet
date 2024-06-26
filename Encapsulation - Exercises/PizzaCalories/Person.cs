﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bagOfProducts;

        public string Name
        {
            get 
            {
                return name;
            }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be empty");
                }
                name = value;
            }
        }

        public decimal Money
        {
            get 
            { 
                return money; 
            }
            set 
            {
                if (value < 0)
                {
                    throw new Exception("Money cannot be negative");
                }
                money = value;
            }
        }

        //public IReadOnlyCollection<Product> BagOfProducts
        //{
        //    get 
        //    {
        //        return bagOfProducts.AsReadOnly(); 
        //    }
        //    set
        //    {
        //        bagOfProducts = (List<Product>)value;
        //        //if (true)
        //        //{

        //        //}

        //        //return bagOfProducts;
        //    }
        //}
        public Person(string name, decimal money)
        {
            this.bagOfProducts = new List<Product>();
            this.Name = name;
            this.Money = money;
        }

        public void AddToBag(Product product)
        {
            if(this.Money - product.Cost >= 0)
            {
                this.bagOfProducts.Add(product);
                this.money -= product.Cost;

                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {

                Console.WriteLine($"{this.Name} can't afford {product.Name}");

            }
        }
        public override string ToString()
        {
            if(this.bagOfProducts.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }
            return $"{this.Name} - {string.Join(", ", this.bagOfProducts.Select(x => x.Name))}";
        }

    }

}
