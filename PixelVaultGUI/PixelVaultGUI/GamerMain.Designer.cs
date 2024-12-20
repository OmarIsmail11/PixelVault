namespace PixelVaultGUI
{
    partial class GamerMain
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
            panel1 = new Panel();
            BrowseTournamentsButton = new Button();
            BrowseGamesButton = new Button();
            LogOutButton = new Button();
            label1 = new Label();
            TournamentsButton = new Button();
            GamerLibraryButton = new Button();
            WelcomeUserLabel = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            browseTournaments1 = new BrowseTournaments();
            tournaments1 = new Tournaments();
            gameLibrary1 = new GameLibrary();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel1.Controls.Add(BrowseTournamentsButton);
            panel1.Controls.Add(BrowseGamesButton);
            panel1.Controls.Add(LogOutButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TournamentsButton);
            panel1.Controls.Add(GamerLibraryButton);
            panel1.Controls.Add(WelcomeUserLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 1);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(346, 816);
            panel1.TabIndex = 0;
            // 
            // BrowseTournamentsButton
            // 
            BrowseTournamentsButton.BackColor = Color.FromArgb(186, 186, 212);
            BrowseTournamentsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BrowseTournamentsButton.Location = new Point(32, 562);
            BrowseTournamentsButton.Margin = new Padding(4, 4, 4, 4);
            BrowseTournamentsButton.Name = "BrowseTournamentsButton";
            BrowseTournamentsButton.Size = new Size(276, 55);
            BrowseTournamentsButton.TabIndex = 22;
            BrowseTournamentsButton.Text = "Browse Tournaments";
            BrowseTournamentsButton.UseVisualStyleBackColor = false;
            BrowseTournamentsButton.Click += BrowseTournamentsButton_Click;
            // 
            // BrowseGamesButton
            // 
            BrowseGamesButton.BackColor = Color.FromArgb(186, 186, 212);
            BrowseGamesButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BrowseGamesButton.Location = new Point(32, 480);
            BrowseGamesButton.Margin = new Padding(4, 4, 4, 4);
            BrowseGamesButton.Name = "BrowseGamesButton";
            BrowseGamesButton.Size = new Size(276, 55);
            BrowseGamesButton.TabIndex = 21;
            BrowseGamesButton.Text = "Browse Games";
            BrowseGamesButton.UseVisualStyleBackColor = false;
            // 
            // LogOutButton
            // 
            LogOutButton.Image = Properties.Resources.logoutbutton;
            LogOutButton.Location = new Point(45, 744);
            LogOutButton.Margin = new Padding(4, 4, 4, 4);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(69, 56);
            LogOutButton.TabIndex = 20;
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = Properties.Resources.dark_purple_colour;
            label1.Location = new Point(136, 748);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 38);
            label1.TabIndex = 19;
            label1.Text = "Sign Out";
            label1.Click += label1_Click;
            // 
            // TournamentsButton
            // 
            TournamentsButton.BackColor = Color.FromArgb(186, 186, 212);
            TournamentsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TournamentsButton.Location = new Point(32, 396);
            TournamentsButton.Margin = new Padding(4, 4, 4, 4);
            TournamentsButton.Name = "TournamentsButton";
            TournamentsButton.Size = new Size(276, 55);
            TournamentsButton.TabIndex = 18;
            TournamentsButton.Text = "My Tournaments";
            TournamentsButton.UseVisualStyleBackColor = false;
            TournamentsButton.Click += TournamentsButton_Click;
            // 
            // GamerLibraryButton
            // 
            GamerLibraryButton.BackColor = Color.Thistle;
            GamerLibraryButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GamerLibraryButton.Location = new Point(32, 309);
            GamerLibraryButton.Margin = new Padding(4, 4, 4, 4);
            GamerLibraryButton.Name = "GamerLibraryButton";
            GamerLibraryButton.Size = new Size(276, 55);
            GamerLibraryButton.TabIndex = 17;
            GamerLibraryButton.Text = "My Games";
            GamerLibraryButton.UseVisualStyleBackColor = false;
            GamerLibraryButton.Click += GamerLibraryButton_Click;
            // 
            // WelcomeUserLabel
            // 
            WelcomeUserLabel.AutoSize = true;
            WelcomeUserLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeUserLabel.ForeColor = SystemColors.ButtonHighlight;
            WelcomeUserLabel.Image = Properties.Resources.solid_color_image;
            WelcomeUserLabel.Location = new Point(32, 249);
            WelcomeUserLabel.Margin = new Padding(4, 0, 4, 0);
            WelcomeUserLabel.Name = "WelcomeUserLabel";
            WelcomeUserLabel.Size = new Size(176, 32);
            WelcomeUserLabel.TabIndex = 1;
            WelcomeUserLabel.Text = "Welcome, User";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.User1;
            pictureBox1.Location = new Point(82, 40);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 191);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(browseTournaments1);
            panel2.Controls.Add(tournaments1);
            panel2.Controls.Add(gameLibrary1);
            panel2.Location = new Point(340, 0);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1264, 816);
            panel2.TabIndex = 1;
            // 
            // browseTournaments1
            // 
            browseTournaments1.BackColor = Color.FromArgb(192, 188, 212);
            browseTournaments1.Location = new Point(0, 0);
            browseTournaments1.Margin = new Padding(5, 5, 5, 5);
            browseTournaments1.Name = "browseTournaments1";
            browseTournaments1.Size = new Size(1580, 1020);
            browseTournaments1.TabIndex = 2;
            // 
            // tournaments1
            // 
            tournaments1.BackColor = Color.FromArgb(192, 188, 212);
            tournaments1.Location = new Point(0, 0);
            tournaments1.Margin = new Padding(5, 5, 5, 5);
            tournaments1.Name = "tournaments1";
            tournaments1.Size = new Size(1580, 1020);
            tournaments1.TabIndex = 1;
            // 
            // gameLibrary1
            // 
            gameLibrary1.BackColor = Color.FromArgb(192, 188, 212);
            gameLibrary1.Location = new Point(0, 0);
            gameLibrary1.Margin = new Padding(5, 5, 5, 5);
            gameLibrary1.Name = "gameLibrary1";
            gameLibrary1.Size = new Size(1580, 1020);
            gameLibrary1.TabIndex = 0;
            gameLibrary1.Load += gameLibrary1_Load;
            // 
            // GamerMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1602, 816);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "GamerMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Library";
            Load += GamerMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label WelcomeUserLabel;
        private PictureBox pictureBox1;
        private Button GamerLibraryButton;
        private Button TournamentsButton;
        private GameLibrary gameLibrary1;
        private Label label1;
        private Button LogOutButton;
        private Tournaments tournaments1;
        private Button BrowseTournamentsButton;
        private Button BrowseGamesButton;
        private BrowseTournaments browseTournaments1;
    }
}