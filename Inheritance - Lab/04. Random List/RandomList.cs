using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Random_List
{
    public class RandomList : List<string>
    {
        private Random rnd { get; set; }

        public RandomList(IEnumerable<string> phrases) : base(phrases)      
        {
            rnd = new Random();
        }

        public string RandomString()
        {
            string result = "";
            int index = rnd.Next(0, this.Count);
            result = this[index];
            this.RemoveAt(index); 
            
            return result;
        }
    }
}
