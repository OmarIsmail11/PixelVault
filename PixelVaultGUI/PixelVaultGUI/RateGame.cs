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
        private RadioButton HardRadioButton;
        private RadioButton MediumRadioButton;
        private RadioButton EasyRadioButton;
        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox2;
        private Label label1;
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
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            HardRadioButton = new RadioButton();
            MediumRadioButton = new RadioButton();
            EasyRadioButton = new RadioButton();
            groupBox1 = new GroupBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label1 = new Label();
            ((ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(283, 37);
            numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.ReadOnly = true;
            numericUpDown1.Size = new Size(73, 38);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.solid_color_image__1_;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(169, 309);
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
            // HardRadioButton
            // 
            HardRadioButton.AutoSize = true;
            HardRadioButton.BackgroundImage = Properties.Resources.dark_purple_colour1;
            HardRadioButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HardRadioButton.ForeColor = SystemColors.Control;
            HardRadioButton.Location = new Point(283, 37);
            HardRadioButton.Name = "HardRadioButton";
            HardRadioButton.Size = new Size(77, 32);
            HardRadioButton.TabIndex = 23;
            HardRadioButton.TabStop = true;
            HardRadioButton.Text = "Hard";
            HardRadioButton.UseVisualStyleBackColor = true;
            // 
            // MediumRadioButton
            // 
            MediumRadioButton.AutoSize = true;
            MediumRadioButton.BackgroundImage = Properties.Resources.dark_purple_colour1;
            MediumRadioButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MediumRadioButton.ForeColor = SystemColors.Control;
            MediumRadioButton.Location = new Point(138, 37);
            MediumRadioButton.Name = "MediumRadioButton";
            MediumRadioButton.Size = new Size(109, 32);
            MediumRadioButton.TabIndex = 22;
            MediumRadioButton.TabStop = true;
            MediumRadioButton.Text = "Medium";
            MediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // EasyRadioButton
            // 
            EasyRadioButton.AutoSize = true;
            EasyRadioButton.BackColor = Color.White;
            EasyRadioButton.BackgroundImage = Properties.Resources.dark_purple_colour1;
            EasyRadioButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EasyRadioButton.ForeColor = SystemColors.Control;
            EasyRadioButton.Location = new Point(18, 37);
            EasyRadioButton.Name = "EasyRadioButton";
            EasyRadioButton.Size = new Size(72, 32);
            EasyRadioButton.TabIndex = 21;
            EasyRadioButton.TabStop = true;
            EasyRadioButton.Text = "Easy";
            EasyRadioButton.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.solid_color_image;
            groupBox1.Controls.Add(EasyRadioButton);
            groupBox1.Controls.Add(HardRadioButton);
            groupBox1.Controls.Add(MediumRadioButton);
            groupBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(44, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 84);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Difficulty";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Image = Properties.Resources.dark_purple_colour;
            label2.Location = new Point(169, 22);
            label2.Name = "label2";
            label2.Size = new Size(170, 41);
            label2.TabIndex = 2;
            label2.Text = "Rate Game";
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources.solid_color_image;
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(44, 198);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(378, 93);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Rating";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = Properties.Resources.dark_purple_colour;
            label1.Location = new Point(18, 41);
            label1.Name = "label1";
            label1.Size = new Size(257, 28);
            label1.TabIndex = 26;
            label1.Text = "Choose a number from 1-5";
            // 
            // RateGame
            // 
            BackgroundImage = Properties.Resources.solid_color_image;
            ClientSize = new Size(482, 403);
            Controls.Add(groupBox2);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "RateGame";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rate Game";
            Load += RateGame_Load;
            ((ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private NumericUpDown numericUpDown1;
        private Button button1;

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
