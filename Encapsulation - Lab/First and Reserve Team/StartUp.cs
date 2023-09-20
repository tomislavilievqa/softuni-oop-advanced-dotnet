using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using First_and_Reserve_Team;
using SalaryIncrease;


namespace PersonsInfo
{

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var players = new List<Person>();
         
            for (int i = 0; i < lines; i++)
            {
                var peopleDetails = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var player = new Person(peopleDetails[0], peopleDetails[1], int.Parse(peopleDetails[2]), decimal.Parse(peopleDetails[3]));
                players.Add(player);
            }

            Team team = new Team("SoftUni");

            foreach (Person player in players)
            {
                team.AddPlayer(player);
            }

            players.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
