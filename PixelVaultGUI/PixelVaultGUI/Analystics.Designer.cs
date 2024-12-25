namespace PixelVaultGUI
{
    partial class Analystics
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
            TrendingGamesButton = new Button();
            MostTrendingGame = new Label();
            panel2 = new Panel();
            MostTrendingGenre = new Label();
            label5 = new Label();
            MostTrendingPlatform = new Label();
            label6 = new Label();
            MostTrendingEngine = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(26, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(1575, 515);
            panel1.TabIndex = 1;
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
            label1.Size = new Size(278, 50);
            label1.TabIndex = 1;
            label1.Text = "Current Market";
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
            // TrendingGamesButton
            // 
            TrendingGamesButton.BackColor = Color.FromArgb(186, 186, 212);
            TrendingGamesButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            TrendingGamesButton.Location = new Point(65, 635);
            TrendingGamesButton.Name = "TrendingGamesButton";
            TrendingGamesButton.Size = new Size(413, 104);
            TrendingGamesButton.TabIndex = 2;
            TrendingGamesButton.Text = "View Trending Games";
            TrendingGamesButton.UseVisualStyleBackColor = false;
            TrendingGamesButton.Click += button1_Click;
            // 
            // MostTrendingGame
            // 
            MostTrendingGame.AutoSize = true;
            MostTrendingGame.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            MostTrendingGame.ForeColor = SystemColors.Window;
            MostTrendingGame.Image = Properties.Resources.solid_color_image;
            MostTrendingGame.Location = new Point(258, 72);
            MostTrendingGame.Name = "MostTrendingGame";
            MostTrendingGame.Size = new Size(110, 45);
            MostTrendingGame.TabIndex = 0;
            MostTrendingGame.Text = "label3";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.solid_color_image;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(MostTrendingGenre);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(MostTrendingPlatform);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(MostTrendingEngine);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(MostTrendingGame);
            panel2.Location = new Point(1067, 620);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 382);
            panel2.TabIndex = 5;
            // 
            // MostTrendingGenre
            // 
            MostTrendingGenre.AutoSize = true;
            MostTrendingGenre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            MostTrendingGenre.ForeColor = SystemColors.ButtonHighlight;
            MostTrendingGenre.Image = Properties.Resources.dark_purple_colour;
            MostTrendingGenre.Location = new Point(258, 145);
            MostTrendingGenre.Name = "MostTrendingGenre";
            MostTrendingGenre.Size = new Size(110, 45);
            MostTrendingGenre.TabIndex = 7;
            MostTrendingGenre.Text = "label7";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Image = Properties.Resources.dark_purple_colour;
            label5.Location = new Point(27, 145);
            label5.Name = "label5";
            label5.Size = new Size(127, 45);
            label5.TabIndex = 6;
            label5.Text = "Genre :";
            // 
            // MostTrendingPlatform
            // 
            MostTrendingPlatform.AutoSize = true;
            MostTrendingPlatform.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            MostTrendingPlatform.ForeColor = SystemColors.ButtonHighlight;
            MostTrendingPlatform.Image = Properties.Resources.dark_purple_colour;
            MostTrendingPlatform.Location = new Point(258, 300);
            MostTrendingPlatform.Name = "MostTrendingPlatform";
            MostTrendingPlatform.Size = new Size(110, 45);
            MostTrendingPlatform.TabIndex = 5;
            MostTrendingPlatform.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Image = Properties.Resources.dark_purple_colour;
            label6.Location = new Point(27, 300);
            label6.Name = "label6";
            label6.Size = new Size(170, 45);
            label6.TabIndex = 4;
            label6.Text = "Platform :";
            // 
            // MostTrendingEngine
            // 
            MostTrendingEngine.AutoSize = true;
            MostTrendingEngine.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            MostTrendingEngine.ForeColor = SystemColors.ButtonFace;
            MostTrendingEngine.Image = Properties.Resources.dark_purple_colour;
            MostTrendingEngine.Location = new Point(258, 221);
            MostTrendingEngine.Name = "MostTrendingEngine";
            MostTrendingEngine.Size = new Size(110, 45);
            MostTrendingEngine.TabIndex = 3;
            MostTrendingEngine.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Image = Properties.Resources.dark_purple_colour;
            label4.Location = new Point(27, 221);
            label4.Name = "label4";
            label4.Size = new Size(139, 45);
            label4.TabIndex = 2;
            label4.Text = "Engine :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Window;
            label3.Image = Properties.Resources.dark_purple_colour;
            label3.Location = new Point(155, 13);
            label3.Name = "label3";
            label3.Size = new Size(240, 45);
            label3.TabIndex = 1;
            label3.Text = "Most Trending";
            label3.Click += label3_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Image = Properties.Resources.solid_color_image;
            label2.Location = new Point(27, 72);
            label2.Name = "label2";
            label2.Size = new Size(124, 45);
            label2.TabIndex = 0;
            label2.Text = "Game :";
            // 
            // Analystics
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.solid_color_image__1_;
            Controls.Add(panel2);
            Controls.Add(TrendingGamesButton);
            Controls.Add(panel1);
            Name = "Analystics";
            Size = new Size(1643, 1045);
            Load += Analystics_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button TrendingGamesButton;
        private Label MostTrendingGame;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label MostTrendingPlatform;
        private Label label6;
        private Label MostTrendingEngine;
        private Label label4;
        private Label MostTrendingGenre;
        private Label label5;
    }
}
