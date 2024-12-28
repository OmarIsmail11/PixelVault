namespace PixelVaultGUI
{
    partial class EditProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProfile));
            label1 = new Label();
            label2 = new Label();
            PasswordTextBox = new TextBox();
            label3 = new Label();
            NewPasswordTextBox = new TextBox();
            ConfirmButton = new Button();
            Return = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = Properties.Resources.dark_purple_colour;
            label1.Location = new Point(284, 23);
            label1.Name = "label1";
            label1.Size = new Size(245, 38);
            label1.TabIndex = 0;
            label1.Text = "Change Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Image = Properties.Resources.dark_purple_colour;
            label2.Location = new Point(173, 110);
            label2.Name = "label2";
            label2.Size = new Size(165, 31);
            label2.TabIndex = 1;
            label2.Text = "New Password";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(367, 114);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(334, 27);
            PasswordTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Image = Properties.Resources.dark_purple_colour;
            label3.Location = new Point(79, 180);
            label3.Name = "label3";
            label3.Size = new Size(259, 31);
            label3.TabIndex = 3;
            label3.Text = "Re-enter New Password";
            // 
            // NewPasswordTextBox
            // 
            NewPasswordTextBox.Location = new Point(367, 186);
            NewPasswordTextBox.Name = "NewPasswordTextBox";
            NewPasswordTextBox.Size = new Size(334, 27);
            NewPasswordTextBox.TabIndex = 4;
            // 
            // ConfirmButton
            // 
            ConfirmButton.BackColor = Color.Black;
            ConfirmButton.BackgroundImage = (Image)resources.GetObject("ConfirmButton.BackgroundImage");
            ConfirmButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmButton.Location = new Point(325, 248);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(142, 44);
            ConfirmButton.TabIndex = 18;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = false;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // Return
            // 
            Return.Image = Properties.Resources.prev;
            Return.Location = new Point(12, 12);
            Return.Name = "Return";
            Return.Size = new Size(48, 49);
            Return.TabIndex = 35;
            Return.UseVisualStyleBackColor = true;
            Return.Click += Return_Click;
            // 
            // EditGamerProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dark_purple_colour;
            ClientSize = new Size(800, 350);
            Controls.Add(Return);
            Controls.Add(ConfirmButton);
            Controls.Add(NewPasswordTextBox);
            Controls.Add(label3);
            Controls.Add(PasswordTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditGamerProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditGamerProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox PasswordTextBox;
        private Label label3;
        private TextBox NewPasswordTextBox;
        private Button ConfirmButton;
        private Button Return;
    }
}