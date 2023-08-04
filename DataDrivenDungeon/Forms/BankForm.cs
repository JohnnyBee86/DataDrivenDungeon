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
        /// <summary>
        /// This is the form for the Bank, where the player can store and take out coins and magic items,
        /// so that if they fail in a dungeon, they won't lose the items in the bank.
        /// </summary>
        public BankForm()
        {
            InitializeComponent();
        }

        private void HubBtn_Click(object sender, EventArgs e)
        {
            // leave the bank
            Close();
        }

        private void DepositItemsBtn_Click(object sender, EventArgs e)
        {
            // store items in bank
            MessageBox.Show("Items put in storage.");
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            // remove items from bank
            MessageBox.Show("Items removed from storage.");
        }

        private void DepositMoneyBtn_Click(object sender, EventArgs e)
        {
            // store money in bank
            MessageBox.Show("Money stored in the vault.");
        }

        private void WithdrawMoneyBtn_Click(object sender, EventArgs e)
        {
            // remove money from bank
            MessageBox.Show("Money removed from the vault.");
        }
    }
}
