namespace PixelVaultGUI
{
    partial class GamerSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamerSignUp));
            label3 = new Label();
            SignInButton = new Button();
            label1 = new Label();
            UserNameTextBox = new TextBox();
            label2 = new Label();
            FirstNameTextBox = new TextBox();
            label4 = new Label();
            LastNameTextBox = new TextBox();
            label5 = new Label();
            EmailTextBox = new TextBox();
            label6 = new Label();
            CountryComboBox = new ComboBox();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            PasswordTextBox = new TextBox();
            ReEnterPasswordTextBox = new TextBox();
            label8 = new Label();
            label9 = new Label();
            ShowHideButton = new Button();
            button1 = new Button();
            ExitButton = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(255, 9);
            label3.Name = "label3";
            label3.Size = new Size(306, 54);
            label3.TabIndex = 5;
            label3.Text = "Gamer Sign Up";
            // 
            // SignInButton
            // 
            SignInButton.BackColor = Color.Black;
            SignInButton.BackgroundImage = (Image)resources.GetObject("SignInButton.BackgroundImage");
            SignInButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignInButton.Location = new Point(330, 379);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(142, 44);
            SignInButton.TabIndex = 17;
            SignInButton.Text = "Sign Up";
            SignInButton.UseVisualStyleBackColor = false;
            SignInButton.Click += SignInButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(126, 76);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 16;
            label1.Text = "User Name";
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(250, 77);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(410, 27);
            UserNameTextBox.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(130, 120);
            label2.Name = "label2";
            label2.Size = new Size(115, 28);
            label2.TabIndex = 19;
            label2.Text = "First Name";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(250, 121);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(410, 27);
            FirstNameTextBox.TabIndex = 20;
            FirstNameTextBox.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(130, 159);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 21;
            label4.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(250, 159);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(410, 27);
            LastNameTextBox.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(178, 200);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 23;
            label5.Text = "Email";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(250, 204);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(410, 27);
            EmailTextBox.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(401, 336);
            label6.Name = "label6";
            label6.Size = new Size(88, 28);
            label6.TabIndex = 25;
            label6.Text = "Country";
            // 
            // CountryComboBox
            // 
            CountryComboBox.FormattingEnabled = true;
            CountryComboBox.Location = new Point(495, 337);
            CountryComboBox.Name = "CountryComboBox";
            CountryComboBox.Size = new Size(165, 28);
            CountryComboBox.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(77, 337);
            label7.Name = "label7";
            label7.Size = new Size(111, 28);
            label7.TabIndex = 27;
            label7.Text = "Birth Date";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(194, 338);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(116, 27);
            dateTimePicker1.TabIndex = 28;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(250, 246);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(410, 27);
            PasswordTextBox.TabIndex = 29;
            // 
            // ReEnterPasswordTextBox
            // 
            ReEnterPasswordTextBox.Location = new Point(250, 291);
            ReEnterPasswordTextBox.Name = "ReEnterPasswordTextBox";
            ReEnterPasswordTextBox.Size = new Size(410, 27);
            ReEnterPasswordTextBox.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Image = (Image)resources.GetObject("label8.Image");
            label8.Location = new Point(141, 245);
            label8.Name = "label8";
            label8.Size = new Size(101, 28);
            label8.TabIndex = 31;
            label8.Text = "Password";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.Location = new Point(56, 287);
            label9.Name = "label9";
            label9.Size = new Size(189, 28);
            label9.TabIndex = 32;
            label9.Text = "Re-enter Password";
            // 
            // ShowHideButton
            // 
            ShowHideButton.Image = Properties.Resources.Show_password;
            ShowHideButton.Location = new Point(681, 240);
            ShowHideButton.Name = "ShowHideButton";
            ShowHideButton.Size = new Size(41, 38);
            ShowHideButton.TabIndex = 33;
            ShowHideButton.UseVisualStyleBackColor = true;
            ShowHideButton.Click += ShowHideButton_Click;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.prev;
            button1.Location = new Point(12, 9);
            button1.Name = "button1";
            button1.Size = new Size(50, 51);
            button1.TabIndex = 34;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ButtonHighlight;
            ExitButton.Image = Properties.Resources.dark_purple_colour;
            ExitButton.Location = new Point(753, 12);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(35, 38);
            ExitButton.TabIndex = 35;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // GamerSignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.solid_color_image;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(button1);
            Controls.Add(ShowHideButton);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(ReEnterPasswordTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(CountryComboBox);
            Controls.Add(label6);
            Controls.Add(EmailTextBox);
            Controls.Add(label5);
            Controls.Add(LastNameTextBox);
            Controls.Add(label4);
            Controls.Add(FirstNameTextBox);
            Controls.Add(label2);
            Controls.Add(UserNameTextBox);
            Controls.Add(SignInButton);
            Controls.Add(label1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GamerSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GamerSignUp";
            Load += GamerSignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button SignInButton;
        private Label label1;
        private TextBox UserNameTextBox;
        private Label label2;
        private TextBox FirstNameTextBox;
        private Label label4;
        private TextBox LastNameTextBox;
        private Label label5;
        private TextBox EmailTextBox;
        private Label label6;
        private ComboBox CountryComboBox;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private TextBox PasswordTextBox;
        private TextBox ReEnterPasswordTextBox;
        private Label label8;
        private Label label9;
        private Button ShowHideButton;
        private Button button1;
        private Label ExitButton;
    }
}