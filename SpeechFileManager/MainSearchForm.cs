using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeechFileManager
{
    public partial class MainSearchForm : Form
    {
        string searchFolder;
        System.IO.SearchOption searchOption = System.IO.SearchOption.TopDirectoryOnly;
        enum OpenType
        {
            SelectInExplorer=1,
            Directly
        }
        OpenType openType = OpenType.SelectInExplorer;
        enum SortType
        {
            Alphabetically=1,
            ModifiedDescending
        }
        SortType sortType = SortType.ModifiedDescending;

        public MainSearchForm()
        {
            InitializeComponent();
        }

        private void MainSearchForm_Load(object sender, EventArgs e)
        {
            //Make it look like a Toggle Button
            //this.SearchSubFoldersCheckBox.Appearance = System.Windows.Forms.Appearance.Button;

            searchFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\";
            this.SearchFromTextBox.Text = searchFolder;
            PerformSearch(searchFolder,"*.*",searchOption);
            this.SearchTextBox.Focus();
        }

        private void PerformSearch(string searchFolder, string searchFilter="*.*", System.IO.SearchOption searchOption= System.IO.SearchOption.TopDirectoryOnly)
        {
            if (Directory.Exists(searchFolder))
            {
                IEnumerable<string> fileList = null;
                try
                {
                    // Take a snapshot of the file system.
                    System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(searchFolder);

                    // This method assumes that the application has discovery permissions
                    // for all folders under the specified path.

                    if (sortType == SortType.ModifiedDescending)
                    {
                        fileList = directory.GetFiles(searchFilter, searchOption).OrderByDescending(f => f.LastWriteTime).Select(f => f.FullName);
                    }
                    if (sortType == SortType.Alphabetically)
                    {
                        fileList = directory.GetFiles(searchFilter, searchOption).OrderBy(f => f.Name).Select(f => f.FullName);
                    }

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message,"Exception Occurred",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                fileList = fileList.Take(100).ToList();
                ManageSelectButtons(fileList);
                this.ResultsListBox.DataSource = fileList;

            }
        }

        private void ManageSelectButtons(IEnumerable<string> fileList)
        {
            this.SelectSeventhButton.Visible = true;
            this.SelectSixthButton.Visible = true;
            this.SelectFifthButton.Visible = true;
            this.SelectFourthButton.Visible = true;
            this.SelectThirdButton.Visible = true;
            this.SelectSecondButton.Visible = true;
            this.SelectFirst.Visible = true;

            var listItems = fileList.Count();
            this.ResultsCountLabel.Text = listItems.ToString();
            if (listItems < 8)
            {
                this.SelectSeventhButton.Visible = false;
                if (listItems < 7)
                {
                    this.SelectSixthButton.Visible = false;
                }
                if (listItems < 6)
                {
                    this.SelectSixthButton.Visible = false;
                }
                if (listItems < 5)
                {
                    this.SelectFifthButton.Visible = false;
                }
                if (listItems < 4)
                {
                    this.SelectFourthButton.Visible = false;
                }
                if (listItems < 3)
                {
                    this.SelectThirdButton.Visible = false;
                }
                if (listItems < 2)
                {
                    this.SelectSecondButton.Visible = false;
                }
                if (listItems < 1)
                {
                    this.SelectFirst.Visible = false;
                }
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            PerformSearch(searchFolder,"*" + this.SearchTextBox.Text + "*.*",searchOption);
        }

        private void SelectFirst_Click(object sender, EventArgs e)
        {
            LaunchFile(0);
        }

        private void LaunchFile(int index)
        {
            if (this.ResultsListBox.Items.Count< index+1)
            {
                return;
            }
            this.ResultsListBox.SetSelected(index, true);
            var file = this.ResultsListBox.Text;
            if (openType == OpenType.SelectInExplorer)
            {
                Process.Start("explorer.exe", "/e,/select," + file);
            }
            else
            {
                Process.Start(file);
            }
            this.SearchTextBox.Focus();
        }

        private void SearchSubFoldersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SearchSubFoldersCheckBox.Checked)
            {
                searchOption = System.IO.SearchOption.AllDirectories;
            }
            else
            {
                searchOption = System.IO.SearchOption.TopDirectoryOnly;
            }
        }

        private void SelectSecondButton_Click(object sender, EventArgs e)
        {
            LaunchFile(1);
        }

        private void SelectThirdButton_Click(object sender, EventArgs e)
        {
            LaunchFile(2);
        }

        private void SelectFourthButton_Click(object sender, EventArgs e)
        {
            LaunchFile(3);
        }

        private void OpenFileDirectlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.OpenFileDirectlyCheckBox.Checked)
            {
                openType = OpenType.Directly;
            }
            else
            {
                openType = OpenType.SelectInExplorer;
            }
        }

        private void SearchFromTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.SearchFromTextBox.Text.Length<4)
            {
                SearchSubFoldersCheckBox.Checked = false;
                SearchSubFoldersCheckBox.Visible = false;
            }
            else
            {
                SearchSubFoldersCheckBox.Visible = true;
            }
            searchFolder = this.SearchFromTextBox.Text;
        }

        private void SelectFifthButton_Click(object sender, EventArgs e)
        {
            LaunchFile(4);
        }

        private void SelectSixthButton_Click(object sender, EventArgs e)
        {
            LaunchFile(5);
        }

        private void SelectSeventhButton_Click(object sender, EventArgs e)
        {
            LaunchFile(6);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            this.SearchTextBox.Focus();
        }

        private void RootButton_Click(object sender, EventArgs e)
        {
            this.SearchFromTextBox.Focus();
        }

        private void SortAlphabeticallyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.SortAlphabeticallyCheckBox.Checked)
            {
                sortType = SortType.Alphabetically;
            }
            else
            {
                sortType = SortType.ModifiedDescending;
            }
        }

        private void ClearSearchButton_Click(object sender, EventArgs e)
        {
            this.SearchTextBox.Text = "";
            this.SearchTextBox.Focus();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog()==DialogResult.OK)
            {
                this.SearchFromTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void RootButton_Enter(object sender, EventArgs e)
        {

        }

        private void SearchFromTextBox_Enter(object sender, EventArgs e)
        {
            if (! String.IsNullOrEmpty(SearchFromTextBox.Text))
            {
                SearchFromTextBox.SelectionStart = 0;
                SearchFromTextBox.SelectionLength = SearchFromTextBox.Text.Length;
            }
        }

        private void SearchTextBox_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(SearchTextBox.Text))
            {
                SearchTextBox.SelectionStart = 0;
                SearchTextBox.SelectionLength = SearchTextBox.Text.Length;
            }
        }
    }
}
