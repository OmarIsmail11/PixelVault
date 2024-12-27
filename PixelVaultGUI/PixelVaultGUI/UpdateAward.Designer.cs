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
            GameNametext = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AwardNametext = new TextBox();
            button1 = new Button();
            AwardYearText = new TextBox();
            SuspendLayout();
            // 
            // GameNametext
            // 
            GameNametext.Location = new Point(331, 91);
            GameNametext.Name = "GameNametext";
            GameNametext.Size = new Size(291, 39);
            GameNametext.TabIndex = 0;
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
            // AwardNametext
            // 
            AwardNametext.Location = new Point(331, 310);
            AwardNametext.Name = "AwardNametext";
            AwardNametext.Size = new Size(291, 39);
            AwardNametext.TabIndex = 11;
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
            // UpdateAward
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dark_purple_colour;
            ClientSize = new Size(799, 653);
            Controls.Add(AwardYearText);
            Controls.Add(button1);
            Controls.Add(AwardNametext);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GameNametext);
            Name = "UpdateAward";
            Text = "UpdateAward";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox GameNametext;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox AwardNametext;
        private Button button1;
        private TextBox AwardYearText;
    }
}