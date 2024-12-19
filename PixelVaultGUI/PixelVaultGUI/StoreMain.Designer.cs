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
            ExitButton = new Label();
            Add_Tournament_Panel = new Panel();
            Reg_panel = new Panel();
            Refresh = new Button();
            TName_combobox = new ComboBox();
            label9 = new Label();
            Close = new CheckBox();
            Open = new CheckBox();
            dataGridView1 = new DataGridView();
            Add_Tournament_val = new Button();
            PMoney = new TextBox();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            Region = new ComboBox();
            label6 = new Label();
            Type = new ComboBox();
            label5 = new Label();
            Capacity = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            TName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Store_Info).BeginInit();
            panel1.SuspendLayout();
            Add_Tournament_Panel.SuspendLayout();
            Reg_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Store_Info
            // 
            Store_Info.Image = Properties.Resources.store;
            Store_Info.Location = new Point(10, 12);
            Store_Info.Name = "Store_Info";
            Store_Info.Size = new Size(143, 126);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 623);
            panel1.TabIndex = 1;
            // 
            // Manage_TReg
            // 
            Manage_TReg.BackColor = Color.FromArgb(186, 186, 212);
            Manage_TReg.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Manage_TReg.Location = new Point(22, 474);
            Manage_TReg.Name = "Manage_TReg";
            Manage_TReg.Size = new Size(370, 56);
            Manage_TReg.TabIndex = 28;
            Manage_TReg.Text = "Manage Registration";
            Manage_TReg.UseVisualStyleBackColor = false;
            Manage_TReg.Click += Manage_TReg_Click;
            // 
            // Manage_Partner
            // 
            Manage_Partner.BackColor = Color.FromArgb(186, 186, 212);
            Manage_Partner.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Manage_Partner.Location = new Point(22, 159);
            Manage_Partner.Name = "Manage_Partner";
            Manage_Partner.Size = new Size(370, 56);
            Manage_Partner.TabIndex = 27;
            Manage_Partner.Text = "Manage Partenerships";
            Manage_Partner.UseVisualStyleBackColor = false;
            // 
            // LogOutButton
            // 
            LogOutButton.Image = Properties.Resources.logoutbutton;
            LogOutButton.Location = new Point(69, 547);
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
            label1.Location = new Point(160, 551);
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
            Add_Tournament.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Add_Tournament.Location = new Point(22, 394);
            Add_Tournament.Name = "Add_Tournament";
            Add_Tournament.Size = new Size(370, 56);
            Add_Tournament.TabIndex = 24;
            Add_Tournament.Text = "Add Tournament";
            Add_Tournament.UseVisualStyleBackColor = false;
            Add_Tournament.Click += Add_Tournament_Click;
            // 
            // Promotions
            // 
            Promotions.BackColor = Color.FromArgb(186, 186, 212);
            Promotions.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Promotions.Location = new Point(22, 316);
            Promotions.Name = "Promotions";
            Promotions.Size = new Size(370, 56);
            Promotions.TabIndex = 23;
            Promotions.Text = "Promotions";
            Promotions.UseVisualStyleBackColor = false;
            // 
            // Manage_Inventory
            // 
            Manage_Inventory.BackColor = Color.FromArgb(186, 186, 212);
            Manage_Inventory.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Manage_Inventory.Location = new Point(22, 236);
            Manage_Inventory.Name = "Manage_Inventory";
            Manage_Inventory.Size = new Size(370, 56);
            Manage_Inventory.TabIndex = 1;
            Manage_Inventory.Text = "Manage Inventory";
            Manage_Inventory.UseVisualStyleBackColor = false;
            // 
            // Welcome
            // 
            Welcome.AutoSize = true;
            Welcome.BackColor = Color.Transparent;
            Welcome.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Welcome.ForeColor = Color.White;
            Welcome.Location = new Point(160, 46);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(96, 38);
            Welcome.TabIndex = 0;
            Welcome.Text = "label1";
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ActiveCaptionText;
            ExitButton.Image = Properties.Resources.solid_color_image__1_;
            ExitButton.Location = new Point(1142, 0);
            ExitButton.Margin = new Padding(4, 0, 4, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(42, 45);
            ExitButton.TabIndex = 24;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click_1;
            // 
            // Add_Tournament_Panel
            // 
            Add_Tournament_Panel.BackColor = Color.Transparent;
            Add_Tournament_Panel.BackgroundImage = Properties.Resources.solid_color_image__1_;
            Add_Tournament_Panel.Controls.Add(Reg_panel);
            Add_Tournament_Panel.Controls.Add(Add_Tournament_val);
            Add_Tournament_Panel.Controls.Add(PMoney);
            Add_Tournament_Panel.Controls.Add(label8);
            Add_Tournament_Panel.Controls.Add(dateTimePicker1);
            Add_Tournament_Panel.Controls.Add(label7);
            Add_Tournament_Panel.Controls.Add(Region);
            Add_Tournament_Panel.Controls.Add(label6);
            Add_Tournament_Panel.Controls.Add(Type);
            Add_Tournament_Panel.Controls.Add(label5);
            Add_Tournament_Panel.Controls.Add(Capacity);
            Add_Tournament_Panel.Controls.Add(label4);
            Add_Tournament_Panel.Controls.Add(label3);
            Add_Tournament_Panel.Controls.Add(label2);
            Add_Tournament_Panel.Controls.Add(TName);
            Add_Tournament_Panel.Location = new Point(489, 36);
            Add_Tournament_Panel.Name = "Add_Tournament_Panel";
            Add_Tournament_Panel.Size = new Size(716, 587);
            Add_Tournament_Panel.TabIndex = 25;
            // 
            // Reg_panel
            // 
            Reg_panel.BackgroundImage = Properties.Resources.solid_color_image__1_;
            Reg_panel.Controls.Add(Refresh);
            Reg_panel.Controls.Add(TName_combobox);
            Reg_panel.Controls.Add(label9);
            Reg_panel.Controls.Add(Close);
            Reg_panel.Controls.Add(Open);
            Reg_panel.Controls.Add(dataGridView1);
            Reg_panel.Location = new Point(489, 36);
            Reg_panel.Name = "Reg_panel";
            Reg_panel.Size = new Size(716, 587);
            Reg_panel.TabIndex = 25;
            // 
            // Refresh
            // 
            Refresh.BackgroundImage = Properties.Resources.dark_purple_colour;
            Refresh.Font = new Font("Segoe UI", 14F);
            Refresh.ForeColor = SystemColors.ButtonHighlight;
            Refresh.Location = new Point(546, 496);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(123, 54);
            Refresh.TabIndex = 5;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // TName_combobox
            // 
            TName_combobox.FormattingEnabled = true;
            TName_combobox.Location = new Point(286, 374);
            TName_combobox.Name = "TName_combobox";
            TName_combobox.Size = new Size(257, 33);
            TName_combobox.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(24, 373);
            label9.Name = "label9";
            label9.Size = new Size(247, 38);
            label9.TabIndex = 3;
            label9.Text = "Tournament Name";
            // 
            // Close
            // 
            Close.AutoSize = true;
            Close.Font = new Font("Segoe UI", 12F);
            Close.Location = new Point(335, 496);
            Close.Name = "Close";
            Close.Size = new Size(98, 36);
            Close.TabIndex = 2;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.CheckedChanged += Close_CheckedChanged;
            // 
            // Open
            // 
            Open.AutoSize = true;
            Open.Font = new Font("Segoe UI", 12F);
            Open.Location = new Point(335, 450);
            Open.Name = "Open";
            Open.Size = new Size(99, 36);
            Open.TabIndex = 1;
            Open.Text = "Open";
            Open.UseVisualStyleBackColor = true;
            Open.CheckedChanged += Open_CheckedChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 13);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(693, 340);
            dataGridView1.TabIndex = 0;
            // 
            // Add_Tournament_val
            // 
            Add_Tournament_val.BackColor = Color.FromArgb(186, 186, 212);
            Add_Tournament_val.BackgroundImage = Properties.Resources.dark_purple_colour;
            Add_Tournament_val.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Add_Tournament_val.ForeColor = SystemColors.ButtonHighlight;
            Add_Tournament_val.Location = new Point(192, 511);
            Add_Tournament_val.Name = "Add_Tournament_val";
            Add_Tournament_val.Size = new Size(324, 56);
            Add_Tournament_val.TabIndex = 25;
            Add_Tournament_val.Text = "Add Tournament";
            Add_Tournament_val.UseVisualStyleBackColor = false;
            Add_Tournament_val.Click += Add_Tournament_val_Click;
            // 
            // PMoney
            // 
            PMoney.Font = new Font("Segoe UI", 12F);
            PMoney.Location = new Point(298, 438);
            PMoney.Name = "PMoney";
            PMoney.Size = new Size(363, 39);
            PMoney.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(27, 439);
            label8.Name = "label8";
            label8.Size = new Size(172, 38);
            label8.TabIndex = 11;
            label8.Text = "Prize Money";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(298, 362);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(27, 362);
            label7.Name = "label7";
            label7.Size = new Size(139, 38);
            label7.TabIndex = 9;
            label7.Text = "Start Date";
            // 
            // Region
            // 
            Region.Font = new Font("Segoe UI", 12F);
            Region.FormattingEnabled = true;
            Region.Location = new Point(298, 288);
            Region.Name = "Region";
            Region.Size = new Size(363, 40);
            Region.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(27, 290);
            label6.Name = "label6";
            label6.Size = new Size(103, 38);
            label6.TabIndex = 7;
            label6.Text = "Region";
            // 
            // Type
            // 
            Type.Font = new Font("Segoe UI", 12F);
            Type.FormattingEnabled = true;
            Type.Location = new Point(298, 215);
            Type.Name = "Type";
            Type.Size = new Size(363, 40);
            Type.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(27, 217);
            label5.Name = "label5";
            label5.Size = new Size(231, 38);
            label5.TabIndex = 5;
            label5.Text = "Tournament Type";
            // 
            // Capacity
            // 
            Capacity.Font = new Font("Segoe UI", 12F);
            Capacity.Location = new Point(298, 149);
            Capacity.Name = "Capacity";
            Capacity.Size = new Size(363, 39);
            Capacity.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(27, 150);
            label4.Name = "label4";
            label4.Size = new Size(121, 38);
            label4.TabIndex = 3;
            label4.Text = "Capacity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(192, 0);
            label3.Name = "label3";
            label3.Size = new Size(304, 48);
            label3.TabIndex = 2;
            label3.Text = "Add Tournament";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(27, 81);
            label2.Name = "label2";
            label2.Size = new Size(247, 38);
            label2.TabIndex = 1;
            label2.Text = "Tournament Name";
            // 
            // TName
            // 
            TName.Font = new Font("Segoe UI", 12F);
            TName.Location = new Point(298, 80);
            TName.Name = "TName";
            TName.Size = new Size(363, 39);
            TName.TabIndex = 0;
            // 
            // StoreMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.solid_color_image__1_;
            ClientSize = new Size(1204, 622);
            Controls.Add(Add_Tournament_Panel);
            Controls.Add(ExitButton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StoreMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StoreMain";
            Load += StoreMain_Load;
            ((System.ComponentModel.ISupportInitialize)Store_Info).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Add_Tournament_Panel.ResumeLayout(false);
            Add_Tournament_Panel.PerformLayout();
            Reg_panel.ResumeLayout(false);
            Reg_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Store_Info;
        private Panel panel1;
        private Label Welcome;
        private Button Manage_Inventory;
        private Button Promotions;
        private Button Add_Tournament;
        private Label ExitButton;
        private Button LogOutButton;
        private Label label1;
        private Panel Add_Tournament_Panel;
        private TextBox TName;
        private Label label2;
        private Label label5;
        private TextBox Capacity;
        private Label label4;
        private Label label3;
        private Label label7;
        private ComboBox Region;
        private Label label6;
        private ComboBox Type;
        private DateTimePicker dateTimePicker1;
        private Button Add_Tournament_val;
        private TextBox PMoney;
        private Label label8;
        private Button Manage_Partner;
        private Button Manage_TReg;
        private Panel Reg_panel;
        private CheckBox Open;
        private DataGridView dataGridView1;
        private Label label9;
        private CheckBox Close;
        private ComboBox TName_combobox;
        private Button Refresh;
    }
}