using SalaryIncrease;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfo
{
    public class StartUp
    {

        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            //

            for (int i = 0; i < lines; i++)
            {
                var peopleDetails = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var person = new Person(peopleDetails[0], peopleDetails[1], int.Parse(peopleDetails[2]), decimal.Parse(peopleDetails[3]));
                persons.Add(person);
            }
            var percentage = decimal.Parse(Console.ReadLine());
            persons.ForEach(p => p.IncreaseSalary(percentage));
            persons.ForEach(p => Console.WriteLine(p.ToString()));
            // persons.OrderBy(p => p.FirstName).ThenBy(p => p.LastName).ToList().ForEach(p => Console.WriteLine(p.ToString()));

        }

    }
}

