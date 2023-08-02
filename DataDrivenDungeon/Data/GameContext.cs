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
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        {

        }

        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Armor> Armors { get; set; }
        public DbSet<Dungeon> Dungeons { get; set; }
        public DbSet<Creature>  Creatures { get; set; }
        public DbSet<GameData> Game { get; set; }
        public DbSet<Inventory> GameInventory { get; set; }
    }
}
