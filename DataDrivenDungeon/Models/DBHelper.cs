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
        public static Weapon GetWeapon(int id, GameContext context)
        {
            return context.Weapons.Where(weapon => weapon.WeaponId == id).Single();
        }

        public static Armor GetArmor(int id, GameContext context)
        {
            return context.Armors.Where(armor => armor.ArmorId == id).Single();
        }

        public static GameData GetGameData(int id, GameContext context)
        {
            return context.Game.Where(gameData => gameData.GameId == id).Single();
        }

        public static Inventory GetInventory(int id, GameContext context)
        {
            return context.GameInventory.Where(inventory => inventory.InventoryId == id).Single();
        }

        public static Dungeon GetDungeon(int id, GameContext context)
        {
            return context.Dungeons.Where(dungeon => dungeon.DungeonId == id).Single();
        }

        public static Creature GetCreature(int id, GameContext context)
        {
            return context.Creatures.Where(creature => creature.CreatureId == id).Single();
        }

        public static List<GameData> GetPlayers(GameContext context)
        {
            List<GameData> savedGames = context.Game.Include(game => game.CurrentWeapon)
                        .Include(game => game.CurrentArmor)
                        .Include(game => game.HighestDungeonAllowed).ToList();
            return savedGames;
        }

        /// <summary>
        /// Increases the number of items in a given inventory
        /// </summary>
        /// <param name="inventoryId">The id of the inventory you want to change</param>
        /// <param name="item">The name of the item that you want to add. It should be
        /// a single word with the first letter being capitalized</param>
        /// <param name="context">The Database context</param>
        public static void AddToInventory(int inventoryId, string item, GameContext context)
        {
            Inventory inventory = GetInventory(inventoryId, context);
            if (item.Equals("Fireball"))
            {
                inventory.Fireballs++;
                context.GameInventory.Update(inventory);
                context.SaveChanges();
                MessageBox.Show("A Fireball was added to your inventory");
            } 
            else if (item.Equals("Potion"))
            {
                inventory.Fireballs++;
                context.GameInventory.Update(inventory);
                context.SaveChanges();
                MessageBox.Show("A Potion was added to your inventory");
            }
            else if (item.Equals("Coins"))
            {
                inventory.Coins++;
                context.GameInventory.Update(inventory);
                context.SaveChanges();
                MessageBox.Show("A Coin was added to your inventory");
            }
            else
            {
                MessageBox.Show($"{item} is not a real item.");
            }
        }

        /// <summary>
        /// Removes an item from the given inventory
        /// </summary>
        /// <param name="inventoryId">The id of the inventory you want to change</param>
        /// <param name="item">The name of the item that you want to add. It should be
        /// a single word with the first letter being capitalized</param>
        /// <param name="context">The Database context<param>
        public static void RemoveFromInventory(int inventoryId, string item, GameContext context)
        {
            Inventory inventory = GetInventory(inventoryId, context);
            if (item.Equals("Fireball"))
            {
                inventory.Fireballs--;
                context.GameInventory.Update(inventory);
                context.SaveChanges();
                MessageBox.Show("A Fireball was removed to your inventory");
            }
            else if (item.Equals("Potion"))
            {
                inventory.Fireballs--;
                context.GameInventory.Update(inventory);
                context.SaveChanges();
                MessageBox.Show("A Potion was removed to your inventory");
            }
            else if (item.Equals("Coins"))
            {
                inventory.Coins--;
                context.GameInventory.Update(inventory);
                context.SaveChanges();
                MessageBox.Show("A Coin was removed to your inventory");
            }
            else
            {
                MessageBox.Show($"{item} is not a real item.");
            }
        }
    }
}
