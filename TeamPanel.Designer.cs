
namespace _21_22NBAStats
{
    partial class TeamPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxDataGrid = new System.Windows.Forms.DataGridView();
            this.uxTeamSeasonStats = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.uxTeamName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.uxGamesPlayedMax = new System.Windows.Forms.NumericUpDown();
            this.uxGamesPlayedMin = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uxPPGAgainstMax = new System.Windows.Forms.NumericUpDown();
            this.uxPPGAgainstMin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uxPPGScoredMax = new System.Windows.Forms.NumericUpDown();
            this.uxPPGScoredMin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uxLossesMax = new System.Windows.Forms.NumericUpDown();
            this.uxLossesMin = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxWinsMax = new System.Windows.Forms.NumericUpDown();
            this.uxWinsMin = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGamesPlayedMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGamesPlayedMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPPGAgainstMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPPGAgainstMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPPGScoredMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPPGScoredMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxLossesMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxLossesMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxWinsMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxWinsMin)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDataGrid
            // 
            this.uxDataGrid.AllowUserToAddRows = false;
            this.uxDataGrid.AllowUserToDeleteRows = false;
            this.uxDataGrid.AllowUserToResizeColumns = false;
            this.uxDataGrid.AllowUserToResizeRows = false;
            this.uxDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.uxDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.uxDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGrid.Location = new System.Drawing.Point(3, 3);
            this.uxDataGrid.Name = "uxDataGrid";
            this.uxDataGrid.RowHeadersVisible = false;
            this.uxDataGrid.RowHeadersWidth = 51;
            this.uxDataGrid.RowTemplate.Height = 24;
            this.uxDataGrid.Size = new System.Drawing.Size(1240, 394);
            this.uxDataGrid.TabIndex = 1;
            // 
            // uxTeamSeasonStats
            // 
            this.uxTeamSeasonStats.Location = new System.Drawing.Point(1011, 466);
            this.uxTeamSeasonStats.Name = "uxTeamSeasonStats";
            this.uxTeamSeasonStats.Size = new System.Drawing.Size(184, 43);
            this.uxTeamSeasonStats.TabIndex = 2;
            this.uxTeamSeasonStats.Text = "Season Stats Per Team";
            this.uxTeamSeasonStats.UseVisualStyleBackColor = true;
            this.uxTeamSeasonStats.Click += new System.EventHandler(this.uxTeamSeasonStats_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(577, 479);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 17);
            this.label16.TabIndex = 57;
            this.label16.Text = "Team Name";
            // 
            // uxTeamName
            // 
            this.uxTeamName.FormattingEnabled = true;
            this.uxTeamName.Location = new System.Drawing.Point(688, 476);
            this.uxTeamName.Name = "uxTeamName";
            this.uxTeamName.Size = new System.Drawing.Size(260, 24);
            this.uxTeamName.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(761, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 17);
            this.label9.TabIndex = 53;
            this.label9.Text = "GamesPlayed Max";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(761, 414);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 17);
            this.label10.TabIndex = 52;
            this.label10.Text = "GamesPlayed Min";
            // 
            // uxGamesPlayedMax
            // 
            this.uxGamesPlayedMax.Location = new System.Drawing.Point(892, 444);
            this.uxGamesPlayedMax.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxGamesPlayedMax.Name = "uxGamesPlayedMax";
            this.uxGamesPlayedMax.Size = new System.Drawing.Size(56, 22);
            this.uxGamesPlayedMax.TabIndex = 51;
            this.uxGamesPlayedMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxGamesPlayedMin
            // 
            this.uxGamesPlayedMin.Location = new System.Drawing.Point(892, 412);
            this.uxGamesPlayedMin.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxGamesPlayedMin.Name = "uxGamesPlayedMin";
            this.uxGamesPlayedMin.Size = new System.Drawing.Size(56, 22);
            this.uxGamesPlayedMin.TabIndex = 50;
            this.uxGamesPlayedMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(583, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 49;
            this.label7.Text = "PPGAgainst Max";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(583, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "PPGAgainst Min";
            // 
            // uxPPGAgainstMax
            // 
            this.uxPPGAgainstMax.Location = new System.Drawing.Point(699, 445);
            this.uxPPGAgainstMax.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxPPGAgainstMax.Name = "uxPPGAgainstMax";
            this.uxPPGAgainstMax.Size = new System.Drawing.Size(56, 22);
            this.uxPPGAgainstMax.TabIndex = 47;
            this.uxPPGAgainstMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxPPGAgainstMin
            // 
            this.uxPPGAgainstMin.Location = new System.Drawing.Point(699, 412);
            this.uxPPGAgainstMin.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxPPGAgainstMin.Name = "uxPPGAgainstMin";
            this.uxPPGAgainstMin.Size = new System.Drawing.Size(56, 22);
            this.uxPPGAgainstMin.TabIndex = 46;
            this.uxPPGAgainstMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "PPGScored Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "PPGScored Min";
            // 
            // uxPPGScoredMax
            // 
            this.uxPPGScoredMax.Location = new System.Drawing.Point(521, 443);
            this.uxPPGScoredMax.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxPPGScoredMax.Name = "uxPPGScoredMax";
            this.uxPPGScoredMax.Size = new System.Drawing.Size(56, 22);
            this.uxPPGScoredMax.TabIndex = 43;
            this.uxPPGScoredMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxPPGScoredMin
            // 
            this.uxPPGScoredMin.Location = new System.Drawing.Point(521, 412);
            this.uxPPGScoredMin.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxPPGScoredMin.Name = "uxPPGScoredMin";
            this.uxPPGScoredMin.Size = new System.Drawing.Size(56, 22);
            this.uxPPGScoredMin.TabIndex = 42;
            this.uxPPGScoredMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Losses Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Losses Min";
            // 
            // uxLossesMax
            // 
            this.uxLossesMax.Location = new System.Drawing.Point(350, 443);
            this.uxLossesMax.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxLossesMax.Name = "uxLossesMax";
            this.uxLossesMax.Size = new System.Drawing.Size(56, 22);
            this.uxLossesMax.TabIndex = 39;
            this.uxLossesMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxLossesMin
            // 
            this.uxLossesMin.Location = new System.Drawing.Point(350, 412);
            this.uxLossesMin.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxLossesMin.Name = "uxLossesMin";
            this.uxLossesMin.Size = new System.Drawing.Size(56, 22);
            this.uxLossesMin.TabIndex = 38;
            this.uxLossesMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Wins Max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Wins Min";
            // 
            // uxWinsMax
            // 
            this.uxWinsMax.Location = new System.Drawing.Point(203, 445);
            this.uxWinsMax.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxWinsMax.Name = "uxWinsMax";
            this.uxWinsMax.Size = new System.Drawing.Size(56, 22);
            this.uxWinsMax.TabIndex = 35;
            this.uxWinsMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxWinsMin
            // 
            this.uxWinsMin.Location = new System.Drawing.Point(203, 412);
            this.uxWinsMin.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxWinsMin.Name = "uxWinsMin";
            this.uxWinsMin.Size = new System.Drawing.Size(56, 22);
            this.uxWinsMin.TabIndex = 34;
            this.uxWinsMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TeamPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.uxTeamName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.uxGamesPlayedMax);
            this.Controls.Add(this.uxGamesPlayedMin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uxPPGAgainstMax);
            this.Controls.Add(this.uxPPGAgainstMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uxPPGScoredMax);
            this.Controls.Add(this.uxPPGScoredMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxLossesMax);
            this.Controls.Add(this.uxLossesMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxWinsMax);
            this.Controls.Add(this.uxWinsMin);
            this.Controls.Add(this.uxTeamSeasonStats);
            this.Controls.Add(this.uxDataGrid);
            this.Name = "TeamPanel";
            this.Size = new System.Drawing.Size(1246, 512);
            this.Load += new System.EventHandler(this.TeamPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGamesPlayedMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxGamesPlayedMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPPGAgainstMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPPGAgainstMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPPGScoredMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPPGScoredMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxLossesMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxLossesMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxWinsMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxWinsMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataGrid;
        private System.Windows.Forms.Button uxTeamSeasonStats;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox uxTeamName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown uxGamesPlayedMax;
        private System.Windows.Forms.NumericUpDown uxGamesPlayedMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown uxPPGAgainstMax;
        private System.Windows.Forms.NumericUpDown uxPPGAgainstMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown uxPPGScoredMax;
        private System.Windows.Forms.NumericUpDown uxPPGScoredMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown uxLossesMax;
        private System.Windows.Forms.NumericUpDown uxLossesMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown uxWinsMax;
        private System.Windows.Forms.NumericUpDown uxWinsMin;
    }
}
