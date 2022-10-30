
namespace _21_22NBAStats
{
    partial class QueryStatsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxStartQueryButton = new System.Windows.Forms.Button();
            this.uxBackHomeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxStartQueryButton
            // 
            this.uxStartQueryButton.Location = new System.Drawing.Point(574, 344);
            this.uxStartQueryButton.Name = "uxStartQueryButton";
            this.uxStartQueryButton.Size = new System.Drawing.Size(154, 66);
            this.uxStartQueryButton.TabIndex = 0;
            this.uxStartQueryButton.Text = "Start Query";
            this.uxStartQueryButton.UseVisualStyleBackColor = true;
            // 
            // uxBackHomeButton
            // 
            this.uxBackHomeButton.Location = new System.Drawing.Point(57, 344);
            this.uxBackHomeButton.Name = "uxBackHomeButton";
            this.uxBackHomeButton.Size = new System.Drawing.Size(155, 66);
            this.uxBackHomeButton.TabIndex = 1;
            this.uxBackHomeButton.Text = "Back Home";
            this.uxBackHomeButton.UseVisualStyleBackColor = true;
            this.uxBackHomeButton.Click += new System.EventHandler(this.uxBackHomeButton_Click);
            // 
            // QueryStatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxBackHomeButton);
            this.Controls.Add(this.uxStartQueryButton);
            this.Name = "QueryStatsForm";
            this.Text = "QueryStatsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxStartQueryButton;
        private System.Windows.Forms.Button uxBackHomeButton;
    }
}