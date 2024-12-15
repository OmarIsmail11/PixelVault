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
            label1.Location = new Point(60, 97);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 5;
            label1.Text = "Select Publisher";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 165);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 6;
            label2.Text = "Select Game Store";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 241);
            label3.Name = "label3";
            label3.Size = new Size(127, 25);
            label3.TabIndex = 7;
            label3.Text = "Select Console";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 315);
            label4.Name = "label4";
            label4.Size = new Size(168, 25);
            label4.TabIndex = 8;
            label4.Text = "Select Manufacturer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 377);
            label5.Name = "label5";
            label5.Size = new Size(167, 25);
            label5.TabIndex = 9;
            label5.Text = "Select Game Engine";
            // 
            // remeng
            // 
            remeng.Location = new Point(512, 372);
            remeng.Name = "remeng";
            remeng.Size = new Size(208, 34);
            remeng.TabIndex = 10;
            remeng.Text = "Remove Engine";
            remeng.UseVisualStyleBackColor = true;
            remeng.Click += remeng_Click;
            // 
            // remman
            // 
            remman.Location = new Point(512, 310);
            remman.Name = "remman";
            remman.Size = new Size(208, 34);
            remman.TabIndex = 11;
            remman.Text = "Remove Manufacturer";
            remman.UseVisualStyleBackColor = true;
            remman.Click += remman_Click;
            // 
            // remstor
            // 
            remstor.Location = new Point(512, 160);
            remstor.Name = "remstor";
            remstor.Size = new Size(208, 34);
            remstor.TabIndex = 12;
            remstor.Text = "Remove Store";
            remstor.UseVisualStyleBackColor = true;
            remstor.Click += remstor_Click;
            // 
            // remcon
            // 
            remcon.Location = new Point(512, 232);
            remcon.Name = "remcon";
            remcon.Size = new Size(208, 34);
            remcon.TabIndex = 13;
            remcon.Text = "Remove Console";
            remcon.UseVisualStyleBackColor = true;
            remcon.Click += remcon_Click;
            // 
            // rempub
            // 
            rempub.Location = new Point(512, 88);
            rempub.Name = "rempub";
            rempub.Size = new Size(208, 34);
            rempub.TabIndex = 14;
            rempub.Text = "Remove Publisher";
            rempub.UseVisualStyleBackColor = true;
            rempub.Click += rempub_Click;
            // 
            // remgamer
            // 
            remgamer.Location = new Point(512, 439);
            remgamer.Name = "remgamer";
            remgamer.Size = new Size(208, 34);
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
            label6.Location = new Point(60, 444);
            label6.Name = "label6";
            label6.Size = new Size(115, 25);
            label6.TabIndex = 17;
            label6.Text = "Select Gamer";
            // 
            // remrev
            // 
            remrev.Location = new Point(512, 497);
            remrev.Name = "remrev";
            remrev.Size = new Size(208, 34);
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
            label7.Location = new Point(60, 505);
            label7.Name = "label7";
            label7.Size = new Size(183, 25);
            label7.TabIndex = 21;
            label7.Text = "Select Game Reviewer";
            // 
            // Remove
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(996, 609);
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
            Controls.Add(remeng);
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
            Name = "Remove";
            Text = "Remove";
            Load += Remove_Load;
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
    }
}