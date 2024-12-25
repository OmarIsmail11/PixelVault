namespace PixelVaultGUI
{
    partial class Promotions
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
            label1 = new Label();
            label2 = new Label();
            ExitButton = new Label();
            Genres = new ComboBox();
            label3 = new Label();
            DiscountAmount = new TextBox();
            ApplyDiscount = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(33, 123);
            label1.Name = "label1";
            label1.Size = new Size(116, 48);
            label1.TabIndex = 0;
            label1.Text = "Genre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.Location = new Point(215, 25);
            label2.Name = "label2";
            label2.Size = new Size(242, 54);
            label2.TabIndex = 1;
            label2.Text = "Promotions";
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ActiveCaptionText;
            ExitButton.Image = Properties.Resources.solid_color_image__1_;
            ExitButton.Location = new Point(728, 0);
            ExitButton.Margin = new Padding(4, 0, 4, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(42, 45);
            ExitButton.TabIndex = 28;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // Genres
            // 
            Genres.Font = new Font("Segoe UI", 12F);
            Genres.FormattingEnabled = true;
            Genres.Location = new Point(226, 123);
            Genres.Name = "Genres";
            Genres.Size = new Size(257, 40);
            Genres.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(33, 237);
            label3.Name = "label3";
            label3.Size = new Size(346, 48);
            label3.TabIndex = 30;
            label3.Text = "Discount Percentage";
            // 
            // DiscountAmount
            // 
            DiscountAmount.Font = new Font("Segoe UI", 14F);
            DiscountAmount.Location = new Point(437, 240);
            DiscountAmount.Name = "DiscountAmount";
            DiscountAmount.Size = new Size(239, 45);
            DiscountAmount.TabIndex = 31;
            // 
            // ApplyDiscount
            // 
            ApplyDiscount.BackgroundImage = Properties.Resources.solid_color_image;
            ApplyDiscount.Font = new Font("Segoe UI", 18F);
            ApplyDiscount.ForeColor = SystemColors.ButtonHighlight;
            ApplyDiscount.Location = new Point(215, 356);
            ApplyDiscount.Name = "ApplyDiscount";
            ApplyDiscount.Size = new Size(320, 62);
            ApplyDiscount.TabIndex = 32;
            ApplyDiscount.Text = "Apply Promotion";
            ApplyDiscount.UseVisualStyleBackColor = true;
            ApplyDiscount.Click += ApplyDiscount_Click;
            // 
            // Promotions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.solid_color_image__1_;
            Controls.Add(ApplyDiscount);
            Controls.Add(DiscountAmount);
            Controls.Add(label3);
            Controls.Add(Genres);
            Controls.Add(ExitButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Promotions";
            Size = new Size(774, 471);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label ExitButton;
        private ComboBox Genres;
        private Label label3;
        private TextBox DiscountAmount;
        private Button ApplyDiscount;
    }
}
