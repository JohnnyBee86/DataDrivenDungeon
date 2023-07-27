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
    public partial class JackpotStoreForm : Form
    {
        /// <summary>
        /// This is the form for Jasper's Jackpot, the lottery store where you can trade
        /// Goblin Emblems for a chance at cool items.
        /// </summary>
        public JackpotStoreForm()
        {
            InitializeComponent();
        }

        private void RickBtn_Click(object sender, EventArgs e)
        {
            // use emblems to gamble for items
            MessageBox.Show("You did a thing!");
        }

        private void HubBtn_Click(object sender, EventArgs e)
        {
            // leave the shop
            Close();
        }
    }
}
