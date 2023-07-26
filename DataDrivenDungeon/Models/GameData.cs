using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenDungeon.Models
{
    internal class GameData
    {
        [Key]
        public int GameId { get; set; }

        [StringLength(15, MinimumLength =1)]
        public string PlayerName { get; set; }

        public Weapon CurrentWeapon { get; set; }

        public Armor CurrentArmor { get; set; }

        public short BonusHealth { get; set; }

        public Dungeon HighestDungeonAllowed { get; set; }
    }
}
