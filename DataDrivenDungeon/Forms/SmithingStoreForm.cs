﻿using System;
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

        /// <summary>
        /// Lets you give money from your inventory to buy a new weapon.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuySwordBtn_Click(object sender, EventArgs e)
        {
            // buy weapon (progression based)
            MessageBox.Show("You got a new weapon!");
        }

        /// <summary>
        /// Lets you give money from your inventory to buy some new armor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuyArmorBtn_Click(object sender, EventArgs e)
        {
            // buy armor (progression based)
            MessageBox.Show("You got new armor!");
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
