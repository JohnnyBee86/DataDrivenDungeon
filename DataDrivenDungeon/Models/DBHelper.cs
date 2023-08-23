using DataDrivenDungeon.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenDungeon.Models
{
    public class DBHelper
    {
        // gets
        public static Weapon GetWeapon(int id, GameContext context)
        {
            return context.Weapons.Where(w => w.WeaponId == id).Single();
        }

        public static Armor GetArmor(int id, GameContext context)
        {
            return context.Armors.Where(w => w.ArmorId == id).Single();
        }

        public static GameData GetGameData(int id, GameContext context)
        {
            return context.Game.Where(w => w.GameId == id).Single();
        }

        public static Inventory GetInventory(int id, GameContext context)
        {
            return context.GameInventory.Where(w => w.InventoryId == id).Single();
        }

        public static Dungeon GetDungeon(int id, GameContext context)
        {
            return context.Dungeons.Where(w => w.DungeonId == id).Single();
        }

        public static Creature GetCreature(int id, GameContext context)
        {
            return context.Creatures.Where(w => w.CreatureId == id).Single();
        }
    }
}
