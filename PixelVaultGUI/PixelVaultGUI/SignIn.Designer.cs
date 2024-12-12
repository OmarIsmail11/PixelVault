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
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = Properties.Resources.Logo1;
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
            label3.Image = Properties.Resources.solid_color_image;
            label3.Location = new Point(414, 49);
            label3.Name = "label3";
            label3.Size = new Size(153, 54);
            label3.TabIndex = 3;
            label3.Text = "Sign In";
            // 
            // UserNameSignInTextBox
            // 
            UserNameSignInTextBox.Location = new Point(243, 164);
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
            label1.Image = Properties.Resources.solid_color_image;
            label1.Location = new Point(243, 130);
            label1.Name = "label1";
            label1.Size = new Size(131, 31);
            label1.TabIndex = 5;
            label1.Text = "User Name";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.solid_color_image;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(194, 155);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 36);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Image = Properties.Resources.solid_color_image;
            label2.Location = new Point(243, 216);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 7;
            label2.Text = "Password";
            // 
            // PasswordSignInTextBox
            // 
            PasswordSignInTextBox.Location = new Point(243, 250);
            PasswordSignInTextBox.MaxLength = 20;
            PasswordSignInTextBox.Multiline = true;
            PasswordSignInTextBox.Name = "PasswordSignInTextBox";
            PasswordSignInTextBox.PasswordChar = '*';
            PasswordSignInTextBox.Size = new Size(574, 27);
            PasswordSignInTextBox.TabIndex = 8;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.solid_color_image;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(194, 241);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 36);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImage = Properties.Resources.solid_color_image__1_;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(437, 300);
            button1.Name = "button1";
            button1.Size = new Size(142, 44);
            button1.TabIndex = 10;
            button1.Text = "Sign In";
            button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Image = Properties.Resources.solid_color_image;
            label4.Location = new Point(313, 385);
            label4.Name = "label4";
            label4.Size = new Size(230, 28);
            label4.TabIndex = 11;
            label4.Text = "Don't have an account ?";
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.BackgroundImage = Properties.Resources.solid_color_image__1_;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(558, 377);
            button2.Name = "button2";
            button2.Size = new Size(142, 44);
            button2.TabIndex = 12;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = Properties.Resources.dark_purple_colour;
            ClientSize = new Size(953, 501);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(PasswordSignInTextBox);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(UserNameSignInTextBox);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Name = "SignIn";
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
        private Button button1;
        private Label label4;
        private Button button2;
    }
}
