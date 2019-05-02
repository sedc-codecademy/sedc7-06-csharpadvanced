namespace FibForm
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
            this.numInput = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnAnalyzeFile = new System.Windows.Forms.Button();
            this.lblAnalisysResult = new System.Windows.Forms.Label();
            this.btnAnalFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lbxAnalResult = new System.Windows.Forms.ListBox();
            this.lbxFilenames = new System.Windows.Forms.ListBox();
            this.lblCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numInput)).BeginInit();
            this.SuspendLayout();
            // 
            // numInput
            // 
            this.numInput.Location = new System.Drawing.Point(49, 41);
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(120, 29);
            this.numInput.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(175, 36);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(147, 38);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(49, 86);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(60, 24);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "label1";
            // 
            // btnAnalyzeFile
            // 
            this.btnAnalyzeFile.Location = new System.Drawing.Point(24, 120);
            this.btnAnalyzeFile.Name = "btnAnalyzeFile";
            this.btnAnalyzeFile.Size = new System.Drawing.Size(166, 62);
            this.btnAnalyzeFile.TabIndex = 3;
            this.btnAnalyzeFile.Text = "Analyze";
            this.btnAnalyzeFile.UseVisualStyleBackColor = true;
            this.btnAnalyzeFile.Click += new System.EventHandler(this.btnAnalyzeFile_Click);
            // 
            // lblAnalisysResult
            // 
            this.lblAnalisysResult.AutoSize = true;
            this.lblAnalisysResult.Location = new System.Drawing.Point(197, 142);
            this.lblAnalisysResult.Name = "lblAnalisysResult";
            this.lblAnalisysResult.Size = new System.Drawing.Size(60, 24);
            this.lblAnalisysResult.TabIndex = 4;
            this.lblAnalisysResult.Text = "label1";
            // 
            // btnAnalFolder
            // 
            this.btnAnalFolder.Location = new System.Drawing.Point(28, 188);
            this.btnAnalFolder.Name = "btnAnalFolder";
            this.btnAnalFolder.Size = new System.Drawing.Size(166, 62);
            this.btnAnalFolder.TabIndex = 5;
            this.btnAnalFolder.Text = "Analyze Folder";
            this.btnAnalFolder.UseVisualStyleBackColor = true;
            this.btnAnalFolder.Click += new System.EventHandler(this.btnAnalFolder_Click);
            // 
            // lbxAnalResult
            // 
            this.lbxAnalResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxAnalResult.FormattingEnabled = true;
            this.lbxAnalResult.ItemHeight = 24;
            this.lbxAnalResult.Location = new System.Drawing.Point(200, 188);
            this.lbxAnalResult.Name = "lbxAnalResult";
            this.lbxAnalResult.Size = new System.Drawing.Size(704, 220);
            this.lbxAnalResult.TabIndex = 6;
            // 
            // lbxFilenames
            // 
            this.lbxFilenames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbxFilenames.FormattingEnabled = true;
            this.lbxFilenames.ItemHeight = 24;
            this.lbxFilenames.Location = new System.Drawing.Point(200, 431);
            this.lbxFilenames.Name = "lbxFilenames";
            this.lbxFilenames.Size = new System.Drawing.Size(704, 148);
            this.lbxFilenames.TabIndex = 7;
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(24, 262);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(60, 24);
            this.lblCounter.TabIndex = 8;
            this.lblCounter.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 591);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.lbxFilenames);
            this.Controls.Add(this.lbxAnalResult);
            this.Controls.Add(this.btnAnalFolder);
            this.Controls.Add(this.lblAnalisysResult);
            this.Controls.Add(this.btnAnalyzeFile);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.numInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Calculating Fibonaccis";
            ((System.ComponentModel.ISupportInitialize)(this.numInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnAnalyzeFile;
        private System.Windows.Forms.Label lblAnalisysResult;
        private System.Windows.Forms.Button btnAnalFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox lbxAnalResult;
        private System.Windows.Forms.ListBox lbxFilenames;
        private System.Windows.Forms.Label lblCounter;
    }
}

