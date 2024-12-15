namespace PixelVaultGUI
{
    partial class Admin_Add
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            addstor = new Button();
            addpub = new Button();
            addcon = new Button();
            addrev = new Button();
            addeng = new Button();
            addman = new Button();
            addmin = new Button();
            manname1 = new ComboBox();
            engplat = new ComboBox();
            revdate = new DateTimePicker();
            condate = new DateTimePicker();
            storrate = new TrackBar();
            admin_username = new TextBox();
            adminpass = new TextBox();
            engname = new TextBox();
            englang = new TextBox();
            manname = new TextBox();
            pubname = new TextBox();
            revurl = new TextBox();
            conname = new TextBox();
            revname = new TextBox();
            label12 = new Label();
            pubdate = new DateTimePicker();
            label13 = new Label();
            storname = new TextBox();
            storhot = new TextBox();
            pubhead = new ComboBox();
            pubtype = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            manhead = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)storrate).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(392, 98);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "Headquarters";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 296);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 1;
            label2.Text = "Console Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1076, 49);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 2;
            label3.Text = "Reviewer Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1076, 111);
            label4.Name = "label4";
            label4.Size = new Size(43, 25);
            label4.TabIndex = 3;
            label4.Text = "URL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 52);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 4;
            label5.Text = "Enter Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(729, 110);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 5;
            label6.Text = "Platform";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(729, 46);
            label7.Name = "label7";
            label7.Size = new Size(117, 25);
            label7.TabIndex = 6;
            label7.Text = "Engine Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1076, 164);
            label8.Name = "label8";
            label8.Size = new Size(109, 25);
            label8.TabIndex = 7;
            label8.Text = "Launch Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 101);
            label9.Name = "label9";
            label9.Size = new Size(132, 25);
            label9.TabIndex = 8;
            label9.Text = "Enter Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 46);
            label10.Name = "label10";
            label10.Size = new Size(136, 25);
            label10.TabIndex = 9;
            label10.Text = "Enter Username";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(729, 161);
            label11.Name = "label11";
            label11.Size = new Size(130, 25);
            label11.TabIndex = 10;
            label11.Text = "language Used";
            // 
            // addstor
            // 
            addstor.Location = new Point(521, 494);
            addstor.Name = "addstor";
            addstor.Size = new Size(180, 34);
            addstor.TabIndex = 11;
            addstor.Text = "Add Game Store";
            addstor.UseVisualStyleBackColor = true;
            addstor.Click += addstor_Click_1;
            // 
            // addpub
            // 
            addpub.Location = new Point(879, 537);
            addpub.Name = "addpub";
            addpub.Size = new Size(231, 34);
            addpub.TabIndex = 12;
            addpub.Text = "Add Game Publisher";
            addpub.UseVisualStyleBackColor = true;
            addpub.Click += addpub_Click_1;
            // 
            // addcon
            // 
            addcon.Location = new Point(156, 487);
            addcon.Name = "addcon";
            addcon.Size = new Size(201, 34);
            addcon.TabIndex = 13;
            addcon.Text = "Add Console";
            addcon.UseVisualStyleBackColor = true;
            addcon.Click += addcon_Click_1;
            // 
            // addrev
            // 
            addrev.Location = new Point(1215, 213);
            addrev.Name = "addrev";
            addrev.Size = new Size(184, 34);
            addrev.TabIndex = 14;
            addrev.Text = "Add Game Reviewer";
            addrev.UseVisualStyleBackColor = true;
            addrev.Click += addrev_Click_1;
            // 
            // addeng
            // 
            addeng.Location = new Point(879, 213);
            addeng.Name = "addeng";
            addeng.Size = new Size(182, 34);
            addeng.TabIndex = 15;
            addeng.Text = "Add Game Engine";
            addeng.UseVisualStyleBackColor = true;
            addeng.Click += addeng_Click_1;
            // 
            // addman
            // 
            addman.Location = new Point(530, 155);
            addman.Name = "addman";
            addman.Size = new Size(171, 34);
            addman.TabIndex = 16;
            addman.Text = "Add Manufacturer";
            addman.UseVisualStyleBackColor = true;
            addman.Click += addman_Click_1;
            // 
            // addmin
            // 
            addmin.Location = new Point(188, 152);
            addmin.Name = "addmin";
            addmin.Size = new Size(169, 34);
            addmin.TabIndex = 17;
            addmin.Text = "Add Admin";
            addmin.UseVisualStyleBackColor = true;
            addmin.Click += addmin_Click_1;
            // 
            // manname1
            // 
            manname1.FormattingEnabled = true;
            manname1.Location = new Point(156, 422);
            manname1.Name = "manname1";
            manname1.Size = new Size(201, 33);
            manname1.TabIndex = 18;
            // 
            // engplat
            // 
            engplat.FormattingEnabled = true;
            engplat.Location = new Point(879, 105);
            engplat.Name = "engplat";
            engplat.Size = new Size(182, 33);
            engplat.TabIndex = 19;
            // 
            // revdate
            // 
            revdate.Location = new Point(1215, 156);
            revdate.Name = "revdate";
            revdate.Size = new Size(184, 31);
            revdate.TabIndex = 21;
            // 
            // condate
            // 
            condate.Location = new Point(156, 364);
            condate.Name = "condate";
            condate.Size = new Size(201, 31);
            condate.TabIndex = 22;
            // 
            // storrate
            // 
            storrate.LargeChange = 1;
            storrate.Location = new Point(515, 419);
            storrate.Maximum = 5;
            storrate.Name = "storrate";
            storrate.Size = new Size(186, 69);
            storrate.TabIndex = 23;
            // 
            // admin_username
            // 
            admin_username.Location = new Point(188, 46);
            admin_username.Name = "admin_username";
            admin_username.Size = new Size(169, 31);
            admin_username.TabIndex = 24;
            // 
            // adminpass
            // 
            adminpass.Location = new Point(188, 95);
            adminpass.Name = "adminpass";
            adminpass.Size = new Size(169, 31);
            adminpass.TabIndex = 25;
            // 
            // engname
            // 
            engname.Location = new Point(879, 43);
            engname.Name = "engname";
            engname.Size = new Size(182, 31);
            engname.TabIndex = 26;
            // 
            // englang
            // 
            englang.Location = new Point(879, 158);
            englang.Name = "englang";
            englang.Size = new Size(182, 31);
            englang.TabIndex = 27;
            // 
            // manname
            // 
            manname.Location = new Point(530, 40);
            manname.Name = "manname";
            manname.Size = new Size(171, 31);
            manname.TabIndex = 28;
            // 
            // pubname
            // 
            pubname.Location = new Point(879, 287);
            pubname.Name = "pubname";
            pubname.Size = new Size(231, 31);
            pubname.TabIndex = 29;
            // 
            // revurl
            // 
            revurl.Location = new Point(1215, 105);
            revurl.Name = "revurl";
            revurl.Size = new Size(184, 31);
            revurl.TabIndex = 30;
            // 
            // conname
            // 
            conname.Location = new Point(156, 293);
            conname.Name = "conname";
            conname.Size = new Size(201, 31);
            conname.TabIndex = 31;
            // 
            // revname
            // 
            revname.Location = new Point(1215, 46);
            revname.Name = "revname";
            revname.Size = new Size(184, 31);
            revname.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 370);
            label12.Name = "label12";
            label12.Size = new Size(112, 25);
            label12.TabIndex = 34;
            label12.Text = "Release Date";
            // 
            // pubdate
            // 
            pubdate.Location = new Point(879, 357);
            pubdate.Name = "pubdate";
            pubdate.Size = new Size(231, 31);
            pubdate.TabIndex = 35;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 429);
            label13.Name = "label13";
            label13.Size = new Size(122, 25);
            label13.TabIndex = 36;
            label13.Text = "Developed By";
            // 
            // storname
            // 
            storname.Location = new Point(521, 290);
            storname.Name = "storname";
            storname.Size = new Size(180, 31);
            storname.TabIndex = 37;
            // 
            // storhot
            // 
            storhot.Location = new Point(521, 360);
            storhot.Name = "storhot";
            storhot.Size = new Size(180, 31);
            storhot.TabIndex = 38;
            // 
            // pubhead
            // 
            pubhead.FormattingEnabled = true;
            pubhead.Location = new Point(879, 480);
            pubhead.Name = "pubhead";
            pubhead.Size = new Size(231, 33);
            pubhead.TabIndex = 39;
            // 
            // pubtype
            // 
            pubtype.Location = new Point(879, 417);
            pubtype.Name = "pubtype";
            pubtype.Size = new Size(231, 31);
            pubtype.TabIndex = 40;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(392, 299);
            label14.Name = "label14";
            label14.Size = new Size(105, 25);
            label14.TabIndex = 41;
            label14.Text = "Store Name";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(394, 369);
            label15.Name = "label15";
            label15.Size = new Size(69, 25);
            label15.TabIndex = 42;
            label15.Text = "Hotline";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(397, 429);
            label16.Name = "label16";
            label16.Size = new Size(63, 25);
            label16.TabIndex = 43;
            label16.Text = "Rating";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(729, 290);
            label17.Name = "label17";
            label17.Size = new Size(136, 25);
            label17.TabIndex = 44;
            label17.Text = "Publisher Name";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(729, 364);
            label18.Name = "label18";
            label18.Size = new Size(90, 25);
            label18.TabIndex = 45;
            label18.Text = "Start Date";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(729, 425);
            label19.Name = "label19";
            label19.Size = new Size(118, 25);
            label19.TabIndex = 46;
            label19.Text = "Console Type";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(729, 483);
            label20.Name = "label20";
            label20.Size = new Size(119, 25);
            label20.TabIndex = 47;
            label20.Text = "Headquarters";
            // 
            // manhead
            // 
            manhead.FormattingEnabled = true;
            manhead.Location = new Point(530, 90);
            manhead.Name = "manhead";
            manhead.Size = new Size(171, 33);
            manhead.TabIndex = 48;
            // 
            // Admin_Add
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1426, 641);
            Controls.Add(manhead);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(pubtype);
            Controls.Add(pubhead);
            Controls.Add(storhot);
            Controls.Add(storname);
            Controls.Add(label13);
            Controls.Add(pubdate);
            Controls.Add(label12);
            Controls.Add(revname);
            Controls.Add(conname);
            Controls.Add(revurl);
            Controls.Add(pubname);
            Controls.Add(manname);
            Controls.Add(englang);
            Controls.Add(engname);
            Controls.Add(adminpass);
            Controls.Add(admin_username);
            Controls.Add(storrate);
            Controls.Add(condate);
            Controls.Add(revdate);
            Controls.Add(engplat);
            Controls.Add(manname1);
            Controls.Add(addmin);
            Controls.Add(addman);
            Controls.Add(addeng);
            Controls.Add(addrev);
            Controls.Add(addcon);
            Controls.Add(addpub);
            Controls.Add(addstor);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Admin_Add";
            Text = "Admin_Add";
            Load += Admin_Add_Load;
            ((System.ComponentModel.ISupportInitialize)storrate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button addstor;
        private Button addpub;
        private Button addcon;
        private Button addrev;
        private Button addeng;
        private Button addman;
        private Button addmin;
        private ComboBox manname1;
        private ComboBox engplat;
        private DateTimePicker revdate;
        private DateTimePicker condate;
        private TrackBar storrate;
        private TextBox admin_username;
        private TextBox adminpass;
        private TextBox engname;
        private TextBox englang;
        private TextBox manname;
        private TextBox pubname;
        private TextBox revurl;
        private TextBox conname;
        private TextBox revname;
        private Label label12;
        private DateTimePicker pubdate;
        private Label label13;
        private TextBox storname;
        private TextBox storhot;
        private ComboBox pubhead;
        private TextBox pubtype;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private ComboBox manhead;
    }
}