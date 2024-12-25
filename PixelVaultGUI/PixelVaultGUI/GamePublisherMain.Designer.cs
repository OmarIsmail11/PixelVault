namespace PixelVaultGUI
{
    partial class GamePublisherMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePublisherMain));
            panel1 = new Panel();
            textBox2 = new TextBox();
            LogOutButton = new Button();
            WelcomeTextBox = new TextBox();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            publisherGames1 = new PublisherGames();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            sqlConnection2 = new Microsoft.Data.SqlClient.SqlConnection();
            analystics1 = new Analystics();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(LogOutButton);
            panel1.Controls.Add(WelcomeTextBox);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 1045);
            panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(29, 29, 57);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.Window;
            textBox2.Location = new Point(180, 860);
            textBox2.Margin = new Padding(5);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(202, 49);
            textBox2.TabIndex = 27;
            textBox2.Text = "Sign Out";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // LogOutButton
            // 
            LogOutButton.Image = Properties.Resources.logoutbutton;
            LogOutButton.Location = new Point(67, 854);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(89, 72);
            LogOutButton.TabIndex = 5;
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // WelcomeTextBox
            // 
            WelcomeTextBox.BackColor = Color.FromArgb(29, 29, 57);
            WelcomeTextBox.BorderStyle = BorderStyle.None;
            WelcomeTextBox.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            WelcomeTextBox.ForeColor = SystemColors.Window;
            WelcomeTextBox.Location = new Point(42, 322);
            WelcomeTextBox.Name = "WelcomeTextBox";
            WelcomeTextBox.Size = new Size(359, 49);
            WelcomeTextBox.TabIndex = 4;
            WelcomeTextBox.Text = "Welcome, User";
            WelcomeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(186, 186, 212);
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.Location = new Point(67, 539);
            button2.Name = "button2";
            button2.Size = new Size(315, 73);
            button2.TabIndex = 3;
            button2.Text = "View Analytics";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.Location = new Point(67, 416);
            button1.Name = "button1";
            button1.Size = new Size(315, 78);
            button1.TabIndex = 2;
            button1.Text = "Publisher Games";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.User1;
            pictureBox1.Location = new Point(107, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 245);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // publisherGames1
            // 
            publisherGames1.BackColor = Color.FromArgb(192, 188, 212);
            publisherGames1.Location = new Point(445, 2);
            publisherGames1.Margin = new Padding(5);
            publisherGames1.Name = "publisherGames1";
            publisherGames1.Size = new Size(3286, 2090);
            publisherGames1.TabIndex = 1;
            // 
            // sqlConnection1
            // 
            sqlConnection1.AccessTokenCallback = null;
            sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlConnection2
            // 
            sqlConnection2.AccessTokenCallback = null;
            sqlConnection2.FireInfoMessageEventOnUserErrors = false;
            // 
            // analystics1
            // 
            analystics1.BackgroundImage = (Image)resources.GetObject("analystics1.BackgroundImage");
            analystics1.Location = new Point(445, 2);
            analystics1.Name = "analystics1";
            analystics1.Size = new Size(3286, 2090);
            analystics1.TabIndex = 2;
            // 
            // GamePublisherMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2057, 974);
            Controls.Add(analystics1);
            Controls.Add(publisherGames1);
            Controls.Add(panel1);
            Name = "GamePublisherMain";
            Text = "GamePublisherMain";
            Load += GamePublisherMain_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private PublisherGames publisherGames1;
        private TextBox WelcomeTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection2;
        private Analystics analystics1;
        private Button LogOutButton;
        private TextBox textBox2;
    }
}