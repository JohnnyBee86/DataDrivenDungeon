using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenDungeon.Models
{
    /// <summary>
    /// Represents a single in game armor
    /// </summary>
    public class Armor
    {
        /// <summary>
        /// The armor's unique identifier
        /// </summary>
        [Key]
        public int ArmorId { get; set; }

        /// <summary>
        /// The armor's name
        /// </summary>
        public string ArmorName { get; set; }

        /// <summary>
        /// The armor's cost in game
        /// </summary>
        public short ArmorCost { get; set; }

        /// <summary>
        /// The maximum health the armor can have
        /// </summary>
        public short ArmorHealthMax { get; set; }
    }
}
