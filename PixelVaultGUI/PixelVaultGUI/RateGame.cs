using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelVaultGUI
{
    public partial class RateGame : Form
    {
        public string UserName;
        public string GameName;
        private DataGridViewRow rowToUpdate;
        private Button button2;
        Controller controllerObj = new Controller();
        public RateGame(string gamerusername, string gamename, DataGridViewRow row)
        {
            UserName = gamerusername;
            GameName = gamename;
            rowToUpdate = row;

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            panel1 = new Panel();
            HardRadioButton = new RadioButton();
            MediumRadioButton = new RadioButton();
            EasyRadioButton = new RadioButton();
            Rating = new Label();
            panel2 = new Panel();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel1.Controls.Add(HardRadioButton);
            panel1.Controls.Add(MediumRadioButton);
            panel1.Controls.Add(EasyRadioButton);
            panel1.Controls.Add(Rating);
            panel1.Location = new Point(43, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(583, 144);
            panel1.TabIndex = 0;
            // 
            // HardRadioButton
            // 
            HardRadioButton.AutoSize = true;
            HardRadioButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HardRadioButton.Location = new Point(430, 68);
            HardRadioButton.Name = "HardRadioButton";
            HardRadioButton.Size = new Size(77, 32);
            HardRadioButton.TabIndex = 3;
            HardRadioButton.TabStop = true;
            HardRadioButton.Text = "Hard";
            HardRadioButton.UseVisualStyleBackColor = true;
            // 
            // MediumRadioButton
            // 
            MediumRadioButton.AutoSize = true;
            MediumRadioButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MediumRadioButton.Location = new Point(232, 68);
            MediumRadioButton.Name = "MediumRadioButton";
            MediumRadioButton.Size = new Size(109, 32);
            MediumRadioButton.TabIndex = 2;
            MediumRadioButton.TabStop = true;
            MediumRadioButton.Text = "Medium";
            MediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // EasyRadioButton
            // 
            EasyRadioButton.AutoSize = true;
            EasyRadioButton.BackColor = Color.White;
            EasyRadioButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EasyRadioButton.Location = new Point(52, 69);
            EasyRadioButton.Name = "EasyRadioButton";
            EasyRadioButton.Size = new Size(72, 32);
            EasyRadioButton.TabIndex = 1;
            EasyRadioButton.TabStop = true;
            EasyRadioButton.Text = "Easy";
            EasyRadioButton.UseVisualStyleBackColor = false;
            // 
            // Rating
            // 
            Rating.AutoSize = true;
            Rating.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rating.ForeColor = SystemColors.ButtonHighlight;
            Rating.Image = Properties.Resources.dark_purple_colour;
            Rating.Location = new Point(213, 12);
            Rating.Name = "Rating";
            Rating.Size = new Size(151, 41);
            Rating.TabIndex = 0;
            Rating.Text = "Difficulty";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(151, 250);
            panel2.Name = "panel2";
            panel2.Size = new Size(403, 85);
            panel2.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(239, 34);
            numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(73, 27);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = Properties.Resources.dark_purple_colour;
            label1.Location = new Point(100, 20);
            label1.Name = "label1";
            label1.Size = new Size(112, 41);
            label1.TabIndex = 0;
            label1.Text = "Rating";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.solid_color_image;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(279, 356);
            button1.Name = "button1";
            button1.Size = new Size(163, 67);
            button1.TabIndex = 5;
            button1.Text = "Submit Rating";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.prev;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(49, 51);
            button2.TabIndex = 20;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // RateGame
            // 
            BackgroundImage = Properties.Resources.solid_color_image__1_;
            ClientSize = new Size(682, 453);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RateGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rate Game";
            Load += RateGame_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private RadioButton HardRadioButton;
        private RadioButton MediumRadioButton;
        private RadioButton EasyRadioButton;
        private Panel panel2;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Button button1;
        private Label Rating;

        private void button1_Click(object sender, EventArgs e)
        {
            string difficulty;
            if (EasyRadioButton.Checked) difficulty = EasyRadioButton.Text;
            else if (MediumRadioButton.Checked) difficulty = MediumRadioButton.Text;
            else if (HardRadioButton.Checked) difficulty = HardRadioButton.Text;
            else
            {
                MessageBox.Show("Choose a difficulty !");
                return;
            }

            int rating = Convert.ToInt16(numericUpDown1.Value);

            int result = controllerObj.UpdateRatingandDifficulty(GameName, UserName, difficulty, rating);
            if (result == 0)
            {
                MessageBox.Show("Rating was not submitted!");
                return;
            }
            else
            {
                MessageBox.Show("Rating submitted succesfully !");
                rowToUpdate.Cells["Difficulty"].Value = difficulty;
                rowToUpdate.Cells["Rating"].Value = rating;
                this.Close();
                return;
            }
        }

        private void RateGame_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
