using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using GameLibrary;
namespace GameLibraryManager
{
    public partial class Form1 : Form
    {
        private BindingList<VideoGame> games = new BindingList<VideoGame>();
        private GameEvents gameEvents = new GameEvents();
        public Form1()
        {
            InitializeComponent();
            listBoxGames.DataSource = games;
            gameEvents.GameAdded += GameEvents_GameAdded;
            gameEvents.GameUpdated += GameEvents_GameUpdated;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxGenre.Items.Add("Acción");
            comboBoxGenre.Items.Add("Aventura");
            comboBoxGenre.Items.Add("RPG");
            comboBoxGenre.Items.Add("Disparos");
        }
        private void buttonAddGame_Click(object sender, EventArgs e)
        {
            if (comboBoxGenre.SelectedIndex == -1)
            {
                MessageBox.Show("Porfavor selecciona un genero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            VideoGame newGame = new VideoGame(
                textBoxName.Text,
                textBoxPlatform.Text,
                dateTimePickerReleaseDate.Value,
                comboBoxGenre.SelectedItem?.ToString() ?? "Unknown"
            );
            games.Add(newGame);
            gameEvents.OnGameAdded(newGame);

            listBoxGames.DataSource = null;
            listBoxGames.DataSource = games;
        }

        private void buttonDeleteGame_Click(object sender, EventArgs e)
        {
            if (listBoxGames.SelectedItem is VideoGame selectedGame)
            {
                games.Remove(selectedGame);
            }
        }

        private void buttonEditGame_Click(object sender, EventArgs e)
        {
            if (listBoxGames.SelectedItem != null)
            {
                VideoGame selectedGame = (VideoGame)listBoxGames.SelectedItem;

                FormEdit formEdit = new FormEdit(selectedGame);
                if (formEdit.ShowDialog() == DialogResult.OK)
                {
                    listBoxGames.DataSource = null;
                    listBoxGames.DataSource = games;
                }
            }
            else
            {
                MessageBox.Show("Selecciona un juego para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GameEvents_GameAdded(object? sender, GameEventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            MessageBox.Show($"Game added: {e.Game.Name}", "Game Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GameEvents_GameUpdated(object? sender, GameEventArgs e)
        {
            if (sender == null)
            {
                return;
            }

            MessageBox.Show($"Game updated: {e.Game.Name}", "Game Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
