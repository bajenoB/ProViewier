using System;
using System.Collections.Generic;


namespace WebApplication1
{
    public class Player 
    {
        public int Id { get; set; }
        public string Nick { get; set; }

        public int Age { get; set; }

        public Team team { get; set; }

        public Player()
        {
            Id = 0;
            Nick = string.Empty;
            Age = 0;
            team = new Team();
        }
        public Player(int id, string nickname, int age,  Team team)
        {
            Id = id;
            Nick = nickname;
            this.Age=age;
            this.team = team;
        }


    }
}
