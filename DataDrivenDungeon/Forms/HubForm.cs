using DataDrivenDungeon.Views;
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
    public partial class HubForm : Form
    {
        /// <summary>
        /// The Hub World form that lets you go to the stores, the bank, and the dungeon.
        /// </summary>
        public HubForm()
        {
            InitializeComponent();
        }

        private void BankBtn_Click(object sender, EventArgs e)
        {
            // connect to the bank
            BankForm bankForm = new BankForm();
            bankForm.ShowDialog();
        }

        private void JackpotBtn_Click(object sender, EventArgs e)
        {
            // connect to the jackpot shop form
            JackpotStoreForm jackpotStoreForm = new JackpotStoreForm();
            jackpotStoreForm.ShowDialog();
        }

        private void RepositoryBtn_Click(object sender, EventArgs e)
        {
            // connect to the repository shop form
            RepositoryStoreForm repositoryStoreForm = new RepositoryStoreForm();
            repositoryStoreForm.ShowDialog();
        }

        private void SmithingBtn_Click(object sender, EventArgs e)
        {
            // connect to the smithing shop form
            SmithingStoreForm smithingStoreForm = new SmithingStoreForm();
            smithingStoreForm.ShowDialog();
        }

        private void DungeonBtn_Click(object sender, EventArgs e)
        {
            // connect to the dungeon form
            DungeonForm dungeonForm = new DungeonForm();
            dungeonForm.ShowDialog();
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            // close the program
            Close();
        }





        // save the game as a JSON string?
    }
}
