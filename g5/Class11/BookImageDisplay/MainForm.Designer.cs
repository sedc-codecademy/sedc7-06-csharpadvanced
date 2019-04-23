namespace BookImageDisplay
{
    partial class MainForm
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
            this.pbxCover = new System.Windows.Forms.PictureBox();
            this.lbxAuthors = new System.Windows.Forms.ListBox();
            this.lbxBooks = new System.Windows.Forms.ListBox();
            this.lnkNovelPage = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCover
            // 
            this.pbxCover.Location = new System.Drawing.Point(688, 12);
            this.pbxCover.Name = "pbxCover";
            this.pbxCover.Size = new System.Drawing.Size(390, 437);
            this.pbxCover.TabIndex = 0;
            this.pbxCover.TabStop = false;
            // 
            // lbxAuthors
            // 
            this.lbxAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxAuthors.FormattingEnabled = true;
            this.lbxAuthors.ItemHeight = 23;
            this.lbxAuthors.Location = new System.Drawing.Point(13, 13);
            this.lbxAuthors.Name = "lbxAuthors";
            this.lbxAuthors.Size = new System.Drawing.Size(249, 602);
            this.lbxAuthors.TabIndex = 1;
            this.lbxAuthors.SelectedIndexChanged += new System.EventHandler(this.lbxAuthors_SelectedIndexChanged);
            // 
            // lbxBooks
            // 
            this.lbxBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxBooks.FormattingEnabled = true;
            this.lbxBooks.ItemHeight = 23;
            this.lbxBooks.Location = new System.Drawing.Point(286, 13);
            this.lbxBooks.Name = "lbxBooks";
            this.lbxBooks.Size = new System.Drawing.Size(386, 602);
            this.lbxBooks.TabIndex = 2;
            this.lbxBooks.SelectedIndexChanged += new System.EventHandler(this.lbxBooks_SelectedIndexChanged);
            // 
            // lnkNovelPage
            // 
            this.lnkNovelPage.AutoSize = true;
            this.lnkNovelPage.Location = new System.Drawing.Point(684, 464);
            this.lnkNovelPage.Name = "lnkNovelPage";
            this.lnkNovelPage.Size = new System.Drawing.Size(236, 23);
            this.lnkNovelPage.TabIndex = 3;
            this.lnkNovelPage.TabStop = true;
            this.lnkNovelPage.Text = "Click to open the novel\'s page";
            this.lnkNovelPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNovelPage_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 677);
            this.Controls.Add(this.lnkNovelPage);
            this.Controls.Add(this.lbxBooks);
            this.Controls.Add(this.lbxAuthors);
            this.Controls.Add(this.pbxCover);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Book Image Display";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCover;
        private System.Windows.Forms.ListBox lbxAuthors;
        private System.Windows.Forms.ListBox lbxBooks;
        private System.Windows.Forms.LinkLabel lnkNovelPage;
    }
}

