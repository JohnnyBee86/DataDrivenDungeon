using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenDungeon.Models
{
    internal class Dungeon
    {
        [Key]
        public int DungeonId { get; set; }

        public string DungeonName { get; set; }

        public short FightsBeforeBoss { get; set; }

        public short EnemyMinimumPerFight { get; set; }

        public short ExtraEnemyChance { get; set; }
    }
}
