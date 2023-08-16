using DataDrivenDungeon.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataDrivenDungeon.Views
{
    /// <summary>
    /// This is the form for all the dungeon fights. Depending on the dungeon they're in,
    /// their inventory, and the enemies they're fighting, the data will change.
    /// </summary>
    public partial class DungeonForm : Form
    {
        private GameData PLAYER = new GameData();
        public DungeonForm(GameData player)
        {
            PLAYER = player;
            InitializeComponent();
        }

        /// <summary>
        /// Attacks the monster selected with the radio buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AttackBtn_Click(object sender, EventArgs e)
        {
            // attack monsters (pseudo-code)
            /*foreach (var monsterRdb in MonsterGrb)
            {
                if (monsterRdb.Checked)
                {
                    Attack(monsterRdb);
                    DoMonstersRemain();
                }
            }*/
            MessageBox.Show("You hit the monster.");
        }

        /// <summary>
        /// Throws a fireball at the monster selected with the radio buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FireballBtn_Click(object sender, EventArgs e)
        {
            // use a fireball (pseudo-code)
            /*foreach (var monsterRdb in MonsterGrb)
            {
                if (monsterRdb.Checked)
                {
                    Fireball(monsterRdb);
                    DoMonstersRemain();
                }
            }*/
            MessageBox.Show("You threw the fireball at the monster.");
        }

        /// <summary>
        /// Lets you drink a healing potion to regain health.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PotionBtn_Click(object sender, EventArgs e)
        {
            // use a potion
            // Potion();
            MessageBox.Show("You drank a healing potion.");
        }

        /// <summary>
        /// Closes the form and takes you back to the Hub Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RetreatBtn_Click(object sender, EventArgs e)
        {
            // run from fight, return to hub form
            MessageBox.Show("You ran from the fight. (Wuss)");
            Close();
        }

        private bool DoMonstersRemain() 
        {
            // after fight, pop up a MessageBox with the loot drops
            throw new NotImplementedException();
        }
    }
}
