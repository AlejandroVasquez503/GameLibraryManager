using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLibrary;

namespace GameLibraryManager
{
    public partial class FormEdit : Form
    {
        private VideoGame game;
        public FormEdit(VideoGame game)
        {
            InitializeComponent();
            this.game = game;

            textBoxName.Text = game.Name;
            textBoxPlatform.Text = game.Platform;
            dateTimePickerReleaseDate.Value = game.ReleaseDate;
            comboBoxGenre.SelectedItem = game.Genre;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            comboBoxGenre.Items.Add("Acción");
            comboBoxGenre.Items.Add("Adventura");
            comboBoxGenre.Items.Add("RPG");
            comboBoxGenre.Items.Add("Disparos");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxGenre.SelectedIndex == -1)
            {
                MessageBox.Show("Porfavor Selecciona un genero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            game.Name = textBoxName.Text;
            game.Platform = textBoxPlatform.Text;
            game.ReleaseDate = dateTimePickerReleaseDate.Value;
            game.Genre = comboBoxGenre.SelectedItem?.ToString() ?? "Género Desconocido";

            DialogResult = DialogResult.OK;
            Close();
        }

    }
}
