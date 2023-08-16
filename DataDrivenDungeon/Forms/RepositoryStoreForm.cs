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

namespace DataDrivenDungeon
{
    public partial class RepositoryStoreForm : Form
    {
        private GameData PLAYER = new GameData();
        /// <summary>
        /// This is the form for Renaldo's Repository, where you can buy magic items.
        /// The magic items show up in varying amounts every time you return to town.
        /// </summary>
        public RepositoryStoreForm(GameData player)
        {
            PLAYER = player;
            InitializeComponent();
        }

        /// <summary>
        /// Lets you give money in your inventory to buy a potion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PotionBtn_Click(object sender, EventArgs e)
        {
            // buy potions (random amount)
            MessageBox.Show("You bought a potion.");
        }

        /// <summary>
        /// Lets you give money from your inventory to buy fireballs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FireBallBtn_Click(object sender, EventArgs e)
        {
            // buy fireballs (random amount)
            MessageBox.Show("You bought a fireball.");
        }

        /// <summary>
        /// Lets you sell items from your inventory to get some money.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SellBtn_Click(object sender, EventArgs e)
        {
            // sell monster drops from inventory (and bank?)
            MessageBox.Show("You sold {itemsSold} for {goldEarned}.");
        }

        /// <summary>
        /// Closes the form and takes you back to the Hub Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HubBtn_Click(object sender, EventArgs e)
        {
            // leave the shop
            Close();
        }
    }
}
