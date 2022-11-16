
namespace _21_22NBAStats
{
    partial class TeamGameResultsPanel
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
            this.label16 = new System.Windows.Forms.Label();
            this.uxTeamName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.uxOpponentName = new System.Windows.Forms.ComboBox();
            this.uxRunTeamGameResults = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uxWinLoss = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uxTeamMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.uxTeamMax = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.uxOppMax = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.uxOppMin = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxTeamMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxTeamMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxOppMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxOppMin)).BeginInit();
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
            this.uxDataGrid.Location = new System.Drawing.Point(2, 2);
            this.uxDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDataGrid.Name = "uxDataGrid";
            this.uxDataGrid.RowHeadersVisible = false;
            this.uxDataGrid.RowHeadersWidth = 51;
            this.uxDataGrid.RowTemplate.Height = 24;
            this.uxDataGrid.Size = new System.Drawing.Size(1240, 394);
            this.uxDataGrid.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(50, 470);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "Team Name";
            // 
            // uxTeamName
            // 
            this.uxTeamName.FormattingEnabled = true;
            this.uxTeamName.Location = new System.Drawing.Point(161, 467);
            this.uxTeamName.Name = "uxTeamName";
            this.uxTeamName.Size = new System.Drawing.Size(260, 24);
            this.uxTeamName.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 37;
            this.label1.Text = "Opponent Name";
            // 
            // uxOpponentName
            // 
            this.uxOpponentName.FormattingEnabled = true;
            this.uxOpponentName.Location = new System.Drawing.Point(608, 467);
            this.uxOpponentName.Name = "uxOpponentName";
            this.uxOpponentName.Size = new System.Drawing.Size(260, 24);
            this.uxOpponentName.TabIndex = 36;
            // 
            // uxRunTeamGameResults
            // 
            this.uxRunTeamGameResults.Location = new System.Drawing.Point(961, 457);
            this.uxRunTeamGameResults.Name = "uxRunTeamGameResults";
            this.uxRunTeamGameResults.Size = new System.Drawing.Size(233, 43);
            this.uxRunTeamGameResults.TabIndex = 38;
            this.uxRunTeamGameResults.Text = "Game Results Per Team";
            this.uxRunTeamGameResults.UseVisualStyleBackColor = true;
            this.uxRunTeamGameResults.Click += new System.EventHandler(this.uxRunTeamGameResults_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Wins or Losses";
            // 
            // uxWinLoss
            // 
            this.uxWinLoss.FormattingEnabled = true;
            this.uxWinLoss.Location = new System.Drawing.Point(161, 418);
            this.uxWinLoss.Name = "uxWinLoss";
            this.uxWinLoss.Size = new System.Drawing.Size(124, 24);
            this.uxWinLoss.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "TeamScore Min";
            // 
            // uxTeamMin
            // 
            this.uxTeamMin.Location = new System.Drawing.Point(590, 405);
            this.uxTeamMin.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.uxTeamMin.Name = "uxTeamMin";
            this.uxTeamMin.Size = new System.Drawing.Size(56, 22);
            this.uxTeamMin.TabIndex = 41;
            this.uxTeamMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "TeamScore Max";
            // 
            // uxTeamMax
            // 
            this.uxTeamMax.Location = new System.Drawing.Point(590, 432);
            this.uxTeamMax.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.uxTeamMax.Name = "uxTeamMax";
            this.uxTeamMax.Size = new System.Drawing.Size(56, 22);
            this.uxTeamMax.TabIndex = 43;
            this.uxTeamMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(673, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 48;
            this.label5.Text = "OpponentScore Max";
            // 
            // uxOppMax
            // 
            this.uxOppMax.Location = new System.Drawing.Point(814, 432);
            this.uxOppMax.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.uxOppMax.Name = "uxOppMax";
            this.uxOppMax.Size = new System.Drawing.Size(56, 22);
            this.uxOppMax.TabIndex = 47;
            this.uxOppMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(673, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "OpponentScore Min";
            // 
            // uxOppMin
            // 
            this.uxOppMin.Location = new System.Drawing.Point(814, 405);
            this.uxOppMin.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.uxOppMin.Name = "uxOppMin";
            this.uxOppMin.Size = new System.Drawing.Size(56, 22);
            this.uxOppMin.TabIndex = 45;
            this.uxOppMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TeamGameResultsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uxOppMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uxOppMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxTeamMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxTeamMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxWinLoss);
            this.Controls.Add(this.uxRunTeamGameResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxOpponentName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.uxTeamName);
            this.Controls.Add(this.uxDataGrid);
            this.Name = "TeamGameResultsPanel";
            this.Size = new System.Drawing.Size(1245, 512);
            this.Load += new System.EventHandler(this.TeamGameResultsPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxTeamMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxTeamMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxOppMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxOppMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataGrid;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox uxTeamName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox uxOpponentName;
        private System.Windows.Forms.Button uxRunTeamGameResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox uxWinLoss;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown uxTeamMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown uxTeamMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown uxOppMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown uxOppMin;
    }
}
