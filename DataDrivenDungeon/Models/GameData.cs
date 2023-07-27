using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenDungeon.Models
{
    /// <summary>
    /// Represents a single Game
    /// </summary>
    internal class GameData
    {
        /// <summary>
        /// The game's unique identifier
        /// </summary>
        [Key]
        public int GameId { get; set; }

        /// <summary>
        /// The name of the game's player
        /// </summary>
        [StringLength(15, MinimumLength =1)]
        public string PlayerName { get; set; }

        /// <summary>
        /// The player's current weapon
        /// </summary>
        public Weapon CurrentWeapon { get; set; }

        /// <summary>
        /// The player's current armor
        /// </summary>
        public Armor CurrentArmor { get; set; }

        /// <summary>
        /// The player's health before any armor bonus
        /// </summary>
        public short PlayerHealth { get; set; }

        /// <summary>
        /// The highest level dungeon the player may enter
        /// </summary>
        public Dungeon HighestDungeonAllowed { get; set; }
    }
}
