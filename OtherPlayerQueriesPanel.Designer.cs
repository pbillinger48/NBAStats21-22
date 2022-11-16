
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
            this.uxDataGrid = new System.Windows.Forms.DataGridView();
            this.uxRunRecordBasedOnMinutes = new System.Windows.Forms.Button();
            this.RunPlayerStatsVersus = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMinutesThreshold)).BeginInit();
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
            this.uxDataGrid.Size = new System.Drawing.Size(930, 72);
            this.uxDataGrid.TabIndex = 1;
            // 
            // uxRunRecordBasedOnMinutes
            // 
            this.uxRunRecordBasedOnMinutes.Location = new System.Drawing.Point(597, 103);
            this.uxRunRecordBasedOnMinutes.Margin = new System.Windows.Forms.Padding(2);
            this.uxRunRecordBasedOnMinutes.Name = "uxRunRecordBasedOnMinutes";
            this.uxRunRecordBasedOnMinutes.Size = new System.Drawing.Size(199, 35);
            this.uxRunRecordBasedOnMinutes.TabIndex = 2;
            this.uxRunRecordBasedOnMinutes.Text = "Team Record Per Minutes Threshold";
            this.uxRunRecordBasedOnMinutes.UseVisualStyleBackColor = true;
            this.uxRunRecordBasedOnMinutes.Click += new System.EventHandler(this.uxRunRecordBasedOnMinutes_Click);
            // 
            // RunPlayerStatsVersus
            // 
            this.RunPlayerStatsVersus.Location = new System.Drawing.Point(660, 316);
            this.RunPlayerStatsVersus.Margin = new System.Windows.Forms.Padding(2);
            this.RunPlayerStatsVersus.Name = "RunPlayerStatsVersus";
            this.RunPlayerStatsVersus.Size = new System.Drawing.Size(199, 35);
            this.RunPlayerStatsVersus.TabIndex = 4;
            this.RunPlayerStatsVersus.Text = "Player Stats vs. an Opponent";
            this.RunPlayerStatsVersus.UseVisualStyleBackColor = true;
            this.RunPlayerStatsVersus.Click += new System.EventHandler(this.RunPlayerStatsVersus_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 213);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(930, 72);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // uxMinutesThreshold
            // 
            this.uxMinutesThreshold.Location = new System.Drawing.Point(436, 112);
            this.uxMinutesThreshold.Margin = new System.Windows.Forms.Padding(2);
            this.uxMinutesThreshold.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxMinutesThreshold.Name = "uxMinutesThreshold";
            this.uxMinutesThreshold.Size = new System.Drawing.Size(42, 20);
            this.uxMinutesThreshold.TabIndex = 16;
            this.uxMinutesThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Minutes Threshold";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 114);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Player Name";
            // 
            // uxPlayerName1
            // 
            this.uxPlayerName1.FormattingEnabled = true;
            this.uxPlayerName1.Location = new System.Drawing.Point(122, 111);
            this.uxPlayerName1.Margin = new System.Windows.Forms.Padding(2);
            this.uxPlayerName1.Name = "uxPlayerName1";
            this.uxPlayerName1.Size = new System.Drawing.Size(196, 21);
            this.uxPlayerName1.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(850, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "This query produces a Team\'s record when a player plays a certain number of minut" +
    "es and when they don\'t play that certain number of minutes.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(572, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "This query produces a Player\'s statistical averages when they play against a chos" +
    "en opponent.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 327);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Player Name";
            // 
            // uxPlayerName2
            // 
            this.uxPlayerName2.FormattingEnabled = true;
            this.uxPlayerName2.Location = new System.Drawing.Point(122, 324);
            this.uxPlayerName2.Margin = new System.Windows.Forms.Padding(2);
            this.uxPlayerName2.Name = "uxPlayerName2";
            this.uxPlayerName2.Size = new System.Drawing.Size(196, 21);
            this.uxPlayerName2.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(335, 327);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "Team Name";
            // 
            // uxTeamName
            // 
            this.uxTeamName.FormattingEnabled = true;
            this.uxTeamName.Location = new System.Drawing.Point(419, 324);
            this.uxTeamName.Margin = new System.Windows.Forms.Padding(2);
            this.uxTeamName.Name = "uxTeamName";
            this.uxTeamName.Size = new System.Drawing.Size(196, 21);
            this.uxTeamName.TabIndex = 38;
            // 
            // OtherPlayerQueriesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.uxRunRecordBasedOnMinutes);
            this.Controls.Add(this.uxDataGrid);
            this.Name = "OtherPlayerQueriesPanel";
            this.Size = new System.Drawing.Size(934, 416);
            this.Load += new System.EventHandler(this.OtherPlayerQueriesPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMinutesThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataGrid;
        private System.Windows.Forms.Button uxRunRecordBasedOnMinutes;
        private System.Windows.Forms.Button RunPlayerStatsVersus;
        private System.Windows.Forms.DataGridView dataGridView1;
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
