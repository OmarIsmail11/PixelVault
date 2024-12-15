namespace PixelVaultGUI
{
    partial class Admin
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
            addmin = new Button();
            textBox1 = new TextBox();
            admin_username = new TextBox();
            label1 = new Label();
            label2 = new Label();
            addman = new Button();
            button3 = new Button();
            Manname = new TextBox();
            headman = new TextBox();
            label3 = new Label();
            label4 = new Label();
            engname = new TextBox();
            englan = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            engplat = new ComboBox();
            addcon = new Button();
            addstor = new Button();
            storname = new TextBox();
            conname = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            manname1 = new ComboBox();
            addpub = new Button();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            storhot = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            storrat = new TrackBar();
            pubname = new TextBox();
            pubtype = new ComboBox();
            condate = new DateTimePicker();
            pubdate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)storrat).BeginInit();
            SuspendLayout();
            // 
            // addmin
            // 
            addmin.Location = new Point(158, 205);
            addmin.Name = "addmin";
            addmin.Size = new Size(186, 34);
            addmin.TabIndex = 0;
            addmin.Text = "Add Admin";
            addmin.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 141);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(186, 31);
            textBox1.TabIndex = 1;
            // 
            // admin_username
            // 
            admin_username.Location = new Point(158, 83);
            admin_username.Name = "admin_username";
            admin_username.Size = new Size(186, 31);
            admin_username.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 86);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 3;
            label1.Text = "Enter Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 147);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 4;
            label2.Text = "Enter Password";
            // 
            // addman
            // 
            addman.Location = new Point(507, 205);
            addman.Name = "addman";
            addman.Size = new Size(196, 34);
            addman.TabIndex = 5;
            addman.Text = "Add Manufacturer";
            addman.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(919, 242);
            button3.Name = "button3";
            button3.Size = new Size(207, 34);
            button3.TabIndex = 6;
            button3.Text = "Add Game Engine";
            button3.UseVisualStyleBackColor = true;
            // 
            // Manname
            // 
            Manname.Location = new Point(507, 80);
            Manname.Name = "Manname";
            Manname.Size = new Size(196, 31);
            Manname.TabIndex = 7;
            // 
            // headman
            // 
            headman.Location = new Point(507, 134);
            headman.Name = "headman";
            headman.Size = new Size(196, 31);
            headman.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 83);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 9;
            label3.Text = "Enter Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(382, 134);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 10;
            label4.Text = "Headquarters";
            // 
            // engname
            // 
            engname.Location = new Point(919, 77);
            engname.Name = "engname";
            engname.Size = new Size(207, 31);
            engname.TabIndex = 12;
            // 
            // englan
            // 
            englan.Location = new Point(919, 183);
            englan.Name = "englan";
            englan.Size = new Size(207, 31);
            englan.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(765, 80);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 14;
            label5.Text = "Engine Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(765, 131);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 15;
            label6.Text = "Platform";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(765, 186);
            label7.Name = "label7";
            label7.Size = new Size(134, 25);
            label7.TabIndex = 16;
            label7.Text = "Language Used";
            // 
            // engplat
            // 
            engplat.FormattingEnabled = true;
            engplat.Items.AddRange(new object[] { "Cross-Platform", "Mobile", "Windows", "Playstation" });
            engplat.Location = new Point(919, 131);
            engplat.Name = "engplat";
            engplat.Size = new Size(207, 33);
            engplat.TabIndex = 17;
            // 
            // addcon
            // 
            addcon.Location = new Point(158, 497);
            addcon.Name = "addcon";
            addcon.Size = new Size(186, 34);
            addcon.TabIndex = 18;
            addcon.Text = "Add Console";
            addcon.UseVisualStyleBackColor = true;
            // 
            // addstor
            // 
            addstor.Location = new Point(507, 508);
            addstor.Name = "addstor";
            addstor.Size = new Size(196, 34);
            addstor.TabIndex = 19;
            addstor.Text = "Add Game Store";
            addstor.UseVisualStyleBackColor = true;
            // 
            // storname
            // 
            storname.Location = new Point(507, 323);
            storname.Name = "storname";
            storname.Size = new Size(196, 31);
            storname.TabIndex = 20;
            // 
            // conname
            // 
            conname.Location = new Point(158, 323);
            conname.Name = "conname";
            conname.Size = new Size(186, 31);
            conname.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 383);
            label8.Name = "label8";
            label8.Size = new Size(112, 25);
            label8.TabIndex = 23;
            label8.Text = "Release Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 329);
            label9.Name = "label9";
            label9.Size = new Size(128, 25);
            label9.TabIndex = 24;
            label9.Text = "Console Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 441);
            label10.Name = "label10";
            label10.Size = new Size(123, 25);
            label10.TabIndex = 25;
            label10.Text = "Developed by";
            // 
            // manname1
            // 
            manname1.FormattingEnabled = true;
            manname1.Location = new Point(158, 433);
            manname1.Name = "manname1";
            manname1.Size = new Size(186, 33);
            manname1.TabIndex = 26;
            // 
            // addpub
            // 
            addpub.Location = new Point(919, 508);
            addpub.Name = "addpub";
            addpub.Size = new Size(207, 34);
            addpub.TabIndex = 27;
            addpub.Text = "Add Game Publisher";
            addpub.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(765, 329);
            label11.Name = "label11";
            label11.Size = new Size(136, 25);
            label11.TabIndex = 28;
            label11.Text = "Publisher Name";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(765, 383);
            label12.Name = "label12";
            label12.Size = new Size(90, 25);
            label12.TabIndex = 29;
            label12.Text = "Start Date";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(765, 441);
            label13.Name = "label13";
            label13.Size = new Size(118, 25);
            label13.TabIndex = 30;
            label13.Text = "Console Type";
            // 
            // storhot
            // 
            storhot.Location = new Point(507, 383);
            storhot.Name = "storhot";
            storhot.Size = new Size(196, 31);
            storhot.TabIndex = 31;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(382, 329);
            label14.Name = "label14";
            label14.Size = new Size(105, 25);
            label14.TabIndex = 32;
            label14.Text = "Store Name";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(382, 441);
            label15.Name = "label15";
            label15.Size = new Size(63, 25);
            label15.TabIndex = 33;
            label15.Text = "Rating";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(382, 386);
            label16.Name = "label16";
            label16.Size = new Size(69, 25);
            label16.TabIndex = 34;
            label16.Text = "Hotline";
            // 
            // storrat
            // 
            storrat.Location = new Point(507, 433);
            storrat.Name = "storrat";
            storrat.Size = new Size(196, 69);
            storrat.TabIndex = 35;
            // 
            // pubname
            // 
            pubname.Location = new Point(919, 329);
            pubname.Name = "pubname";
            pubname.Size = new Size(207, 31);
            pubname.TabIndex = 36;
            // 
            // pubtype
            // 
            pubtype.FormattingEnabled = true;
            pubtype.Items.AddRange(new object[] { "Playstation", "Windows", "Nintendo" });
            pubtype.Location = new Point(919, 441);
            pubtype.Name = "pubtype";
            pubtype.Size = new Size(207, 33);
            pubtype.TabIndex = 37;
            // 
            // condate
            // 
            condate.Location = new Point(158, 377);
            condate.Name = "condate";
            condate.Size = new Size(186, 31);
            condate.TabIndex = 38;
            // 
            // pubdate
            // 
            pubdate.Location = new Point(919, 386);
            pubdate.Name = "pubdate";
            pubdate.Size = new Size(207, 31);
            pubdate.TabIndex = 39;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 631);
            Controls.Add(pubdate);
            Controls.Add(condate);
            Controls.Add(pubtype);
            Controls.Add(pubname);
            Controls.Add(storrat);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(storhot);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(addpub);
            Controls.Add(manname1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(conname);
            Controls.Add(storname);
            Controls.Add(addstor);
            Controls.Add(addcon);
            Controls.Add(engplat);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(englan);
            Controls.Add(engname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(headman);
            Controls.Add(Manname);
            Controls.Add(button3);
            Controls.Add(addman);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(admin_username);
            Controls.Add(textBox1);
            Controls.Add(addmin);
            Name = "Admin";
            Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)storrat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addmin;
        private TextBox textBox1;
        private TextBox admin_username;
        private Label label1;
        private Label label2;
        private Button addman;
        private Button button3;
        private TextBox Manname;
        private TextBox headman;
        private Label label3;
        private Label label4;
        private TextBox engname;
        private TextBox englan;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox engplat;
        private Button addcon;
        private Button addstor;
        private TextBox storname;
        private TextBox conname;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox manname1;
        private Button addpub;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox storhot;
        private Label label14;
        private Label label15;
        private Label label16;
        private TrackBar storrat;
        private TextBox pubname;
        private ComboBox pubtype;
        private DateTimePicker condate;
        private DateTimePicker pubdate;
    }
}