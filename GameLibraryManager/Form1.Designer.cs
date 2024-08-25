namespace GameLibraryManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            textBoxPlatform = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dateTimePickerReleaseDate = new DateTimePicker();
            comboBoxGenre = new ComboBox();
            buttonAddGame = new Button();
            buttonDeleteGame = new Button();
            buttonEditGame = new Button();
            listBoxGames = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxName.Location = new Point(561, 108);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(249, 34);
            textBoxName.TabIndex = 0;
            // 
            // textBoxPlatform
            // 
            textBoxPlatform.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPlatform.Location = new Point(561, 283);
            textBoxPlatform.Name = "textBoxPlatform";
            textBoxPlatform.Size = new Size(249, 34);
            textBoxPlatform.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(638, 44);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(626, 208);
            label2.Name = "label2";
            label2.Size = new Size(117, 28);
            label2.TabIndex = 3;
            label2.Text = "Plataforma";
            // 
            // dateTimePickerReleaseDate
            // 
            dateTimePickerReleaseDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dateTimePickerReleaseDate.Location = new Point(521, 363);
            dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            dateTimePickerReleaseDate.Size = new Size(337, 31);
            dateTimePickerReleaseDate.TabIndex = 4;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(595, 435);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(179, 28);
            comboBoxGenre.TabIndex = 5;
            comboBoxGenre.Text = "Generos";
            // 
            // buttonAddGame
            // 
            buttonAddGame.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddGame.Location = new Point(491, 513);
            buttonAddGame.Name = "buttonAddGame";
            buttonAddGame.Size = new Size(146, 45);
            buttonAddGame.TabIndex = 6;
            buttonAddGame.Text = "Agregar Juego";
            buttonAddGame.UseVisualStyleBackColor = true;
            buttonAddGame.Click += buttonAddGame_Click;
            // 
            // buttonDeleteGame
            // 
            buttonDeleteGame.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDeleteGame.Location = new Point(753, 513);
            buttonDeleteGame.Name = "buttonDeleteGame";
            buttonDeleteGame.Size = new Size(146, 45);
            buttonDeleteGame.TabIndex = 7;
            buttonDeleteGame.Text = "Eliminar Juego";
            buttonDeleteGame.UseVisualStyleBackColor = true;
            buttonDeleteGame.Click += buttonDeleteGame_Click;
            // 
            // buttonEditGame
            // 
            buttonEditGame.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEditGame.Location = new Point(626, 584);
            buttonEditGame.Name = "buttonEditGame";
            buttonEditGame.Size = new Size(146, 45);
            buttonEditGame.TabIndex = 8;
            buttonEditGame.Text = "Editar Juego";
            buttonEditGame.UseVisualStyleBackColor = true;
            buttonEditGame.Click += buttonEditGame_Click;
            // 
            // listBoxGames
            // 
            listBoxGames.FormattingEnabled = true;
            listBoxGames.Location = new Point(1009, 283);
            listBoxGames.Name = "listBoxGames";
            listBoxGames.Size = new Size(310, 224);
            listBoxGames.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1088, 225);
            label3.Name = "label3";
            label3.Size = new Size(156, 28);
            label3.TabIndex = 10;
            label3.Text = "Lista de Juegos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 729);
            Controls.Add(label3);
            Controls.Add(listBoxGames);
            Controls.Add(buttonEditGame);
            Controls.Add(buttonDeleteGame);
            Controls.Add(buttonAddGame);
            Controls.Add(comboBoxGenre);
            Controls.Add(dateTimePickerReleaseDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPlatform);
            Controls.Add(textBoxName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxPlatform;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePickerReleaseDate;
        private ComboBox comboBoxGenre;
        private Button buttonAddGame;
        private Button buttonDeleteGame;
        private Button buttonEditGame;
        private ListBox listBoxGames;
        private Label label3;
    }
}
