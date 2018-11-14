using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Mini_RPG_Game.Models
{
    public class Monster
    {
        public int ID { get; set; }
        public string Name {get; set;}
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int LootDropped { get; set; }

        internal static dynamic ToList()
        {
            throw new NotImplementedException();
        }
    }

    public class DBMonsterContext : DbContext
    {
        public DbSet<Monster> Monsters { get; set; }
    }
}