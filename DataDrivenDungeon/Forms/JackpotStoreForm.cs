using DataDrivenDungeon.Data;
using DataDrivenDungeon.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class JackpotStoreForm : Form
    {
        private GameData _player = new GameData();
        private readonly GameContext _context = new();

        /// <summary>
        /// This is the form for Jasper's Jackpot, the lottery store where you can trade
        /// Goblin Emblems for a chance at cool items.
        /// </summary>
        public JackpotStoreForm(GameData player)
        {
            _player = player;
            InitializeComponent();
        }

        /// <summary>
        /// Takes a goblin emblem and lets you gamble for good items.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RiskBtn_Click(object sender, EventArgs e)
        {
            // use emblems to gamble for items
            MessageBox.Show("You did a thing!");
        }

        /// <summary>
        /// Closes the form and takes you back to the Hub Form
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
