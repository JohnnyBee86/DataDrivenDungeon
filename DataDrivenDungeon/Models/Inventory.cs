using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenDungeon.Models
{
    /// <summary>
    /// Represents the player inventory of a single game
    /// </summary>
    public class Inventory
    {
        /// <summary>
        /// The inventory's unique identifier
        /// </summary>
        [Key]
        public int InventoryId { get; set; }

        /// <summary>
        /// The game the inventory belongs to
        /// </summary>
        /*public GameData SaveData { get; set; } = null!;*/

        /// <summary>
        /// How much money the player is carrying
        /// </summary>
        public short Coins { get; set; }

        /// <summary>
        /// How much money the player has in their bank
        /// </summary>
        public short BankedCoins { get; set; }

        /// <summary>
        /// How many potions the player is carrying
        /// </summary>
        public short Potions { get; set; }

        /// <summary>
        /// How many potions the player has in their bank
        /// </summary>
        public short BankedPotions { get; set; }

        /// <summary>
        /// How many fireballs the player is carrying
        /// </summary>
        public short Fireballs { get; set; }

        /// <summary>
        /// How many fireballs the player has in their bank
        /// </summary>
        public short BankedFireballs { get; set; }

        /// <summary>
        /// How many dropped emblems the player is carrying 
        /// </summary>
        public short Emblems { get; set; }
    }
}
