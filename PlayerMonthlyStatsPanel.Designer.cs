
namespace _21_22NBAStats
{
    partial class PlayerMonthlyStatsPanel
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
            this.uxPlayerMonthStats = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.uxMonth = new System.Windows.Forms.ComboBox();
            this.uxPlayerName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).BeginInit();
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
            this.uxDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.uxDataGrid.Name = "uxDataGrid";
            this.uxDataGrid.RowHeadersVisible = false;
            this.uxDataGrid.RowHeadersWidth = 51;
            this.uxDataGrid.RowTemplate.Height = 24;
            this.uxDataGrid.Size = new System.Drawing.Size(930, 320);
            this.uxDataGrid.TabIndex = 2;
            // 
            // uxPlayerMonthStats
            // 
            this.uxPlayerMonthStats.Location = new System.Drawing.Point(685, 367);
            this.uxPlayerMonthStats.Margin = new System.Windows.Forms.Padding(2);
            this.uxPlayerMonthStats.Name = "uxPlayerMonthStats";
            this.uxPlayerMonthStats.Size = new System.Drawing.Size(138, 35);
            this.uxPlayerMonthStats.TabIndex = 3;
            this.uxPlayerMonthStats.Text = "Monthly Stats Per Player";
            this.uxPlayerMonthStats.UseVisualStyleBackColor = true;
            this.uxPlayerMonthStats.Click += new System.EventHandler(this.uxPlayerMonthStats_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 353);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Month";
            // 
            // uxMonth
            // 
            this.uxMonth.FormattingEnabled = true;
            this.uxMonth.Location = new System.Drawing.Point(75, 350);
            this.uxMonth.Margin = new System.Windows.Forms.Padding(2);
            this.uxMonth.Name = "uxMonth";
            this.uxMonth.Size = new System.Drawing.Size(154, 21);
            this.uxMonth.TabIndex = 57;
            // 
            // uxPlayerName
            // 
            this.uxPlayerName.FormattingEnabled = true;
            this.uxPlayerName.Location = new System.Drawing.Point(366, 350);
            this.uxPlayerName.Margin = new System.Windows.Forms.Padding(2);
            this.uxPlayerName.Name = "uxPlayerName";
            this.uxPlayerName.Size = new System.Drawing.Size(196, 21);
            this.uxPlayerName.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 353);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Player Name";
            // 
            // PlayerMonthlyStatsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxPlayerName);
            this.Controls.Add(this.uxMonth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxPlayerMonthStats);
            this.Controls.Add(this.uxDataGrid);
            this.Name = "PlayerMonthlyStatsPanel";
            this.Size = new System.Drawing.Size(934, 416);
            this.Load += new System.EventHandler(this.PlayersMonthStatsPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataGrid;
        private System.Windows.Forms.Button uxPlayerMonthStats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox uxMonth;
        private System.Windows.Forms.ComboBox uxPlayerName;
        private System.Windows.Forms.Label label1;
    }
}
