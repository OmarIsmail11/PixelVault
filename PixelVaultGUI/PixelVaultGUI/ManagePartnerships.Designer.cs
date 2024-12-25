namespace PixelVaultGUI
{
    partial class ManagePartnerships
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
            ExitButton = new Label();
            dataGridView1 = new DataGridView();
            RemovePub = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ActiveCaptionText;
            ExitButton.Image = Properties.Resources.solid_color_image__1_;
            ExitButton.Location = new Point(725, 3);
            ExitButton.Margin = new Padding(4, 0, 4, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(42, 45);
            ExitButton.TabIndex = 27;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(689, 291);
            dataGridView1.TabIndex = 26;
            // 
            // RemovePub
            // 
            RemovePub.BackgroundImage = Properties.Resources.solid_color_image;
            RemovePub.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            RemovePub.ForeColor = SystemColors.ButtonHighlight;
            RemovePub.Location = new Point(417, 387);
            RemovePub.Name = "RemovePub";
            RemovePub.Size = new Size(275, 52);
            RemovePub.TabIndex = 28;
            RemovePub.Text = "Remove Partner";
            RemovePub.UseVisualStyleBackColor = true;
            RemovePub.Click += RemovePub_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(146, 3);
            label1.Name = "label1";
            label1.Size = new Size(424, 54);
            label1.TabIndex = 29;
            label1.Text = "Manage Partnerships";
            // 
            // ManagePartnerships
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.solid_color_image__1_;
            Controls.Add(label1);
            Controls.Add(RemovePub);
            Controls.Add(ExitButton);
            Controls.Add(dataGridView1);
            Name = "ManagePartnerships";
            Size = new Size(774, 471);
            Load += ManagePartnerships_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ExitButton;
        private DataGridView dataGridView1;
        private Button RemovePub;
        private Label label1;
    }
}
