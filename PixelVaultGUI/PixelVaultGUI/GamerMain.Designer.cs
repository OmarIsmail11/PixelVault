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
            TournamentsButton = new Button();
            GamerLibraryButton = new Button();
            WelcomeUserLabel = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            gameLibrary1 = new GameLibrary();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel1.Controls.Add(TournamentsButton);
            panel1.Controls.Add(GamerLibraryButton);
            panel1.Controls.Add(WelcomeUserLabel);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 653);
            panel1.TabIndex = 0;
            // 
            // TournamentsButton
            // 
            TournamentsButton.BackColor = Color.FromArgb(186, 186, 212);
            TournamentsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TournamentsButton.Location = new Point(55, 317);
            TournamentsButton.Name = "TournamentsButton";
            TournamentsButton.Size = new Size(181, 44);
            TournamentsButton.TabIndex = 18;
            TournamentsButton.Text = "Tournaments";
            TournamentsButton.UseVisualStyleBackColor = false;
            TournamentsButton.Click += TournamentsButton_Click;
            // 
            // GamerLibraryButton
            // 
            GamerLibraryButton.BackColor = Color.Thistle;
            GamerLibraryButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GamerLibraryButton.Location = new Point(55, 247);
            GamerLibraryButton.Name = "GamerLibraryButton";
            GamerLibraryButton.Size = new Size(176, 44);
            GamerLibraryButton.TabIndex = 17;
            GamerLibraryButton.Text = "Game Library";
            GamerLibraryButton.UseVisualStyleBackColor = false;
            GamerLibraryButton.Click += GamerLibraryButton_Click;
            // 
            // WelcomeUserLabel
            // 
            WelcomeUserLabel.AutoSize = true;
            WelcomeUserLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeUserLabel.ForeColor = SystemColors.ButtonHighlight;
            WelcomeUserLabel.Image = Properties.Resources.solid_color_image;
            WelcomeUserLabel.Location = new Point(26, 199);
            WelcomeUserLabel.Name = "WelcomeUserLabel";
            WelcomeUserLabel.Size = new Size(148, 28);
            WelcomeUserLabel.TabIndex = 1;
            WelcomeUserLabel.Text = "Welcome, User";
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
            panel2.Controls.Add(gameLibrary1);
            panel2.Location = new Point(272, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1011, 653);
            panel2.TabIndex = 1;
            // 
            // gameLibrary1
            // 
            gameLibrary1.BackColor = Color.FromArgb(192, 188, 212);
            gameLibrary1.Location = new Point(0, 0);
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
            Name = "GamerMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GamerMain";
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
    }
}