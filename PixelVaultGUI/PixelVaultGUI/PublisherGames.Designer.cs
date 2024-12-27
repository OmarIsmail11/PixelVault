namespace PixelVaultGUI
{
    partial class PublisherGames
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ExitButton = new Label();
            panel2 = new Panel();
            UpdateAwardButton = new Button();
            DeleteGameButton = new Button();
            AwardedGamesButton = new Button();
            RefreshListButton = new Button();
            groupBox3 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            groupBox4 = new GroupBox();
            MostTrendingGenre = new Label();
            label7 = new Label();
            label8 = new Label();
            MostTrendingGame = new Label();
            MostTrendingPlatform = new Label();
            label11 = new Label();
            label12 = new Label();
            MostTrendingEngine = new Label();
            PublishGameButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(34, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(1575, 515);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = Properties.Resources.dark_purple_colour1;
            label1.Location = new Point(39, 21);
            label1.Name = "label1";
            label1.Size = new Size(312, 50);
            label1.TabIndex = 1;
            label1.Text = "Published Games";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1498, 378);
            dataGridView1.TabIndex = 0;
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ButtonHighlight;
            ExitButton.Image = Properties.Resources.dark_purple_colour;
            ExitButton.Location = new Point(1586, 0);
            ExitButton.Margin = new Padding(5, 0, 5, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(54, 60);
            ExitButton.TabIndex = 18;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel2.Controls.Add(UpdateAwardButton);
            panel2.Controls.Add(DeleteGameButton);
            panel2.Controls.Add(AwardedGamesButton);
            panel2.Controls.Add(RefreshListButton);
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(PublishGameButton);
            panel2.Location = new Point(34, 615);
            panel2.Name = "panel2";
            panel2.Size = new Size(1575, 379);
            panel2.TabIndex = 22;
            // 
            // UpdateAwardButton
            // 
            UpdateAwardButton.BackColor = Color.FromArgb(186, 186, 212);
            UpdateAwardButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            UpdateAwardButton.Location = new Point(326, 147);
            UpdateAwardButton.Name = "UpdateAwardButton";
            UpdateAwardButton.Size = new Size(271, 104);
            UpdateAwardButton.TabIndex = 11;
            UpdateAwardButton.Text = "Update Award";
            UpdateAwardButton.UseVisualStyleBackColor = false;
            UpdateAwardButton.Click += UpdateAwardButton_Click;
            // 
            // DeleteGameButton
            // 
            DeleteGameButton.BackColor = Color.FromArgb(186, 186, 212);
            DeleteGameButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            DeleteGameButton.Location = new Point(326, 27);
            DeleteGameButton.Name = "DeleteGameButton";
            DeleteGameButton.Size = new Size(271, 104);
            DeleteGameButton.TabIndex = 10;
            DeleteGameButton.Text = "Delete Game";
            DeleteGameButton.UseVisualStyleBackColor = false;
            DeleteGameButton.Click += DeleteGameButton_Click;
            // 
            // AwardedGamesButton
            // 
            AwardedGamesButton.BackColor = Color.FromArgb(186, 186, 212);
            AwardedGamesButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            AwardedGamesButton.Location = new Point(22, 262);
            AwardedGamesButton.Name = "AwardedGamesButton";
            AwardedGamesButton.Size = new Size(575, 104);
            AwardedGamesButton.TabIndex = 9;
            AwardedGamesButton.Text = "View All Awarded Games";
            AwardedGamesButton.UseVisualStyleBackColor = false;
            AwardedGamesButton.Click += AwardedGamesButton_Click;
            // 
            // RefreshListButton
            // 
            RefreshListButton.BackColor = Color.FromArgb(186, 186, 212);
            RefreshListButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            RefreshListButton.Location = new Point(22, 147);
            RefreshListButton.Name = "RefreshListButton";
            RefreshListButton.Size = new Size(271, 104);
            RefreshListButton.TabIndex = 8;
            RefreshListButton.Text = "Refresh List";
            RefreshListButton.UseVisualStyleBackColor = false;
            RefreshListButton.Click += RefreshListButton_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = Properties.Resources.dark_purple_colour;
            groupBox3.Controls.Add(radioButton4);
            groupBox3.Controls.Add(radioButton5);
            groupBox3.Controls.Add(radioButton6);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.ButtonFace;
            groupBox3.Location = new Point(624, 27);
            groupBox3.Margin = new Padding(5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5);
            groupBox3.Size = new Size(375, 303);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order by";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackgroundImage = Properties.Resources.dark_purple_colour;
            radioButton4.Location = new Point(27, 235);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(331, 49);
            radioButton4.TabIndex = 10;
            radioButton4.TabStop = true;
            radioButton4.Text = "Number of Players";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AccessibleRole = AccessibleRole.TitleBar;
            radioButton5.AutoSize = true;
            radioButton5.BackgroundImage = Properties.Resources.dark_purple_colour1;
            radioButton5.Location = new Point(27, 70);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(225, 49);
            radioButton5.TabIndex = 8;
            radioButton5.TabStop = true;
            radioButton5.Text = "User Rating";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.BackgroundImage = Properties.Resources.dark_purple_colour;
            radioButton6.Location = new Point(27, 141);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(149, 49);
            radioButton6.TabIndex = 9;
            radioButton6.TabStop = true;
            radioButton6.Text = "Rating";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // groupBox4
            // 
            groupBox4.BackgroundImage = Properties.Resources.dark_purple_colour;
            groupBox4.Controls.Add(MostTrendingGenre);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(MostTrendingGame);
            groupBox4.Controls.Add(MostTrendingPlatform);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(MostTrendingEngine);
            groupBox4.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.ButtonHighlight;
            groupBox4.Location = new Point(1021, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(487, 354);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Your Most Populer";
            // 
            // MostTrendingGenre
            // 
            MostTrendingGenre.AutoSize = true;
            MostTrendingGenre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            MostTrendingGenre.ForeColor = SystemColors.ButtonHighlight;
            MostTrendingGenre.Image = Properties.Resources.dark_purple_colour;
            MostTrendingGenre.Location = new Point(212, 130);
            MostTrendingGenre.Name = "MostTrendingGenre";
            MostTrendingGenre.Size = new Size(85, 45);
            MostTrendingGenre.TabIndex = 7;
            MostTrendingGenre.Text = "-----";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Window;
            label7.Image = Properties.Resources.solid_color_image;
            label7.Location = new Point(29, 57);
            label7.Name = "label7";
            label7.Size = new Size(124, 45);
            label7.TabIndex = 0;
            label7.Text = "Game :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Image = Properties.Resources.dark_purple_colour;
            label8.Location = new Point(29, 130);
            label8.Name = "label8";
            label8.Size = new Size(127, 45);
            label8.TabIndex = 6;
            label8.Text = "Genre :";
            // 
            // MostTrendingGame
            // 
            MostTrendingGame.AutoSize = true;
            MostTrendingGame.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            MostTrendingGame.ForeColor = SystemColors.Window;
            MostTrendingGame.Image = Properties.Resources.solid_color_image;
            MostTrendingGame.Location = new Point(212, 57);
            MostTrendingGame.Name = "MostTrendingGame";
            MostTrendingGame.Size = new Size(85, 45);
            MostTrendingGame.TabIndex = 0;
            MostTrendingGame.Text = "-----";
            // 
            // MostTrendingPlatform
            // 
            MostTrendingPlatform.AutoSize = true;
            MostTrendingPlatform.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            MostTrendingPlatform.ForeColor = SystemColors.ButtonHighlight;
            MostTrendingPlatform.Image = Properties.Resources.dark_purple_colour;
            MostTrendingPlatform.Location = new Point(212, 285);
            MostTrendingPlatform.Name = "MostTrendingPlatform";
            MostTrendingPlatform.Size = new Size(85, 45);
            MostTrendingPlatform.TabIndex = 5;
            MostTrendingPlatform.Text = "-----";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Image = Properties.Resources.dark_purple_colour;
            label11.Location = new Point(29, 206);
            label11.Name = "label11";
            label11.Size = new Size(139, 45);
            label11.TabIndex = 2;
            label11.Text = "Engine :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Image = Properties.Resources.dark_purple_colour;
            label12.Location = new Point(29, 285);
            label12.Name = "label12";
            label12.Size = new Size(170, 45);
            label12.TabIndex = 4;
            label12.Text = "Platform :";
            // 
            // MostTrendingEngine
            // 
            MostTrendingEngine.AutoSize = true;
            MostTrendingEngine.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            MostTrendingEngine.ForeColor = SystemColors.ButtonFace;
            MostTrendingEngine.Image = Properties.Resources.dark_purple_colour;
            MostTrendingEngine.Location = new Point(212, 206);
            MostTrendingEngine.Name = "MostTrendingEngine";
            MostTrendingEngine.Size = new Size(85, 45);
            MostTrendingEngine.TabIndex = 3;
            MostTrendingEngine.Text = "-----";
            // 
            // PublishGameButton
            // 
            PublishGameButton.BackColor = Color.FromArgb(186, 186, 212);
            PublishGameButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            PublishGameButton.Location = new Point(22, 27);
            PublishGameButton.Name = "PublishGameButton";
            PublishGameButton.Size = new Size(271, 104);
            PublishGameButton.TabIndex = 2;
            PublishGameButton.Text = "Publish Game";
            PublishGameButton.UseVisualStyleBackColor = false;
            PublishGameButton.Click += PublishGameButton_Click;
            // 
            // PublisherGames
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 188, 212);
            Controls.Add(panel2);
            Controls.Add(ExitButton);
            Controls.Add(panel1);
            Margin = new Padding(5);
            Name = "PublisherGames";
            Size = new Size(1643, 1045);
            Load += PublisherGames_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label ExitButton;
        private Panel panel2;
        private GroupBox groupBox3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private GroupBox groupBox4;
        private Label MostTrendingGenre;
        private Label label7;
        private Label label8;
        private Label MostTrendingGame;
        private Label MostTrendingPlatform;
        private Label label11;
        private Label label12;
        private Label MostTrendingEngine;
        private Button PublishGameButton;
        private Button RefreshListButton;
        private Button AwardedGamesButton;
        private Button DeleteGameButton;
        private Button UpdateAwardButton;
    }
}
