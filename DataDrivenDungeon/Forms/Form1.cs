using DataDrivenDungeon.Data;
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
        private void NewGameBtn_Click(object sender, EventArgs e)
        {
            if (PlayerNameTxt.Text != null && PlayerNameTxt.Text != "")
            {
                // make a new GameContext and GameData
                GameData newPlayer = new();
                newPlayer.PlayerName = PlayerNameTxt.Text;
                newPlayer.PlayerHealth = 25;
                newPlayer.CurrentWeapon = new() { WeaponName = "Dagger" };
                newPlayer.CurrentArmor = new() { ArmorName = "T-Shirt" };
                newPlayer.HighestDungeonAllowed = new() { DungeonName = "Helhigm" };

                GameContext newGame = new();
                newGame.Game.Add(newPlayer);
                newGame.SaveChanges();

                // send the player to the hub world
                HubForm hubForm = new HubForm(newPlayer);
                hubForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must enter a player name.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<GameData> savedGames = new();
            GameContext getSaved = new();
            savedGames = (from games in getSaved.Game select games).ToList();
            foreach (GameData game in savedGames)
            {
                SavedGameslst.Items.Add(game);
            }
        }

        private void LoadGameBtn_Click(object sender, EventArgs e)
        {
            if (SavedGameslst.SelectedItem != null)
            {
                GameData gameToLoad = (GameData)SavedGameslst.SelectedItem;
                HubForm hubForm = new HubForm(gameToLoad);
                hubForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must pick a game to load.");
            }
        }
    }
}