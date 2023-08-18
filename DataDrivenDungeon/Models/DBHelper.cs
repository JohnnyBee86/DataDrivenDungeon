using DataDrivenDungeon.Data;
using Microsoft.EntityFrameworkCore;
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
        public static Weapon GetWeapon(GameData player, GameContext context)
        {
            Weapon w = context.Weapons.Where(w => w.WeaponId == player.CurrentWeapon.WeaponId).Single();
            return w;
        }

        public static Armor GetArmor(GameData player, GameContext context)
        {
            Armor a = context.Armors.Where(a => a.ArmorId == player.CurrentArmor.ArmorId).Single();
            return a;
        }

        public GameData GetGameData()
        {
            throw new NotImplementedException();
        }

        public static Inventory GetInventory(GameData player, GameContext context)
        {
            throw new NotImplementedException();
            /*
            Inventory i = context.GameInventory.Where(i => i.InventoryId == player.GameId).Single();
            return i;
            */
        }

        public static Dungeon GetDungeon(GameData player, GameContext context)
        {
            throw new NotImplementedException();
        }

        public Creature GetCreature()
        {
            throw new NotImplementedException();
        }
    }
}
