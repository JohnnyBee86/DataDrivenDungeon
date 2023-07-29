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
    public partial class SmithingStoreForm : Form
    {
        /// <summary>
        /// This is the form for Stanley's Smithing, a shop where you can buy weapons and armor,
        /// which you can gain access to better armor/weapons when you complete dungeon levels.
        /// </summary>
        public SmithingStoreForm()
        {
            InitializeComponent();
        }

        private void BuySwordBtn_Click(object sender, EventArgs e)
        {
            // buy weapon (progression based)
            MessageBox.Show("You got a new weapon!");
        }

        private void BuyArmorBtn_Click(object sender, EventArgs e)
        {
            // buy armor (progression based)
            MessageBox.Show("You got new armor!");
        }

        private void HubBtn_Click(object sender, EventArgs e)
        {
            // leave the shop
            Close();
        }
    }
}
