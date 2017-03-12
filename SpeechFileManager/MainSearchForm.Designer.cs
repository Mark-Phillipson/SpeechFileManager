namespace SpeechFileManager
{
    partial class MainSearchForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSearchForm));
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.SelectFirst = new System.Windows.Forms.Button();
            this.SelectSecondButton = new System.Windows.Forms.Button();
            this.SelectThirdButton = new System.Windows.Forms.Button();
            this.SelectFourthButton = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SearchSubFoldersCheckBox = new System.Windows.Forms.CheckBox();
            this.OpenFileDirectlyCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchFromTextBox = new System.Windows.Forms.TextBox();
            this.SelectSeventhButton = new System.Windows.Forms.Button();
            this.SelectSixthButton = new System.Windows.Forms.Button();
            this.SelectFifthButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.RootButton = new System.Windows.Forms.Button();
            this.SortAlphabeticallyCheckBox = new System.Windows.Forms.CheckBox();
            this.ResultsCountLabel = new System.Windows.Forms.Label();
            this.ClearSearchButton = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchTextBox.Location = new System.Drawing.Point(74, 28);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(286, 26);
            this.SearchTextBox.TabIndex = 0;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            this.SearchTextBox.Enter += new System.EventHandler(this.SearchTextBox_Enter);
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.AllowDrop = true;
            this.ResultsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultsListBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ResultsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsListBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.ItemHeight = 24;
            this.ResultsListBox.Location = new System.Drawing.Point(74, 58);
            this.ResultsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(773, 292);
            this.ResultsListBox.TabIndex = 3;
            // 
            // SelectFirst
            // 
            this.SelectFirst.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectFirst.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SelectFirst.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectFirst.Location = new System.Drawing.Point(0, 60);
            this.SelectFirst.Margin = new System.Windows.Forms.Padding(2);
            this.SelectFirst.Name = "SelectFirst";
            this.SelectFirst.Size = new System.Drawing.Size(70, 25);
            this.SelectFirst.TabIndex = 4;
            this.SelectFirst.Text = "Select 1st";
            this.SelectFirst.UseVisualStyleBackColor = false;
            this.SelectFirst.Click += new System.EventHandler(this.SelectFirst_Click);
            // 
            // SelectSecondButton
            // 
            this.SelectSecondButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectSecondButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SelectSecondButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectSecondButton.Location = new System.Drawing.Point(0, 84);
            this.SelectSecondButton.Margin = new System.Windows.Forms.Padding(2);
            this.SelectSecondButton.Name = "SelectSecondButton";
            this.SelectSecondButton.Size = new System.Drawing.Size(70, 25);
            this.SelectSecondButton.TabIndex = 5;
            this.SelectSecondButton.Text = "Select 2nd";
            this.SelectSecondButton.UseVisualStyleBackColor = false;
            this.SelectSecondButton.Click += new System.EventHandler(this.SelectSecondButton_Click);
            // 
            // SelectThirdButton
            // 
            this.SelectThirdButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectThirdButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SelectThirdButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectThirdButton.Location = new System.Drawing.Point(0, 107);
            this.SelectThirdButton.Margin = new System.Windows.Forms.Padding(2);
            this.SelectThirdButton.Name = "SelectThirdButton";
            this.SelectThirdButton.Size = new System.Drawing.Size(70, 25);
            this.SelectThirdButton.TabIndex = 6;
            this.SelectThirdButton.Text = "Select 3rd";
            this.SelectThirdButton.UseVisualStyleBackColor = false;
            this.SelectThirdButton.Click += new System.EventHandler(this.SelectThirdButton_Click);
            // 
            // SelectFourthButton
            // 
            this.SelectFourthButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectFourthButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SelectFourthButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectFourthButton.Location = new System.Drawing.Point(0, 131);
            this.SelectFourthButton.Margin = new System.Windows.Forms.Padding(2);
            this.SelectFourthButton.Name = "SelectFourthButton";
            this.SelectFourthButton.Size = new System.Drawing.Size(70, 25);
            this.SelectFourthButton.TabIndex = 7;
            this.SelectFourthButton.Text = "Select 4th";
            this.SelectFourthButton.UseVisualStyleBackColor = false;
            this.SelectFourthButton.Click += new System.EventHandler(this.SelectFourthButton_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 320);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.Padding = new System.Windows.Forms.Padding(0);
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(814, 25);
            this.bindingNavigator1.TabIndex = 11;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(27, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SearchSubFoldersCheckBox
            // 
            this.SearchSubFoldersCheckBox.AutoSize = true;
            this.SearchSubFoldersCheckBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchSubFoldersCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchSubFoldersCheckBox.Location = new System.Drawing.Point(453, 35);
            this.SearchSubFoldersCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchSubFoldersCheckBox.Name = "SearchSubFoldersCheckBox";
            this.SearchSubFoldersCheckBox.Size = new System.Drawing.Size(122, 17);
            this.SearchSubFoldersCheckBox.TabIndex = 12;
            this.SearchSubFoldersCheckBox.Text = "Search Sub  Folders";
            this.SearchSubFoldersCheckBox.UseVisualStyleBackColor = false;
            this.SearchSubFoldersCheckBox.CheckedChanged += new System.EventHandler(this.SearchSubFoldersCheckBox_CheckedChanged);
            // 
            // OpenFileDirectlyCheckBox
            // 
            this.OpenFileDirectlyCheckBox.AutoSize = true;
            this.OpenFileDirectlyCheckBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OpenFileDirectlyCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OpenFileDirectlyCheckBox.Location = new System.Drawing.Point(579, 35);
            this.OpenFileDirectlyCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.OpenFileDirectlyCheckBox.Name = "OpenFileDirectlyCheckBox";
            this.OpenFileDirectlyCheckBox.Size = new System.Drawing.Size(109, 17);
            this.OpenFileDirectlyCheckBox.TabIndex = 13;
            this.OpenFileDirectlyCheckBox.Text = "Open File Directly";
            this.OpenFileDirectlyCheckBox.UseVisualStyleBackColor = false;
            this.OpenFileDirectlyCheckBox.CheckedChanged += new System.EventHandler(this.OpenFileDirectlyCheckBox_CheckedChanged);
            // 
            // SearchFromTextBox
            // 
            this.SearchFromTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchFromTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchFromTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.SearchFromTextBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchFromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFromTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchFromTextBox.Location = new System.Drawing.Point(74, 0);
            this.SearchFromTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchFromTextBox.Name = "SearchFromTextBox";
            this.SearchFromTextBox.Size = new System.Drawing.Size(718, 26);
            this.SearchFromTextBox.TabIndex = 16;
            this.SearchFromTextBox.TextChanged += new System.EventHandler(this.SearchFromTextBox_TextChanged);
            this.SearchFromTextBox.Enter += new System.EventHandler(this.SearchFromTextBox_Enter);
            // 
            // SelectSeventhButton
            // 
            this.SelectSeventhButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectSeventhButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SelectSeventhButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectSeventhButton.Location = new System.Drawing.Point(0, 203);
            this.SelectSeventhButton.Margin = new System.Windows.Forms.Padding(2);
            this.SelectSeventhButton.Name = "SelectSeventhButton";
            this.SelectSeventhButton.Size = new System.Drawing.Size(70, 25);
            this.SelectSeventhButton.TabIndex = 18;
            this.SelectSeventhButton.Text = "Select 7th";
            this.SelectSeventhButton.UseVisualStyleBackColor = false;
            this.SelectSeventhButton.Click += new System.EventHandler(this.SelectSeventhButton_Click);
            // 
            // SelectSixthButton
            // 
            this.SelectSixthButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectSixthButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SelectSixthButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectSixthButton.Location = new System.Drawing.Point(0, 179);
            this.SelectSixthButton.Margin = new System.Windows.Forms.Padding(2);
            this.SelectSixthButton.Name = "SelectSixthButton";
            this.SelectSixthButton.Size = new System.Drawing.Size(70, 25);
            this.SelectSixthButton.TabIndex = 19;
            this.SelectSixthButton.Text = "Select 6th";
            this.SelectSixthButton.UseVisualStyleBackColor = false;
            this.SelectSixthButton.Click += new System.EventHandler(this.SelectSixthButton_Click);
            // 
            // SelectFifthButton
            // 
            this.SelectFifthButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectFifthButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SelectFifthButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SelectFifthButton.Location = new System.Drawing.Point(0, 155);
            this.SelectFifthButton.Margin = new System.Windows.Forms.Padding(2);
            this.SelectFifthButton.Name = "SelectFifthButton";
            this.SelectFifthButton.Size = new System.Drawing.Size(70, 25);
            this.SelectFifthButton.TabIndex = 20;
            this.SelectFifthButton.Text = "Select 5th";
            this.SelectFifthButton.UseVisualStyleBackColor = false;
            this.SelectFifthButton.Click += new System.EventHandler(this.SelectFifthButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchButton.Location = new System.Drawing.Point(0, 30);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(70, 25);
            this.SearchButton.TabIndex = 21;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RootButton
            // 
            this.RootButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RootButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.RootButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RootButton.Location = new System.Drawing.Point(0, 0);
            this.RootButton.Margin = new System.Windows.Forms.Padding(2);
            this.RootButton.Name = "RootButton";
            this.RootButton.Size = new System.Drawing.Size(70, 25);
            this.RootButton.TabIndex = 22;
            this.RootButton.Text = "Root";
            this.RootButton.UseVisualStyleBackColor = false;
            this.RootButton.Click += new System.EventHandler(this.RootButton_Click);
            this.RootButton.Enter += new System.EventHandler(this.RootButton_Enter);
            // 
            // SortAlphabeticallyCheckBox
            // 
            this.SortAlphabeticallyCheckBox.AutoSize = true;
            this.SortAlphabeticallyCheckBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SortAlphabeticallyCheckBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SortAlphabeticallyCheckBox.Location = new System.Drawing.Point(692, 35);
            this.SortAlphabeticallyCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.SortAlphabeticallyCheckBox.Name = "SortAlphabeticallyCheckBox";
            this.SortAlphabeticallyCheckBox.Size = new System.Drawing.Size(119, 17);
            this.SortAlphabeticallyCheckBox.TabIndex = 23;
            this.SortAlphabeticallyCheckBox.Text = "Sort Alphabetically?";
            this.SortAlphabeticallyCheckBox.UseVisualStyleBackColor = false;
            this.SortAlphabeticallyCheckBox.CheckedChanged += new System.EventHandler(this.SortAlphabeticallyCheckBox_CheckedChanged);
            // 
            // ResultsCountLabel
            // 
            this.ResultsCountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResultsCountLabel.Location = new System.Drawing.Point(0, 313);
            this.ResultsCountLabel.Name = "ResultsCountLabel";
            this.ResultsCountLabel.Size = new System.Drawing.Size(70, 28);
            this.ResultsCountLabel.TabIndex = 24;
            this.ResultsCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearSearchButton
            // 
            this.ClearSearchButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearSearchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ClearSearchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearSearchButton.Location = new System.Drawing.Point(364, 29);
            this.ClearSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearSearchButton.Name = "ClearSearchButton";
            this.ClearSearchButton.Size = new System.Drawing.Size(80, 25);
            this.ClearSearchButton.TabIndex = 25;
            this.ClearSearchButton.Text = "Clear Search";
            this.ClearSearchButton.UseVisualStyleBackColor = false;
            this.ClearSearchButton.Click += new System.EventHandler(this.ClearSearchButton_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BrowseButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BrowseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BrowseButton.Location = new System.Drawing.Point(796, 0);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(2);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(51, 25);
            this.BrowseButton.TabIndex = 26;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // MainSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(850, 345);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.ResultsCountLabel);
            this.Controls.Add(this.SortAlphabeticallyCheckBox);
            this.Controls.Add(this.RootButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SelectFifthButton);
            this.Controls.Add(this.SelectSixthButton);
            this.Controls.Add(this.SelectSeventhButton);
            this.Controls.Add(this.SearchFromTextBox);
            this.Controls.Add(this.OpenFileDirectlyCheckBox);
            this.Controls.Add(this.SearchSubFoldersCheckBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.SelectFourthButton);
            this.Controls.Add(this.SelectThirdButton);
            this.Controls.Add(this.SelectSecondButton);
            this.Controls.Add(this.SelectFirst);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ClearSearchButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainSearchForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search For Files";
            this.Load += new System.EventHandler(this.MainSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ListBox ResultsListBox;
        private System.Windows.Forms.Button SelectFirst;
        private System.Windows.Forms.Button SelectSecondButton;
        private System.Windows.Forms.Button SelectThirdButton;
        private System.Windows.Forms.Button SelectFourthButton;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.CheckBox SearchSubFoldersCheckBox;
        private System.Windows.Forms.CheckBox OpenFileDirectlyCheckBox;
        private System.Windows.Forms.TextBox SearchFromTextBox;
        private System.Windows.Forms.Button SelectSeventhButton;
        private System.Windows.Forms.Button SelectSixthButton;
        private System.Windows.Forms.Button SelectFifthButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button RootButton;
        private System.Windows.Forms.CheckBox SortAlphabeticallyCheckBox;
        private System.Windows.Forms.Label ResultsCountLabel;
        private System.Windows.Forms.Button ClearSearchButton;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

