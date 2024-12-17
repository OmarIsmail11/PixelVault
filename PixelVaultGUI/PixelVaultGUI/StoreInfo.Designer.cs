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
            user_name.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            user_name.Location = new Point(330, 31);
            user_name.Name = "user_name";
            user_name.Size = new Size(110, 45);
            user_name.TabIndex = 24;
            user_name.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(272, 45);
            label1.TabIndex = 25;
            label1.Text = "Store UserName:";
            // 
            // StoreInfo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.solid_color_image__1_;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
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
    }
}