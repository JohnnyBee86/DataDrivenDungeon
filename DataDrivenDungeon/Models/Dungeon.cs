using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenDungeon.Models
{
    /// <summary>
    /// Represents a single dungeon in the game
    /// </summary>
    public class Dungeon
    {
        /// <summary>
        /// The dungeon's unique identifier
        /// </summary>
        [Key]
        public int DungeonId { get; set; }

        /// <summary>
        /// The dungeon's name
        /// </summary>
        public string DungeonName { get; set; }

        /// <summary>
        /// How many fights the player must win before the boss apears
        /// </summary>
        public short FightsBeforeBoss { get; set; }

        /// <summary>
        /// The minimum number of enemies in a single fight
        /// </summary>
        public short EnemyMinPerFight { get; set; }

        /// <summary>
        /// The chance of 1 extra enemy being added to a fight
        /// </summary>
        public short ExtraEnemyChance { get; set; }
    }
}
