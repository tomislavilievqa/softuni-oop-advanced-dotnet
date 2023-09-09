using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryIncrease;

namespace First_and_Reserve_Team
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public IReadOnlyCollection<Person> FirstTeam { 
            get 
            { 
                return this.firstTeam.AsReadOnly(); 
            } 
        }
        public IReadOnlyCollection<Person> ReserveTeam
        {
            get 
            {
                return this.reserveTeam.AsReadOnly();
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Team(string name)
        {
            this.Name = name;
        }
        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                firstTeam.Add(player);
            }
            else
            {
                reserveTeam.Add(player);
            }
        }

    }
}
