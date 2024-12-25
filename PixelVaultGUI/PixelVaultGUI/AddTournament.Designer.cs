namespace PixelVaultGUI
{
    partial class AddTournament
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Add_Tournament_Panel = new Panel();
            GameName = new ComboBox();
            label1 = new Label();
            ExitButton = new Label();
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
            Add_Tournament_Panel.SuspendLayout();
            SuspendLayout();
            // 
            // Add_Tournament_Panel
            // 
            Add_Tournament_Panel.BackColor = Color.Transparent;
            Add_Tournament_Panel.BackgroundImage = Properties.Resources.solid_color_image__1_;
            Add_Tournament_Panel.Controls.Add(GameName);
            Add_Tournament_Panel.Controls.Add(label1);
            Add_Tournament_Panel.Controls.Add(ExitButton);
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
            Add_Tournament_Panel.Location = new Point(3, 3);
            Add_Tournament_Panel.Name = "Add_Tournament_Panel";
            Add_Tournament_Panel.Size = new Size(800, 610);
            Add_Tournament_Panel.TabIndex = 28;
            Add_Tournament_Panel.Paint += Add_Tournament_Panel_Paint;
            // 
            // GameName
            // 
            GameName.Font = new Font("Segoe UI", 12F);
            GameName.FormattingEnabled = true;
            GameName.Location = new Point(220, 154);
            GameName.Name = "GameName";
            GameName.Size = new Size(250, 40);
            GameName.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(31, 152);
            label1.Name = "label1";
            label1.Size = new Size(171, 38);
            label1.TabIndex = 27;
            label1.Text = "Game Name";
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ActiveCaptionText;
            ExitButton.Image = Properties.Resources.solid_color_image__1_;
            ExitButton.Location = new Point(714, 0);
            ExitButton.Margin = new Padding(4, 0, 4, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(42, 45);
            ExitButton.TabIndex = 26;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // Add_Tournament_val
            // 
            Add_Tournament_val.BackColor = Color.FromArgb(186, 186, 212);
            Add_Tournament_val.BackgroundImage = Properties.Resources.dark_purple_colour;
            Add_Tournament_val.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            Add_Tournament_val.ForeColor = SystemColors.ButtonHighlight;
            Add_Tournament_val.Location = new Point(531, 263);
            Add_Tournament_val.Name = "Add_Tournament_val";
            Add_Tournament_val.Size = new Size(216, 111);
            Add_Tournament_val.TabIndex = 25;
            Add_Tournament_val.Text = "Add \r\nTournament";
            Add_Tournament_val.UseVisualStyleBackColor = false;
            Add_Tournament_val.Click += Add_Tournament_val_Click;
            // 
            // PMoney
            // 
            PMoney.Font = new Font("Segoe UI", 12F);
            PMoney.Location = new Point(220, 478);
            PMoney.Name = "PMoney";
            PMoney.Size = new Size(250, 39);
            PMoney.TabIndex = 12;
            
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F);
            label8.Location = new Point(31, 476);
            label8.Name = "label8";
            label8.Size = new Size(172, 38);
            label8.TabIndex = 11;
            label8.Text = "Prize Money";
            label8.Click += label8_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(176, 307);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(294, 31);
            dateTimePicker1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(31, 300);
            label7.Name = "label7";
            label7.Size = new Size(139, 38);
            label7.TabIndex = 9;
            label7.Text = "Start Date";
            // 
            // Region
            // 
            Region.Font = new Font("Segoe UI", 12F);
            Region.FormattingEnabled = true;
            Region.Location = new Point(167, 420);
            Region.Name = "Region";
            Region.Size = new Size(303, 40);
            Region.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(31, 418);
            label6.Name = "label6";
            label6.Size = new Size(103, 38);
            label6.TabIndex = 7;
            label6.Text = "Region";
            // 
            // Type
            // 
            Type.Font = new Font("Segoe UI", 12F);
            Type.FormattingEnabled = true;
            Type.Location = new Point(268, 226);
            Type.Name = "Type";
            Type.Size = new Size(202, 40);
            Type.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(31, 224);
            label5.Name = "label5";
            label5.Size = new Size(231, 38);
            label5.TabIndex = 5;
            label5.Text = "Tournament Type";
            // 
            // Capacity
            // 
            Capacity.Font = new Font("Segoe UI", 12F);
            Capacity.Location = new Point(167, 356);
            Capacity.Name = "Capacity";
            Capacity.Size = new Size(303, 39);
            Capacity.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(31, 354);
            label4.Name = "label4";
            label4.Size = new Size(121, 38);
            label4.TabIndex = 3;
            label4.Text = "Capacity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(207, 21);
            label3.Name = "label3";
            label3.Size = new Size(304, 48);
            label3.TabIndex = 2;
            label3.Text = "Add Tournament";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(31, 88);
            label2.Name = "label2";
            label2.Size = new Size(247, 38);
            label2.TabIndex = 1;
            label2.Text = "Tournament Name";
            // 
            // TName
            // 
            TName.Font = new Font("Segoe UI", 12F);
            TName.Location = new Point(284, 90);
            TName.Name = "TName";
            TName.Size = new Size(186, 39);
            TName.TabIndex = 0;
            // 
            // AddTournament
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Add_Tournament_Panel);
            Name = "AddTournament";
            Size = new Size(800, 610);
            Add_Tournament_Panel.ResumeLayout(false);
            Add_Tournament_Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Add_Tournament_Panel;
        private ComboBox GameName;
        private Label label1;
        private Label ExitButton;
        private Button Add_Tournament_val;
        private TextBox PMoney;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private ComboBox Region;
        private Label label6;
        private ComboBox Type;
        private Label label5;
        private TextBox Capacity;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TName;
    }
}
