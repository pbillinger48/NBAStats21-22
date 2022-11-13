
namespace _21_22NBAStats
{
    partial class PlayerSeasonStatsPanel
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
            this.uxRunPlayerSeasonStats = new System.Windows.Forms.Button();
            this.uxPPGMin = new System.Windows.Forms.NumericUpDown();
            this.uxPPGMax = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uxRPGMax = new System.Windows.Forms.NumericUpDown();
            this.uxRPGMin = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uxAPGMax = new System.Windows.Forms.NumericUpDown();
            this.uxAPGMin = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uxBPGMax = new System.Windows.Forms.NumericUpDown();
            this.uxBPGMin = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.uxSPGMax = new System.Windows.Forms.NumericUpDown();
            this.uxSPGMin = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.uxTPGMax = new System.Windows.Forms.NumericUpDown();
            this.uxTPGMin = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.uxMPGMin = new System.Windows.Forms.NumericUpDown();
            this.uxMPGMax = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPPGMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPPGMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxRPGMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxRPGMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxAPGMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxAPGMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBPGMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBPGMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSPGMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSPGMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxTPGMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxTPGMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMPGMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMPGMax)).BeginInit();
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
            this.uxDataGrid.TabIndex = 0;
            // 
            // uxRunPlayerSeasonStats
            // 
            this.uxRunPlayerSeasonStats.Location = new System.Drawing.Point(1022, 459);
            this.uxRunPlayerSeasonStats.Name = "uxRunPlayerSeasonStats";
            this.uxRunPlayerSeasonStats.Size = new System.Drawing.Size(184, 43);
            this.uxRunPlayerSeasonStats.TabIndex = 1;
            this.uxRunPlayerSeasonStats.Text = "Season Stats Per Player";
            this.uxRunPlayerSeasonStats.UseVisualStyleBackColor = true;
            this.uxRunPlayerSeasonStats.Click += new System.EventHandler(this.uxRunPlayerSeasonStats_Click);
            // 
            // uxPPGMin
            // 
            this.uxPPGMin.Location = new System.Drawing.Point(102, 400);
            this.uxPPGMin.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxPPGMin.Name = "uxPPGMin";
            this.uxPPGMin.ReadOnly = true;
            this.uxPPGMin.Size = new System.Drawing.Size(56, 22);
            this.uxPPGMin.TabIndex = 2;
            this.uxPPGMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxPPGMax
            // 
            this.uxPPGMax.Location = new System.Drawing.Point(102, 431);
            this.uxPPGMax.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxPPGMax.Name = "uxPPGMax";
            this.uxPPGMax.ReadOnly = true;
            this.uxPPGMax.Size = new System.Drawing.Size(56, 22);
            this.uxPPGMax.TabIndex = 3;
            this.uxPPGMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "PointsPG Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "PointsPG Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "ReboundsPG Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "ReboundsPG Min";
            // 
            // uxRPGMax
            // 
            this.uxRPGMax.Location = new System.Drawing.Point(289, 431);
            this.uxRPGMax.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxRPGMax.Name = "uxRPGMax";
            this.uxRPGMax.ReadOnly = true;
            this.uxRPGMax.Size = new System.Drawing.Size(56, 22);
            this.uxRPGMax.TabIndex = 7;
            this.uxRPGMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxRPGMin
            // 
            this.uxRPGMin.Location = new System.Drawing.Point(289, 400);
            this.uxRPGMin.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxRPGMin.Name = "uxRPGMin";
            this.uxRPGMin.ReadOnly = true;
            this.uxRPGMin.Size = new System.Drawing.Size(56, 22);
            this.uxRPGMin.TabIndex = 6;
            this.uxRPGMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 433);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "AssistsPG Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "AssistsPG Min";
            // 
            // uxAPGMax
            // 
            this.uxAPGMax.Location = new System.Drawing.Point(455, 431);
            this.uxAPGMax.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxAPGMax.Name = "uxAPGMax";
            this.uxAPGMax.ReadOnly = true;
            this.uxAPGMax.Size = new System.Drawing.Size(56, 22);
            this.uxAPGMax.TabIndex = 11;
            this.uxAPGMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxAPGMin
            // 
            this.uxAPGMin.Location = new System.Drawing.Point(455, 400);
            this.uxAPGMin.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxAPGMin.Name = "uxAPGMin";
            this.uxAPGMin.ReadOnly = true;
            this.uxAPGMin.Size = new System.Drawing.Size(56, 22);
            this.uxAPGMin.TabIndex = 10;
            this.uxAPGMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "BlocksPG Max";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(517, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "BlocksPG Min";
            // 
            // uxBPGMax
            // 
            this.uxBPGMax.Location = new System.Drawing.Point(621, 431);
            this.uxBPGMax.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxBPGMax.Name = "uxBPGMax";
            this.uxBPGMax.ReadOnly = true;
            this.uxBPGMax.Size = new System.Drawing.Size(56, 22);
            this.uxBPGMax.TabIndex = 15;
            this.uxBPGMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxBPGMin
            // 
            this.uxBPGMin.Location = new System.Drawing.Point(621, 400);
            this.uxBPGMin.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxBPGMin.Name = "uxBPGMin";
            this.uxBPGMin.ReadOnly = true;
            this.uxBPGMin.Size = new System.Drawing.Size(56, 22);
            this.uxBPGMin.TabIndex = 14;
            this.uxBPGMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(683, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "StealsPG Max";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(683, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "StealsPG Min";
            // 
            // uxSPGMax
            // 
            this.uxSPGMax.Location = new System.Drawing.Point(785, 431);
            this.uxSPGMax.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxSPGMax.Name = "uxSPGMax";
            this.uxSPGMax.ReadOnly = true;
            this.uxSPGMax.Size = new System.Drawing.Size(56, 22);
            this.uxSPGMax.TabIndex = 19;
            this.uxSPGMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxSPGMin
            // 
            this.uxSPGMin.Location = new System.Drawing.Point(785, 400);
            this.uxSPGMin.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxSPGMin.Name = "uxSPGMin";
            this.uxSPGMin.ReadOnly = true;
            this.uxSPGMin.Size = new System.Drawing.Size(56, 22);
            this.uxSPGMin.TabIndex = 18;
            this.uxSPGMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(848, 433);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "TurnoversPG Max";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(848, 402);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "TurnoversPG Min";
            // 
            // uxTPGMax
            // 
            this.uxTPGMax.Location = new System.Drawing.Point(973, 431);
            this.uxTPGMax.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxTPGMax.Name = "uxTPGMax";
            this.uxTPGMax.ReadOnly = true;
            this.uxTPGMax.Size = new System.Drawing.Size(56, 22);
            this.uxTPGMax.TabIndex = 23;
            this.uxTPGMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxTPGMin
            // 
            this.uxTPGMin.Location = new System.Drawing.Point(973, 400);
            this.uxTPGMin.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxTPGMin.Name = "uxTPGMin";
            this.uxTPGMin.ReadOnly = true;
            this.uxTPGMin.Size = new System.Drawing.Size(56, 22);
            this.uxTPGMin.TabIndex = 22;
            this.uxTPGMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1041, 433);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "MinutesPG Max";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1041, 405);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "MinutesPG Min";
            // 
            // uxMPGMin
            // 
            this.uxMPGMin.Location = new System.Drawing.Point(1150, 400);
            this.uxMPGMin.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxMPGMin.Name = "uxMPGMin";
            this.uxMPGMin.ReadOnly = true;
            this.uxMPGMin.Size = new System.Drawing.Size(56, 22);
            this.uxMPGMin.TabIndex = 27;
            this.uxMPGMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxMPGMax
            // 
            this.uxMPGMax.Location = new System.Drawing.Point(1150, 431);
            this.uxMPGMax.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxMPGMax.Name = "uxMPGMax";
            this.uxMPGMax.ReadOnly = true;
            this.uxMPGMax.Size = new System.Drawing.Size(56, 22);
            this.uxMPGMax.TabIndex = 26;
            this.uxMPGMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlayerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.uxMPGMin);
            this.Controls.Add(this.uxMPGMax);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.uxTPGMax);
            this.Controls.Add(this.uxTPGMin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.uxSPGMax);
            this.Controls.Add(this.uxSPGMin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.uxBPGMax);
            this.Controls.Add(this.uxBPGMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uxAPGMax);
            this.Controls.Add(this.uxAPGMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxRPGMax);
            this.Controls.Add(this.uxRPGMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxPPGMax);
            this.Controls.Add(this.uxPPGMin);
            this.Controls.Add(this.uxRunPlayerSeasonStats);
            this.Controls.Add(this.uxDataGrid);
            this.Name = "PlayerPanel";
            this.Size = new System.Drawing.Size(1246, 512);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPPGMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxPPGMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxRPGMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxRPGMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxAPGMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxAPGMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBPGMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxBPGMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSPGMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxSPGMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxTPGMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxTPGMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMPGMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMPGMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataGrid;
        private System.Windows.Forms.Button uxRunPlayerSeasonStats;
        private System.Windows.Forms.NumericUpDown uxPPGMin;
        private System.Windows.Forms.NumericUpDown uxPPGMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown uxRPGMax;
        private System.Windows.Forms.NumericUpDown uxRPGMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown uxAPGMax;
        private System.Windows.Forms.NumericUpDown uxAPGMin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown uxBPGMax;
        private System.Windows.Forms.NumericUpDown uxBPGMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown uxSPGMax;
        private System.Windows.Forms.NumericUpDown uxSPGMin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown uxTPGMax;
        private System.Windows.Forms.NumericUpDown uxTPGMin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown uxMPGMin;
        private System.Windows.Forms.NumericUpDown uxMPGMax;
    }
}
