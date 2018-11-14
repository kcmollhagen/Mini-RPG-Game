using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mini_RPG_Game.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Lives { get; set; }
        public int Attack { get; set; }
        public int Gold { get; set; }

        internal static dynamic ToList(Player player)
        {
            List<Player> players = new List<Player>();
            players.Add(player);
            return players;
        }

        //internal static dynamic ToList()
        //{
        //    throw new NotImplementedException();
        //}
    }

    public class DBPlayerContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
    }
}