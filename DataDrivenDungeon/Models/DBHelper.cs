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
        public static Weapon GetWeapon(GameData player, GameContext context)
        {
            Weapon w = context.Weapons.Where(w => w.WeaponId == player.CurrentWeapon.WeaponId).Single();
            return w;
        }

        public Armor GetArmor()
        {
            throw new NotImplementedException();
        }

        public GameData GetGameData()
        {
            throw new NotImplementedException();
        }

        public Inventory GetInventory()
        {
            throw new NotImplementedException();
        }

        public Dungeon GetDungeon()
        {
            throw new NotImplementedException();
        }

        public Creature GetCreature()
        {
            throw new NotImplementedException();
        }
    }
}
