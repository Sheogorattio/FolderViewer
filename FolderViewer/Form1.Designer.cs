namespace FolderViewer
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
            this.MaskTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyWordsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DiskComboBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SubFoldersCheckBox = new System.Windows.Forms.CheckBox();
            this.SearchResultLabel = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListRadio = new System.Windows.Forms.RadioButton();
            this.TileRadio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // MaskTextBox
            // 
            this.MaskTextBox.Location = new System.Drawing.Point(12, 28);
            this.MaskTextBox.Multiline = true;
            this.MaskTextBox.Name = "MaskTextBox";
            this.MaskTextBox.Size = new System.Drawing.Size(100, 24);
            this.MaskTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mask";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Key word";
            // 
            // KeyWordsTextBox
            // 
            this.KeyWordsTextBox.Enabled = false;
            this.KeyWordsTextBox.Location = new System.Drawing.Point(118, 28);
            this.KeyWordsTextBox.Multiline = true;
            this.KeyWordsTextBox.Name = "KeyWordsTextBox";
            this.KeyWordsTextBox.Size = new System.Drawing.Size(162, 24);
            this.KeyWordsTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Drive";
            // 
            // DiskComboBox
            // 
            this.DiskComboBox.FormattingEnabled = true;
            this.DiskComboBox.Items.AddRange(new object[] {
            "C:\\$Recycle.Bin\\"});
            this.DiskComboBox.Location = new System.Drawing.Point(286, 28);
            this.DiskComboBox.Name = "DiskComboBox";
            this.DiskComboBox.Size = new System.Drawing.Size(72, 24);
            this.DiskComboBox.TabIndex = 5;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(364, 26);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 26);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(445, 26);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 26);
            this.StopButton.TabIndex = 6;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // SubFoldersCheckBox
            // 
            this.SubFoldersCheckBox.AutoSize = true;
            this.SubFoldersCheckBox.Location = new System.Drawing.Point(526, 32);
            this.SubFoldersCheckBox.Name = "SubFoldersCheckBox";
            this.SubFoldersCheckBox.Size = new System.Drawing.Size(94, 20);
            this.SubFoldersCheckBox.TabIndex = 7;
            this.SubFoldersCheckBox.Text = "Subfolders";
            this.SubFoldersCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchResultLabel
            // 
            this.SearchResultLabel.AutoSize = true;
            this.SearchResultLabel.Location = new System.Drawing.Point(195, 72);
            this.SearchResultLabel.Name = "SearchResultLabel";
            this.SearchResultLabel.Size = new System.Drawing.Size(85, 16);
            this.SearchResultLabel.TabIndex = 8;
            this.SearchResultLabel.Text = "Search result";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 98);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(617, 412);
            this.listView.TabIndex = 9;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Folder";
            this.columnHeader2.Width = 173;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            this.columnHeader3.Width = 116;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Last modified";
            this.columnHeader4.Width = 173;
            // 
            // ListRadio
            // 
            this.ListRadio.AutoSize = true;
            this.ListRadio.Location = new System.Drawing.Point(13, 72);
            this.ListRadio.Name = "ListRadio";
            this.ListRadio.Size = new System.Drawing.Size(48, 20);
            this.ListRadio.TabIndex = 10;
            this.ListRadio.Text = "List";
            this.ListRadio.UseVisualStyleBackColor = true;
            this.ListRadio.CheckedChanged += new System.EventHandler(this.ListRadio_CheckedChanged);
            // 
            // TileRadio
            // 
            this.TileRadio.AutoSize = true;
            this.TileRadio.Checked = true;
            this.TileRadio.Location = new System.Drawing.Point(68, 72);
            this.TileRadio.Name = "TileRadio";
            this.TileRadio.Size = new System.Drawing.Size(51, 20);
            this.TileRadio.TabIndex = 11;
            this.TileRadio.TabStop = true;
            this.TileRadio.Text = "Tile";
            this.TileRadio.UseVisualStyleBackColor = true;
            this.TileRadio.CheckedChanged += new System.EventHandler(this.TileRadio_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 522);
            this.Controls.Add(this.TileRadio);
            this.Controls.Add(this.ListRadio);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.SearchResultLabel);
            this.Controls.Add(this.SubFoldersCheckBox);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DiskComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KeyWordsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaskTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "FileViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MaskTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KeyWordsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DiskComboBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.CheckBox SubFoldersCheckBox;
        private System.Windows.Forms.Label SearchResultLabel;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.RadioButton ListRadio;
        private System.Windows.Forms.RadioButton TileRadio;
    }
}

