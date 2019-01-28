namespace Comp_Science_Coursework
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.NewGameButton = new System.Windows.Forms.Button();
            this.LoadGameButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadGameTextBox = new System.Windows.Forms.TextBox();
            this.ListOfFilesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewGameButton
            // 
            this.NewGameButton.Location = new System.Drawing.Point(392, 113);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(124, 59);
            this.NewGameButton.TabIndex = 1;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = true;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // LoadGameButton
            // 
            this.LoadGameButton.Location = new System.Drawing.Point(392, 178);
            this.LoadGameButton.Name = "LoadGameButton";
            this.LoadGameButton.Size = new System.Drawing.Size(124, 59);
            this.LoadGameButton.TabIndex = 2;
            this.LoadGameButton.Text = "Load Game Button";
            this.LoadGameButton.UseVisualStyleBackColor = true;
            this.LoadGameButton.Click += new System.EventHandler(this.LoadGameButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Location = new System.Drawing.Point(392, 243);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(124, 59);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sigma Five", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(212, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 41);
            this.label1.TabIndex = 11;
            this.label1.Text = "KNIGHTS OF THE GALAXY";
            // 
            // LoadGameTextBox
            // 
            this.LoadGameTextBox.Location = new System.Drawing.Point(522, 198);
            this.LoadGameTextBox.Name = "LoadGameTextBox";
            this.LoadGameTextBox.Size = new System.Drawing.Size(139, 20);
            this.LoadGameTextBox.TabIndex = 12;
            // 
            // ListOfFilesLabel
            // 
            this.ListOfFilesLabel.AutoSize = true;
            this.ListOfFilesLabel.BackColor = System.Drawing.Color.Transparent;
            this.ListOfFilesLabel.Font = new System.Drawing.Font("Sigma Five", 12F, System.Drawing.FontStyle.Bold);
            this.ListOfFilesLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ListOfFilesLabel.Location = new System.Drawing.Point(664, 113);
            this.ListOfFilesLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.ListOfFilesLabel.Name = "ListOfFilesLabel";
            this.ListOfFilesLabel.Size = new System.Drawing.Size(162, 21);
            this.ListOfFilesLabel.TabIndex = 13;
            this.ListOfFilesLabel.Text = "List of Files : ";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(919, 435);
            this.Controls.Add(this.ListOfFilesLabel);
            this.Controls.Add(this.LoadGameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.LoadGameButton);
            this.Controls.Add(this.NewGameButton);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button LoadGameButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoadGameTextBox;
        private System.Windows.Forms.Label ListOfFilesLabel;
    }
}

