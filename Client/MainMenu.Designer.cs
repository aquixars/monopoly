namespace Client
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
            this.quitBtn = new System.Windows.Forms.Button();
            this.startSingleplayerGameBtn = new System.Windows.Forms.Button();
            this.startMultiplayerGameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.BackColor = System.Drawing.Color.Transparent;
            this.quitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quitBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.quitBtn.ForeColor = System.Drawing.Color.White;
            this.quitBtn.Location = new System.Drawing.Point(180, 272);
            this.quitBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(226, 35);
            this.quitBtn.TabIndex = 6;
            this.quitBtn.Text = "Exit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // startSingleplayerGameBtn
            // 
            this.startSingleplayerGameBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startSingleplayerGameBtn.BackColor = System.Drawing.Color.Transparent;
            this.startSingleplayerGameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startSingleplayerGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startSingleplayerGameBtn.ForeColor = System.Drawing.Color.White;
            this.startSingleplayerGameBtn.Location = new System.Drawing.Point(180, 182);
            this.startSingleplayerGameBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startSingleplayerGameBtn.Name = "startSingleplayerGameBtn";
            this.startSingleplayerGameBtn.Size = new System.Drawing.Size(226, 35);
            this.startSingleplayerGameBtn.TabIndex = 5;
            this.startSingleplayerGameBtn.Text = "Singleplayer";
            this.startSingleplayerGameBtn.UseVisualStyleBackColor = true;
            this.startSingleplayerGameBtn.Click += new System.EventHandler(this.StartSingleplayerGameBtn_Click);
            // 
            // startMultiplayerGameBtn
            // 
            this.startMultiplayerGameBtn.BackColor = System.Drawing.Color.Transparent;
            this.startMultiplayerGameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startMultiplayerGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startMultiplayerGameBtn.ForeColor = System.Drawing.Color.White;
            this.startMultiplayerGameBtn.Location = new System.Drawing.Point(180, 227);
            this.startMultiplayerGameBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startMultiplayerGameBtn.Name = "startMultiplayerGameBtn";
            this.startMultiplayerGameBtn.Size = new System.Drawing.Size(226, 35);
            this.startMultiplayerGameBtn.TabIndex = 7;
            this.startMultiplayerGameBtn.Text = "Multiplayer";
            this.startMultiplayerGameBtn.UseVisualStyleBackColor = true;
            this.startMultiplayerGameBtn.Click += new System.EventHandler(this.StartMultiplayerGameBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(587, 339);
            this.Controls.Add(this.startMultiplayerGameBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.startSingleplayerGameBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button startSingleplayerGameBtn;
        private System.Windows.Forms.Button startMultiplayerGameBtn;
    }
}