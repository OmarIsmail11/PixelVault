namespace PixelVaultGUI
{
    partial class Publish_Game
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
            GameNameText = new TextBox();
            GenreCombo = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            RatingText = new TextBox();
            ReviewerText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            ConsoleNameText = new TextBox();
            EngineNameText = new TextBox();
            SuspendLayout();
            // 
            // GameNameText
            // 
            GameNameText.Location = new Point(285, 57);
            GameNameText.Name = "GameNameText";
            GameNameText.Size = new Size(357, 39);
            GameNameText.TabIndex = 0;
            // 
            // GenreCombo
            // 
            GenreCombo.FormattingEnabled = true;
            GenreCombo.Items.AddRange(new object[] { "Sports", "Racing", "Fighting", "Battle Royale", "FPS" });
            GenreCombo.Location = new Point(285, 158);
            GenreCombo.Name = "GenreCombo";
            GenreCombo.Size = new Size(161, 40);
            GenreCombo.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(285, 270);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(290, 39);
            dateTimePicker1.TabIndex = 2;
            // 
            // RatingText
            // 
            RatingText.Location = new Point(285, 577);
            RatingText.Name = "RatingText";
            RatingText.Size = new Size(128, 39);
            RatingText.TabIndex = 5;
            // 
            // ReviewerText
            // 
            ReviewerText.Location = new Point(285, 669);
            ReviewerText.Name = "ReviewerText";
            ReviewerText.Size = new Size(274, 39);
            ReviewerText.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = Properties.Resources.dark_purple_colour;
            label1.Location = new Point(43, 57);
            label1.Name = "label1";
            label1.Size = new Size(230, 50);
            label1.TabIndex = 7;
            label1.Text = "Game Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Image = Properties.Resources.dark_purple_colour;
            label2.Location = new Point(43, 158);
            label2.Name = "label2";
            label2.Size = new Size(107, 45);
            label2.TabIndex = 8;
            label2.Text = "Genre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Image = Properties.Resources.dark_purple_colour;
            label3.Location = new Point(43, 270);
            label3.Name = "label3";
            label3.Size = new Size(207, 45);
            label3.TabIndex = 9;
            label3.Text = "Release Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Image = Properties.Resources.dark_purple_colour1;
            label4.Location = new Point(43, 365);
            label4.Name = "label4";
            label4.Size = new Size(232, 45);
            label4.TabIndex = 10;
            label4.Text = "Console Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Image = Properties.Resources.dark_purple_colour;
            label5.Location = new Point(43, 463);
            label5.Name = "label5";
            label5.Size = new Size(215, 45);
            label5.TabIndex = 11;
            label5.Text = "Engine Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Image = Properties.Resources.dark_purple_colour;
            label6.Location = new Point(43, 577);
            label6.Name = "label6";
            label6.Size = new Size(115, 45);
            label6.TabIndex = 12;
            label6.Text = "Rating";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Image = Properties.Resources.dark_purple_colour;
            label7.Location = new Point(43, 669);
            label7.Name = "label7";
            label7.Size = new Size(150, 45);
            label7.TabIndex = 13;
            label7.Text = "Reviewer";
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(810, 610);
            button1.Name = "button1";
            button1.Size = new Size(317, 98);
            button1.TabIndex = 14;
            button1.Text = "Publish Game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ConsoleNameText
            // 
            ConsoleNameText.Location = new Point(285, 372);
            ConsoleNameText.Name = "ConsoleNameText";
            ConsoleNameText.Size = new Size(274, 39);
            ConsoleNameText.TabIndex = 15;
            // 
            // EngineNameText
            // 
            EngineNameText.Location = new Point(285, 463);
            EngineNameText.Name = "EngineNameText";
            EngineNameText.Size = new Size(274, 39);
            EngineNameText.TabIndex = 16;
            // 
            // Publish_Game
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dark_purple_colour;
            ClientSize = new Size(1234, 801);
            Controls.Add(EngineNameText);
            Controls.Add(ConsoleNameText);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ReviewerText);
            Controls.Add(RatingText);
            Controls.Add(dateTimePicker1);
            Controls.Add(GenreCombo);
            Controls.Add(GameNameText);
            Name = "Publish_Game";
            Text = "Publish_Game";
            Load += Publish_Game_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox GameNameText;
        private ComboBox GenreCombo;
        private DateTimePicker dateTimePicker1;
        private TextBox RatingText;
        private TextBox ReviewerText;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private TextBox ConsoleNameText;
        private TextBox EngineNameText;
    }
}