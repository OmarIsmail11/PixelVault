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
            add.Location = new Point(303, 210);
            add.Name = "add";
            add.Size = new Size(153, 86);
            add.TabIndex = 0;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // remove
            // 
            remove.BackgroundImage = Properties.Resources.solid_color_image__1_;
            remove.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remove.Location = new Point(490, 210);
            remove.Name = "remove";
            remove.Size = new Size(150, 86);
            remove.TabIndex = 1;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.dark_purple_colour1;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(reports);
            panel1.Controls.Add(remove);
            panel1.Controls.Add(add);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(738, 392);
            panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._142p;
            pictureBox3.Location = new Point(119, 58);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(155, 146);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._141p;
            pictureBox2.Location = new Point(490, 58);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 146);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(303, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 146);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // reports
            // 
            reports.BackgroundImage = Properties.Resources.solid_color_image__1_;
            reports.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reports.Location = new Point(119, 210);
            reports.Name = "reports";
            reports.Size = new Size(155, 86);
            reports.TabIndex = 2;
            reports.Text = "View Reports";
            reports.UseVisualStyleBackColor = true;
            reports.Click += reports_Click;
            // 
            // Admin_Edit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 392);
            Controls.Add(panel1);
            Name = "Admin_Edit";
            Text = "Admin_Edit";
            panel1.ResumeLayout(false);
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
    }
}