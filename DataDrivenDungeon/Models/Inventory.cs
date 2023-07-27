using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenDungeon.Models
{
    internal class Inventory
    {
        [Key]
        public int InventoryId { get; set; }

        public GameData SaveData { get; set; }

        public short Coins { get; set; }

        public short BankedCoins { get; set; }

        public short Potions { get; set; }

        public short BankedPotions { get; set; }

        public short Fireballs { get; set; }

        public short BankedFireballs { get; set; }

        public short Emblems { get; set; }
    }
}
