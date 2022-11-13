
namespace _21_22NBAStats
{
    partial class HomePanel
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
            this.uxHomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxHomeLabel
            // 
            this.uxHomeLabel.AutoSize = true;
            this.uxHomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxHomeLabel.Location = new System.Drawing.Point(447, 200);
            this.uxHomeLabel.Name = "uxHomeLabel";
            this.uxHomeLabel.Size = new System.Drawing.Size(354, 38);
            this.uxHomeLabel.TabIndex = 1;
            this.uxHomeLabel.Text = "2021-22 NBA Statistics";
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.uxHomeLabel);
            this.Name = "HomePanel";
            this.Size = new System.Drawing.Size(1246, 512);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label uxHomeLabel;
    }
}
