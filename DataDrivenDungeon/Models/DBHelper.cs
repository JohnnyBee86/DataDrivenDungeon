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
    }
}
