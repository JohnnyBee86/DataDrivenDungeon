using DataDrivenDungeon.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenDungeon.Models
{
    public class DBHelper
    {
        // gets
        public Weapon GetWeapon(int id, GameContext context)
        {
            return context.Weapons.Find(id);
        }

        public Armor GetArmor(int id, GameContext context)
        {
            return context.Armors.Find(id);
        }

        public GameData GetGameData(int id, GameContext context)
        {
            return context.Game.Find(id);
        }

        public Inventory GetInventory(int id, GameContext context)
        {
            return context.GameInventory.Find(id);
        }

        public Dungeon GetDungeon(int id, GameContext context)
        {
            return context.Dungeons.Find(id);
        }

        public Creature GetCreature(int id, GameContext context)
        {
            return context.Creatures.Find(id);
        }
    }
}
