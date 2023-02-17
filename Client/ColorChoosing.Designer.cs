namespace Client
{
    partial class ColorChoosing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorChoosing));
            this.chooseBluePlayerBtn = new System.Windows.Forms.Button();
            this.chooseRedPlayerBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.lbColor = new System.Windows.Forms.Label();
            this.connect_button = new System.Windows.Forms.Button();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chooseBluePlayerBtn
            // 
            this.chooseBluePlayerBtn.BackColor = System.Drawing.Color.White;
            this.chooseBluePlayerBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chooseBluePlayerBtn.BackgroundImage")));
            this.chooseBluePlayerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseBluePlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseBluePlayerBtn.Location = new System.Drawing.Point(301, 226);
            this.chooseBluePlayerBtn.Name = "chooseBluePlayerBtn";
            this.chooseBluePlayerBtn.Size = new System.Drawing.Size(70, 70);
            this.chooseBluePlayerBtn.TabIndex = 30;
            this.chooseBluePlayerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chooseBluePlayerBtn.UseVisualStyleBackColor = false;
            this.chooseBluePlayerBtn.Click += new System.EventHandler(this.chooseBluePlayerBtn_Click);
            // 
            // chooseRedPlayerBtn
            // 
            this.chooseRedPlayerBtn.BackColor = System.Drawing.Color.White;
            this.chooseRedPlayerBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chooseRedPlayerBtn.BackgroundImage")));
            this.chooseRedPlayerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseRedPlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseRedPlayerBtn.Location = new System.Drawing.Point(225, 226);
            this.chooseRedPlayerBtn.Name = "chooseRedPlayerBtn";
            this.chooseRedPlayerBtn.Size = new System.Drawing.Size(70, 70);
            this.chooseRedPlayerBtn.TabIndex = 29;
            this.chooseRedPlayerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chooseRedPlayerBtn.UseVisualStyleBackColor = false;
            this.chooseRedPlayerBtn.Click += new System.EventHandler(this.chooseRedPlayerBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.White;
            this.returnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Location = new System.Drawing.Point(160, 351);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(135, 35);
            this.returnBtn.TabIndex = 28;
            this.returnBtn.Text = "Back";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.BackColor = System.Drawing.Color.Transparent;
            this.lbColor.Location = new System.Drawing.Point(244, 170);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(84, 20);
            this.lbColor.TabIndex = 27;
            this.lbColor.Text = "Pawn color:";
            // 
            // connect_button
            // 
            this.connect_button.BackColor = System.Drawing.Color.White;
            this.connect_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connect_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.connect_button.ForeColor = System.Drawing.Color.White;
            this.connect_button.Location = new System.Drawing.Point(301, 351);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(135, 35);
            this.connect_button.TabIndex = 24;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = false;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // tbColor
            // 
            this.tbColor.Enabled = false;
            this.tbColor.Location = new System.Drawing.Point(225, 193);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(146, 27);
            this.tbColor.TabIndex = 31;
            // 
            // ColorChoosing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(583, 394);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.chooseBluePlayerBtn);
            this.Controls.Add(this.chooseRedPlayerBtn);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.connect_button);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorChoosing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color choosing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button chooseBluePlayerBtn;
        public System.Windows.Forms.Button chooseRedPlayerBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.TextBox tbColor;
    }
}