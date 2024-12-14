namespace PixelVaultGUI
{
    partial class SignIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            pictureBox1 = new PictureBox();
            label3 = new Label();
            UserNameSignInTextBox = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            PasswordSignInTextBox = new TextBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            SignUpButton = new Button();
            ShowHideButton = new Button();
            SignInButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 148);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(330, 54);
            label3.Name = "label3";
            label3.Size = new Size(153, 54);
            label3.TabIndex = 3;
            label3.Text = "Sign In";
            // 
            // UserNameSignInTextBox
            // 
            UserNameSignInTextBox.Location = new Point(118, 169);
            UserNameSignInTextBox.Multiline = true;
            UserNameSignInTextBox.Name = "UserNameSignInTextBox";
            UserNameSignInTextBox.Size = new Size(574, 27);
            UserNameSignInTextBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(118, 135);
            label1.Name = "label1";
            label1.Size = new Size(131, 31);
            label1.TabIndex = 5;
            label1.Text = "User Name";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Image = Properties.Resources.userlogo;
            pictureBox2.Location = new Point(69, 160);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 36);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(118, 221);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // PasswordSignInTextBox
            // 
            PasswordSignInTextBox.Location = new Point(118, 255);
            PasswordSignInTextBox.MaxLength = 20;
            PasswordSignInTextBox.Multiline = true;
            PasswordSignInTextBox.Name = "PasswordSignInTextBox";
            PasswordSignInTextBox.PasswordChar = '*';
            PasswordSignInTextBox.Size = new Size(574, 27);
            PasswordSignInTextBox.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(69, 246);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 36);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(215, 380);
            label4.Name = "label4";
            label4.Size = new Size(223, 28);
            label4.TabIndex = 11;
            label4.Text = "Don't have an account?";
            // 
            // SignUpButton
            // 
            SignUpButton.BackColor = Color.Black;
            SignUpButton.BackgroundImage = (Image)resources.GetObject("SignUpButton.BackgroundImage");
            SignUpButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpButton.Location = new Point(460, 372);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(142, 44);
            SignUpButton.TabIndex = 12;
            SignUpButton.Text = "Sign Up";
            SignUpButton.UseVisualStyleBackColor = false;
            SignUpButton.Click += SignUpButton_Click;
            // 
            // ShowHideButton
            // 
            ShowHideButton.Image = Properties.Resources.Show_password;
            ShowHideButton.Location = new Point(698, 246);
            ShowHideButton.Name = "ShowHideButton";
            ShowHideButton.Size = new Size(41, 38);
            ShowHideButton.TabIndex = 14;
            ShowHideButton.UseVisualStyleBackColor = true;
            ShowHideButton.Click += ShowHideButton_Click;
            // 
            // SignInButton
            // 
            SignInButton.BackColor = Color.Black;
            SignInButton.BackgroundImage = (Image)resources.GetObject("SignInButton.BackgroundImage");
            SignInButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignInButton.Location = new Point(341, 301);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(142, 44);
            SignInButton.TabIndex = 15;
            SignInButton.Text = "Sign In";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(782, 453);
            Controls.Add(SignInButton);
            Controls.Add(ShowHideButton);
            Controls.Add(SignUpButton);
            Controls.Add(label4);
            Controls.Add(pictureBox3);
            Controls.Add(PasswordSignInTextBox);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(UserNameSignInTextBox);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "SignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox UserNameSignInTextBox;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox PasswordSignInTextBox;
        private PictureBox pictureBox3;
        private Label label4;
        private Button SignUpButton;
        private Button ShowHideButton;
        private Button SignInButton;
    }
}
