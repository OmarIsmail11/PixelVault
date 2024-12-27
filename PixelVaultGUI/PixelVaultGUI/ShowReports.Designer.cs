namespace PixelVaultGUI
{
    partial class ShowReports
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
            label3 = new Label();
            PartnersNum = new Button();
            AvgPMoney = new Button();
            TournamentsNum = new Button();
            AvgPrice = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(447, 311);
            dataGridView1.TabIndex = 0;
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ActiveCaptionText;
            ExitButton.Image = Properties.Resources.solid_color_image__1_;
            ExitButton.Location = new Point(752, 5);
            ExitButton.Margin = new Padding(4, 0, 4, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(42, 45);
            ExitButton.TabIndex = 28;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.Location = new Point(338, 19);
            label3.Name = "label3";
            label3.Size = new Size(151, 48);
            label3.TabIndex = 27;
            label3.Text = "Reports";
            // 
            // PartnersNum
            // 
            PartnersNum.BackColor = Color.Transparent;
            PartnersNum.BackgroundImage = Properties.Resources.solid_color_image;
            PartnersNum.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            PartnersNum.ForeColor = Color.White;
            PartnersNum.Location = new Point(470, 112);
            PartnersNum.Name = "PartnersNum";
            PartnersNum.Size = new Size(314, 49);
            PartnersNum.TabIndex = 29;
            PartnersNum.Text = "Number of Partners";
            PartnersNum.UseVisualStyleBackColor = false;
            PartnersNum.Click += PartnersNum_Click;
            // 
            // AvgPMoney
            // 
            AvgPMoney.BackColor = Color.Transparent;
            AvgPMoney.BackgroundImage = Properties.Resources.solid_color_image;
            AvgPMoney.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AvgPMoney.ForeColor = Color.White;
            AvgPMoney.Location = new Point(470, 355);
            AvgPMoney.Name = "AvgPMoney";
            AvgPMoney.Size = new Size(314, 49);
            AvgPMoney.TabIndex = 30;
            AvgPMoney.Text = "Average Prize Money";
            AvgPMoney.UseVisualStyleBackColor = false;
            AvgPMoney.Click += AvgPMoney_Click;
            // 
            // TournamentsNum
            // 
            TournamentsNum.BackColor = Color.Transparent;
            TournamentsNum.BackgroundImage = Properties.Resources.solid_color_image;
            TournamentsNum.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            TournamentsNum.ForeColor = Color.White;
            TournamentsNum.Location = new Point(470, 276);
            TournamentsNum.Name = "TournamentsNum";
            TournamentsNum.Size = new Size(314, 49);
            TournamentsNum.TabIndex = 31;
            TournamentsNum.Text = "Number of Tournaments";
            TournamentsNum.UseVisualStyleBackColor = false;
            TournamentsNum.Click += TournamentsNum_Click;
            // 
            // AvgPrice
            // 
            AvgPrice.BackColor = Color.Transparent;
            AvgPrice.BackgroundImage = Properties.Resources.solid_color_image;
            AvgPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            AvgPrice.ForeColor = Color.White;
            AvgPrice.Location = new Point(470, 197);
            AvgPrice.Name = "AvgPrice";
            AvgPrice.Size = new Size(314, 48);
            AvgPrice.TabIndex = 32;
            AvgPrice.Text = "Average Game Price";
            AvgPrice.UseVisualStyleBackColor = false;
            AvgPrice.Click += AvgPrice_Click;
            // 
            // ShowReports
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.solid_color_image__1_;
            Controls.Add(AvgPrice);
            Controls.Add(TournamentsNum);
            Controls.Add(AvgPMoney);
            Controls.Add(PartnersNum);
            Controls.Add(ExitButton);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Name = "ShowReports";
            Size = new Size(800, 610);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label ExitButton;
        private Label label3;
        private Button PartnersNum;
        private Button AvgPMoney;
        private Button TournamentsNum;
        private Button AvgPrice;
    }
}
