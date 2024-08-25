namespace GameLibraryManager
{
    partial class FormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxName = new TextBox();
            textBoxPlatform = new TextBox();
            dateTimePickerReleaseDate = new DateTimePicker();
            comboBoxGenre = new ComboBox();
            buttonSave = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(504, 94);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxPlatform
            // 
            textBoxPlatform.Location = new Point(763, 94);
            textBoxPlatform.Name = "textBoxPlatform";
            textBoxPlatform.Size = new Size(125, 27);
            textBoxPlatform.TabIndex = 1;
            // 
            // dateTimePickerReleaseDate
            // 
            dateTimePickerReleaseDate.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            dateTimePickerReleaseDate.Location = new Point(550, 191);
            dateTimePickerReleaseDate.Name = "dateTimePickerReleaseDate";
            dateTimePickerReleaseDate.Size = new Size(338, 31);
            dateTimePickerReleaseDate.TabIndex = 2;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(620, 285);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(202, 28);
            comboBoxGenre.TabIndex = 3;
            comboBoxGenre.Text = "Action, Aventura, RPG";
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonSave.Location = new Point(669, 362);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(112, 44);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Guardar";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(609, 24);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 5;
            label1.Text = "Editar Información";
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 737);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Controls.Add(comboBoxGenre);
            Controls.Add(dateTimePickerReleaseDate);
            Controls.Add(textBoxPlatform);
            Controls.Add(textBoxName);
            Name = "FormEdit";
            Text = "FormEdit";
            Load += FormEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxPlatform;
        private DateTimePicker dateTimePickerReleaseDate;
        private ComboBox comboBoxGenre;
        private Button buttonSave;
        private Label label1;
    }
}