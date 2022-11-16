
namespace _21_22NBAStats
{
    partial class CoachesListPanel
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
            this.uxGetAllCoaches = new System.Windows.Forms.Button();
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
            this.uxDataGrid.Location = new System.Drawing.Point(3, 2);
            this.uxDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxDataGrid.Name = "uxDataGrid";
            this.uxDataGrid.RowHeadersVisible = false;
            this.uxDataGrid.RowHeadersWidth = 51;
            this.uxDataGrid.RowTemplate.Height = 24;
            this.uxDataGrid.Size = new System.Drawing.Size(501, 508);
            this.uxDataGrid.TabIndex = 3;
            // 
            // uxGetAllCoaches
            // 
            this.uxGetAllCoaches.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxGetAllCoaches.Location = new System.Drawing.Point(740, 235);
            this.uxGetAllCoaches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uxGetAllCoaches.Name = "uxGetAllCoaches";
            this.uxGetAllCoaches.Size = new System.Drawing.Size(292, 43);
            this.uxGetAllCoaches.TabIndex = 4;
            this.uxGetAllCoaches.Text = "Head Coaches for Each Team";
            this.uxGetAllCoaches.UseVisualStyleBackColor = true;
            this.uxGetAllCoaches.Click += new System.EventHandler(this.uxGetAllCoaches_Click);
            // 
            // CoachesListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uxGetAllCoaches);
            this.Controls.Add(this.uxDataGrid);
            this.Name = "CoachesListPanel";
            this.Size = new System.Drawing.Size(1246, 512);
            this.Load += new System.EventHandler(this.CoachesListPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataGrid;
        private System.Windows.Forms.Button uxGetAllCoaches;
    }
}
