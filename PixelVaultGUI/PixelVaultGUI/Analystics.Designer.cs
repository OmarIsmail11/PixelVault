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
            MostTrendingGenre = new Label();
            label5 = new Label();
            MostTrendingPlatform = new Label();
            label6 = new Label();
            MostTrendingEngine = new Label();
            label4 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            AwardedGamesButton = new Button();
            groupBox2 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
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
            TrendingGamesButton.Location = new Point(22, 40);
            TrendingGamesButton.Name = "TrendingGamesButton";
            TrendingGamesButton.Size = new Size(272, 104);
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
            MostTrendingGame.Location = new Point(212, 57);
            MostTrendingGame.Name = "MostTrendingGame";
            MostTrendingGame.Size = new Size(110, 45);
            MostTrendingGame.TabIndex = 0;
            MostTrendingGame.Text = "label3";
            // 
            // MostTrendingGenre
            // 
            MostTrendingGenre.AutoSize = true;
            MostTrendingGenre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            MostTrendingGenre.ForeColor = SystemColors.ButtonHighlight;
            MostTrendingGenre.Image = Properties.Resources.dark_purple_colour;
            MostTrendingGenre.Location = new Point(212, 130);
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
            label5.Location = new Point(29, 130);
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
            MostTrendingPlatform.Location = new Point(212, 285);
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
            label6.Location = new Point(29, 285);
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
            MostTrendingEngine.Location = new Point(212, 206);
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
            label4.Location = new Point(29, 206);
            label4.Name = "label4";
            label4.Size = new Size(139, 45);
            label4.TabIndex = 2;
            label4.Text = "Engine :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Window;
            label2.Image = Properties.Resources.solid_color_image;
            label2.Location = new Point(29, 57);
            label2.Name = "label2";
            label2.Size = new Size(124, 45);
            label2.TabIndex = 0;
            label2.Text = "Game :";
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.dark_purple_colour;
            groupBox1.Controls.Add(MostTrendingGenre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(MostTrendingGame);
            groupBox1.Controls.Add(MostTrendingPlatform);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(MostTrendingEngine);
            groupBox1.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(1050, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(487, 354);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Most Trending";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(AwardedGamesButton);
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(TrendingGamesButton);
            panel2.Location = new Point(26, 633);
            panel2.Name = "panel2";
            panel2.Size = new Size(1575, 379);
            panel2.TabIndex = 7;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.solid_color_image__1_;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(355, 263);
            button3.Name = "button3";
            button3.Size = new Size(219, 59);
            button3.TabIndex = 11;
            button3.Text = "Populer Platform";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.solid_color_image__1_;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(353, 151);
            button2.Name = "button2";
            button2.Size = new Size(221, 60);
            button2.TabIndex = 10;
            button2.Text = "Populer Engine";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.solid_color_image__1_;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(353, 40);
            button1.Name = "button1";
            button1.Size = new Size(218, 59);
            button1.TabIndex = 9;
            button1.Text = "Populer Genres";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // AwardedGamesButton
            // 
            AwardedGamesButton.BackColor = Color.FromArgb(186, 186, 212);
            AwardedGamesButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            AwardedGamesButton.Location = new Point(22, 218);
            AwardedGamesButton.Name = "AwardedGamesButton";
            AwardedGamesButton.Size = new Size(272, 104);
            AwardedGamesButton.TabIndex = 8;
            AwardedGamesButton.Text = "View Awarded Games";
            AwardedGamesButton.UseVisualStyleBackColor = false;
            AwardedGamesButton.Click += AwardedGamesButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources.dark_purple_colour;
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(667, 40);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(375, 303);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order by";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackgroundImage = Properties.Resources.dark_purple_colour;
            radioButton3.Location = new Point(25, 233);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(331, 49);
            radioButton3.TabIndex = 10;
            radioButton3.TabStop = true;
            radioButton3.Text = "Number of Players";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AccessibleRole = AccessibleRole.TitleBar;
            radioButton1.AutoSize = true;
            radioButton1.BackgroundImage = Properties.Resources.dark_purple_colour1;
            radioButton1.Location = new Point(25, 68);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(225, 49);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "User Rating";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackgroundImage = Properties.Resources.dark_purple_colour;
            radioButton2.Location = new Point(25, 139);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(149, 49);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Rating";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // Analystics
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.solid_color_image__1_;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Analystics";
            Size = new Size(1643, 1045);
            Load += Analystics_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Button TrendingGamesButton;
        private Label MostTrendingGame;
        private Label label2;
        private Label MostTrendingPlatform;
        private Label label6;
        private Label MostTrendingEngine;
        private Label label4;
        private Label MostTrendingGenre;
        private Label label5;
        private GroupBox groupBox1;
        private Panel panel2;
        private GroupBox groupBox2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button AwardedGamesButton;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
