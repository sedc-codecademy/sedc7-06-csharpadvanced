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
            this.pboxBadge = new System.Windows.Forms.PictureBox();
            this.pboxTeam = new System.Windows.Forms.PictureBox();
            this.pboxPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBadge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlayer)).BeginInit();
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
            this.cbxTeams.SelectedIndexChanged += new System.EventHandler(this.cbxTeams_SelectedIndexChanged);
            // 
            // lblSelectedTeam
            // 
            this.lblSelectedTeam.AutoSize = true;
            this.lblSelectedTeam.Location = new System.Drawing.Point(274, 26);
            this.lblSelectedTeam.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSelectedTeam.Name = "lblSelectedTeam";
            this.lblSelectedTeam.Size = new System.Drawing.Size(0, 25);
            this.lblSelectedTeam.TabIndex = 1;
            // 
            // pboxBadge
            // 
            this.pboxBadge.Location = new System.Drawing.Point(24, 76);
            this.pboxBadge.Name = "pboxBadge";
            this.pboxBadge.Size = new System.Drawing.Size(296, 340);
            this.pboxBadge.TabIndex = 2;
            this.pboxBadge.TabStop = false;
            // 
            // pboxTeam
            // 
            this.pboxTeam.Location = new System.Drawing.Point(326, 76);
            this.pboxTeam.Name = "pboxTeam";
            this.pboxTeam.Size = new System.Drawing.Size(472, 340);
            this.pboxTeam.TabIndex = 3;
            this.pboxTeam.TabStop = false;
            // 
            // pboxPlayer
            // 
            this.pboxPlayer.Location = new System.Drawing.Point(24, 422);
            this.pboxPlayer.Name = "pboxPlayer";
            this.pboxPlayer.Size = new System.Drawing.Size(296, 319);
            this.pboxPlayer.TabIndex = 4;
            this.pboxPlayer.TabStop = false;
            // 
            // WorldCupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 766);
            this.Controls.Add(this.pboxPlayer);
            this.Controls.Add(this.pboxTeam);
            this.Controls.Add(this.pboxBadge);
            this.Controls.Add(this.lblSelectedTeam);
            this.Controls.Add(this.cbxTeams);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "WorldCupForm";
            this.Text = "World Cup Images";
            this.Load += new System.EventHandler(this.WorldCupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxBadge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxTeams;
        private System.Windows.Forms.Label lblSelectedTeam;
        private System.Windows.Forms.PictureBox pboxBadge;
        private System.Windows.Forms.PictureBox pboxTeam;
        private System.Windows.Forms.PictureBox pboxPlayer;
    }
}

