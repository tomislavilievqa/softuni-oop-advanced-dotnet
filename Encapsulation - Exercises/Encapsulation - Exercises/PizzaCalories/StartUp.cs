using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class StartUp
    {
        
        public static void Main(string[] args)
        {
            

            try
            {
                string[] peopleInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();

                List<Person> people = new List<Person>();
                List<Product> products = new List<Product>();

                for (int i = 0; i < peopleInput.Length; i++)
                {
                    string[] currPerson = peopleInput[i].Split("=");
                    string name = currPerson[0];
                    decimal money = decimal.Parse(currPerson[1]);

                    Person person = new Person(name, money);

                    people.Add(person);

                }

                string[] productInput = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < productInput.Length; i++)
                {
                    string[] currProduct = productInput[i].Split("=");
                    string name = currProduct[0];
                    decimal cost = decimal.Parse(currProduct[1]);

                    Product product = new Product(name, cost);

                    products.Add(product);

                }
                string input = Console.ReadLine();

                while (input != "END")
                {
                    string[] inputInfo = input.Split();
                    string name = inputInfo[0];
                    string productName = inputInfo[1];

                    Person person = people.FirstOrDefault(x => x.Name == name);
                    Product product = products.FirstOrDefault(x => x.Name == productName);
                    person.AddToBag(product);

                    input = Console.ReadLine();

                }

                foreach (var person in people)
                {

                    Console.WriteLine(person);

                }
            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
   
}
