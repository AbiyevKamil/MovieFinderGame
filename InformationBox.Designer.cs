
namespace MovieFinderGame
{
    partial class InformationBox
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
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelMadeBy = new System.Windows.Forms.Label();
            this.labelGithubRepo = new System.Windows.Forms.Label();
            this.linkLabelRepo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(13, 20);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(122, 25);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "Version: 3.0.0";
            // 
            // labelMadeBy
            // 
            this.labelMadeBy.AutoSize = true;
            this.labelMadeBy.Location = new System.Drawing.Point(13, 59);
            this.labelMadeBy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMadeBy.Name = "labelMadeBy";
            this.labelMadeBy.Size = new System.Drawing.Size(198, 25);
            this.labelMadeBy.TabIndex = 1;
            this.labelMadeBy.Text = "Made by Kamil Abiyev";
            // 
            // labelGithubRepo
            // 
            this.labelGithubRepo.AutoSize = true;
            this.labelGithubRepo.Location = new System.Drawing.Point(13, 103);
            this.labelGithubRepo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGithubRepo.Name = "labelGithubRepo";
            this.labelGithubRepo.Size = new System.Drawing.Size(163, 25);
            this.labelGithubRepo.TabIndex = 2;
            this.labelGithubRepo.Text = "Github repository:";
            // 
            // linkLabelRepo
            // 
            this.linkLabelRepo.AutoSize = true;
            this.linkLabelRepo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelRepo.LinkColor = System.Drawing.Color.Crimson;
            this.linkLabelRepo.Location = new System.Drawing.Point(86, 160);
            this.linkLabelRepo.Name = "linkLabelRepo";
            this.linkLabelRepo.Size = new System.Drawing.Size(176, 25);
            this.linkLabelRepo.TabIndex = 3;
            this.linkLabelRepo.TabStop = true;
            this.linkLabelRepo.Text = "Movie Finder Game";
            this.linkLabelRepo.VisitedLinkColor = System.Drawing.Color.Red;
            this.linkLabelRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRepo_LinkClicked);
            // 
            // InformationBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 211);
            this.Controls.Add(this.linkLabelRepo);
            this.Controls.Add(this.labelGithubRepo);
            this.Controls.Add(this.labelMadeBy);
            this.Controls.Add(this.labelVersion);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(339, 258);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(339, 258);
            this.Name = "InformationBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Movie Finder Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelMadeBy;
        private System.Windows.Forms.Label labelGithubRepo;
        private System.Windows.Forms.LinkLabel linkLabelRepo;
    }
}