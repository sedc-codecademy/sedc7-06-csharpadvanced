namespace WorldCup
{
    partial class WorldCupForm
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
            this.cbxTeams = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbxTeams
            // 
            this.cbxTeams.FormattingEnabled = true;
            this.cbxTeams.Location = new System.Drawing.Point(12, 12);
            this.cbxTeams.Name = "cbxTeams";
            this.cbxTeams.Size = new System.Drawing.Size(121, 21);
            this.cbxTeams.TabIndex = 0;
            // 
            // WorldCupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 587);
            this.Controls.Add(this.cbxTeams);
            this.Name = "WorldCupForm";
            this.Text = "World Cup Images";
            this.Load += new System.EventHandler(this.WorldCupForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTeams;
    }
}

