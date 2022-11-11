
namespace _21_22NBAStats
{
    partial class Form1
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
            this.uxAddPlayerButton = new System.Windows.Forms.Button();
            this.uxAddGameButton = new System.Windows.Forms.Button();
            this.uxQueryStats = new System.Windows.Forms.Button();
            this.uxMainPageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxAddPlayerButton
            // 
            this.uxAddPlayerButton.Location = new System.Drawing.Point(45, 358);
            this.uxAddPlayerButton.Name = "uxAddPlayerButton";
            this.uxAddPlayerButton.Size = new System.Drawing.Size(163, 65);
            this.uxAddPlayerButton.TabIndex = 0;
            this.uxAddPlayerButton.Text = "Add Player";
            this.uxAddPlayerButton.UseVisualStyleBackColor = true;
            // 
            // uxAddGameButton
            // 
            this.uxAddGameButton.Location = new System.Drawing.Point(313, 358);
            this.uxAddGameButton.Name = "uxAddGameButton";
            this.uxAddGameButton.Size = new System.Drawing.Size(163, 65);
            this.uxAddGameButton.TabIndex = 1;
            this.uxAddGameButton.Text = "Add Game";
            this.uxAddGameButton.UseVisualStyleBackColor = true;
            this.uxAddGameButton.Click += new System.EventHandler(this.uxAddGameButton_Click);
            // 
            // uxQueryStats
            // 
            this.uxQueryStats.Location = new System.Drawing.Point(568, 358);
            this.uxQueryStats.Name = "uxQueryStats";
            this.uxQueryStats.Size = new System.Drawing.Size(163, 65);
            this.uxQueryStats.TabIndex = 2;
            this.uxQueryStats.Text = "Query Stats";
            this.uxQueryStats.UseVisualStyleBackColor = true;
            this.uxQueryStats.Click += new System.EventHandler(this.uxQueryStats_Click);
            // 
            // uxMainPageLabel
            // 
            this.uxMainPageLabel.AutoSize = true;
            this.uxMainPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.uxMainPageLabel.Location = new System.Drawing.Point(228, 94);
            this.uxMainPageLabel.Name = "uxMainPageLabel";
            this.uxMainPageLabel.Size = new System.Drawing.Size(346, 39);
            this.uxMainPageLabel.TabIndex = 3;
            this.uxMainPageLabel.Text = "NBA Stats 2021-2022";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uxMainPageLabel);
            this.Controls.Add(this.uxQueryStats);
            this.Controls.Add(this.uxAddGameButton);
            this.Controls.Add(this.uxAddPlayerButton);
            this.Name = "Form1";
            this.Text = "NBAStats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxAddPlayerButton;
        private System.Windows.Forms.Button uxAddGameButton;
        private System.Windows.Forms.Button uxQueryStats;
        private System.Windows.Forms.Label uxMainPageLabel;
    }
}

