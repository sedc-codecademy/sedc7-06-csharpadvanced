namespace BooksEditor
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
            this.lbxBooks = new System.Windows.Forms.ListBox();
            this.lbxAuthors = new System.Windows.Forms.ListBox();
            this.cbxColumnSelector = new System.Windows.Forms.ComboBox();
            this.txtНаслов = new System.Windows.Forms.TextBox();
            this.lblНаслов = new System.Windows.Forms.Label();
            this.btnSaveНаслов = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxBooks
            // 
            this.lbxBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxBooks.FormattingEnabled = true;
            this.lbxBooks.ItemHeight = 24;
            this.lbxBooks.Location = new System.Drawing.Point(285, 60);
            this.lbxBooks.Name = "lbxBooks";
            this.lbxBooks.Size = new System.Drawing.Size(386, 532);
            this.lbxBooks.TabIndex = 4;
            this.lbxBooks.SelectedIndexChanged += new System.EventHandler(this.lbxBooks_SelectedIndexChanged);
            // 
            // lbxAuthors
            // 
            this.lbxAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxAuthors.FormattingEnabled = true;
            this.lbxAuthors.ItemHeight = 24;
            this.lbxAuthors.Location = new System.Drawing.Point(12, 12);
            this.lbxAuthors.Name = "lbxAuthors";
            this.lbxAuthors.Size = new System.Drawing.Size(249, 580);
            this.lbxAuthors.TabIndex = 3;
            this.lbxAuthors.SelectedIndexChanged += new System.EventHandler(this.lbxAuthors_SelectedIndexChanged);
            // 
            // cbxColumnSelector
            // 
            this.cbxColumnSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxColumnSelector.FormattingEnabled = true;
            this.cbxColumnSelector.Items.AddRange(new object[] {
            "ID",
            "Title",
            "Year",
            "Series",
            "SeriesIndex",
            "SeriesDisplay"});
            this.cbxColumnSelector.Location = new System.Drawing.Point(285, 12);
            this.cbxColumnSelector.Name = "cbxColumnSelector";
            this.cbxColumnSelector.Size = new System.Drawing.Size(386, 32);
            this.cbxColumnSelector.TabIndex = 5;
            this.cbxColumnSelector.SelectedIndexChanged += new System.EventHandler(this.cbxColumnSelector_SelectedIndexChanged);
            // 
            // txtНаслов
            // 
            this.txtНаслов.Location = new System.Drawing.Point(709, 87);
            this.txtНаслов.Name = "txtНаслов";
            this.txtНаслов.Size = new System.Drawing.Size(240, 29);
            this.txtНаслов.TabIndex = 6;
            // 
            // lblНаслов
            // 
            this.lblНаслов.AutoSize = true;
            this.lblНаслов.Location = new System.Drawing.Point(705, 60);
            this.lblНаслов.Name = "lblНаслов";
            this.lblНаслов.Size = new System.Drawing.Size(161, 24);
            this.lblНаслов.TabIndex = 7;
            this.lblНаслов.Text = "Внесете Наслов:";
            // 
            // btnSaveНаслов
            // 
            this.btnSaveНаслов.Location = new System.Drawing.Point(709, 123);
            this.btnSaveНаслов.Name = "btnSaveНаслов";
            this.btnSaveНаслов.Size = new System.Drawing.Size(179, 48);
            this.btnSaveНаслов.TabIndex = 8;
            this.btnSaveНаслов.Text = "Save";
            this.btnSaveНаслов.UseVisualStyleBackColor = true;
            this.btnSaveНаслов.Click += new System.EventHandler(this.btnSaveНаслов_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 607);
            this.Controls.Add(this.btnSaveНаслов);
            this.Controls.Add(this.lblНаслов);
            this.Controls.Add(this.txtНаслов);
            this.Controls.Add(this.cbxColumnSelector);
            this.Controls.Add(this.lbxBooks);
            this.Controls.Add(this.lbxAuthors);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxBooks;
        private System.Windows.Forms.ListBox lbxAuthors;
        private System.Windows.Forms.ComboBox cbxColumnSelector;
        private System.Windows.Forms.TextBox txtНаслов;
        private System.Windows.Forms.Label lblНаслов;
        private System.Windows.Forms.Button btnSaveНаслов;
    }
}

