namespace PixelVaultGUI
{
    partial class Remove
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
            man = new ComboBox();
            con = new ComboBox();
            pub = new ComboBox();
            eng = new ComboBox();
            stor = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            remeng = new Button();
            remman = new Button();
            remstor = new Button();
            remcon = new Button();
            rempub = new Button();
            remgamer = new Button();
            gamer = new ComboBox();
            label6 = new Label();
            remrev = new Button();
            rev = new ComboBox();
            label7 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // man
            // 
            man.FormattingEnabled = true;
            man.Location = new Point(264, 306);
            man.Name = "man";
            man.Size = new Size(182, 33);
            man.TabIndex = 0;
            // 
            // con
            // 
            con.FormattingEnabled = true;
            con.Location = new Point(264, 230);
            con.Name = "con";
            con.Size = new Size(182, 33);
            con.TabIndex = 1;
            // 
            // pub
            // 
            pub.FormattingEnabled = true;
            pub.Location = new Point(264, 89);
            pub.Name = "pub";
            pub.Size = new Size(182, 33);
            pub.TabIndex = 2;
            // 
            // eng
            // 
            eng.FormattingEnabled = true;
            eng.Location = new Point(264, 369);
            eng.Name = "eng";
            eng.Size = new Size(182, 33);
            eng.TabIndex = 3;
            // 
            // stor
            // 
            stor.FormattingEnabled = true;
            stor.Location = new Point(264, 156);
            stor.Name = "stor";
            stor.Size = new Size(182, 33);
            stor.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = Properties.Resources.solid_color_image;
            label1.Location = new Point(26, 94);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 5;
            label1.Text = "Select Publisher";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Image = Properties.Resources.solid_color_image;
            label2.Location = new Point(26, 162);
            label2.Name = "label2";
            label2.Size = new Size(185, 28);
            label2.TabIndex = 6;
            label2.Text = "Select Game Store";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Image = Properties.Resources.solid_color_image;
            label3.Location = new Point(26, 238);
            label3.Name = "label3";
            label3.Size = new Size(149, 28);
            label3.TabIndex = 7;
            label3.Text = "Select Console";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Image = Properties.Resources.solid_color_image;
            label4.Location = new Point(26, 312);
            label4.Name = "label4";
            label4.Size = new Size(205, 28);
            label4.TabIndex = 8;
            label4.Text = "Select Manufacturer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Image = Properties.Resources.solid_color_image;
            label5.Location = new Point(26, 374);
            label5.Name = "label5";
            label5.Size = new Size(199, 28);
            label5.TabIndex = 9;
            label5.Text = "Select Game Engine";
            // 
            // remeng
            // 
            remeng.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            remeng.ForeColor = SystemColors.ActiveCaptionText;
            remeng.Image = Properties.Resources.solid_color_image__1_;
            remeng.Location = new Point(510, 368);
            remeng.Name = "remeng";
            remeng.Size = new Size(208, 40);
            remeng.TabIndex = 10;
            remeng.Text = "Remove Engine";
            remeng.UseVisualStyleBackColor = true;
            remeng.Click += remeng_Click;
            // 
            // remman
            // 
            remman.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            remman.ForeColor = SystemColors.ActiveCaptionText;
            remman.Image = Properties.Resources.solid_color_image__1_;
            remman.Location = new Point(512, 287);
            remman.Name = "remman";
            remman.Size = new Size(208, 67);
            remman.TabIndex = 11;
            remman.Text = "Remove Manufacturer";
            remman.UseVisualStyleBackColor = true;
            remman.Click += remman_Click;
            // 
            // remstor
            // 
            remstor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            remstor.ForeColor = SystemColors.ActiveCaptionText;
            remstor.Image = Properties.Resources.solid_color_image__1_;
            remstor.Location = new Point(512, 155);
            remstor.Name = "remstor";
            remstor.Size = new Size(208, 43);
            remstor.TabIndex = 12;
            remstor.Text = "Remove Store";
            remstor.UseVisualStyleBackColor = true;
            remstor.Click += remstor_Click;
            // 
            // remcon
            // 
            remcon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            remcon.ForeColor = SystemColors.ActiveCaptionText;
            remcon.Image = Properties.Resources.solid_color_image__1_;
            remcon.Location = new Point(512, 222);
            remcon.Name = "remcon";
            remcon.Size = new Size(208, 45);
            remcon.TabIndex = 13;
            remcon.Text = "Remove Console";
            remcon.UseVisualStyleBackColor = true;
            remcon.Click += remcon_Click;
            // 
            // rempub
            // 
            rempub.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rempub.ForeColor = SystemColors.ActiveCaptionText;
            rempub.Image = Properties.Resources.solid_color_image__1_;
            rempub.Location = new Point(512, 80);
            rempub.Name = "rempub";
            rempub.Size = new Size(208, 46);
            rempub.TabIndex = 14;
            rempub.Text = "Remove Publisher";
            rempub.UseVisualStyleBackColor = true;
            rempub.Click += rempub_Click;
            // 
            // remgamer
            // 
            remgamer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            remgamer.ForeColor = SystemColors.ActiveCaptionText;
            remgamer.Image = Properties.Resources.solid_color_image__1_;
            remgamer.Location = new Point(512, 429);
            remgamer.Name = "remgamer";
            remgamer.Size = new Size(208, 40);
            remgamer.TabIndex = 15;
            remgamer.Text = "Remove Gamer";
            remgamer.UseVisualStyleBackColor = true;
            remgamer.Click += remgamer_Click;
            // 
            // gamer
            // 
            gamer.FormattingEnabled = true;
            gamer.Location = new Point(264, 436);
            gamer.Name = "gamer";
            gamer.Size = new Size(182, 33);
            gamer.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Image = Properties.Resources.solid_color_image;
            label6.Location = new Point(26, 441);
            label6.Name = "label6";
            label6.Size = new Size(137, 28);
            label6.TabIndex = 17;
            label6.Text = "Select Gamer";
            // 
            // remrev
            // 
            remrev.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            remrev.ForeColor = SystemColors.ActiveCaptionText;
            remrev.Image = Properties.Resources.solid_color_image__1_;
            remrev.Location = new Point(512, 490);
            remrev.Name = "remrev";
            remrev.Size = new Size(208, 40);
            remrev.TabIndex = 18;
            remrev.Text = "Remove Reviewer";
            remrev.UseVisualStyleBackColor = true;
            remrev.Click += remrev_Click;
            // 
            // rev
            // 
            rev.FormattingEnabled = true;
            rev.Location = new Point(264, 497);
            rev.Name = "rev";
            rev.Size = new Size(182, 33);
            rev.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Image = Properties.Resources.solid_color_image;
            label7.Location = new Point(26, 502);
            label7.Name = "label7";
            label7.Size = new Size(222, 28);
            label7.TabIndex = 21;
            label7.Text = "Select Game Reviewer";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.solid_color_image;
            panel1.Controls.Add(remeng);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 608);
            panel1.TabIndex = 22;
            // 
            // Remove
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 609);
            Controls.Add(label7);
            Controls.Add(rev);
            Controls.Add(remrev);
            Controls.Add(label6);
            Controls.Add(gamer);
            Controls.Add(remgamer);
            Controls.Add(rempub);
            Controls.Add(remcon);
            Controls.Add(remstor);
            Controls.Add(remman);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(stor);
            Controls.Add(eng);
            Controls.Add(pub);
            Controls.Add(con);
            Controls.Add(man);
            Controls.Add(panel1);
            Name = "Remove";
            Text = "Remove";
            Load += Remove_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox man;
        private ComboBox con;
        private ComboBox pub;
        private ComboBox eng;
        private ComboBox stor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button remeng;
        private Button remman;
        private Button remstor;
        private Button remcon;
        private Button rempub;
        private Button remgamer;
        private ComboBox gamer;
        private Label label6;
        private Button remrev;
        private ComboBox rev;
        private Label label7;
        private Panel panel1;
    }
}