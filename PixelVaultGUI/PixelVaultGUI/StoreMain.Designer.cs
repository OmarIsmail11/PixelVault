namespace PixelVaultGUI
{
    partial class StoreMain
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            Manage_Inventory = new Button();
            Welcome = new Label();
            ExitButton = new Label();
            Inventory = new Panel();
            Promotions = new Button();
            Add_Tournament = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            Inventory.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.store;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 157);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel1.Controls.Add(Add_Tournament);
            panel1.Controls.Add(Promotions);
            panel1.Controls.Add(Manage_Inventory);
            panel1.Controls.Add(Welcome);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 587);
            panel1.TabIndex = 1;
            // 
            // Manage_Inventory
            // 
            Manage_Inventory.BackColor = Color.FromArgb(186, 186, 212);
            Manage_Inventory.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Manage_Inventory.Location = new Point(12, 298);
            Manage_Inventory.Name = "Manage_Inventory";
            Manage_Inventory.Size = new Size(324, 56);
            Manage_Inventory.TabIndex = 1;
            Manage_Inventory.Text = "Manage Inventory";
            Manage_Inventory.UseVisualStyleBackColor = false;
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.BackColor = Color.Transparent;
            Welcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Welcome.ForeColor = Color.White;
            Welcome.Location = new Point(136, 220);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(96, 38);
            Welcome.TabIndex = 0;
            Welcome.Text = "label1";
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ActiveCaptionText;
            ExitButton.Image = Properties.Resources.solid_color_image__1_;
            ExitButton.Location = new Point(724, 0);
            ExitButton.Margin = new Padding(4, 0, 4, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(42, 45);
            ExitButton.TabIndex = 22;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // Inventory
            // 
            Inventory.BackColor = Color.White;
            Inventory.BackgroundImage = Properties.Resources.solid_color_image__1_;
            Inventory.Controls.Add(ExitButton);
            Inventory.Location = new Point(416, 0);
            Inventory.Name = "Inventory";
            Inventory.Size = new Size(766, 587);
            Inventory.TabIndex = 2;
            Inventory.Paint += Inventory_Paint_1;
            // 
            // Promotions
            // 
            Promotions.BackColor = Color.FromArgb(186, 186, 212);
            Promotions.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Promotions.Location = new Point(12, 398);
            Promotions.Name = "Promotions";
            Promotions.Size = new Size(324, 56);
            Promotions.TabIndex = 23;
            Promotions.Text = "Promotions";
            Promotions.UseVisualStyleBackColor = false;
            // 
            // Add_Tournament
            // 
            Add_Tournament.BackColor = Color.FromArgb(186, 186, 212);
            Add_Tournament.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Add_Tournament.Location = new Point(12, 489);
            Add_Tournament.Name = "Add_Tournament";
            Add_Tournament.Size = new Size(324, 56);
            Add_Tournament.TabIndex = 24;
            Add_Tournament.Text = "Add Tournament";
            Add_Tournament.UseVisualStyleBackColor = false;
            // 
            // StoreMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dark_purple_colour;
            ClientSize = new Size(1183, 587);
            Controls.Add(Inventory);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StoreMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StoreMain";
            Load += StoreMain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Inventory.ResumeLayout(false);
            Inventory.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label Welcome;
        private Button Manage_Inventory;
        private Label ExitButton;
        private Panel Inventory;
        private Button Promotions;
        private Button Add_Tournament;
    }
}