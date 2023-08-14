using DataDrivenDungeon.Models;

namespace DataDrivenDungeon
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// This is the start-up form for the game. Might possibly add the ability to enter a JSON
        /// string so that you can load a save file of a previous game.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        // connect to the hub form
        /// <summary>
        /// The button that links to the hub world.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            // send the player to the hub world
            HubForm hubForm = new HubForm();
            GameData gameData = new(PlayerNameTxt.Text);
            hubForm.ShowDialog();
        }

    }
}