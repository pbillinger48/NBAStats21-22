
namespace _21_22NBAStats
{
    partial class PlayerGameStatsPanel
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
            this.uxRunPlayerGameStats = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.uxPlayerName = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.uxOppName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxPointsMax = new System.Windows.Forms.NumericUpDown();
            this.uxPointsMin = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.uxMinutesMin = new System.Windows.Forms.NumericUpDown();
            this.uxMinutesMax = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPointsMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPointsMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMinutesMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMinutesMax)).BeginInit();
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
            this.uxDataGrid.Location = new System.Drawing.Point(2, 3);
            this.uxDataGrid.Name = "uxDataGrid";
            this.uxDataGrid.RowHeadersVisible = false;
            this.uxDataGrid.RowHeadersWidth = 51;
            this.uxDataGrid.RowTemplate.Height = 24;
            this.uxDataGrid.Size = new System.Drawing.Size(1240, 394);
            this.uxDataGrid.TabIndex = 1;
            // 
            // uxRunPlayerGameStats
            // 
            this.uxRunPlayerGameStats.Location = new System.Drawing.Point(944, 426);
            this.uxRunPlayerGameStats.Name = "uxRunPlayerGameStats";
            this.uxRunPlayerGameStats.Size = new System.Drawing.Size(233, 43);
            this.uxRunPlayerGameStats.TabIndex = 2;
            this.uxRunPlayerGameStats.Text = "Stat Lines Per Player";
            this.uxRunPlayerGameStats.UseVisualStyleBackColor = true;
            this.uxRunPlayerGameStats.Click += new System.EventHandler(this.uxRunPlayerGameStats_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(85, 473);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "Player Name";
            // 
            // uxPlayerName
            // 
            this.uxPlayerName.FormattingEnabled = true;
            this.uxPlayerName.Location = new System.Drawing.Point(196, 470);
            this.uxPlayerName.Name = "uxPlayerName";
            this.uxPlayerName.Size = new System.Drawing.Size(260, 24);
            this.uxPlayerName.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(500, 439);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "Opponent Name";
            // 
            // uxOppName
            // 
            this.uxOppName.FormattingEnabled = true;
            this.uxOppName.Location = new System.Drawing.Point(618, 436);
            this.uxOppName.Name = "uxOppName";
            this.uxOppName.Size = new System.Drawing.Size(260, 24);
            this.uxOppName.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Points Max";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Points Min";
            // 
            // uxPointsMax
            // 
            this.uxPointsMax.Location = new System.Drawing.Point(184, 437);
            this.uxPointsMax.Name = "uxPointsMax";
            this.uxPointsMax.Size = new System.Drawing.Size(56, 22);
            this.uxPointsMax.TabIndex = 37;
            this.uxPointsMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxPointsMin
            // 
            this.uxPointsMin.Location = new System.Drawing.Point(184, 406);
            this.uxPointsMin.Name = "uxPointsMin";
            this.uxPointsMin.Size = new System.Drawing.Size(56, 22);
            this.uxPointsMin.TabIndex = 36;
            this.uxPointsMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(283, 439);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 17);
            this.label13.TabIndex = 43;
            this.label13.Text = "Minutes Max";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(283, 408);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 17);
            this.label14.TabIndex = 42;
            this.label14.Text = "Minutes Min";
            // 
            // uxMinutesMin
            // 
            this.uxMinutesMin.Location = new System.Drawing.Point(392, 406);
            this.uxMinutesMin.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxMinutesMin.Name = "uxMinutesMin";
            this.uxMinutesMin.Size = new System.Drawing.Size(56, 22);
            this.uxMinutesMin.TabIndex = 41;
            this.uxMinutesMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxMinutesMax
            // 
            this.uxMinutesMax.Location = new System.Drawing.Point(392, 437);
            this.uxMinutesMax.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxMinutesMax.Name = "uxMinutesMax";
            this.uxMinutesMax.Size = new System.Drawing.Size(56, 22);
            this.uxMinutesMax.TabIndex = 40;
            this.uxMinutesMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayerGameStatsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.uxMinutesMin);
            this.Controls.Add(this.uxMinutesMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxPointsMax);
            this.Controls.Add(this.uxPointsMin);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.uxOppName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.uxPlayerName);
            this.Controls.Add(this.uxRunPlayerGameStats);
            this.Controls.Add(this.uxDataGrid);
            this.Name = "PlayerGameStatsPanel";
            this.Size = new System.Drawing.Size(1245, 512);
            this.Load += new System.EventHandler(this.PlayerGameStatsPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPointsMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPointsMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMinutesMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMinutesMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataGrid;
        private System.Windows.Forms.Button uxRunPlayerGameStats;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox uxPlayerName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox uxOppName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown uxPointsMax;
        private System.Windows.Forms.NumericUpDown uxPointsMin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown uxMinutesMin;
        private System.Windows.Forms.NumericUpDown uxMinutesMax;
    }
}
