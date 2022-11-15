
namespace _21_22NBAStats
{
    partial class HomeForm
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
            this.uxMenuStrip = new System.Windows.Forms.MenuStrip();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seasonSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coachesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testPanelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMainPanel = new System.Windows.Forms.Panel();
            this.monthlyStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMenuStrip
            // 
            this.uxMenuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uxMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playersToolStripMenuItem,
            this.teamsToolStripMenuItem,
            this.coachesToolStripMenuItem,
            this.testPanelsToolStripMenuItem});
            this.uxMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.uxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxMenuStrip.Name = "uxMenuStrip";
            this.uxMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.uxMenuStrip.Size = new System.Drawing.Size(944, 24);
            this.uxMenuStrip.TabIndex = 0;
            this.uxMenuStrip.Text = "menuStrip1";
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerStatsToolStripMenuItem,
            this.monthlyStatsToolStripMenuItem});
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.playersToolStripMenuItem.Text = "Players";
            // 
            // playerStatsToolStripMenuItem
            // 
            this.playerStatsToolStripMenuItem.Name = "playerStatsToolStripMenuItem";
            this.playerStatsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playerStatsToolStripMenuItem.Text = "Season Stats";
            this.playerStatsToolStripMenuItem.Click += new System.EventHandler(this.PlayerSeasonStatsToolStripMenuItem_Click);
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seasonSummaryToolStripMenuItem});
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.teamsToolStripMenuItem.Text = "Teams";
            // 
            // seasonSummaryToolStripMenuItem
            // 
            this.seasonSummaryToolStripMenuItem.Name = "seasonSummaryToolStripMenuItem";
            this.seasonSummaryToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.seasonSummaryToolStripMenuItem.Text = "Season Summary";
            this.seasonSummaryToolStripMenuItem.Click += new System.EventHandler(this.seasonSummaryToolStripMenuItem_Click);
            // 
            // coachesToolStripMenuItem
            // 
            this.coachesToolStripMenuItem.Name = "coachesToolStripMenuItem";
            this.coachesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.coachesToolStripMenuItem.Text = "Coaches";
            // 
            // testPanelsToolStripMenuItem
            // 
            this.testPanelsToolStripMenuItem.Name = "testPanelsToolStripMenuItem";
            this.testPanelsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.testPanelsToolStripMenuItem.Text = "Home";
            this.testPanelsToolStripMenuItem.Click += new System.EventHandler(this.testPanelsToolStripMenuItem_Click);
            // 
            // uxMainPanel
            // 
            this.uxMainPanel.Location = new System.Drawing.Point(4, 25);
            this.uxMainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uxMainPanel.Name = "uxMainPanel";
            this.uxMainPanel.Size = new System.Drawing.Size(934, 416);
            this.uxMainPanel.TabIndex = 2;
            // 
            // monthlyStatsToolStripMenuItem
            // 
            this.monthlyStatsToolStripMenuItem.Name = "monthlyStatsToolStripMenuItem";
            this.monthlyStatsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monthlyStatsToolStripMenuItem.Text = "Monthly Stats";
            this.monthlyStatsToolStripMenuItem.Click += new System.EventHandler(this.monthlyStatsToolStripMenuItem_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 444);
            this.Controls.Add(this.uxMainPanel);
            this.Controls.Add(this.uxMenuStrip);
            this.MainMenuStrip = this.uxMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomeForm";
            this.Text = "21-22NBAStats";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.uxMenuStrip.ResumeLayout(false);
            this.uxMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coachesToolStripMenuItem;
        private System.Windows.Forms.Panel uxMainPanel;
        private System.Windows.Forms.ToolStripMenuItem testPanelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seasonSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyStatsToolStripMenuItem;
    }
}