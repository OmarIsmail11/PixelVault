namespace PixelVaultGUI
{
    partial class ManageRegistration
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
            Reg_panel = new Panel();
            ExitButton = new Label();
            Refresh = new Button();
            TName_combobox = new ComboBox();
            label9 = new Label();
            Close = new CheckBox();
            Open = new CheckBox();
            dataGridView1 = new DataGridView();
            Reg_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Reg_panel
            // 
            Reg_panel.BackgroundImage = Properties.Resources.solid_color_image__1_;
            Reg_panel.Controls.Add(ExitButton);
            Reg_panel.Controls.Add(Refresh);
            Reg_panel.Controls.Add(TName_combobox);
            Reg_panel.Controls.Add(label9);
            Reg_panel.Controls.Add(Close);
            Reg_panel.Controls.Add(Open);
            Reg_panel.Controls.Add(dataGridView1);
            Reg_panel.Location = new Point(0, 2);
            Reg_panel.Name = "Reg_panel";
            Reg_panel.Size = new Size(1151, 580);
            Reg_panel.TabIndex = 32;
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ActiveCaptionText;
            ExitButton.Image = Properties.Resources.solid_color_image__1_;
            ExitButton.Location = new Point(1109, 0);
            ExitButton.Margin = new Padding(4, 0, 4, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(42, 45);
            ExitButton.TabIndex = 25;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // Refresh
            // 
            Refresh.BackgroundImage = Properties.Resources.dark_purple_colour;
            Refresh.Font = new Font("Segoe UI", 14F);
            Refresh.ForeColor = SystemColors.ButtonHighlight;
            Refresh.Location = new Point(546, 496);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(123, 54);
            Refresh.TabIndex = 5;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click_1;
            // 
            // TName_combobox
            // 
            TName_combobox.FormattingEnabled = true;
            TName_combobox.Location = new Point(286, 374);
            TName_combobox.Name = "TName_combobox";
            TName_combobox.Size = new Size(257, 33);
            TName_combobox.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(24, 373);
            label9.Name = "label9";
            label9.Size = new Size(247, 38);
            label9.TabIndex = 3;
            label9.Text = "Tournament Name";
            // 
            // Close
            // 
            Close.AutoSize = true;
            Close.Font = new Font("Segoe UI", 12F);
            Close.Location = new Point(335, 496);
            Close.Name = "Close";
            Close.Size = new Size(98, 36);
            Close.TabIndex = 2;
            Close.Text = "Close";
            Close.UseVisualStyleBackColor = true;
            Close.CheckedChanged += Close_CheckedChanged_1;
            // 
            // Open
            // 
            Open.AutoSize = true;
            Open.Font = new Font("Segoe UI", 12F);
            Open.Location = new Point(335, 450);
            Open.Name = "Open";
            Open.Size = new Size(99, 36);
            Open.TabIndex = 1;
            Open.Text = "Open";
            Open.UseVisualStyleBackColor = true;
            Open.CheckedChanged += Open_CheckedChanged_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1023, 340);
            dataGridView1.TabIndex = 0;
            // 
            // ManageRegistration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1155, 571);
            Controls.Add(Reg_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageRegistration";
            Text = "ManageRegistration";
            Reg_panel.ResumeLayout(false);
            Reg_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Reg_panel;
        private Button Refresh;
        private ComboBox TName_combobox;
        private Label label9;
        private CheckBox Close;
        private CheckBox Open;
        private DataGridView dataGridView1;
        private Label ExitButton;
    }
}