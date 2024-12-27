namespace PixelVaultGUI
{
    partial class PublisherGames
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
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ExitButton = new Label();
            panel2 = new Panel();
            groupBox3 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            groupBox4 = new GroupBox();
            label3 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            PublishGameButton = new Button();
            RefreshListButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(34, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(1575, 515);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = Properties.Resources.dark_purple_colour1;
            label1.Location = new Point(39, 21);
            label1.Name = "label1";
            label1.Size = new Size(312, 50);
            label1.TabIndex = 1;
            label1.Text = "Published Games";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1498, 378);
            dataGridView1.TabIndex = 0;
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ButtonHighlight;
            ExitButton.Image = Properties.Resources.dark_purple_colour;
            ExitButton.Location = new Point(1586, 0);
            ExitButton.Margin = new Padding(5, 0, 5, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(54, 60);
            ExitButton.TabIndex = 18;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel2.Controls.Add(RefreshListButton);
            panel2.Controls.Add(groupBox3);
            panel2.Controls.Add(groupBox4);
            panel2.Controls.Add(PublishGameButton);
            panel2.Location = new Point(34, 615);
            panel2.Name = "panel2";
            panel2.Size = new Size(1575, 379);
            panel2.TabIndex = 22;
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = Properties.Resources.dark_purple_colour;
            groupBox3.Controls.Add(radioButton4);
            groupBox3.Controls.Add(radioButton5);
            groupBox3.Controls.Add(radioButton6);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.ButtonFace;
            groupBox3.Location = new Point(624, 27);
            groupBox3.Margin = new Padding(5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5);
            groupBox3.Size = new Size(375, 303);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order by";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackgroundImage = Properties.Resources.dark_purple_colour;
            radioButton4.Location = new Point(27, 235);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(331, 49);
            radioButton4.TabIndex = 10;
            radioButton4.TabStop = true;
            radioButton4.Text = "Number of Players";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AccessibleRole = AccessibleRole.TitleBar;
            radioButton5.AutoSize = true;
            radioButton5.BackgroundImage = Properties.Resources.dark_purple_colour1;
            radioButton5.Location = new Point(27, 70);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(225, 49);
            radioButton5.TabIndex = 8;
            radioButton5.TabStop = true;
            radioButton5.Text = "User Rating";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.BackgroundImage = Properties.Resources.dark_purple_colour;
            radioButton6.Location = new Point(27, 141);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(149, 49);
            radioButton6.TabIndex = 9;
            radioButton6.TabStop = true;
            radioButton6.Text = "Rating";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.BackgroundImage = Properties.Resources.dark_purple_colour;
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label13);
            groupBox4.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.ButtonHighlight;
            groupBox4.Location = new Point(1021, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(487, 354);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Most Trending";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Image = Properties.Resources.dark_purple_colour;
            label3.Location = new Point(212, 130);
            label3.Name = "label3";
            label3.Size = new Size(110, 45);
            label3.TabIndex = 7;
            label3.Text = "label7";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Window;
            label7.Image = Properties.Resources.solid_color_image;
            label7.Location = new Point(29, 57);
            label7.Name = "label7";
            label7.Size = new Size(124, 45);
            label7.TabIndex = 0;
            label7.Text = "Game :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Image = Properties.Resources.dark_purple_colour;
            label8.Location = new Point(29, 130);
            label8.Name = "label8";
            label8.Size = new Size(127, 45);
            label8.TabIndex = 6;
            label8.Text = "Genre :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.Window;
            label9.Image = Properties.Resources.solid_color_image;
            label9.Location = new Point(212, 57);
            label9.Name = "label9";
            label9.Size = new Size(110, 45);
            label9.TabIndex = 0;
            label9.Text = "label3";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Image = Properties.Resources.dark_purple_colour;
            label10.Location = new Point(212, 285);
            label10.Name = "label10";
            label10.Size = new Size(110, 45);
            label10.TabIndex = 5;
            label10.Text = "label7";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Image = Properties.Resources.dark_purple_colour;
            label11.Location = new Point(29, 206);
            label11.Name = "label11";
            label11.Size = new Size(139, 45);
            label11.TabIndex = 2;
            label11.Text = "Engine :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Image = Properties.Resources.dark_purple_colour;
            label12.Location = new Point(29, 285);
            label12.Name = "label12";
            label12.Size = new Size(170, 45);
            label12.TabIndex = 4;
            label12.Text = "Platform :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Image = Properties.Resources.dark_purple_colour;
            label13.Location = new Point(212, 206);
            label13.Name = "label13";
            label13.Size = new Size(110, 45);
            label13.TabIndex = 3;
            label13.Text = "label5";
            // 
            // PublishGameButton
            // 
            PublishGameButton.BackColor = Color.FromArgb(186, 186, 212);
            PublishGameButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            PublishGameButton.Location = new Point(22, 27);
            PublishGameButton.Name = "PublishGameButton";
            PublishGameButton.Size = new Size(413, 104);
            PublishGameButton.TabIndex = 2;
            PublishGameButton.Text = "Publish Game";
            PublishGameButton.UseVisualStyleBackColor = false;
            PublishGameButton.Click += PublishGameButton_Click;
            // 
            // RefreshListButton
            // 
            RefreshListButton.BackColor = Color.FromArgb(186, 186, 212);
            RefreshListButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            RefreshListButton.Location = new Point(22, 206);
            RefreshListButton.Name = "RefreshListButton";
            RefreshListButton.Size = new Size(413, 104);
            RefreshListButton.TabIndex = 8;
            RefreshListButton.Text = "Refresh List";
            RefreshListButton.UseVisualStyleBackColor = false;
            RefreshListButton.Click += RefreshListButton_Click;
            // 
            // PublisherGames
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 188, 212);
            Controls.Add(panel2);
            Controls.Add(ExitButton);
            Controls.Add(panel1);
            Margin = new Padding(5);
            Name = "PublisherGames";
            Size = new Size(1643, 1045);
            Load += PublisherGames_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label ExitButton;
        private Panel panel2;
        private GroupBox groupBox3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private GroupBox groupBox4;
        private Label label3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button PublishGameButton;
        private Button RefreshListButton;
    }
}
