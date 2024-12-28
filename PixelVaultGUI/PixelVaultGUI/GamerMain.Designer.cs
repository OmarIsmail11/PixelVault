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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            EditProfile = new Button();
            WelcomeTextBox = new TextBox();
            BrowseTournamentsButton = new Button();
            BrowseGamesButton = new Button();
            LogOutButton = new Button();
            TournamentsButton = new Button();
            GamerLibraryButton = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            browseGames1 = new BrowseGames();
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
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(EditProfile);
            panel1.Controls.Add(WelcomeTextBox);
            panel1.Controls.Add(BrowseTournamentsButton);
            panel1.Controls.Add(BrowseGamesButton);
            panel1.Controls.Add(LogOutButton);
            panel1.Controls.Add(TournamentsButton);
            panel1.Controls.Add(GamerLibraryButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 653);
            panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(29, 29, 57);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(104, 598);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(124, 31);
            textBox2.TabIndex = 26;
            textBox2.Text = "Sign Out";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(29, 29, 57);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.Location = new Point(104, 535);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(143, 31);
            textBox1.TabIndex = 25;
            textBox1.Text = "Edit Profile";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // EditProfile
            // 
            EditProfile.Image = Properties.Resources.settings1;
            EditProfile.Location = new Point(43, 532);
            EditProfile.Name = "EditProfile";
            EditProfile.Size = new Size(55, 44);
            EditProfile.TabIndex = 24;
            EditProfile.UseVisualStyleBackColor = true;
            EditProfile.Click += EditProfile_Click;
            // 
            // WelcomeTextBox
            // 
            WelcomeTextBox.BackColor = Color.FromArgb(29, 29, 57);
            WelcomeTextBox.BorderStyle = BorderStyle.None;
            WelcomeTextBox.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeTextBox.ForeColor = SystemColors.Window;
            WelcomeTextBox.Location = new Point(26, 201);
            WelcomeTextBox.Name = "WelcomeTextBox";
            WelcomeTextBox.ReadOnly = true;
            WelcomeTextBox.Size = new Size(221, 31);
            WelcomeTextBox.TabIndex = 23;
            WelcomeTextBox.Text = "Welcome, User";
            WelcomeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // BrowseTournamentsButton
            // 
            BrowseTournamentsButton.BackColor = Color.FromArgb(186, 186, 212);
            BrowseTournamentsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BrowseTournamentsButton.Location = new Point(26, 465);
            BrowseTournamentsButton.Name = "BrowseTournamentsButton";
            BrowseTournamentsButton.Size = new Size(221, 44);
            BrowseTournamentsButton.TabIndex = 22;
            BrowseTournamentsButton.Text = "Browse Tournaments";
            BrowseTournamentsButton.UseVisualStyleBackColor = false;
            BrowseTournamentsButton.Click += BrowseTournamentsButton_Click;
            // 
            // BrowseGamesButton
            // 
            BrowseGamesButton.BackColor = Color.FromArgb(186, 186, 212);
            BrowseGamesButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BrowseGamesButton.Location = new Point(26, 398);
            BrowseGamesButton.Name = "BrowseGamesButton";
            BrowseGamesButton.Size = new Size(221, 44);
            BrowseGamesButton.TabIndex = 21;
            BrowseGamesButton.Text = "Browse Games";
            BrowseGamesButton.UseVisualStyleBackColor = false;
            BrowseGamesButton.Click += BrowseGamesButton_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.Image = Properties.Resources.logoutbutton;
            LogOutButton.Location = new Point(43, 595);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(55, 45);
            LogOutButton.TabIndex = 20;
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // TournamentsButton
            // 
            TournamentsButton.BackColor = Color.FromArgb(186, 186, 212);
            TournamentsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TournamentsButton.Location = new Point(26, 327);
            TournamentsButton.Name = "TournamentsButton";
            TournamentsButton.Size = new Size(221, 44);
            TournamentsButton.TabIndex = 18;
            TournamentsButton.Text = "My Tournaments";
            TournamentsButton.UseVisualStyleBackColor = false;
            TournamentsButton.Click += TournamentsButton_Click;
            // 
            // GamerLibraryButton
            // 
            GamerLibraryButton.BackColor = Color.Thistle;
            GamerLibraryButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GamerLibraryButton.Location = new Point(26, 254);
            GamerLibraryButton.Name = "GamerLibraryButton";
            GamerLibraryButton.Size = new Size(221, 44);
            GamerLibraryButton.TabIndex = 17;
            GamerLibraryButton.Text = "My Games";
            GamerLibraryButton.UseVisualStyleBackColor = false;
            GamerLibraryButton.Click += GamerLibraryButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.User1;
            pictureBox1.Location = new Point(66, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 153);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(browseGames1);
            panel2.Controls.Add(browseTournaments1);
            panel2.Controls.Add(tournaments1);
            panel2.Controls.Add(gameLibrary1);
            panel2.Location = new Point(272, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1011, 653);
            panel2.TabIndex = 1;
            // 
            // browseGames1
            // 
            browseGames1.BackColor = Color.FromArgb(192, 188, 212);
            browseGames1.Location = new Point(0, 0);
            browseGames1.Name = "browseGames1";
            browseGames1.Size = new Size(1264, 816);
            browseGames1.TabIndex = 3;
            browseGames1.Load += browseGames1_Load;
            // 
            // browseTournaments1
            // 
            browseTournaments1.BackColor = Color.FromArgb(192, 188, 212);
            browseTournaments1.Location = new Point(0, 0);
            browseTournaments1.Margin = new Padding(4);
            browseTournaments1.Name = "browseTournaments1";
            browseTournaments1.Size = new Size(1264, 816);
            browseTournaments1.TabIndex = 2;
            browseTournaments1.Load += browseTournaments1_Load;
            // 
            // tournaments1
            // 
            tournaments1.BackColor = Color.FromArgb(192, 188, 212);
            tournaments1.Location = new Point(0, 0);
            tournaments1.Margin = new Padding(4);
            tournaments1.Name = "tournaments1";
            tournaments1.Size = new Size(1264, 816);
            tournaments1.TabIndex = 1;
            // 
            // gameLibrary1
            // 
            gameLibrary1.BackColor = Color.FromArgb(192, 188, 212);
            gameLibrary1.Location = new Point(0, 0);
            gameLibrary1.Margin = new Padding(4);
            gameLibrary1.Name = "gameLibrary1";
            gameLibrary1.Size = new Size(1264, 816);
            gameLibrary1.TabIndex = 0;
            gameLibrary1.Load += gameLibrary1_Load;
            // 
            // GamerMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 653);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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
        private TextBox WelcomeTextBox;
        private BrowseGames browseGames1;
        private Button EditProfile;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}