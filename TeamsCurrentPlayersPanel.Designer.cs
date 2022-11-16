
namespace _21_22NBAStats
{
    partial class TeamsCurrentPlayersPanel
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
            this.uxTeamsCurrentPlayers = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.uxTeamName = new System.Windows.Forms.ComboBox();
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
            this.uxDataGrid.Location = new System.Drawing.Point(3, 3);
            this.uxDataGrid.Name = "uxDataGrid";
            this.uxDataGrid.RowHeadersVisible = false;
            this.uxDataGrid.RowHeadersWidth = 51;
            this.uxDataGrid.RowTemplate.Height = 24;
            this.uxDataGrid.Size = new System.Drawing.Size(1240, 394);
            this.uxDataGrid.TabIndex = 1;
            // 
            // uxTeamsCurrentPlayers
            // 
            this.uxTeamsCurrentPlayers.Location = new System.Drawing.Point(780, 434);
            this.uxTeamsCurrentPlayers.Name = "uxTeamsCurrentPlayers";
            this.uxTeamsCurrentPlayers.Size = new System.Drawing.Size(241, 43);
            this.uxTeamsCurrentPlayers.TabIndex = 2;
            this.uxTeamsCurrentPlayers.Text = "Current Players Per Team";
            this.uxTeamsCurrentPlayers.UseVisualStyleBackColor = true;
            this.uxTeamsCurrentPlayers.Click += new System.EventHandler(this.uxTeamsCurrentPlayers_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(186, 447);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 17);
            this.label16.TabIndex = 35;
            this.label16.Text = "Team Name";
            // 
            // uxTeamName
            // 
            this.uxTeamName.FormattingEnabled = true;
            this.uxTeamName.Location = new System.Drawing.Point(297, 444);
            this.uxTeamName.Name = "uxTeamName";
            this.uxTeamName.Size = new System.Drawing.Size(260, 24);
            this.uxTeamName.TabIndex = 34;
            // 
            // TeamsCurrentPlayersPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.uxTeamName);
            this.Controls.Add(this.uxTeamsCurrentPlayers);
            this.Controls.Add(this.uxDataGrid);
            this.Name = "TeamsCurrentPlayersPanel";
            this.Size = new System.Drawing.Size(1246, 512);
            this.Load += new System.EventHandler(this.TeamsCurrentPlayersPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uxDataGrid;
        private System.Windows.Forms.Button uxTeamsCurrentPlayers;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox uxTeamName;
    }
}
