namespace DownloadManagerUI
{
    partial class DownloadmanagerUI
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
            this.buttonSaveTo = new System.Windows.Forms.Button();
            this.buttonAddLink = new System.Windows.Forms.Button();
            this.buttonRemoveLink = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelStatusProgress = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.listBoxOfDownloadFiles = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // buttonSaveTo
            // 
            this.buttonSaveTo.BackColor = System.Drawing.Color.White;
            this.buttonSaveTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveTo.Location = new System.Drawing.Point(473, 12);
            this.buttonSaveTo.Name = "buttonSaveTo";
            this.buttonSaveTo.Size = new System.Drawing.Size(127, 28);
            this.buttonSaveTo.TabIndex = 1;
            this.buttonSaveTo.Text = "Save To";
            this.buttonSaveTo.UseVisualStyleBackColor = false;
            this.buttonSaveTo.Click += new System.EventHandler(this.buttonSaveTo_Click);
            // 
            // buttonAddLink
            // 
            this.buttonAddLink.BackColor = System.Drawing.Color.White;
            this.buttonAddLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddLink.Location = new System.Drawing.Point(473, 46);
            this.buttonAddLink.Name = "buttonAddLink";
            this.buttonAddLink.Size = new System.Drawing.Size(127, 28);
            this.buttonAddLink.TabIndex = 2;
            this.buttonAddLink.Text = "Add Link";
            this.buttonAddLink.UseVisualStyleBackColor = false;
            this.buttonAddLink.Click += new System.EventHandler(this.buttonAddLink_Click);
            // 
            // buttonRemoveLink
            // 
            this.buttonRemoveLink.BackColor = System.Drawing.Color.White;
            this.buttonRemoveLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveLink.Location = new System.Drawing.Point(473, 80);
            this.buttonRemoveLink.Name = "buttonRemoveLink";
            this.buttonRemoveLink.Size = new System.Drawing.Size(127, 28);
            this.buttonRemoveLink.TabIndex = 3;
            this.buttonRemoveLink.Text = "Remove Link";
            this.buttonRemoveLink.UseVisualStyleBackColor = false;
            this.buttonRemoveLink.Click += new System.EventHandler(this.buttonRemoveLink_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.BackColor = System.Drawing.Color.White;
            this.buttonClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearAll.Location = new System.Drawing.Point(473, 114);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(127, 28);
            this.buttonClearAll.TabIndex = 4;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = false;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(12, 320);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(60, 20);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status:";
            // 
            // labelStatusProgress
            // 
            this.labelStatusProgress.AutoSize = true;
            this.labelStatusProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusProgress.Location = new System.Drawing.Point(78, 320);
            this.labelStatusProgress.Name = "labelStatusProgress";
            this.labelStatusProgress.Size = new System.Drawing.Size(21, 20);
            this.labelStatusProgress.TabIndex = 6;
            this.labelStatusProgress.Text = "...";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.White;
            this.progressBar.Location = new System.Drawing.Point(12, 343);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(455, 28);
            this.progressBar.TabIndex = 7;
            // 
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.Color.White;
            this.buttonDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownload.Location = new System.Drawing.Point(473, 343);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(127, 28);
            this.buttonDownload.TabIndex = 8;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // listBoxOfDownloadFiles
            // 
            this.listBoxOfDownloadFiles.FormattingEnabled = true;
            this.listBoxOfDownloadFiles.HorizontalScrollbar = true;
            this.listBoxOfDownloadFiles.Location = new System.Drawing.Point(12, 12);
            this.listBoxOfDownloadFiles.Name = "listBoxOfDownloadFiles";
            this.listBoxOfDownloadFiles.Size = new System.Drawing.Size(455, 290);
            this.listBoxOfDownloadFiles.TabIndex = 9;
            // 
            // DownloadmanagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 382);
            this.Controls.Add(this.listBoxOfDownloadFiles);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelStatusProgress);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonRemoveLink);
            this.Controls.Add(this.buttonAddLink);
            this.Controls.Add(this.buttonSaveTo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DownloadmanagerUI";
            this.Text = "DownloadManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSaveTo;
        private System.Windows.Forms.Button buttonAddLink;
        private System.Windows.Forms.Button buttonRemoveLink;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelStatusProgress;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.ListBox listBoxOfDownloadFiles;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

