using DataDrivenDungeon.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDrivenDungeon.Models
{
    /// <summary>
    /// Represents a single Game
    /// </summary>
    public class GameData
    {
        public GameData(String playerName) 
        {
            /**
             * Not sure if this is right. I'm trying to 
             * Use the GameContext get methods to populate
             * the GameData with the default equipment, but
             * I need to finish watching lectures about how
             * this actually works. PLEASE REVIEW
             */

            // getting the GameContext
            GameContext gameContext = new();

            // getting the lists of all the weapons, armor, etc...
            DbSet<Weapon> weaponList = gameContext.Weapons;
            DbSet<Armor> armorList = gameContext.Armors;
            DbSet<Dungeon> dungeonList = gameContext.Dungeons;

            // setting the PlayerName to the name that was passed in
            PlayerName = playerName;

            // setting the armor, weapon and dungeon to the defaults
            CurrentWeapon = weaponList.Find(1);
            CurrentArmor = armorList.Find(1);
            HighestDungeonAllowed = dungeonList.Find(1);

            // setting the player's starting health
            PlayerHealth = 25;
        }
        /// <summary>
        /// The game's unique identifier
        /// </summary>
        [Key]
        public int GameId { get; set; }

        /// <summary>
        /// The name of the game's player
        /// </summary>
        [StringLength(15, MinimumLength = 1)]
        public string PlayerName { get; set; } = null!;

        /// <summary>
        /// The player's current weapon
        /// </summary>
        public Weapon CurrentWeapon { get; set; } = null!;

        /// <summary>
        /// The player's current armor
        /// </summary>
        public Armor CurrentArmor { get; set; } = null!;

        /// <summary>
        /// The player's health before any armor bonus
        /// </summary>
        public short PlayerHealth { get; set; }

        /// <summary>
        /// The highest level dungeon the player may enter
        /// </summary>
        public Dungeon HighestDungeonAllowed { get; set; } = null!;
    }
}
