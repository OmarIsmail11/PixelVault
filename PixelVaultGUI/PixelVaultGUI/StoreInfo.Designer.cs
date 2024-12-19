namespace PixelVaultGUI
{
    partial class StoreInfo
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
            ExitButton = new Label();
            user_name = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            real_name = new Label();
            Rating = new Label();
            Hotline = new Label();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ActiveCaptionText;
            ExitButton.Image = Properties.Resources.solid_color_image__1_;
            ExitButton.Location = new Point(745, 9);
            ExitButton.Margin = new Padding(4, 0, 4, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(42, 45);
            ExitButton.TabIndex = 23;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // user_name
            // 
            user_name.AutoSize = true;
            user_name.BackColor = Color.Transparent;
            user_name.Font = new Font("Segoe UI", 16F);
            user_name.Location = new Point(251, 31);
            user_name.Name = "user_name";
            user_name.Size = new Size(105, 45);
            user_name.TabIndex = 24;
            user_name.Text = "label1";
            user_name.Click += user_name_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(193, 45);
            label1.TabIndex = 25;
            label1.Text = "User Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label2.Location = new Point(12, 120);
            label2.Name = "label2";
            label2.Size = new Size(189, 45);
            label2.TabIndex = 26;
            label2.Text = "Real Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.Location = new Point(12, 216);
            label3.Name = "label3";
            label3.Size = new Size(127, 45);
            label3.TabIndex = 27;
            label3.Text = "Rating:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.Location = new Point(12, 303);
            label4.Name = "label4";
            label4.Size = new Size(140, 45);
            label4.TabIndex = 28;
            label4.Text = "Hotline:";
            // 
            // real_name
            // 
            real_name.AutoSize = true;
            real_name.BackColor = Color.Transparent;
            real_name.Font = new Font("Segoe UI", 16F);
            real_name.ForeColor = SystemColors.ActiveCaptionText;
            real_name.Location = new Point(251, 120);
            real_name.Name = "real_name";
            real_name.Size = new Size(105, 45);
            real_name.TabIndex = 29;
            real_name.Text = "label5";
            // 
            // Rating
            // 
            Rating.AutoSize = true;
            Rating.BackColor = Color.Transparent;
            Rating.Font = new Font("Segoe UI", 16F);
            Rating.Location = new Point(251, 216);
            Rating.Name = "Rating";
            Rating.Size = new Size(105, 45);
            Rating.TabIndex = 30;
            Rating.Text = "label5";
            // 
            // Hotline
            // 
            Hotline.AutoSize = true;
            Hotline.BackColor = Color.Transparent;
            Hotline.Font = new Font("Segoe UI", 16F);
            Hotline.Location = new Point(251, 303);
            Hotline.Name = "Hotline";
            Hotline.Size = new Size(105, 45);
            Hotline.TabIndex = 31;
            Hotline.Text = "label5";
            // 
            // StoreInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.solid_color_image__1_;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(Hotline);
            Controls.Add(Rating);
            Controls.Add(real_name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(user_name);
            Controls.Add(ExitButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StoreInfo";
            Text = "StoreInfo";
            Load += StoreInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ExitButton;
        private Label user_name;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label real_name;
        private Label Rating;
        private Label Hotline;
    }
}