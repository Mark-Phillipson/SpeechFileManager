namespace SpeechFileManager
{
    partial class Form1
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
            this.EditFavouritesButton = new System.Windows.Forms.Button();
            this.ListFavouriteFolders = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EditFavouritesButton
            // 
            this.EditFavouritesButton.Location = new System.Drawing.Point(0, -2);
            this.EditFavouritesButton.Name = "EditFavouritesButton";
            this.EditFavouritesButton.Size = new System.Drawing.Size(166, 39);
            this.EditFavouritesButton.TabIndex = 0;
            this.EditFavouritesButton.Text = "Edit Favourites";
            this.EditFavouritesButton.UseVisualStyleBackColor = true;
            // 
            // ListFavouriteFolders
            // 
            this.ListFavouriteFolders.Location = new System.Drawing.Point(0, 43);
            this.ListFavouriteFolders.Name = "ListFavouriteFolders";
            this.ListFavouriteFolders.Size = new System.Drawing.Size(256, 39);
            this.ListFavouriteFolders.TabIndex = 1;
            this.ListFavouriteFolders.Text = "List Favourite Folders";
            this.ListFavouriteFolders.UseVisualStyleBackColor = true;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(262, 47);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(280, 31);
            this.SearchTextBox.TabIndex = 2;
            this.SearchTextBox.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 630);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ListFavouriteFolders);
            this.Controls.Add(this.EditFavouritesButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditFavouritesButton;
        private System.Windows.Forms.Button ListFavouriteFolders;
        private System.Windows.Forms.TextBox SearchTextBox;
    }
}

