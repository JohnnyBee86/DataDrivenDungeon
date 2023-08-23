using DataDrivenDungeon.Data;
using DataDrivenDungeon.Models;
using DataDrivenDungeon.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataDrivenDungeon
{
    public partial class HubForm : Form
    {
        private GameData _player;

        /// <summary>
        /// The Hub World form that lets you go to the stores, the bank, and the dungeon.
        /// </summary>
        public HubForm(GameData player)
        {
            _player = player;
            InitializeComponent();
        }

        /// <summary>
        /// Takes you to the Bank Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BankBtn_Click(object sender, EventArgs e)
        {
            // connect to the bank
            BankForm bankForm = new BankForm(_player);
            bankForm.ShowDialog();
        }

        /// <summary>
        /// Takes you to the Jackpot Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JackpotBtn_Click(object sender, EventArgs e)
        {
            // connect to the jackpot shop form
            JackpotStoreForm jackpotStoreForm = new JackpotStoreForm(_player);
            jackpotStoreForm.ShowDialog();
        }

        /// <summary>
        /// Takes you to the Repository Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RepositoryBtn_Click(object sender, EventArgs e)
        {
            // connect to the repository shop form
            RepositoryStoreForm repositoryStoreForm = new RepositoryStoreForm(_player);
            repositoryStoreForm.ShowDialog();
        }

        /// <summary>
        /// Takes you to the Smithing Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmithingBtn_Click(object sender, EventArgs e)
        {
            // connect to the smithing shop form
            SmithingStoreForm smithingStoreForm = new SmithingStoreForm(_player);
            smithingStoreForm.ShowDialog();
        }

        /// <summary>
        /// Takes you to the Dungeon Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DungeonBtn_Click(object sender, EventArgs e)
        {
            // connect to the dungeon form
            DungeonForm dungeonForm = new DungeonForm(_player);
            dungeonForm.ShowDialog();
        }

        /// <summary>
        /// Closes the form and takes you back to the Home Form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QuitBtn_Click(object sender, EventArgs e)
        {
            // close the program
            Close();
        }





        // save the game as a JSON string?
    }
}
