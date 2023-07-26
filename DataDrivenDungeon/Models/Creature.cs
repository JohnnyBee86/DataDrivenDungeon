using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenDungeon.Models
{
    internal class Creature
    {
        [Key]
        public int CreatureId { get; set; }

        public Dungeon FightInDungeon { get; set; }

        public string CreatureName { get; set; }

        public bool IsBoss { get; set; }

        public short HealthMinimum { get; set; }

        public short HealthMaximum { get; set; }

        public short DamageMinimum { get; set; }

        public short DamageMaximum { get; set; }

        public short CoinDropMinimum { get; set; }

        public short CoinDropMaximum { get; set; }

        public string BonusDrop { get; set; }

        public short BonusDropChance { get; set; }
    }
}
