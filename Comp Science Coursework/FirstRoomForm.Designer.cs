namespace Comp_Science_Coursework
{
    partial class FirstRoomForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstRoomForm));
            this.Enemy1Button = new System.Windows.Forms.Button();
            this.MiniGameButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.PlayerNameBox = new System.Windows.Forms.Label();
            this.PlayerXP = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Enemy1Button
            // 
            this.Enemy1Button.Image = ((System.Drawing.Image)(resources.GetObject("Enemy1Button.Image")));
            this.Enemy1Button.Location = new System.Drawing.Point(624, 88);
            this.Enemy1Button.Name = "Enemy1Button";
            this.Enemy1Button.Size = new System.Drawing.Size(263, 350);
            this.Enemy1Button.TabIndex = 0;
            this.Enemy1Button.UseVisualStyleBackColor = true;
            this.Enemy1Button.Click += new System.EventHandler(this.Enemy1Button_Click);
            // 
            // MiniGameButton
            // 
            this.MiniGameButton.Font = new System.Drawing.Font("Sigma Five", 16F);
            this.MiniGameButton.Location = new System.Drawing.Point(343, 19);
            this.MiniGameButton.Name = "MiniGameButton";
            this.MiniGameButton.Size = new System.Drawing.Size(156, 43);
            this.MiniGameButton.TabIndex = 1;
            this.MiniGameButton.Text = "Mini Game";
            this.MiniGameButton.UseVisualStyleBackColor = true;
            this.MiniGameButton.Click += new System.EventHandler(this.MiniGameButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 148);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(705, 196);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(126, 135);
            this.ContinueButton.TabIndex = 6;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Visible = false;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_click);
            // 
            // PlayerNameBox
            // 
            this.PlayerNameBox.AutoSize = true;
            this.PlayerNameBox.Font = new System.Drawing.Font("Sigma Five", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameBox.Location = new System.Drawing.Point(12, 9);
            this.PlayerNameBox.Name = "PlayerNameBox";
            this.PlayerNameBox.Size = new System.Drawing.Size(64, 24);
            this.PlayerNameBox.TabIndex = 15;
            this.PlayerNameBox.Text = "Name";
            this.PlayerNameBox.Click += new System.EventHandler(this.PlayerName_Click);
            // 
            // PlayerXP
            // 
            this.PlayerXP.AutoSize = true;
            this.PlayerXP.Font = new System.Drawing.Font("Sigma Five", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerXP.Location = new System.Drawing.Point(12, 38);
            this.PlayerXP.Name = "PlayerXP";
            this.PlayerXP.Size = new System.Drawing.Size(64, 24);
            this.PlayerXP.TabIndex = 16;
            this.PlayerXP.Text = "Name";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Sigma Five", 16F);
            this.SaveButton.Location = new System.Drawing.Point(780, 19);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(107, 43);
            this.SaveButton.TabIndex = 17;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // FirstRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PlayerXP);
            this.Controls.Add(this.PlayerNameBox);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MiniGameButton);
            this.Controls.Add(this.Enemy1Button);
            this.Name = "FirstRoomForm";
            this.Text = "FirstRoomForm";
            this.Load += new System.EventHandler(this.FirstRoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enemy1Button;
        private System.Windows.Forms.Button MiniGameButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Label PlayerNameBox;
        private System.Windows.Forms.Label PlayerXP;
        private System.Windows.Forms.Button SaveButton;
    }
}