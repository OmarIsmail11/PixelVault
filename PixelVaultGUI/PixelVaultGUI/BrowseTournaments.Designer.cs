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
            SearchButton = new Button();
            label3 = new Label();
            SearchTextBox = new TextBox();
            LiveTournamentsDataGrid = new DataGridView();
            label1 = new Label();
            ExitButton = new Label();
            panel1 = new Panel();
            groupBox4 = new GroupBox();
            GameComboBox = new ComboBox();
            groupBox3 = new GroupBox();
            TypeCheckedListBox = new CheckedListBox();
            EnrollButton = new Button();
            FilterButton = new Button();
            SortBy = new GroupBox();
            SortByCheckedListBox = new CheckedListBox();
            groupBox2 = new GroupBox();
            RegionCheckedListBox = new CheckedListBox();
            groupBox1 = new GroupBox();
            GenreCheckedListBox = new CheckedListBox();
            label2 = new Label();
            panel2 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LiveTournamentsDataGrid).BeginInit();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SortBy.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel3.Controls.Add(SearchButton);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(SearchTextBox);
            panel3.Controls.Add(LiveTournamentsDataGrid);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(17, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(969, 322);
            panel3.TabIndex = 2;
            // 
            // SearchButton
            // 
            SearchButton.Image = Properties.Resources.search2;
            SearchButton.Location = new Point(912, 17);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(34, 31);
            SearchButton.TabIndex = 4;
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Image = Properties.Resources.dark_purple_colour;
            label3.Location = new Point(547, 22);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 3;
            label3.Text = "Search";
            // 
            // SearchTextBox
            // 
            SearchTextBox.ForeColor = Color.Gray;
            SearchTextBox.Location = new Point(617, 19);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(289, 27);
            SearchTextBox.TabIndex = 2;
            SearchTextBox.Text = "Search game or tournament";
            SearchTextBox.TextChanged += SearchTextBox_TextChanged;
            SearchTextBox.Enter += SearchTextBox_Enter;
            SearchTextBox.Leave += SearchTextBox_Leave;
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
            panel1.Controls.Add(SortBy);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(20, 390);
            panel1.Name = "panel1";
            panel1.Size = new Size(694, 241);
            panel1.TabIndex = 19;
            // 
            // groupBox4
            // 
            groupBox4.BackgroundImage = Properties.Resources.dark_purple_colour;
            groupBox4.Controls.Add(GameComboBox);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.ButtonFace;
            groupBox4.Location = new Point(382, 50);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(286, 76);
            groupBox4.TabIndex = 24;
            groupBox4.TabStop = false;
            groupBox4.Text = "Game";
            // 
            // GameComboBox
            // 
            GameComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GameComboBox.FormattingEnabled = true;
            GameComboBox.Location = new Point(16, 33);
            GameComboBox.Name = "GameComboBox";
            GameComboBox.Size = new Size(254, 28);
            GameComboBox.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = Properties.Resources.dark_purple_colour;
            groupBox3.Controls.Add(TypeCheckedListBox);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.ButtonFace;
            groupBox3.Location = new Point(382, 132);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(99, 89);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Type";
            // 
            // TypeCheckedListBox
            // 
            TypeCheckedListBox.BackColor = Color.FromArgb(29, 29, 57);
            TypeCheckedListBox.BorderStyle = BorderStyle.None;
            TypeCheckedListBox.CheckOnClick = true;
            TypeCheckedListBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TypeCheckedListBox.ForeColor = SystemColors.ButtonHighlight;
            TypeCheckedListBox.FormattingEnabled = true;
            TypeCheckedListBox.Items.AddRange(new object[] { "1v1", "Teams" });
            TypeCheckedListBox.Location = new Point(16, 33);
            TypeCheckedListBox.Name = "TypeCheckedListBox";
            TypeCheckedListBox.Size = new Size(75, 50);
            TypeCheckedListBox.TabIndex = 0;
            TypeCheckedListBox.ItemCheck += TypeCheckedListBox_ItemCheck;
            // 
            // EnrollButton
            // 
            EnrollButton.BackColor = Color.FromArgb(186, 186, 212);
            EnrollButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnrollButton.Location = new Point(46, 142);
            EnrollButton.Name = "EnrollButton";
            EnrollButton.Size = new Size(159, 49);
            EnrollButton.TabIndex = 23;
            EnrollButton.Text = "Enroll";
            EnrollButton.UseVisualStyleBackColor = false;
            EnrollButton.Click += EnrollButton_Click;
            // 
            // FilterButton
            // 
            FilterButton.BackColor = Color.FromArgb(186, 186, 212);
            FilterButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FilterButton.Location = new Point(46, 48);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(159, 52);
            FilterButton.TabIndex = 22;
            FilterButton.Text = "Filter";
            FilterButton.UseVisualStyleBackColor = false;
            FilterButton.Click += FilterButton_Click;
            // 
            // SortBy
            // 
            SortBy.BackgroundImage = Properties.Resources.dark_purple_colour;
            SortBy.Controls.Add(SortByCheckedListBox);
            SortBy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SortBy.ForeColor = SystemColors.ButtonFace;
            SortBy.Location = new Point(501, 134);
            SortBy.Name = "SortBy";
            SortBy.Size = new Size(167, 87);
            SortBy.TabIndex = 4;
            SortBy.TabStop = false;
            SortBy.Text = "Sort By";
            // 
            // SortByCheckedListBox
            // 
            SortByCheckedListBox.BackColor = Color.FromArgb(29, 29, 57);
            SortByCheckedListBox.BorderStyle = BorderStyle.None;
            SortByCheckedListBox.CheckOnClick = true;
            SortByCheckedListBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SortByCheckedListBox.ForeColor = SystemColors.ButtonHighlight;
            SortByCheckedListBox.FormattingEnabled = true;
            SortByCheckedListBox.Items.AddRange(new object[] { "Available Spots", "Start Date" });
            SortByCheckedListBox.Location = new Point(16, 33);
            SortByCheckedListBox.Name = "SortByCheckedListBox";
            SortByCheckedListBox.Size = new Size(145, 50);
            SortByCheckedListBox.TabIndex = 0;
            SortByCheckedListBox.ItemCheck += SortByCheckedListBox_ItemCheck;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources.dark_purple_colour;
            groupBox2.Controls.Add(RegionCheckedListBox);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(196, 50);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(167, 170);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Region";
            // 
            // RegionCheckedListBox
            // 
            RegionCheckedListBox.BackColor = Color.FromArgb(29, 29, 57);
            RegionCheckedListBox.BorderStyle = BorderStyle.None;
            RegionCheckedListBox.CheckOnClick = true;
            RegionCheckedListBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegionCheckedListBox.ForeColor = SystemColors.ButtonHighlight;
            RegionCheckedListBox.FormattingEnabled = true;
            RegionCheckedListBox.Items.AddRange(new object[] { "North America", "South America", "Europe", "Asia", "Africa" });
            RegionCheckedListBox.Location = new Point(16, 33);
            RegionCheckedListBox.Name = "RegionCheckedListBox";
            RegionCheckedListBox.Size = new Size(145, 125);
            RegionCheckedListBox.TabIndex = 0;
            RegionCheckedListBox.ItemCheck += RegionCheckedListBox_ItemCheck;
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.dark_purple_colour;
            groupBox1.Controls.Add(GenreCheckedListBox);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonFace;
            groupBox1.Location = new Point(27, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(154, 170);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Genre";
            // 
            // GenreCheckedListBox
            // 
            GenreCheckedListBox.BackColor = Color.FromArgb(29, 29, 57);
            GenreCheckedListBox.BorderStyle = BorderStyle.None;
            GenreCheckedListBox.CheckOnClick = true;
            GenreCheckedListBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenreCheckedListBox.ForeColor = SystemColors.ButtonHighlight;
            GenreCheckedListBox.FormattingEnabled = true;
            GenreCheckedListBox.Items.AddRange(new object[] { "Sports", "Racing", "Fighting", "FPS", "Battle Royale" });
            GenreCheckedListBox.Location = new Point(18, 33);
            GenreCheckedListBox.Name = "GenreCheckedListBox";
            GenreCheckedListBox.Size = new Size(130, 125);
            GenreCheckedListBox.TabIndex = 1;
            GenreCheckedListBox.ItemCheck += GenreCheckedListBox_ItemCheck;
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
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel2.Controls.Add(FilterButton);
            panel2.Controls.Add(EnrollButton);
            panel2.Location = new Point(739, 392);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 232);
            panel2.TabIndex = 20;
            // 
            // BrowseTournaments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 188, 212);
            Controls.Add(panel2);
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
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            SortBy.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
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
        private GroupBox groupBox2;
        private CheckedListBox RegionCheckedListBox;
        private GroupBox SortBy;
        private CheckedListBox SortByCheckedListBox;
        private Button EnrollButton;
        private Button FilterButton;
        private Label label3;
        private TextBox SearchTextBox;
        private GroupBox groupBox3;
        private CheckedListBox TypeCheckedListBox;
        private GroupBox groupBox4;
        private ComboBox GameComboBox;
        private Button SearchButton;
        private CheckedListBox GenreCheckedListBox;
        private Panel panel2;
    }
}
