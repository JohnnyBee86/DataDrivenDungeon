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
    public partial class BankForm : Form
    {
        private GameData _player;
        private readonly GameContext _context = new();

        /// <summary>
        /// This is the form for the Bank, where the player can store and take out coins and magic items,
        /// so that if they fail in a dungeon, they won't lose the items in the bank.
        /// </summary>
        public BankForm(GameData player)
        {
            _player = player;
            InitializeComponent();
        }

        /// <summary>
        /// Takes items from your inventory and stores them in the bank vault.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepositItemsBtn_Click(object sender, EventArgs e)
        {
            // store items in bank
            MessageBox.Show("Items put in storage.");
        }

        /// <summary>
        /// Takes items from the bank storage and puts them into your inventory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WithdrawItemsBtn_Click(object sender, EventArgs e)
        {
            // remove items from bank
            MessageBox.Show("Items removed from storage.");
        }

        /// <summary>
        /// Takes money from your inventory and puts it into the bank vault.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepositMoneyBtn_Click(object sender, EventArgs e)
        {
            // store money in bank
            MessageBox.Show("Money stored in the vault.");
        }

        /// <summary>
        /// Takes money from the bank vault and puts it into your inventory.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WithdrawMoneyBtn_Click(object sender, EventArgs e)
        {
            // remove money from bank
            MessageBox.Show("Money removed from the vault.");
        }

        /// <summary>
        /// Closes the form and takes you back to the Hub Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HubBtn_Click(object sender, EventArgs e)
        {
            // leave the bank
            Close();
        }
    }
}
