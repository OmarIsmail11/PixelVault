namespace PixelVaultGUI
{
    partial class GameLibrary
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
            panel3 = new Panel();
            YourGamesDataGridView = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            UpdateGameCompletionButton = new Button();
            RateGameButton = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)YourGamesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel3.Controls.Add(YourGamesDataGridView);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(20, 24);
            panel3.Name = "panel3";
            panel3.Size = new Size(969, 299);
            panel3.TabIndex = 1;
            // 
            // YourGamesDataGridView
            // 
            YourGamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            YourGamesDataGridView.Location = new Point(24, 59);
            YourGamesDataGridView.Name = "YourGamesDataGridView";
            YourGamesDataGridView.RowHeadersWidth = 51;
            YourGamesDataGridView.Size = new Size(922, 212);
            YourGamesDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = Properties.Resources.dark_purple_colour;
            label1.Location = new Point(24, 13);
            label1.Name = "label1";
            label1.Size = new Size(137, 31);
            label1.TabIndex = 0;
            label1.Text = "Your Games";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.solid_color_image;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(328, 339);
            button1.Name = "button1";
            button1.Size = new Size(362, 67);
            button1.TabIndex = 2;
            button1.Text = "Remove Game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UpdateGameCompletionButton
            // 
            UpdateGameCompletionButton.BackgroundImage = Properties.Resources.solid_color_image;
            UpdateGameCompletionButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateGameCompletionButton.ForeColor = SystemColors.ButtonHighlight;
            UpdateGameCompletionButton.Location = new Point(328, 422);
            UpdateGameCompletionButton.Name = "UpdateGameCompletionButton";
            UpdateGameCompletionButton.Size = new Size(358, 67);
            UpdateGameCompletionButton.TabIndex = 3;
            UpdateGameCompletionButton.Text = "Update Game Completion";
            UpdateGameCompletionButton.UseVisualStyleBackColor = true;
            UpdateGameCompletionButton.Click += UpdateGameCompletionButton_Click;
            // 
            // RateGameButton
            // 
            RateGameButton.BackgroundImage = Properties.Resources.solid_color_image;
            RateGameButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RateGameButton.ForeColor = SystemColors.ButtonHighlight;
            RateGameButton.Location = new Point(324, 511);
            RateGameButton.Name = "RateGameButton";
            RateGameButton.Size = new Size(362, 67);
            RateGameButton.TabIndex = 4;
            RateGameButton.Text = "Rate Game";
            RateGameButton.UseVisualStyleBackColor = true;
            RateGameButton.Click += RateGameButton_Click;
            // 
            // GameLibrary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 188, 212);
            Controls.Add(RateGameButton);
            Controls.Add(UpdateGameCompletionButton);
            Controls.Add(button1);
            Controls.Add(panel3);
            Name = "GameLibrary";
            Size = new Size(1011, 653);
            Load += GameLibrary_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)YourGamesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private DataGridView YourGamesDataGridView;
        private Label label1;
        private Button button1;
        private Button UpdateGameCompletionButton;
        private Button RateGameButton;
    }
}
