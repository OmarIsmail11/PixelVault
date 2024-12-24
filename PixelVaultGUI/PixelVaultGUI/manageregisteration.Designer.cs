namespace PixelVaultGUI
{
    partial class manageregisteration
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
            dataGridView1 = new DataGridView();
            ExitButton = new Label();
            Open = new CheckBox();
            Close = new CheckBox();
            Refresh = new Button();
            TName_combobox = new ComboBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(665, 246);
            dataGridView1.TabIndex = 1;
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ActiveCaptionText;
            ExitButton.Image = Properties.Resources.solid_color_image__1_;
            ExitButton.Location = new Point(754, 3);
            ExitButton.Margin = new Padding(4, 0, 4, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(42, 45);
            ExitButton.TabIndex = 26;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // Open
            // 
            Open.AutoSize = true;
            Open.BackColor = Color.Transparent;
            Open.Font = new Font("Segoe UI", 16F);
            Open.Location = new Point(264, 407);
            Open.Name = "Open";
            Open.Size = new Size(124, 49);
            Open.TabIndex = 27;
            Open.Text = "Open";
            Open.UseVisualStyleBackColor = false;
            Open.CheckedChanged += Open_CheckedChanged;
            // 
            // Close
            // 
            Close.AutoSize = true;
            Close.BackColor = Color.Transparent;
            Close.Font = new Font("Segoe UI", 16F);
            Close.Location = new Point(264, 474);
            Close.Name = "Close";
            Close.Size = new Size(124, 49);
            Close.TabIndex = 28;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = false;
            Close.CheckedChanged += Close_CheckedChanged;
            // 
            // Refresh
            // 
            Refresh.BackgroundImage = Properties.Resources.dark_purple_colour;
            Refresh.Font = new Font("Segoe UI", 18F);
            Refresh.ForeColor = SystemColors.ButtonHighlight;
            Refresh.Location = new Point(508, 440);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(160, 83);
            Refresh.TabIndex = 29;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // TName_combobox
            // 
            TName_combobox.FormattingEnabled = true;
            TName_combobox.Location = new Point(268, 293);
            TName_combobox.Name = "TName_combobox";
            TName_combobox.Size = new Size(257, 33);
            TName_combobox.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label9.Location = new Point(0, 293);
            label9.Name = "label9";
            label9.Size = new Size(262, 38);
            label9.TabIndex = 30;
            label9.Text = "Tournament Name";
            // 
            // manageregisteration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.solid_color_image__1_;
            Controls.Add(TName_combobox);
            Controls.Add(label9);
            Controls.Add(Refresh);
            Controls.Add(Close);
            Controls.Add(Open);
            Controls.Add(ExitButton);
            Controls.Add(dataGridView1);
            Name = "manageregisteration";
            Size = new Size(813, 620);
            Load += manageregisteration_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label ExitButton;
        private CheckBox Open;
        private CheckBox Close;
        private Button Refresh;
        private ComboBox TName_combobox;
        private Label label9;
    }
}
