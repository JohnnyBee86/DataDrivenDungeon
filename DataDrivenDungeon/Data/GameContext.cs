using DataDrivenDungeon.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenDungeon.Data
{
    public class GameContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DungeonGame");
            }
        }

        public GameContext() { }

        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Armor> Armors { get; set; }
        public DbSet<Dungeon> Dungeons { get; set; }
        public DbSet<Creature>  Creatures { get; set; }
        public DbSet<GameData> Game { get; set; }
        public DbSet<Inventory> GameInventory { get; set; }
    }
}
