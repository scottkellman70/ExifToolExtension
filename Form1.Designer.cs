namespace ExifToolExtension
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
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonGPSData = new System.Windows.Forms.Button();
            this.listBoxTopResults = new System.Windows.Forms.ListBox();
            this.buttonAllEXIFData = new System.Windows.Forms.Button();
            this.buttonSerialNumber = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearchTerm = new System.Windows.Forms.TextBox();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.listBoxBottomResults = new System.Windows.Forms.ListBox();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxTag = new System.Windows.Forms.TextBox();
            this.ButtonByTag = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Location = new System.Drawing.Point(12, 22);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(93, 23);
            this.buttonSelectFile.TabIndex = 0;
            this.buttonSelectFile.Text = "Select File";
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.ButtonSelectFile_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(111, 22);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(440, 20);
            this.textBoxFile.TabIndex = 1;
            // 
            // buttonGPSData
            // 
            this.buttonGPSData.Location = new System.Drawing.Point(12, 48);
            this.buttonGPSData.Name = "buttonGPSData";
            this.buttonGPSData.Size = new System.Drawing.Size(93, 23);
            this.buttonGPSData.TabIndex = 2;
            this.buttonGPSData.Text = "GPS Data";
            this.buttonGPSData.UseVisualStyleBackColor = true;
            this.buttonGPSData.Click += new System.EventHandler(this.ButtonGPSData_Click);
            // 
            // listBoxTopResults
            // 
            this.listBoxTopResults.FormattingEnabled = true;
            this.listBoxTopResults.Location = new System.Drawing.Point(111, 48);
            this.listBoxTopResults.Name = "listBoxTopResults";
            this.listBoxTopResults.Size = new System.Drawing.Size(440, 199);
            this.listBoxTopResults.TabIndex = 3;
            // 
            // buttonAllEXIFData
            // 
            this.buttonAllEXIFData.Location = new System.Drawing.Point(12, 77);
            this.buttonAllEXIFData.Name = "buttonAllEXIFData";
            this.buttonAllEXIFData.Size = new System.Drawing.Size(93, 23);
            this.buttonAllEXIFData.TabIndex = 4;
            this.buttonAllEXIFData.Text = "All EXIF";
            this.buttonAllEXIFData.UseVisualStyleBackColor = true;
            this.buttonAllEXIFData.Click += new System.EventHandler(this.ButtonAllEXIF_Click);
            // 
            // buttonSerialNumber
            // 
            this.buttonSerialNumber.Location = new System.Drawing.Point(12, 106);
            this.buttonSerialNumber.Name = "buttonSerialNumber";
            this.buttonSerialNumber.Size = new System.Drawing.Size(93, 23);
            this.buttonSerialNumber.TabIndex = 5;
            this.buttonSerialNumber.Text = "Serial Number";
            this.buttonSerialNumber.UseVisualStyleBackColor = true;
            this.buttonSerialNumber.Click += new System.EventHandler(this.ButtonSerialNumber_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(12, 323);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(93, 23);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // textBoxSearchTerm
            // 
            this.textBoxSearchTerm.Location = new System.Drawing.Point(111, 323);
            this.textBoxSearchTerm.Name = "textBoxSearchTerm";
            this.textBoxSearchTerm.Size = new System.Drawing.Size(295, 20);
            this.textBoxSearchTerm.TabIndex = 7;
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Location = new System.Drawing.Point(111, 299);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(440, 20);
            this.textBoxFolder.TabIndex = 9;
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(12, 299);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(93, 23);
            this.buttonSelectFolder.TabIndex = 8;
            this.buttonSelectFolder.Text = "Select Folder";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.ButtonSelectFolder_Click);
            // 
            // listBoxBottomResults
            // 
            this.listBoxBottomResults.FormattingEnabled = true;
            this.listBoxBottomResults.Location = new System.Drawing.Point(111, 349);
            this.listBoxBottomResults.Name = "listBoxBottomResults";
            this.listBoxBottomResults.Size = new System.Drawing.Size(440, 199);
            this.listBoxBottomResults.TabIndex = 10;
            // 
            // textBoxTag
            // 
            this.textBoxTag.Location = new System.Drawing.Point(557, 22);
            this.textBoxTag.Name = "textBoxTag";
            this.textBoxTag.Size = new System.Drawing.Size(100, 20);
            this.textBoxTag.TabIndex = 11;
            // 
            // ButtonByTag
            // 
            this.ButtonByTag.Location = new System.Drawing.Point(557, 48);
            this.ButtonByTag.Name = "ButtonByTag";
            this.ButtonByTag.Size = new System.Drawing.Size(75, 23);
            this.ButtonByTag.TabIndex = 12;
            this.ButtonByTag.Text = "By Tag";
            this.ButtonByTag.UseVisualStyleBackColor = true;
            this.ButtonByTag.Click += new System.EventHandler(this.ButtonByTag_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.ButtonByTag);
            this.Controls.Add(this.textBoxTag);
            this.Controls.Add(this.listBoxBottomResults);
            this.Controls.Add(this.textBoxFolder);
            this.Controls.Add(this.buttonSelectFolder);
            this.Controls.Add(this.textBoxSearchTerm);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonSerialNumber);
            this.Controls.Add(this.buttonAllEXIFData);
            this.Controls.Add(this.listBoxTopResults);
            this.Controls.Add(this.buttonGPSData);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.buttonSelectFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button buttonGPSData;
        private System.Windows.Forms.ListBox listBoxTopResults;
        private System.Windows.Forms.Button buttonAllEXIFData;
        private System.Windows.Forms.Button buttonSerialNumber;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearchTerm;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.ListBox listBoxBottomResults;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.TextBox textBoxTag;
        private System.Windows.Forms.Button ButtonByTag;
    }
}

