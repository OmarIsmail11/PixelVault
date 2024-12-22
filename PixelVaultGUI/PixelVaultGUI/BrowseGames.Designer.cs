namespace PixelVaultGUI
{
    partial class BrowseGames
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
            AllGamesDataGridView = new DataGridView();
            label1 = new Label();
            panel1 = new Panel();
            AddToLibraryButton = new Button();
            FilterButton = new Button();
            groupBox1 = new GroupBox();
            GenreCheckedListBox = new CheckedListBox();
            label2 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            AddRecommendedGameButton = new Button();
            RecommendedGamesDataGrid = new DataGridView();
            label5 = new Label();
            ExitButton = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllGamesDataGridView).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RecommendedGamesDataGrid).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel3.Controls.Add(SearchButton);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(SearchTextBox);
            panel3.Controls.Add(AllGamesDataGridView);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(17, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(969, 322);
            panel3.TabIndex = 3;
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
            SearchTextBox.Text = "Search game";
            SearchTextBox.Enter += SearchTextBox_Enter;
            SearchTextBox.Leave += SearchTextBox_Leave;
            // 
            // AllGamesDataGridView
            // 
            AllGamesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AllGamesDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            AllGamesDataGridView.GridColor = Color.Black;
            AllGamesDataGridView.Location = new Point(24, 59);
            AllGamesDataGridView.Name = "AllGamesDataGridView";
            AllGamesDataGridView.RowHeadersWidth = 51;
            AllGamesDataGridView.Size = new Size(922, 236);
            AllGamesDataGridView.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Image = Properties.Resources.dark_purple_colour;
            label1.Location = new Point(24, 13);
            label1.Name = "label1";
            label1.Size = new Size(84, 31);
            label1.TabIndex = 0;
            label1.Text = "Games";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel1.Controls.Add(AddToLibraryButton);
            panel1.Controls.Add(FilterButton);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(17, 388);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 241);
            panel1.TabIndex = 20;
            // 
            // AddToLibraryButton
            // 
            AddToLibraryButton.BackColor = Color.FromArgb(186, 186, 212);
            AddToLibraryButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddToLibraryButton.Location = new Point(218, 148);
            AddToLibraryButton.Name = "AddToLibraryButton";
            AddToLibraryButton.Size = new Size(175, 49);
            AddToLibraryButton.TabIndex = 24;
            AddToLibraryButton.Text = "Add To Library";
            AddToLibraryButton.UseVisualStyleBackColor = false;
            AddToLibraryButton.Click += AddToLibraryButton_Click;
            // 
            // FilterButton
            // 
            FilterButton.BackColor = Color.FromArgb(186, 186, 212);
            FilterButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FilterButton.Location = new Point(249, 63);
            FilterButton.Name = "FilterButton";
            FilterButton.Size = new Size(113, 52);
            FilterButton.TabIndex = 23;
            FilterButton.Text = "Filter";
            FilterButton.UseVisualStyleBackColor = false;
            FilterButton.Click += FilterButton_Click;
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
            panel2.BackColor = Color.White;
            panel2.BackgroundImage = Properties.Resources.dark_purple_colour;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(AddRecommendedGameButton);
            panel2.Controls.Add(RecommendedGamesDataGrid);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(455, 388);
            panel2.Name = "panel2";
            panel2.Size = new Size(531, 241);
            panel2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Image = Properties.Resources.dark_purple_colour;
            label4.Location = new Point(347, 16);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 5;
            label4.Text = "Add To Library";
            // 
            // AddRecommendedGameButton
            // 
            AddRecommendedGameButton.Image = Properties.Resources.add3;
            AddRecommendedGameButton.Location = new Point(474, 13);
            AddRecommendedGameButton.Name = "AddRecommendedGameButton";
            AddRecommendedGameButton.Size = new Size(34, 31);
            AddRecommendedGameButton.TabIndex = 2;
            AddRecommendedGameButton.UseVisualStyleBackColor = true;
            AddRecommendedGameButton.Click += AddRecommendedGameButton_Click;
            // 
            // RecommendedGamesDataGrid
            // 
            RecommendedGamesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RecommendedGamesDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            RecommendedGamesDataGrid.GridColor = Color.Black;
            RecommendedGamesDataGrid.Location = new Point(24, 59);
            RecommendedGamesDataGrid.Name = "RecommendedGamesDataGrid";
            RecommendedGamesDataGrid.RowHeadersWidth = 51;
            RecommendedGamesDataGrid.Size = new Size(484, 158);
            RecommendedGamesDataGrid.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Image = Properties.Resources.dark_purple_colour;
            label5.Location = new Point(24, 13);
            label5.Name = "label5";
            label5.Size = new Size(226, 31);
            label5.TabIndex = 0;
            label5.Text = "Games You May Like";
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExitButton.ForeColor = SystemColors.ButtonHighlight;
            ExitButton.Image = Properties.Resources.dark_purple_colour;
            ExitButton.Location = new Point(976, -1);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(35, 38);
            ExitButton.TabIndex = 19;
            ExitButton.Text = "X";
            ExitButton.Click += ExitButton_Click;
            // 
            // BrowseGames
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 188, 212);
            Controls.Add(ExitButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "BrowseGames";
            Size = new Size(1011, 653);
            Load += BrowseGames_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AllGamesDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RecommendedGamesDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel3;
        private Button SearchButton;
        private Label label3;
        private TextBox SearchTextBox;
        private DataGridView AllGamesDataGridView;
        private Label label1;
        private Panel panel1;
        private GroupBox groupBox1;
        private CheckedListBox GenreCheckedListBox;
        private Label label2;
        private Button FilterButton;
        private Panel panel2;
        private Label label4;
        private TextBox textBox1;
        private DataGridView RecommendedGamesDataGrid;
        private Label label5;
        private Button AddToLibraryButton;
        private Button AddRecommendedGameButton;
        private Label ExitButton;
    }
}
