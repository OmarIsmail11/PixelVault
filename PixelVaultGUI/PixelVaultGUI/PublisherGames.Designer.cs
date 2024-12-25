namespace PixelVaultGUI
{
    partial class PublisherGames
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
            ExitButton = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(34, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(1575, 515);
            panel1.TabIndex = 0;
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
            label1.Size = new Size(312, 50);
            label1.TabIndex = 1;
            label1.Text = "Published Games";
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
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ButtonHighlight;
            ExitButton.Image = Properties.Resources.dark_purple_colour;
            ExitButton.Location = new Point(1586, 0);
            ExitButton.Margin = new Padding(5, 0, 5, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(54, 60);
            ExitButton.TabIndex = 18;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.dark_purple_colour;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(73, 629);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(588, 107);
            button1.TabIndex = 19;
            button1.Text = "Publish Game";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PublisherGames
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 188, 212);
            Controls.Add(button1);
            Controls.Add(ExitButton);
            Controls.Add(panel1);
            Margin = new Padding(5);
            Name = "PublisherGames";
            Size = new Size(1643, 1045);
            Load += PublisherGames_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label ExitButton;
        private Button button1;
    }
}
