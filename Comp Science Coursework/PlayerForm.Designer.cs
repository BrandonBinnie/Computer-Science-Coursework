namespace Comp_Science_Coursework
{
    partial class PlayerForm
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
            this.PlayerNameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.TextBox();
            this.EnterNameButton = new System.Windows.Forms.Button();
            this.ClassBox = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ClassButton = new System.Windows.Forms.Button();
            this.PlayerContinueButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlayerNameBox
            // 
            this.PlayerNameBox.Font = new System.Drawing.Font("Sigma Five", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameBox.Location = new System.Drawing.Point(438, 109);
            this.PlayerNameBox.Name = "PlayerNameBox";
            this.PlayerNameBox.Size = new System.Drawing.Size(177, 28);
            this.PlayerNameBox.TabIndex = 2;
            this.PlayerNameBox.TextChanged += new System.EventHandler(this.PlayerNameBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.Font = new System.Drawing.Font("Sigma Five", 12F);
            this.NameLabel.Location = new System.Drawing.Point(187, 109);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(245, 28);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Please enter your name :";
            // 
            // EnterNameButton
            // 
            this.EnterNameButton.Font = new System.Drawing.Font("Sigma Five", 8.25F);
            this.EnterNameButton.Location = new System.Drawing.Point(622, 109);
            this.EnterNameButton.Name = "EnterNameButton";
            this.EnterNameButton.Size = new System.Drawing.Size(61, 28);
            this.EnterNameButton.TabIndex = 4;
            this.EnterNameButton.Text = "Enter";
            this.EnterNameButton.UseVisualStyleBackColor = true;
            this.EnterNameButton.Click += new System.EventHandler(this.EnterNameButton_Click);
            // 
            // ClassBox
            // 
            this.ClassBox.Font = new System.Drawing.Font("Sigma Five", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassBox.FormattingEnabled = true;
            this.ClassBox.ItemHeight = 21;
            this.ClassBox.Items.AddRange(new object[] {
            "Fighter",
            "Agent",
            "Mystic"});
            this.ClassBox.Location = new System.Drawing.Point(438, 143);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(177, 151);
            this.ClassBox.TabIndex = 5;
            this.ClassBox.SelectedIndexChanged += new System.EventHandler(this.ClassBox_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Sigma Five", 12F);
            this.textBox2.Location = new System.Drawing.Point(187, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 28);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Please select a class :";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Sigma Five", 12F);
            this.textBox3.Location = new System.Drawing.Point(12, 311);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(888, 114);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "Each Class comes with it\'s own special bonuses : \r\nFighter - Starts with more max" +
    "imum health.\r\nAgent - Starts with more maximum energy. \r\nMystic - Each ability c" +
    "osts less energy to use.\r\n";
            // 
            // ClassButton
            // 
            this.ClassButton.Font = new System.Drawing.Font("Sigma Five", 8.25F);
            this.ClassButton.Location = new System.Drawing.Point(621, 144);
            this.ClassButton.Name = "ClassButton";
            this.ClassButton.Size = new System.Drawing.Size(62, 28);
            this.ClassButton.TabIndex = 8;
            this.ClassButton.Text = "Enter";
            this.ClassButton.UseVisualStyleBackColor = true;
            this.ClassButton.Click += new System.EventHandler(this.ClassButton_Click);
            // 
            // PlayerContinueButton
            // 
            this.PlayerContinueButton.Font = new System.Drawing.Font("Sigma Five", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerContinueButton.Location = new System.Drawing.Point(689, 109);
            this.PlayerContinueButton.Name = "PlayerContinueButton";
            this.PlayerContinueButton.Size = new System.Drawing.Size(211, 78);
            this.PlayerContinueButton.TabIndex = 9;
            this.PlayerContinueButton.Text = "CONTINUE";
            this.PlayerContinueButton.UseVisualStyleBackColor = true;
            this.PlayerContinueButton.Click += new System.EventHandler(this.PlayerContinueButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sigma Five", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 41);
            this.label1.TabIndex = 10;
            this.label1.Text = "KNIGHTS OF THE GALAXY";
            // 
            // PlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerContinueButton);
            this.Controls.Add(this.ClassButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ClassBox);
            this.Controls.Add(this.EnterNameButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PlayerNameBox);
            this.Name = "PlayerForm";
            this.Text = "PlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PlayerNameBox;
        private System.Windows.Forms.TextBox NameLabel;
        private System.Windows.Forms.Button EnterNameButton;
        private System.Windows.Forms.ListBox ClassBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button ClassButton;
        private System.Windows.Forms.Button PlayerContinueButton;
        private System.Windows.Forms.Label label1;
    }
}