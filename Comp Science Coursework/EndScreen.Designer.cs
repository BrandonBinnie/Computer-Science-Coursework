namespace Comp_Science_Coursework
{
    partial class EndScreen
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
            this.Title = new System.Windows.Forms.Label();
            this.GameWinLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Sigma Five", 24F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Title.Location = new System.Drawing.Point(169, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(486, 41);
            this.Title.TabIndex = 12;
            this.Title.Text = "KNIGHTS OF THE GALAXY";
            // 
            // GameWinLabel
            // 
            this.GameWinLabel.AllowDrop = true;
            this.GameWinLabel.AutoSize = true;
            this.GameWinLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameWinLabel.Font = new System.Drawing.Font("Sigma Five", 16F, System.Drawing.FontStyle.Bold);
            this.GameWinLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GameWinLabel.Location = new System.Drawing.Point(40, 100);
            this.GameWinLabel.MaximumSize = new System.Drawing.Size(800, 500);
            this.GameWinLabel.Name = "GameWinLabel";
            this.GameWinLabel.Size = new System.Drawing.Size(753, 58);
            this.GameWinLabel.TabIndex = 13;
            this.GameWinLabel.Text = "Congratulations! You have defeated the Overlord and his inner circle! The galaxy " +
    "thanks you hero!";
            // 
            // EndScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 436);
            this.Controls.Add(this.GameWinLabel);
            this.Controls.Add(this.Title);
            this.Name = "EndScreen";
            this.Text = "EndScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label GameWinLabel;
    }
}