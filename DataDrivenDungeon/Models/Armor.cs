using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenDungeon.Models
{
    internal class Armor
    {
        [Key]
        public int ArmorId { get; set; }

        public string ArmorName { get; set; }

        public short ArmorCost { get; set; }

        public short ArmorHealthMaximum { get; set; }
    }
}
