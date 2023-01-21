namespace DownloadManagerUI
{
    partial class AddLinkUI
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
            this.labelAddLink = new System.Windows.Forms.Label();
            this.textBoxAddLink = new System.Windows.Forms.TextBox();
            this.buttonOKAddLink = new System.Windows.Forms.Button();
            this.buttonCancelAddLink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddLink
            // 
            this.labelAddLink.AutoSize = true;
            this.labelAddLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddLink.Location = new System.Drawing.Point(12, 18);
            this.labelAddLink.Name = "labelAddLink";
            this.labelAddLink.Size = new System.Drawing.Size(108, 20);
            this.labelAddLink.TabIndex = 6;
            this.labelAddLink.Text = "Add URL Link";
            // 
            // textBoxAddLink
            // 
            this.textBoxAddLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddLink.Location = new System.Drawing.Point(126, 15);
            this.textBoxAddLink.Name = "textBoxAddLink";
            this.textBoxAddLink.Size = new System.Drawing.Size(585, 26);
            this.textBoxAddLink.TabIndex = 7;
            // 
            // buttonOKAddLink
            // 
            this.buttonOKAddLink.BackColor = System.Drawing.Color.White;
            this.buttonOKAddLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOKAddLink.Location = new System.Drawing.Point(584, 60);
            this.buttonOKAddLink.Name = "buttonOKAddLink";
            this.buttonOKAddLink.Size = new System.Drawing.Size(127, 28);
            this.buttonOKAddLink.TabIndex = 8;
            this.buttonOKAddLink.Text = "OK";
            this.buttonOKAddLink.UseVisualStyleBackColor = false;
            this.buttonOKAddLink.Click += new System.EventHandler(this.buttonOKAddLink_Click);
            // 
            // buttonCancelAddLink
            // 
            this.buttonCancelAddLink.BackColor = System.Drawing.Color.White;
            this.buttonCancelAddLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelAddLink.Location = new System.Drawing.Point(451, 60);
            this.buttonCancelAddLink.Name = "buttonCancelAddLink";
            this.buttonCancelAddLink.Size = new System.Drawing.Size(127, 28);
            this.buttonCancelAddLink.TabIndex = 9;
            this.buttonCancelAddLink.Text = "Cancel";
            this.buttonCancelAddLink.UseVisualStyleBackColor = false;
            this.buttonCancelAddLink.Click += new System.EventHandler(this.buttonCancelAddLink_Click);
            // 
            // AddLinkUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 99);
            this.Controls.Add(this.buttonCancelAddLink);
            this.Controls.Add(this.buttonOKAddLink);
            this.Controls.Add(this.textBoxAddLink);
            this.Controls.Add(this.labelAddLink);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddLinkUI";
            this.Text = "Add Link";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddLink;
        private System.Windows.Forms.TextBox textBoxAddLink;
        private System.Windows.Forms.Button buttonOKAddLink;
        private System.Windows.Forms.Button buttonCancelAddLink;
    }
}