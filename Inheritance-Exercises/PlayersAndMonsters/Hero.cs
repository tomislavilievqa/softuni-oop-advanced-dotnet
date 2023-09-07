using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    class Hero
    {
        private string Username;
        private int Level;

        public Hero(string username, int level)
        {
            this.Username = username;
            this.Level = level;
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }

        //public string Username
        //{
        //    get
        //    {
        //        return this.Username;
        //    }
        //    set
        //    {
        //        this.Username = value;
        //    }
        //}
        //public int Level
        //{
        //    get
        //    {
        //        return this.Level;
        //    }
        //    set
        //    {
        //        this.Level = value;
        //    }
        //}



    }
}
