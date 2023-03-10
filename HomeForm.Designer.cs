
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
            this.testPanelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameStatLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherPlayerQueriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seasonSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentPlayersListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coachesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coachesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataModificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeleteCoachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMainPanel = new System.Windows.Forms.Panel();
            this.uxPageLabel = new System.Windows.Forms.Label();
            this.uxMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMenuStrip
            // 
            this.uxMenuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uxMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testPanelsToolStripMenuItem,
            this.playersToolStripMenuItem,
            this.teamsToolStripMenuItem,
            this.coachesToolStripMenuItem,
            this.dataModificationToolStripMenuItem,
            this.sourcesToolStripMenuItem});
            this.uxMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.uxMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.uxMenuStrip.Name = "uxMenuStrip";
            this.uxMenuStrip.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.uxMenuStrip.Size = new System.Drawing.Size(1259, 28);
            this.uxMenuStrip.TabIndex = 0;
            this.uxMenuStrip.Text = "menuStrip1";
            // 
            // testPanelsToolStripMenuItem
            // 
            this.testPanelsToolStripMenuItem.Name = "testPanelsToolStripMenuItem";
            this.testPanelsToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.testPanelsToolStripMenuItem.Text = "Home";
            this.testPanelsToolStripMenuItem.Click += new System.EventHandler(this.testPanelsToolStripMenuItem_Click);
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerStatsToolStripMenuItem,
            this.monthlyStatsToolStripMenuItem,
            this.gameStatLinesToolStripMenuItem,
            this.otherPlayerQueriesToolStripMenuItem});
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.playersToolStripMenuItem.Text = "Players";
            // 
            // playerStatsToolStripMenuItem
            // 
            this.playerStatsToolStripMenuItem.Name = "playerStatsToolStripMenuItem";
            this.playerStatsToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.playerStatsToolStripMenuItem.Text = "Season Stats";
            this.playerStatsToolStripMenuItem.Click += new System.EventHandler(this.PlayerSeasonStatsToolStripMenuItem_Click);
            // 
            // monthlyStatsToolStripMenuItem
            // 
            this.monthlyStatsToolStripMenuItem.Name = "monthlyStatsToolStripMenuItem";
            this.monthlyStatsToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.monthlyStatsToolStripMenuItem.Text = "Monthly Stats";
            this.monthlyStatsToolStripMenuItem.Click += new System.EventHandler(this.monthlyStatsToolStripMenuItem_Click);
            // 
            // gameStatLinesToolStripMenuItem
            // 
            this.gameStatLinesToolStripMenuItem.Name = "gameStatLinesToolStripMenuItem";
            this.gameStatLinesToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.gameStatLinesToolStripMenuItem.Text = "Game Stat Lines";
            this.gameStatLinesToolStripMenuItem.Click += new System.EventHandler(this.gameStatLinesToolStripMenuItem_Click);
            // 
            // otherPlayerQueriesToolStripMenuItem
            // 
            this.otherPlayerQueriesToolStripMenuItem.Name = "otherPlayerQueriesToolStripMenuItem";
            this.otherPlayerQueriesToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.otherPlayerQueriesToolStripMenuItem.Text = "Other Player Queries";
            this.otherPlayerQueriesToolStripMenuItem.Click += new System.EventHandler(this.otherPlayerQueriesToolStripMenuItem_Click);
            // 
            // teamsToolStripMenuItem
            // 
            this.teamsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seasonSummaryToolStripMenuItem,
            this.gamesToolStripMenuItem,
            this.currentPlayersListToolStripMenuItem});
            this.teamsToolStripMenuItem.Name = "teamsToolStripMenuItem";
            this.teamsToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.teamsToolStripMenuItem.Text = "Teams";
            // 
            // seasonSummaryToolStripMenuItem
            // 
            this.seasonSummaryToolStripMenuItem.Name = "seasonSummaryToolStripMenuItem";
            this.seasonSummaryToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.seasonSummaryToolStripMenuItem.Text = "Season Summary";
            this.seasonSummaryToolStripMenuItem.Click += new System.EventHandler(this.seasonSummaryToolStripMenuItem_Click);
            // 
            // gamesToolStripMenuItem
            // 
            this.gamesToolStripMenuItem.Name = "gamesToolStripMenuItem";
            this.gamesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.gamesToolStripMenuItem.Text = "Game Results";
            this.gamesToolStripMenuItem.Click += new System.EventHandler(this.gamesToolStripMenuItem_Click);
            // 
            // currentPlayersListToolStripMenuItem
            // 
            this.currentPlayersListToolStripMenuItem.Name = "currentPlayersListToolStripMenuItem";
            this.currentPlayersListToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.currentPlayersListToolStripMenuItem.Text = "Current Players List";
            this.currentPlayersListToolStripMenuItem.Click += new System.EventHandler(this.currentPlayersListToolStripMenuItem_Click);
            // 
            // coachesToolStripMenuItem
            // 
            this.coachesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coachesListToolStripMenuItem});
            this.coachesToolStripMenuItem.Name = "coachesToolStripMenuItem";
            this.coachesToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.coachesToolStripMenuItem.Text = "Coaches";
            // 
            // coachesListToolStripMenuItem
            // 
            this.coachesListToolStripMenuItem.Name = "coachesListToolStripMenuItem";
            this.coachesListToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.coachesListToolStripMenuItem.Text = "Coaches List";
            this.coachesListToolStripMenuItem.Click += new System.EventHandler(this.coachesListToolStripMenuItem_Click);
            // 
            // dataModificationToolStripMenuItem
            // 
            this.dataModificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGameToolStripMenuItem,
            this.addDeleteCoachToolStripMenuItem,
            this.addPlayerToolStripMenuItem});
            this.dataModificationToolStripMenuItem.Name = "dataModificationToolStripMenuItem";
            this.dataModificationToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.dataModificationToolStripMenuItem.Text = "Data Modification";
            // 
            // addGameToolStripMenuItem
            // 
            this.addGameToolStripMenuItem.Name = "addGameToolStripMenuItem";
            this.addGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addGameToolStripMenuItem.Text = "Add Game";
            this.addGameToolStripMenuItem.Click += new System.EventHandler(this.addGameToolStripMenuItem_Click);
            // 
            // addDeleteCoachToolStripMenuItem
            // 
            this.addDeleteCoachToolStripMenuItem.Name = "addDeleteCoachToolStripMenuItem";
            this.addDeleteCoachToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addDeleteCoachToolStripMenuItem.Text = "Add/Delete Coach";
            this.addDeleteCoachToolStripMenuItem.Click += new System.EventHandler(this.addDeleteCoachToolStripMenuItem_Click);
            // 
            // addPlayerToolStripMenuItem
            // 
            this.addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            this.addPlayerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addPlayerToolStripMenuItem.Text = "Add/Update Player";
            this.addPlayerToolStripMenuItem.Click += new System.EventHandler(this.addPlayerToolStripMenuItem_Click);
            // 
            // sourcesToolStripMenuItem
            // 
            this.sourcesToolStripMenuItem.Name = "sourcesToolStripMenuItem";
            this.sourcesToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.sourcesToolStripMenuItem.Text = "Sources";
            this.sourcesToolStripMenuItem.Click += new System.EventHandler(this.sourcesToolStripMenuItem_Click);
            // 
            // uxMainPanel
            // 
            this.uxMainPanel.Location = new System.Drawing.Point(5, 73);
            this.uxMainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxMainPanel.Name = "uxMainPanel";
            this.uxMainPanel.Size = new System.Drawing.Size(1246, 512);
            this.uxMainPanel.TabIndex = 2;
            // 
            // uxPageLabel
            // 
            this.uxPageLabel.AutoSize = true;
            this.uxPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxPageLabel.Location = new System.Drawing.Point(12, 38);
            this.uxPageLabel.Name = "uxPageLabel";
            this.uxPageLabel.Size = new System.Drawing.Size(255, 29);
            this.uxPageLabel.TabIndex = 3;
            this.uxPageLabel.Text = "2021-22 NBA Statistics";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 594);
            this.Controls.Add(this.uxPageLabel);
            this.Controls.Add(this.uxMainPanel);
            this.Controls.Add(this.uxMenuStrip);
            this.MainMenuStrip = this.uxMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ToolStripMenuItem otherPlayerQueriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coachesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameStatLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataModificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentPlayersListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDeleteCoachToolStripMenuItem;
        private System.Windows.Forms.Label uxPageLabel;
        private System.Windows.Forms.ToolStripMenuItem sourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPlayerToolStripMenuItem;
    }
}