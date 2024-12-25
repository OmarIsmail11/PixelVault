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
            Genre = new ComboBox();
            label3 = new Label();
            Discount = new TextBox();
            ApplyPromo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(201, 16);
            label1.Name = "label1";
            label1.Size = new Size(290, 65);
            label1.TabIndex = 0;
            label1.Text = "Promotions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(44, 141);
            label2.Name = "label2";
            label2.Size = new Size(221, 48);
            label2.TabIndex = 1;
            label2.Text = "Select Genre";
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
            ExitButton.TabIndex = 26;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // Genre
            // 
            Genre.Font = new Font("Segoe UI", 16F);
            Genre.FormattingEnabled = true;
            Genre.Location = new Point(396, 141);
            Genre.Name = "Genre";
            Genre.Size = new Size(259, 53);
            Genre.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(44, 267);
            label3.Name = "label3";
            label3.Size = new Size(346, 48);
            label3.TabIndex = 28;
            label3.Text = "Discount Percentage";
            // 
            // Discount
            // 
            Discount.Font = new Font("Segoe UI", 16F);
            Discount.Location = new Point(396, 267);
            Discount.Name = "Discount";
            Discount.Size = new Size(259, 50);
            Discount.TabIndex = 29;
            // 
            // ApplyPromo
            // 
            ApplyPromo.BackgroundImage = Properties.Resources.dark_purple_colour1;
            ApplyPromo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            ApplyPromo.ForeColor = SystemColors.ButtonHighlight;
            ApplyPromo.Location = new Point(201, 365);
            ApplyPromo.Name = "ApplyPromo";
            ApplyPromo.Size = new Size(344, 65);
            ApplyPromo.TabIndex = 30;
            ApplyPromo.Text = "Apply Promotion";
            ApplyPromo.UseVisualStyleBackColor = true;
            ApplyPromo.Click += ApplyPromo_Click;
            // 
            // Promotions
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.solid_color_image__1_;
            Controls.Add(ApplyPromo);
            Controls.Add(Discount);
            Controls.Add(label3);
            Controls.Add(Genre);
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
        private ComboBox Genre;
        private Label label3;
        private TextBox Discount;
        private Button ApplyPromo;
    }
}
