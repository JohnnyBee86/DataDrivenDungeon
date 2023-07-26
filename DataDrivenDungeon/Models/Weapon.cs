using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenDungeon.Models
{
    internal class Weapon
    {
        [Key]
        public int WeaponId { get; set; }

        public string WeaponName { get; set; }

        public short WeaponCost { get; set; }

        public short DamageMinimum { get; set; }

        public short DamageMaximum { get; set;}
    }
}
