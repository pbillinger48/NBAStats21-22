
namespace _21_22NBAStats
{
    partial class RecordBasedOnMinutesPanel
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
            this.uxDataGrid.TabIndex = 1;
            // 
            // uxRunRecordBasedOnMinutes
            // 
            this.uxRunRecordBasedOnMinutes.Location = new System.Drawing.Point(716, 370);
            this.uxRunRecordBasedOnMinutes.Margin = new System.Windows.Forms.Padding(2);
            this.uxRunRecordBasedOnMinutes.Name = "uxRunRecordBasedOnMinutes";
            this.uxRunRecordBasedOnMinutes.Size = new System.Drawing.Size(199, 35);
            this.uxRunRecordBasedOnMinutes.TabIndex = 2;
            this.uxRunRecordBasedOnMinutes.Text = "Team Record Per Minutes Threshold";
            this.uxRunRecordBasedOnMinutes.UseVisualStyleBackColor = true;
            // 
            // RecordBasedOnMinutesPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxRunRecordBasedOnMinutes);
            this.Controls.Add(this.uxDataGrid);
            this.Name = "RecordBasedOnMinutesPanel";
            this.Size = new System.Drawing.Size(934, 416);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataGrid;
        private System.Windows.Forms.Button uxRunRecordBasedOnMinutes;
    }
}
