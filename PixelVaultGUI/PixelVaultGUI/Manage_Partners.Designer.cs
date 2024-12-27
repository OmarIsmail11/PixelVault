namespace PixelVaultGUI
{
    partial class Manage_Partners
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
            panel2 = new Panel();
            DeletePartnerButton = new Button();
            AddPartnershipButton = new Button();
            ViewPartnersButton = new Button();
            ViewStroresButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(32, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(1575, 515);
            panel1.TabIndex = 1;
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
            label1.Size = new Size(302, 50);
            label1.TabIndex = 1;
            label1.Text = "Partnered Stores";
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
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel2.Controls.Add(DeletePartnerButton);
            panel2.Controls.Add(AddPartnershipButton);
            panel2.Controls.Add(ViewPartnersButton);
            panel2.Controls.Add(ViewStroresButton);
            panel2.Location = new Point(32, 644);
            panel2.Name = "panel2";
            panel2.Size = new Size(1575, 354);
            panel2.TabIndex = 2;
            // 
            // DeletePartnerButton
            // 
            DeletePartnerButton.BackColor = Color.FromArgb(186, 186, 212);
            DeletePartnerButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            DeletePartnerButton.Location = new Point(599, 208);
            DeletePartnerButton.Name = "DeletePartnerButton";
            DeletePartnerButton.Size = new Size(413, 104);
            DeletePartnerButton.TabIndex = 6;
            DeletePartnerButton.Text = "Delete Partnership";
            DeletePartnerButton.UseVisualStyleBackColor = false;
            DeletePartnerButton.Click += DeletePartnerButton_Click;
            // 
            // AddPartnershipButton
            // 
            AddPartnershipButton.BackColor = Color.FromArgb(186, 186, 212);
            AddPartnershipButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            AddPartnershipButton.Location = new Point(599, 41);
            AddPartnershipButton.Name = "AddPartnershipButton";
            AddPartnershipButton.Size = new Size(413, 104);
            AddPartnershipButton.TabIndex = 5;
            AddPartnershipButton.Text = "Add Partnership";
            AddPartnershipButton.UseVisualStyleBackColor = false;
            AddPartnershipButton.Click += AddPartnershipButton_Click;
            // 
            // ViewPartnersButton
            // 
            ViewPartnersButton.BackColor = Color.FromArgb(186, 186, 212);
            ViewPartnersButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            ViewPartnersButton.Location = new Point(39, 208);
            ViewPartnersButton.Name = "ViewPartnersButton";
            ViewPartnersButton.Size = new Size(413, 104);
            ViewPartnersButton.TabIndex = 4;
            ViewPartnersButton.Text = "View Partners";
            ViewPartnersButton.UseVisualStyleBackColor = false;
            ViewPartnersButton.Click += ViewPartnersButton_Click;
            // 
            // ViewStroresButton
            // 
            ViewStroresButton.BackColor = Color.FromArgb(186, 186, 212);
            ViewStroresButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            ViewStroresButton.Location = new Point(39, 41);
            ViewStroresButton.Name = "ViewStroresButton";
            ViewStroresButton.Size = new Size(413, 104);
            ViewStroresButton.TabIndex = 3;
            ViewStroresButton.Text = "View All Stores";
            ViewStroresButton.UseVisualStyleBackColor = false;
            ViewStroresButton.Click += ViewStroresButton_Click;
            // 
            // Manage_Partners
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.solid_color_image__1_;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Manage_Partners";
            Size = new Size(1643, 1045);
            Load += Manage_Partners_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button ViewStroresButton;
        private Button ViewPartnersButton;
        private Button AddPartnershipButton;
        private Button DeletePartnerButton;
    }
}
