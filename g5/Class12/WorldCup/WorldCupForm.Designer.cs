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
            this.lblSelectedTeam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxTeams
            // 
            this.cbxTeams.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTeams.FormattingEnabled = true;
            this.cbxTeams.Location = new System.Drawing.Point(24, 23);
            this.cbxTeams.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxTeams.Name = "cbxTeams";
            this.cbxTeams.Size = new System.Drawing.Size(238, 33);
            this.cbxTeams.TabIndex = 0;
            // 
            // lblSelectedTeam
            // 
            this.lblSelectedTeam.AutoSize = true;
            this.lblSelectedTeam.Location = new System.Drawing.Point(26, 77);
            this.lblSelectedTeam.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSelectedTeam.Name = "lblSelectedTeam";
            this.lblSelectedTeam.Size = new System.Drawing.Size(0, 25);
            this.lblSelectedTeam.TabIndex = 1;
            // 
            // WorldCupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 320);
            this.Controls.Add(this.lblSelectedTeam);
            this.Controls.Add(this.cbxTeams);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "WorldCupForm";
            this.Text = "World Cup Images";
            this.Load += new System.EventHandler(this.WorldCupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTeams;
        private System.Windows.Forms.Label lblSelectedTeam;
    }
}

