namespace PixelVaultGUI
{
    partial class StoreMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreMain));
            Store_Info = new PictureBox();
            panel1 = new Panel();
            Manage_TReg = new Button();
            Manage_Partner = new Button();
            LogOutButton = new Button();
            label1 = new Label();
            Add_Tournament = new Button();
            Promotions = new Button();
            Manage_Inventory = new Button();
            Welcome = new Label();
            manageInventory1 = new ManageInventory();
            panel2 = new Panel();
            addTournament1 = new AddTournament();
            manageregisteration1 = new manageregisteration();
            managePartnerships1 = new ManagePartnerships();
            promotions1 = new Promotions();
            ((System.ComponentModel.ISupportInitialize)Store_Info).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // Store_Info
            // 
            Store_Info.Image = Properties.Resources.store;
            Store_Info.Location = new Point(106, 12);
            Store_Info.Margin = new Padding(2);
            Store_Info.Name = "Store_Info";
            Store_Info.Size = new Size(169, 139);
            Store_Info.SizeMode = PictureBoxSizeMode.StretchImage;
            Store_Info.TabIndex = 0;
            Store_Info.TabStop = false;
            Store_Info.Click += Store_Info_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel1.Controls.Add(Manage_TReg);
            panel1.Controls.Add(Manage_Partner);
            panel1.Controls.Add(LogOutButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Add_Tournament);
            panel1.Controls.Add(Promotions);
            panel1.Controls.Add(Manage_Inventory);
            panel1.Controls.Add(Welcome);
            panel1.Controls.Add(Store_Info);
            panel1.Location = new Point(2, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 622);
            panel1.TabIndex = 1;
            // 
            // Manage_TReg
            // 
            Manage_TReg.BackColor = Color.FromArgb(186, 186, 212);
            Manage_TReg.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Manage_TReg.Location = new Point(22, 492);
            Manage_TReg.Margin = new Padding(2);
            Manage_TReg.Name = "Manage_TReg";
            Manage_TReg.Size = new Size(370, 45);
            Manage_TReg.TabIndex = 28;
            Manage_TReg.Text = "Manage Registration";
            Manage_TReg.UseVisualStyleBackColor = false;
            Manage_TReg.Click += Manage_TReg_Click;
            // 
            // Manage_Partner
            // 
            Manage_Partner.BackColor = Color.FromArgb(186, 186, 212);
            Manage_Partner.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Manage_Partner.Location = new Point(22, 232);
            Manage_Partner.Margin = new Padding(2);
            Manage_Partner.Name = "Manage_Partner";
            Manage_Partner.Size = new Size(370, 45);
            Manage_Partner.TabIndex = 27;
            Manage_Partner.Text = "Manage Partenerships";
            Manage_Partner.UseVisualStyleBackColor = false;
            Manage_Partner.Click += Manage_Partner_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.Image = Properties.Resources.logoutbutton;
            LogOutButton.Location = new Point(38, 552);
            LogOutButton.Margin = new Padding(4);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.RightToLeft = RightToLeft.No;
            LogOutButton.Size = new Size(69, 56);
            LogOutButton.TabIndex = 26;
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = Properties.Resources.dark_purple_colour;
            label1.Location = new Point(128, 558);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 38);
            label1.TabIndex = 25;
            label1.Text = "Sign Out";
            label1.Click += label1_Click;
            // 
            // Add_Tournament
            // 
            Add_Tournament.BackColor = Color.FromArgb(186, 186, 212);
            Add_Tournament.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Add_Tournament.Location = new Point(22, 428);
            Add_Tournament.Margin = new Padding(2);
            Add_Tournament.Name = "Add_Tournament";
            Add_Tournament.Size = new Size(370, 45);
            Add_Tournament.TabIndex = 24;
            Add_Tournament.Text = "Add Tournament";
            Add_Tournament.UseVisualStyleBackColor = false;
            Add_Tournament.Click += Add_Tournament_Click;
            // 
            // Promotions
            // 
            Promotions.BackColor = Color.FromArgb(186, 186, 212);
            Promotions.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Promotions.Location = new Point(22, 359);
            Promotions.Margin = new Padding(2);
            Promotions.Name = "Promotions";
            Promotions.Size = new Size(370, 45);
            Promotions.TabIndex = 23;
            Promotions.Text = "Promotions";
            Promotions.UseVisualStyleBackColor = false;
            Promotions.Click += Promotions_Click;
            // 
            // Manage_Inventory
            // 
            Manage_Inventory.BackColor = Color.FromArgb(186, 186, 212);
            Manage_Inventory.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Manage_Inventory.Location = new Point(22, 294);
            Manage_Inventory.Margin = new Padding(2);
            Manage_Inventory.Name = "Manage_Inventory";
            Manage_Inventory.Size = new Size(370, 45);
            Manage_Inventory.TabIndex = 1;
            Manage_Inventory.Text = "Manage Inventory";
            Manage_Inventory.UseVisualStyleBackColor = false;
            Manage_Inventory.Click += Manage_Inventory_Click;
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.BackColor = Color.Transparent;
            Welcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Welcome.ForeColor = Color.White;
            Welcome.Location = new Point(2, 176);
            Welcome.Margin = new Padding(2, 0, 2, 0);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(96, 38);
            Welcome.TabIndex = 0;
            Welcome.Text = "label1";
            // 
            // manageInventory1
            // 
            manageInventory1.AutoSize = true;
            manageInventory1.BackgroundImage = (Image)resources.GetObject("manageInventory1.BackgroundImage");
            manageInventory1.Location = new Point(2, -2);
            manageInventory1.Margin = new Padding(2);
            manageInventory1.Name = "manageInventory1";
            manageInventory1.Size = new Size(812, 620);
            manageInventory1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.solid_color_image;
            panel2.Controls.Add(addTournament1);
            panel2.Controls.Add(manageregisteration1);
            panel2.Controls.Add(manageInventory1);
            panel2.Controls.Add(managePartnerships1);
            panel2.Controls.Add(promotions1);
            panel2.Location = new Point(419, 4);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(812, 620);
            panel2.TabIndex = 3;
            // 
            // addTournament1
            // 
            addTournament1.Location = new Point(3, -2);
            addTournament1.Name = "addTournament1";
            addTournament1.Size = new Size(812, 620);
            addTournament1.TabIndex = 29;
            // 
            // manageregisteration1
            // 
            manageregisteration1.BackgroundImage = (Image)resources.GetObject("manageregisteration1.BackgroundImage");
            manageregisteration1.Location = new Point(2, -2);
            manageregisteration1.Margin = new Padding(2);
            manageregisteration1.Name = "manageregisteration1";
            manageregisteration1.Size = new Size(812, 620);
            manageregisteration1.TabIndex = 3;
            // 
            // managePartnerships1
            // 
            managePartnerships1.BackgroundImage = (Image)resources.GetObject("managePartnerships1.BackgroundImage");
            managePartnerships1.Location = new Point(2, 2);
            managePartnerships1.Margin = new Padding(2);
            managePartnerships1.Name = "managePartnerships1";
            managePartnerships1.Size = new Size(812, 620);
            managePartnerships1.TabIndex = 0;
            // 
            // promotions1
            // 
            promotions1.AutoSize = true;
            promotions1.BackgroundImage = (Image)resources.GetObject("promotions1.BackgroundImage");
            promotions1.Location = new Point(2, -2);
            promotions1.Margin = new Padding(2);
            promotions1.Name = "promotions1";
            promotions1.Size = new Size(812, 620);
            promotions1.TabIndex = 2;
            // 
            // StoreMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1235, 622);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "StoreMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StoreMain";
            Load += StoreMain_Load;
            ((System.ComponentModel.ISupportInitialize)Store_Info).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Store_Info;
        private Panel panel1;
        private Label Welcome;
        private Button Manage_Inventory;
        private Button Promotions;
        private Button Add_Tournament;
        private Button LogOutButton;
        private Label label1;
        private Button Manage_Partner;
        private Button Manage_TReg;
        private ManageInventory manageInventory1;
        private Panel panel2;
        private ManagePartnerships managePartnerships1;
        private manageregisteration manageregisteration1;
        private Promotions promotions1;
        private AddTournament addTournament1;
    }
}