namespace PixelVaultGUI
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            GamerButton = new Button();
            GameStoreButton = new Button();
            GamePublisherButton = new Button();
            button1 = new Button();
            ExitButton = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(332, 9);
            label3.Name = "label3";
            label3.Size = new Size(170, 54);
            label3.TabIndex = 4;
            label3.Text = "Sign Up";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(221, 76);
            label1.Name = "label1";
            label1.Size = new Size(376, 41);
            label1.TabIndex = 5;
            label1.Text = "Please select account type";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 178);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.store;
            pictureBox2.Location = new Point(306, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(196, 178);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(563, 141);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(196, 189);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // GamerButton
            // 
            GamerButton.BackColor = Color.Black;
            GamerButton.BackgroundImage = (Image)resources.GetObject("GamerButton.BackgroundImage");
            GamerButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GamerButton.Location = new Point(50, 342);
            GamerButton.Name = "GamerButton";
            GamerButton.Size = new Size(176, 44);
            GamerButton.TabIndex = 16;
            GamerButton.Text = "Gamer";
            GamerButton.UseVisualStyleBackColor = false;
            GamerButton.Click += GamerButton_Click;
            // 
            // GameStoreButton
            // 
            GameStoreButton.BackColor = Color.Black;
            GameStoreButton.BackgroundImage = (Image)resources.GetObject("GameStoreButton.BackgroundImage");
            GameStoreButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GameStoreButton.Location = new Point(321, 342);
            GameStoreButton.Name = "GameStoreButton";
            GameStoreButton.Size = new Size(181, 44);
            GameStoreButton.TabIndex = 17;
            GameStoreButton.Text = "Game Store";
            GameStoreButton.UseVisualStyleBackColor = false;
            // 
            // GamePublisherButton
            // 
            GamePublisherButton.BackColor = Color.Black;
            GamePublisherButton.BackgroundImage = (Image)resources.GetObject("GamePublisherButton.BackgroundImage");
            GamePublisherButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GamePublisherButton.Location = new Point(563, 342);
            GamePublisherButton.Name = "GamePublisherButton";
            GamePublisherButton.Size = new Size(186, 44);
            GamePublisherButton.TabIndex = 18;
            GamePublisherButton.Text = "Game Publisher";
            GamePublisherButton.UseVisualStyleBackColor = false;
            GamePublisherButton.Click += GamePublisherButton_Click;
            // 
            // button1
            // 
            button1.Image = Properties.Resources.prev;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(49, 51);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ButtonHighlight;
            ExitButton.Image = Properties.Resources.dark_purple_colour;
            ExitButton.Location = new Point(741, 13);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(35, 38);
            ExitButton.TabIndex = 20;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.solid_color_image;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(button1);
            Controls.Add(GamePublisherButton);
            Controls.Add(GameStoreButton);
            Controls.Add(GamerButton);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button GamerButton;
        private Button GameStoreButton;
        private Button GamePublisherButton;
        private Button button1;
        private Label ExitButton;
    }
}