
namespace _21_22NBAStats
{
    partial class AddDeleteCoachPanel
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
            this.label15 = new System.Windows.Forms.Label();
            this.uxCoachName = new System.Windows.Forms.ComboBox();
            this.uxDeleteCoach = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.uxTeamName = new System.Windows.Forms.ComboBox();
            this.uxAddCoach = new System.Windows.Forms.Button();
            this.uxNewCoachName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(760, 277);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 17);
            this.label15.TabIndex = 33;
            this.label15.Text = "Coach Name";
            // 
            // uxCoachName
            // 
            this.uxCoachName.FormattingEnabled = true;
            this.uxCoachName.Location = new System.Drawing.Point(871, 274);
            this.uxCoachName.Name = "uxCoachName";
            this.uxCoachName.Size = new System.Drawing.Size(260, 24);
            this.uxCoachName.TabIndex = 32;
            // 
            // uxDeleteCoach
            // 
            this.uxDeleteCoach.Location = new System.Drawing.Point(850, 389);
            this.uxDeleteCoach.Name = "uxDeleteCoach";
            this.uxDeleteCoach.Size = new System.Drawing.Size(233, 43);
            this.uxDeleteCoach.TabIndex = 34;
            this.uxDeleteCoach.Text = "Delete Selected Coach";
            this.uxDeleteCoach.UseVisualStyleBackColor = true;
            this.uxDeleteCoach.Click += new System.EventHandler(this.uxDeleteCoach_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(873, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "Delete Coach";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(80, 277);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 17);
            this.label16.TabIndex = 37;
            this.label16.Text = "Team Name";
            // 
            // uxTeamName
            // 
            this.uxTeamName.FormattingEnabled = true;
            this.uxTeamName.Location = new System.Drawing.Point(191, 274);
            this.uxTeamName.Name = "uxTeamName";
            this.uxTeamName.Size = new System.Drawing.Size(260, 24);
            this.uxTeamName.TabIndex = 36;
            // 
            // uxAddCoach
            // 
            this.uxAddCoach.Location = new System.Drawing.Point(159, 389);
            this.uxAddCoach.Name = "uxAddCoach";
            this.uxAddCoach.Size = new System.Drawing.Size(233, 43);
            this.uxAddCoach.TabIndex = 38;
            this.uxAddCoach.Text = "Add Coach";
            this.uxAddCoach.UseVisualStyleBackColor = true;
            this.uxAddCoach.Click += new System.EventHandler(this.uxAddCoach_Click);
            // 
            // uxNewCoachName
            // 
            this.uxNewCoachName.Location = new System.Drawing.Point(191, 208);
            this.uxNewCoachName.Name = "uxNewCoachName";
            this.uxNewCoachName.Size = new System.Drawing.Size(260, 22);
            this.uxNewCoachName.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Coach Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 32);
            this.label3.TabIndex = 41;
            this.label3.Text = "Add Coach";
            // 
            // AddDeleteCoachPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxNewCoachName);
            this.Controls.Add(this.uxAddCoach);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.uxTeamName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxDeleteCoach);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.uxCoachName);
            this.Name = "AddDeleteCoachPanel";
            this.Size = new System.Drawing.Size(1245, 512);
            this.Load += new System.EventHandler(this.AddDeleteCoachPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox uxCoachName;
        private System.Windows.Forms.Button uxDeleteCoach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox uxTeamName;
        private System.Windows.Forms.Button uxAddCoach;
        private System.Windows.Forms.TextBox uxNewCoachName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
