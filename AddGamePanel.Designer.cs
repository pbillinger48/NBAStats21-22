﻿
namespace _21_22NBAStats
{
    partial class AddGamePanel
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
            this.uxHomeTeamPlayerGrid = new System.Windows.Forms.DataGridView();
            this.uxAwayTeamPlayerGrid = new System.Windows.Forms.DataGridView();
            this.uxHomeTeamComboBox = new System.Windows.Forms.ComboBox();
            this.uxAwayTeamComboBox = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.uxHomeScoreBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxAwayScoreBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uxInsertButton = new System.Windows.Forms.Button();
            this.uxYearBox = new System.Windows.Forms.NumericUpDown();
            this.uxMonthBox = new System.Windows.Forms.NumericUpDown();
            this.uxDayBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxHomeTeamPlayerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxAwayTeamPlayerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxYearBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMonthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxDayBox)).BeginInit();
            this.SuspendLayout();
            // 
            // uxHomeTeamPlayerGrid
            // 
            this.uxHomeTeamPlayerGrid.AllowUserToResizeColumns = false;
            this.uxHomeTeamPlayerGrid.AllowUserToResizeRows = false;
            this.uxHomeTeamPlayerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.uxHomeTeamPlayerGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.uxHomeTeamPlayerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxHomeTeamPlayerGrid.Location = new System.Drawing.Point(2, 55);
            this.uxHomeTeamPlayerGrid.Margin = new System.Windows.Forms.Padding(2);
            this.uxHomeTeamPlayerGrid.Name = "uxHomeTeamPlayerGrid";
            this.uxHomeTeamPlayerGrid.RowHeadersVisible = false;
            this.uxHomeTeamPlayerGrid.RowHeadersWidth = 51;
            this.uxHomeTeamPlayerGrid.RowTemplate.Height = 24;
            this.uxHomeTeamPlayerGrid.Size = new System.Drawing.Size(930, 110);
            this.uxHomeTeamPlayerGrid.TabIndex = 2;
            this.uxHomeTeamPlayerGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.uxHomeTeamPlayerGrid_CellEndEdit);
            // 
            // uxAwayTeamPlayerGrid
            // 
            this.uxAwayTeamPlayerGrid.AllowUserToResizeColumns = false;
            this.uxAwayTeamPlayerGrid.AllowUserToResizeRows = false;
            this.uxAwayTeamPlayerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.uxAwayTeamPlayerGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.uxAwayTeamPlayerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uxAwayTeamPlayerGrid.Location = new System.Drawing.Point(2, 244);
            this.uxAwayTeamPlayerGrid.Margin = new System.Windows.Forms.Padding(2);
            this.uxAwayTeamPlayerGrid.Name = "uxAwayTeamPlayerGrid";
            this.uxAwayTeamPlayerGrid.RowHeadersVisible = false;
            this.uxAwayTeamPlayerGrid.RowHeadersWidth = 51;
            this.uxAwayTeamPlayerGrid.RowTemplate.Height = 24;
            this.uxAwayTeamPlayerGrid.Size = new System.Drawing.Size(930, 110);
            this.uxAwayTeamPlayerGrid.TabIndex = 3;
            this.uxAwayTeamPlayerGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.uxAwayTeamPlayerGrid_CellEndEdit);
            // 
            // uxHomeTeamComboBox
            // 
            this.uxHomeTeamComboBox.FormattingEnabled = true;
            this.uxHomeTeamComboBox.Location = new System.Drawing.Point(157, 25);
            this.uxHomeTeamComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxHomeTeamComboBox.Name = "uxHomeTeamComboBox";
            this.uxHomeTeamComboBox.Size = new System.Drawing.Size(196, 21);
            this.uxHomeTeamComboBox.TabIndex = 39;
            // 
            // uxAwayTeamComboBox
            // 
            this.uxAwayTeamComboBox.FormattingEnabled = true;
            this.uxAwayTeamComboBox.Location = new System.Drawing.Point(157, 214);
            this.uxAwayTeamComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxAwayTeamComboBox.Name = "uxAwayTeamComboBox";
            this.uxAwayTeamComboBox.Size = new System.Drawing.Size(196, 21);
            this.uxAwayTeamComboBox.TabIndex = 40;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(71, 28);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 15);
            this.label16.TabIndex = 41;
            this.label16.Text = "Home Team: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "Away Team: ";
            // 
            // uxHomeScoreBox
            // 
            this.uxHomeScoreBox.Enabled = false;
            this.uxHomeScoreBox.Location = new System.Drawing.Point(718, 26);
            this.uxHomeScoreBox.Name = "uxHomeScoreBox";
            this.uxHomeScoreBox.Size = new System.Drawing.Size(39, 20);
            this.uxHomeScoreBox.TabIndex = 43;
            this.uxHomeScoreBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 44;
            this.label2.Text = "Home Score: ";
            // 
            // uxAwayScoreBox
            // 
            this.uxAwayScoreBox.Enabled = false;
            this.uxAwayScoreBox.Location = new System.Drawing.Point(718, 215);
            this.uxAwayScoreBox.Name = "uxAwayScoreBox";
            this.uxAwayScoreBox.Size = new System.Drawing.Size(39, 20);
            this.uxAwayScoreBox.TabIndex = 45;
            this.uxAwayScoreBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 46;
            this.label3.Text = "Away Score: ";
            // 
            // uxInsertButton
            // 
            this.uxInsertButton.Location = new System.Drawing.Point(699, 359);
            this.uxInsertButton.Name = "uxInsertButton";
            this.uxInsertButton.Size = new System.Drawing.Size(172, 54);
            this.uxInsertButton.TabIndex = 47;
            this.uxInsertButton.Text = "Complete Insert";
            this.uxInsertButton.UseVisualStyleBackColor = true;
            this.uxInsertButton.Click += new System.EventHandler(this.uxInsertButton_Click);
            // 
            // uxYearBox
            // 
            this.uxYearBox.Location = new System.Drawing.Point(111, 380);
            this.uxYearBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxYearBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.uxYearBox.Name = "uxYearBox";
            this.uxYearBox.Size = new System.Drawing.Size(42, 20);
            this.uxYearBox.TabIndex = 48;
            this.uxYearBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxMonthBox
            // 
            this.uxMonthBox.Location = new System.Drawing.Point(260, 380);
            this.uxMonthBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxMonthBox.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxMonthBox.Name = "uxMonthBox";
            this.uxMonthBox.Size = new System.Drawing.Size(42, 20);
            this.uxMonthBox.TabIndex = 49;
            this.uxMonthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uxDayBox
            // 
            this.uxDayBox.Location = new System.Drawing.Point(396, 380);
            this.uxDayBox.Margin = new System.Windows.Forms.Padding(2);
            this.uxDayBox.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.uxDayBox.Name = "uxDayBox";
            this.uxDayBox.Size = new System.Drawing.Size(42, 20);
            this.uxDayBox.TabIndex = 50;
            this.uxDayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 382);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 51;
            this.label4.Text = "Year: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 380);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 52;
            this.label5.Text = "Month: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 380);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 53;
            this.label6.Text = "Day: ";
            // 
            // AddGamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxDayBox);
            this.Controls.Add(this.uxMonthBox);
            this.Controls.Add(this.uxYearBox);
            this.Controls.Add(this.uxInsertButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxAwayScoreBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxHomeScoreBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.uxAwayTeamComboBox);
            this.Controls.Add(this.uxHomeTeamComboBox);
            this.Controls.Add(this.uxAwayTeamPlayerGrid);
            this.Controls.Add(this.uxHomeTeamPlayerGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddGamePanel";
            this.Size = new System.Drawing.Size(934, 416);
            this.Load += new System.EventHandler(this.AddGamePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxHomeTeamPlayerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxAwayTeamPlayerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxYearBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxMonthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxDayBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxHomeTeamPlayerGrid;
        private System.Windows.Forms.DataGridView uxAwayTeamPlayerGrid;
        private System.Windows.Forms.ComboBox uxHomeTeamComboBox;
        private System.Windows.Forms.ComboBox uxAwayTeamComboBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxHomeScoreBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxAwayScoreBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uxInsertButton;
        private System.Windows.Forms.NumericUpDown uxYearBox;
        private System.Windows.Forms.NumericUpDown uxMonthBox;
        private System.Windows.Forms.NumericUpDown uxDayBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
