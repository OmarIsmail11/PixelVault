namespace PixelVaultGUI
{
    partial class Admin_Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Edit));
            add = new Button();
            remove = new Button();
            panel1 = new Panel();
            textBox2 = new TextBox();
            LogOutButton = new Button();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            reports = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // add
            // 
            add.BackgroundImage = Properties.Resources.solid_color_image__1_;
            add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.Location = new Point(394, 269);
            add.Margin = new Padding(4);
            add.Name = "add";
            add.Size = new Size(199, 110);
            add.TabIndex = 0;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // remove
            // 
            remove.BackgroundImage = Properties.Resources.solid_color_image__1_;
            remove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remove.Location = new Point(637, 269);
            remove.Margin = new Padding(4);
            remove.Name = "remove";
            remove.Size = new Size(195, 110);
            remove.TabIndex = 1;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.dark_purple_colour1;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(LogOutButton);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(reports);
            panel1.Controls.Add(remove);
            panel1.Controls.Add(add);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(979, 510);
            panel1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(29, 29, 57);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(133, 412);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(202, 49);
            textBox2.TabIndex = 28;
            textBox2.Text = "Sign Out";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // LogOutButton
            // 
            LogOutButton.Image = Properties.Resources.logoutbutton;
            LogOutButton.Location = new Point(36, 389);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(89, 72);
            LogOutButton.TabIndex = 6;
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._142p;
            pictureBox3.Location = new Point(155, 74);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(202, 187);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._141p;
            pictureBox2.Location = new Point(637, 74);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(195, 187);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(394, 74);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 187);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // reports
            // 
            reports.BackgroundImage = Properties.Resources.solid_color_image__1_;
            reports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reports.Location = new Point(155, 269);
            reports.Margin = new Padding(4);
            reports.Name = "reports";
            reports.Size = new Size(202, 110);
            reports.TabIndex = 2;
            reports.Text = "View Reports";
            reports.UseVisualStyleBackColor = true;
            reports.Click += reports_Click;
            // 
            // Admin_Edit
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 510);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Admin_Edit";
            Text = "Admin_Edit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button add;
        private Button remove;
        private Panel panel1;
        private Button reports;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Button LogOutButton;
        private TextBox textBox2;
    }
}