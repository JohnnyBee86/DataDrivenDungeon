using DataDrivenDungeon.Data;
using DataDrivenDungeon.Models;

namespace DataDrivenDungeon
{
    public partial class Form1 : Form
    {
        private readonly GameContext _context = new();

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
                newPlayer.PlayerHealth = 0;
                newPlayer.CurrentWeapon = _context.Weapons.First();
                newPlayer.CurrentArmor = _context.Armors.First();
                newPlayer.HighestDungeonAllowed = _context.Dungeons.First();

                _context.Game.Add(newPlayer);
                _context.SaveChanges();

                // send the player to the hub world
                HubForm hubForm = new HubForm(newPlayer);
                hubForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("You must enter a player name.");
            }
        }

        /// <summary>
        /// The form's on-load event
        /// Gets all saved games from the database
        /// Then populates the "Saved Games" list-box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            List<GameData> savedGames = new();
            savedGames = _context.Game.ToList();
            // "games" coming out of database with null FKs
            foreach (GameData game in savedGames)
            {
                SavedGameslst.Items.Add(game);
            }
        }

        /// <summary>
        /// Gets the selected Saved Game to load and passes it to the Hub form
        /// If no Saved game is selected it shows appropriate instructions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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