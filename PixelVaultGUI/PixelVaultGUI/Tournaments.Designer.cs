namespace PixelVaultGUI
{
    partial class Tournaments
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
            EnrolledInTournaments = new DataGridView();
            label1 = new Label();
            ExitButton = new Label();
            UnregisterButton = new Button();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EnrolledInTournaments).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel3.Controls.Add(EnrolledInTournaments);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(15, 41);
            panel3.Name = "panel3";
            panel3.Size = new Size(971, 303);
            panel3.TabIndex = 2;
            // 
            // EnrolledInTournaments
            // 
            EnrolledInTournaments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EnrolledInTournaments.Location = new Point(24, 59);
            EnrolledInTournaments.Name = "EnrolledInTournaments";
            EnrolledInTournaments.RowHeadersWidth = 51;
            EnrolledInTournaments.Size = new Size(922, 218);
            EnrolledInTournaments.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = Properties.Resources.dark_purple_colour;
            label1.Location = new Point(24, 13);
            label1.Name = "label1";
            label1.Size = new Size(267, 31);
            label1.TabIndex = 0;
            label1.Text = "Tournaments Enrolled In";
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ButtonHighlight;
            ExitButton.Image = Properties.Resources.dark_purple_colour;
            ExitButton.Location = new Point(976, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(35, 38);
            ExitButton.TabIndex = 18;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // UnregisterButton
            // 
            UnregisterButton.BackgroundImage = Properties.Resources.solid_color_image;
            UnregisterButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UnregisterButton.ForeColor = SystemColors.ButtonHighlight;
            UnregisterButton.Location = new Point(361, 388);
            UnregisterButton.Name = "UnregisterButton";
            UnregisterButton.Size = new Size(286, 67);
            UnregisterButton.TabIndex = 19;
            UnregisterButton.Text = "Unenroll";
            UnregisterButton.UseVisualStyleBackColor = true;
            UnregisterButton.Click += button1_Click;
            // 
            // Tournaments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 188, 212);
            Controls.Add(UnregisterButton);
            Controls.Add(ExitButton);
            Controls.Add(panel3);
            Name = "Tournaments";
            Size = new Size(1011, 653);
            Load += Tournaments_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EnrolledInTournaments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private DataGridView EnrolledInTournaments;
        private Label label1;
        private Label ExitButton;
        private Button UnregisterButton;
    }
}
