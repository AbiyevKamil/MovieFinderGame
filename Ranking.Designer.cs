
namespace MovieFinderGame
{
    partial class Ranking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ranking));
            this.listViewRanking = new System.Windows.Forms.ListView();
            this.columnHeaderUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewRanking
            // 
            this.listViewRanking.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewRanking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewRanking.BackColor = System.Drawing.SystemColors.InfoText;
            this.listViewRanking.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderUsername,
            this.columnHeaderScore});
            this.listViewRanking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewRanking.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewRanking.FullRowSelect = true;
            this.listViewRanking.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewRanking.HideSelection = false;
            this.listViewRanking.Location = new System.Drawing.Point(-1, -1);
            this.listViewRanking.Margin = new System.Windows.Forms.Padding(4);
            this.listViewRanking.Name = "listViewRanking";
            this.listViewRanking.Size = new System.Drawing.Size(690, 459);
            this.listViewRanking.TabIndex = 0;
            this.listViewRanking.UseCompatibleStateImageBehavior = false;
            this.listViewRanking.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderUsername
            // 
            this.columnHeaderUsername.Text = "Username";
            this.columnHeaderUsername.Width = 300;
            // 
            // columnHeaderScore
            // 
            this.columnHeaderScore.Text = "Score";
            this.columnHeaderScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderScore.Width = 100;
            // 
            // Ranking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 450);
            this.Controls.Add(this.listViewRanking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 497);
            this.Name = "Ranking";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Ranking_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewRanking;
        private System.Windows.Forms.ColumnHeader columnHeaderUsername;
        private System.Windows.Forms.ColumnHeader columnHeaderScore;
    }
}