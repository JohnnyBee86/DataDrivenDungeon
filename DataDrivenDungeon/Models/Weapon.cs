using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenDungeon.Models
{
    /// <summary>
    /// Represents a single in game weapon
    /// </summary>
    public class Weapon
    {
        /// <summary>
        /// The weapon's unique identifier
        /// </summary>
        [Key]
        public int WeaponId { get; set; }

        /// <summary>
        /// The weapon's name
        /// </summary>
        public string WeaponName { get; set; } = null!;

        /// <summary>
        /// The weapon's cost in game
        /// </summary>
        public short WeaponCost { get; set; }

        /// <summary>
        /// The minimum damage the weapon can deal
        /// </summary>
        public short DamageMin { get; set; }

        /// <summary>
        /// The maximum damage the weapon can deal
        /// </summary>
        public short DamageMax { get; set;}
    }
}
