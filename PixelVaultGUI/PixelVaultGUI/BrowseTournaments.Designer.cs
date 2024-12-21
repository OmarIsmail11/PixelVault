namespace PixelVaultGUI
{
    partial class BrowseTournaments
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
            panel3 = new Panel();
            label3 = new Label();
            SearchSpecificTournamentButton = new TextBox();
            LiveTournamentsDataGrid = new DataGridView();
            label1 = new Label();
            ExitButton = new Label();
            panel1 = new Panel();
            EnrollButton = new Button();
            FilterButton = new Button();
            SortBy = new GroupBox();
            checkedListBox3 = new CheckedListBox();
            groupBox2 = new GroupBox();
            checkedListBox2 = new CheckedListBox();
            groupBox1 = new GroupBox();
            Genre = new CheckedListBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            checkedListBox4 = new CheckedListBox();
            groupBox4 = new GroupBox();
            comboBox1 = new ComboBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LiveTournamentsDataGrid).BeginInit();
            panel1.SuspendLayout();
            SortBy.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(SearchSpecificTournamentButton);
            panel3.Controls.Add(LiveTournamentsDataGrid);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(17, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(969, 322);
            panel3.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Image = Properties.Resources.dark_purple_colour;
            label3.Location = new Point(558, 20);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 3;
            label3.Text = "Search";
            // 
            // SearchSpecificTournamentButton
            // 
            SearchSpecificTournamentButton.Location = new Point(625, 17);
            SearchSpecificTournamentButton.Name = "SearchSpecificTournamentButton";
            SearchSpecificTournamentButton.Size = new Size(314, 27);
            SearchSpecificTournamentButton.TabIndex = 2;
            // 
            // LiveTournamentsDataGrid
            // 
            LiveTournamentsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LiveTournamentsDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            LiveTournamentsDataGrid.GridColor = Color.Black;
            LiveTournamentsDataGrid.Location = new Point(24, 59);
            LiveTournamentsDataGrid.Name = "LiveTournamentsDataGrid";
            LiveTournamentsDataGrid.RowHeadersWidth = 51;
            LiveTournamentsDataGrid.Size = new Size(922, 236);
            LiveTournamentsDataGrid.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = Properties.Resources.dark_purple_colour;
            label1.Location = new Point(24, 13);
            label1.Name = "label1";
            label1.Size = new Size(196, 31);
            label1.TabIndex = 0;
            label1.Text = "Live Tournaments";
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ButtonHighlight;
            ExitButton.Image = Properties.Resources.dark_purple_colour;
            ExitButton.Location = new Point(976, 0);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(35, 38);
            ExitButton.TabIndex = 18;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(EnrollButton);
            panel1.Controls.Add(FilterButton);
            panel1.Controls.Add(SortBy);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(20, 390);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 241);
            panel1.TabIndex = 19;
            // 
            // EnrollButton
            // 
            EnrollButton.BackColor = Color.FromArgb(186, 186, 212);
            EnrollButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnrollButton.Location = new Point(711, 40);
            EnrollButton.Name = "EnrollButton";
            EnrollButton.Size = new Size(161, 44);
            EnrollButton.TabIndex = 23;
            EnrollButton.Text = "Enroll";
            EnrollButton.UseVisualStyleBackColor = false;
            EnrollButton.Click += EnrollButton_Click;
            // 
            // FilterButton
            // 
            FilterButton.BackColor = Color.FromArgb(186, 186, 212);
            FilterButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FilterButton.Location = new Point(455, 40);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(161, 44);
            FilterButton.TabIndex = 22;
            FilterButton.Text = "Filter";
            FilterButton.UseVisualStyleBackColor = false;
            FilterButton.Click += FilterButton_Click;
            // 
            // SortBy
            // 
            SortBy.BackgroundImage = Properties.Resources.dark_purple_colour;
            SortBy.Controls.Add(checkedListBox3);
            SortBy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SortBy.ForeColor = SystemColors.ButtonFace;
            SortBy.Location = new Point(399, 99);
            SortBy.Name = "SortBy";
            SortBy.Size = new Size(167, 121);
            SortBy.TabIndex = 4;
            SortBy.TabStop = false;
            SortBy.Text = "Sort By";
            // 
            // checkedListBox3
            // 
            checkedListBox3.BackColor = Color.FromArgb(29, 29, 57);
            checkedListBox3.BorderStyle = BorderStyle.None;
            checkedListBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox3.ForeColor = SystemColors.ButtonHighlight;
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Items.AddRange(new object[] { "Available Spots", "Start Date", "Prize Money" });
            checkedListBox3.Location = new Point(16, 33);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(145, 75);
            checkedListBox3.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources.dark_purple_colour;
            groupBox2.Controls.Add(checkedListBox2);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(206, 50);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(167, 170);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Region";
            // 
            // checkedListBox2
            // 
            checkedListBox2.BackColor = Color.FromArgb(29, 29, 57);
            checkedListBox2.BorderStyle = BorderStyle.None;
            checkedListBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox2.ForeColor = SystemColors.ButtonHighlight;
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "North America", "South America", "Europe", "Asia", "Africa" });
            checkedListBox2.Location = new Point(16, 33);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(145, 125);
            checkedListBox2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.dark_purple_colour;
            groupBox1.Controls.Add(Genre);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(27, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(154, 170);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Genre";
            // 
            // Genre
            // 
            Genre.BackColor = Color.FromArgb(29, 29, 57);
            Genre.BorderStyle = BorderStyle.None;
            Genre.CheckOnClick = true;
            Genre.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Genre.ForeColor = SystemColors.ButtonHighlight;
            Genre.FormattingEnabled = true;
            Genre.Items.AddRange(new object[] { "Sports", "Racing", "Fighting", "Battle Royale", "FPS" });
            Genre.Location = new Point(16, 33);
            Genre.Name = "Genre";
            Genre.Size = new Size(129, 125);
            Genre.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Image = Properties.Resources.dark_purple_colour;
            label2.Location = new Point(21, 16);
            label2.Name = "label2";
            label2.Size = new Size(177, 31);
            label2.TabIndex = 1;
            label2.Text = "Filter Results By";
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = Properties.Resources.dark_purple_colour;
            groupBox3.Controls.Add(checkedListBox4);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.ButtonFace;
            groupBox3.Location = new Point(598, 131);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(110, 89);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Type";
            // 
            // checkedListBox4
            // 
            checkedListBox4.BackColor = Color.FromArgb(29, 29, 57);
            checkedListBox4.BorderStyle = BorderStyle.None;
            checkedListBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkedListBox4.ForeColor = SystemColors.ButtonHighlight;
            checkedListBox4.FormattingEnabled = true;
            checkedListBox4.Items.AddRange(new object[] { "1v1", "Teams" });
            checkedListBox4.Location = new Point(16, 33);
            checkedListBox4.Name = "checkedListBox4";
            checkedListBox4.Size = new Size(84, 50);
            checkedListBox4.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.BackgroundImage = Properties.Resources.dark_purple_colour;
            groupBox4.Controls.Add(comboBox1);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.ButtonFace;
            groupBox4.Location = new Point(735, 132);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(208, 89);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            groupBox4.Text = "Game";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(16, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(176, 36);
            comboBox1.TabIndex = 0;
            // 
            // BrowseTournaments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 188, 212);
            Controls.Add(panel1);
            Controls.Add(ExitButton);
            Controls.Add(panel3);
            Name = "BrowseTournaments";
            Size = new Size(1011, 653);
            Load += BrowseTournaments_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LiveTournamentsDataGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            SortBy.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private DataGridView LiveTournamentsDataGrid;
        private Label label1;
        private Label ExitButton;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label2;
        private CheckedListBox Genre;
        private GroupBox groupBox2;
        private CheckedListBox checkedListBox2;
        private GroupBox SortBy;
        private CheckedListBox checkedListBox3;
        private Button EnrollButton;
        private Button FilterButton;
        private Label label3;
        private TextBox SearchSpecificTournamentButton;
        private GroupBox groupBox3;
        private CheckedListBox checkedListBox4;
        private GroupBox groupBox4;
        private ComboBox comboBox1;
    }
}
