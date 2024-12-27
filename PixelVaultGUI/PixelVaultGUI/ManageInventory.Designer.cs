namespace PixelVaultGUI
{
    partial class ManageInventory
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
            label1 = new Label();
            NewPrice = new TextBox();
            AdjustPrice = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(689, 220);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ActiveCaptionText;
            ExitButton.Image = Properties.Resources.solid_color_image__1_;
            ExitButton.Location = new Point(728, 3);
            ExitButton.Margin = new Padding(4, 0, 4, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(42, 45);
            ExitButton.TabIndex = 25;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(14, 343);
            label1.Name = "label1";
            label1.Size = new Size(227, 45);
            label1.TabIndex = 26;
            label1.Text = "Set New Price";
            // 
            // NewPrice
            // 
            NewPrice.Font = new Font("Segoe UI", 14F);
            NewPrice.Location = new Point(262, 343);
            NewPrice.Name = "NewPrice";
            NewPrice.Size = new Size(276, 45);
            NewPrice.TabIndex = 27;
            // 
            // AdjustPrice
            // 
            AdjustPrice.BackColor = Color.Transparent;
            AdjustPrice.BackgroundImage = Properties.Resources.solid_color_image;
            AdjustPrice.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            AdjustPrice.ForeColor = SystemColors.ButtonHighlight;
            AdjustPrice.Location = new Point(409, 399);
            AdjustPrice.Name = "AdjustPrice";
            AdjustPrice.Size = new Size(309, 51);
            AdjustPrice.TabIndex = 28;
            AdjustPrice.Text = "Adjust Game Price";
            AdjustPrice.UseVisualStyleBackColor = false;
            AdjustPrice.Click += AdjustPrice_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(166, 14);
            label2.Name = "label2";
            label2.Size = new Size(372, 54);
            label2.TabIndex = 29;
            label2.Text = "Manage Inventory";
            // 
            // ManageInventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.solid_color_image__1_;
            Controls.Add(label2);
            Controls.Add(AdjustPrice);
            Controls.Add(NewPrice);
            Controls.Add(label1);
            Controls.Add(ExitButton);
            Controls.Add(dataGridView1);
            Name = "ManageInventory";
            Size = new Size(774, 471);
            Load += ManageInventory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label ExitButton;
        private Label label1;
        private TextBox NewPrice;
        private Button AdjustPrice;
        private Label label2;
    }
}
