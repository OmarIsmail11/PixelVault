namespace PixelVaultGUI
{
    partial class UpdateAward
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            AwardYearText = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = Properties.Resources.dark_purple_colour;
            label1.Location = new Point(12, 80);
            label1.Name = "label1";
            label1.Size = new Size(230, 50);
            label1.TabIndex = 8;
            label1.Text = "Game Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Image = Properties.Resources.dark_purple_colour;
            label2.Location = new Point(22, 188);
            label2.Name = "label2";
            label2.Size = new Size(227, 45);
            label2.TabIndex = 9;
            label2.Text = "Awarded Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Image = Properties.Resources.dark_purple_colour;
            label3.Location = new Point(22, 303);
            label3.Name = "label3";
            label3.Size = new Size(209, 45);
            label3.TabIndex = 10;
            label3.Text = "Award Name";
            // 
            // button1
            // 
            button1.BackColor = Color.Thistle;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(208, 474);
            button1.Name = "button1";
            button1.Size = new Size(341, 96);
            button1.TabIndex = 12;
            button1.Text = "Award Game";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AwardYearText
            // 
            AwardYearText.Location = new Point(331, 195);
            AwardYearText.Name = "AwardYearText";
            AwardYearText.Size = new Size(291, 39);
            AwardYearText.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(332, 310);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(297, 40);
            comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(332, 91);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(281, 40);
            comboBox2.TabIndex = 15;
            // 
            // UpdateAward
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dark_purple_colour;
            ClientSize = new Size(799, 653);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(AwardYearText);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateAward";
            Text = "UpdateAward";
            Load += UpdateAward_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox AwardYearText;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}