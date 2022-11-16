
namespace _21_22NBAStats
{
    partial class OtherPlayerQueriesPanel
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
            this.uxDataGrid1 = new System.Windows.Forms.DataGridView();
            this.uxRunRecordBasedOnMinutes = new System.Windows.Forms.Button();
            this.RunPlayerStatsVersus = new System.Windows.Forms.Button();
            this.uxDataGrid2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uxMinutesThreshold = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.uxPlayerName1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxPlayerName2 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.uxTeamName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMinutesThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // uxDataGrid1
            // 
            this.uxDataGrid1.AllowUserToAddRows = false;
            this.uxDataGrid1.AllowUserToDeleteRows = false;
            this.uxDataGrid1.AllowUserToResizeColumns = false;
            this.uxDataGrid1.AllowUserToResizeRows = false;
            this.uxDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.uxDataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.uxDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGrid1.Location = new System.Drawing.Point(3, 2);
            this.uxDataGrid1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDataGrid1.Name = "uxDataGrid1";
            this.uxDataGrid1.RowHeadersVisible = false;
            this.uxDataGrid1.RowHeadersWidth = 51;
            this.uxDataGrid1.RowTemplate.Height = 24;
            this.uxDataGrid1.Size = new System.Drawing.Size(1240, 89);
            this.uxDataGrid1.TabIndex = 1;
            // 
            // uxRunRecordBasedOnMinutes
            // 
            this.uxRunRecordBasedOnMinutes.Location = new System.Drawing.Point(884, 127);
            this.uxRunRecordBasedOnMinutes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxRunRecordBasedOnMinutes.Name = "uxRunRecordBasedOnMinutes";
            this.uxRunRecordBasedOnMinutes.Size = new System.Drawing.Size(265, 43);
            this.uxRunRecordBasedOnMinutes.TabIndex = 2;
            this.uxRunRecordBasedOnMinutes.Text = "Team Record Per Minutes Threshold";
            this.uxRunRecordBasedOnMinutes.UseVisualStyleBackColor = true;
            this.uxRunRecordBasedOnMinutes.Click += new System.EventHandler(this.uxRunRecordBasedOnMinutes_Click);
            // 
            // RunPlayerStatsVersus
            // 
            this.RunPlayerStatsVersus.Location = new System.Drawing.Point(884, 389);
            this.RunPlayerStatsVersus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RunPlayerStatsVersus.Name = "RunPlayerStatsVersus";
            this.RunPlayerStatsVersus.Size = new System.Drawing.Size(265, 43);
            this.RunPlayerStatsVersus.TabIndex = 4;
            this.RunPlayerStatsVersus.Text = "Player Stats vs. an Opponent";
            this.RunPlayerStatsVersus.UseVisualStyleBackColor = true;
            this.RunPlayerStatsVersus.Click += new System.EventHandler(this.RunPlayerStatsVersus_Click);
            // 
            // uxDataGrid2
            // 
            this.uxDataGrid2.AllowUserToAddRows = false;
            this.uxDataGrid2.AllowUserToDeleteRows = false;
            this.uxDataGrid2.AllowUserToResizeColumns = false;
            this.uxDataGrid2.AllowUserToResizeRows = false;
            this.uxDataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.uxDataGrid2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.uxDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxDataGrid2.Location = new System.Drawing.Point(3, 262);
            this.uxDataGrid2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDataGrid2.Name = "uxDataGrid2";
            this.uxDataGrid2.RowHeadersVisible = false;
            this.uxDataGrid2.RowHeadersWidth = 51;
            this.uxDataGrid2.RowTemplate.Height = 24;
            this.uxDataGrid2.Size = new System.Drawing.Size(1240, 89);
            this.uxDataGrid2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 5;
            // 
            // uxMinutesThreshold
            // 
            this.uxMinutesThreshold.Location = new System.Drawing.Point(581, 138);
            this.uxMinutesThreshold.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxMinutesThreshold.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxMinutesThreshold.Name = "uxMinutesThreshold";
            this.uxMinutesThreshold.Size = new System.Drawing.Size(56, 22);
            this.uxMinutesThreshold.TabIndex = 16;
            this.uxMinutesThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Minutes Threshold";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(51, 140);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "Player Name";
            // 
            // uxPlayerName1
            // 
            this.uxPlayerName1.FormattingEnabled = true;
            this.uxPlayerName1.Location = new System.Drawing.Point(163, 137);
            this.uxPlayerName1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxPlayerName1.Name = "uxPlayerName1";
            this.uxPlayerName1.Size = new System.Drawing.Size(260, 24);
            this.uxPlayerName1.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1079, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "This query produces a Team\'s record when a player plays a certain number of minut" +
    "es and when they don\'t play that certain number of minutes.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 353);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(714, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "This query produces a Player\'s statistical averages when they play against a chos" +
    "en opponent.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Player Name";
            // 
            // uxPlayerName2
            // 
            this.uxPlayerName2.FormattingEnabled = true;
            this.uxPlayerName2.Location = new System.Drawing.Point(163, 399);
            this.uxPlayerName2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxPlayerName2.Name = "uxPlayerName2";
            this.uxPlayerName2.Size = new System.Drawing.Size(260, 24);
            this.uxPlayerName2.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(447, 402);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 17);
            this.label16.TabIndex = 39;
            this.label16.Text = "Opponent Name";
            // 
            // uxTeamName
            // 
            this.uxTeamName.FormattingEnabled = true;
            this.uxTeamName.Location = new System.Drawing.Point(565, 399);
            this.uxTeamName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxTeamName.Name = "uxTeamName";
            this.uxTeamName.Size = new System.Drawing.Size(260, 24);
            this.uxTeamName.TabIndex = 38;
            // 
            // OtherPlayerQueriesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.uxTeamName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uxPlayerName2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.uxPlayerName1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxMinutesThreshold);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RunPlayerStatsVersus);
            this.Controls.Add(this.uxDataGrid2);
            this.Controls.Add(this.uxRunRecordBasedOnMinutes);
            this.Controls.Add(this.uxDataGrid1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OtherPlayerQueriesPanel";
            this.Size = new System.Drawing.Size(1245, 512);
            this.Load += new System.EventHandler(this.OtherPlayerQueriesPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMinutesThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataGrid1;
        private System.Windows.Forms.Button uxRunRecordBasedOnMinutes;
        private System.Windows.Forms.Button RunPlayerStatsVersus;
        private System.Windows.Forms.DataGridView uxDataGrid2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown uxMinutesThreshold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox uxPlayerName1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox uxPlayerName2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox uxTeamName;
    }
}
