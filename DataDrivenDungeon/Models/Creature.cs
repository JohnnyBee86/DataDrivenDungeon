using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenDungeon.Models
{
    /// <summary>
    /// Represents a single enemy creature in the game
    /// </summary>
    public class Creature
    {
        /// <summary>
        /// The creature's unique identifier
        /// </summary>
        [Key]
        public int CreatureId { get; set; }

        /// <summary>
        /// What dungeon this creature appears in
        /// </summary>
        public Dungeon FightInDungeon { get; set; } = null!;

        /// <summary>
        /// The creature's name
        /// </summary>
        public string CreatureName { get; set; } = null!;

        /// <summary>
        /// Is the creature a dungeon boss
        /// </summary>
        public bool IsBoss { get; set; }

        /// <summary>
        /// The creature's minimum health it can spawn with
        /// </summary>
        public short HealthMin { get; set; }

        /// <summary>
        /// The creature's maximum health it can spawn with
        /// </summary>
        public short HealthMax { get; set; }

        /// <summary>
        /// The minimum damage the creature can do
        /// </summary>
        public short DamageMin { get; set; }

        /// <summary>
        /// The maximum damage the creature can do
        /// </summary>
        public short DamageMax { get; set; }

        /// <summary>
        /// The minimum amount of money a creature can drop
        /// </summary>
        public short CoinDropMin { get; set; }

        /// <summary>
        /// The maximum amount of money a creature can drop
        /// </summary>
        public short CoinDropMax { get; set; }

        /// <summary>
        /// The extra item a creature can drop, if any
        /// </summary>
        public string? BonusDrop { get; set; }

        /// <summary>
        /// The chance of the creature dropping its bonus item
        /// </summary>
        public short BonusDropChance { get; set; }
    }
}
