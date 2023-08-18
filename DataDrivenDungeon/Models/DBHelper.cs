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
        /// <summary>
        /// Gets the player's current weapon
        /// </summary>
        /// <param name="player"></param>
        /// <param name="context"></param>
        /// <returns>The current weapon object</returns>
        public static Weapon GetWeapon(GameData player, GameContext context)
        {
            Weapon w = context.Weapons.Where(w => w.WeaponId == player.CurrentWeapon.WeaponId).Single();
            return w;
        }

        /// <summary>
        /// Gets the player's current armor
        /// </summary>
        /// <param name="player"></param>
        /// <param name="context"></param>
        /// <returns>The current weapon object</returns>
        public static Armor GetArmor(GameData player, GameContext context)
        {
            Armor a = context.Armors.Where(a => a.ArmorId == player.CurrentArmor.ArmorId).Single();
            return a;
        }

        public GameData GetGameData()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the player's current inventory
        /// </summary>
        /// <param name="player"></param>
        /// <param name="context"></param>
        /// <returns>The current inventory object</returns>
        /// <exception cref="NotImplementedException"></exception>
        public static Inventory GetInventory(GameData player, GameContext context)
        {
            throw new NotImplementedException();
            /*
            Inventory i = context.GameInventory.Where(i => i.InventoryId == player.GameId).Single();
            return i;
            */
        }

        /// <summary>
        /// Gets the dungeon the player is allowed in
        /// </summary>
        /// <param name="player"></param>
        /// <param name="context"></param>
        /// <returns>The current dungeon object</returns>
        public static Dungeon GetDungeon(GameData player, GameContext context)
        {
            Dungeon d = context.Dungeons.Where(d => d.DungeonId == player.HighestDungeonAllowed.DungeonId).Single();
            return d;
        }

        /// <summary>
        /// Gets a creature from the current dungeon
        /// </summary>
        /// <returns>A creature object</returns>
        /// <exception cref="NotImplementedException"></exception>
        public Creature GetCreature()
        {
            throw new NotImplementedException();
        }
    }
}
