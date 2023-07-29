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
        /// <summary>
        /// This is the form for Renaldo's Repository, where you can buy magic items.
        /// The magic items show up in varying amounts every time you return to town.
        /// </summary>
        public RepositoryStoreForm()
        {
            InitializeComponent();
        }

        private void PotionBtn_Click(object sender, EventArgs e)
        {
            // buy potions (random amount)
            MessageBox.Show("You bought a potion.");
        }

        private void FireBallBtn_Click(object sender, EventArgs e)
        {
            // buy fireballs (random amount)
            MessageBox.Show("You bought a fireball.");
        }

        private void HubBtn_Click(object sender, EventArgs e)
        {
            // leave the shop
            Close();
        }

        private void SellBtn_Click(object sender, EventArgs e)
        {
            // sell monster drops from inventory (and bank?)
            MessageBox.Show("You sold {itemsSold} for {goldEarned}.");
        }
    }
}
