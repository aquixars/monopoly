namespace Client
{
    partial class Connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.port_textbox = new System.Windows.Forms.TextBox();
            this.ip_textbox = new System.Windows.Forms.TextBox();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.IPLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.returnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // port_textbox
            // 
            this.port_textbox.BackColor = System.Drawing.Color.White;
            this.port_textbox.ForeColor = System.Drawing.Color.Black;
            this.port_textbox.Location = new System.Drawing.Point(158, 251);
            this.port_textbox.MaxLength = 15;
            this.port_textbox.Name = "port_textbox";
            this.port_textbox.Size = new System.Drawing.Size(276, 27);
            this.port_textbox.TabIndex = 15;
            // 
            // ip_textbox
            // 
            this.ip_textbox.BackColor = System.Drawing.Color.White;
            this.ip_textbox.ForeColor = System.Drawing.Color.Black;
            this.ip_textbox.Location = new System.Drawing.Point(158, 197);
            this.ip_textbox.MaxLength = 15;
            this.ip_textbox.Name = "ip_textbox";
            this.ip_textbox.Size = new System.Drawing.Size(276, 27);
            this.ip_textbox.TabIndex = 14;
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.BackColor = System.Drawing.Color.Transparent;
            this.btnChooseColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChooseColor.ForeColor = System.Drawing.Color.White;
            this.btnChooseColor.Location = new System.Drawing.Point(299, 351);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(135, 35);
            this.btnChooseColor.TabIndex = 13;
            this.btnChooseColor.Text = "Next";
            this.btnChooseColor.UseVisualStyleBackColor = false;
            this.btnChooseColor.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.BackColor = System.Drawing.Color.Transparent;
            this.IPLabel.ForeColor = System.Drawing.Color.White;
            this.IPLabel.Location = new System.Drawing.Point(154, 174);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(24, 20);
            this.IPLabel.TabIndex = 11;
            this.IPLabel.Text = "IP:";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.BackColor = System.Drawing.Color.Transparent;
            this.portLabel.ForeColor = System.Drawing.Color.White;
            this.portLabel.Location = new System.Drawing.Point(154, 227);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(38, 20);
            this.portLabel.TabIndex = 10;
            this.portLabel.Text = "Port:";
            this.portLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.Transparent;
            this.returnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Location = new System.Drawing.Point(158, 351);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(135, 35);
            this.returnBtn.TabIndex = 19;
            this.returnBtn.Text = "Back";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(587, 398);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.port_textbox);
            this.Controls.Add(this.ip_textbox);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this.portLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox port_textbox;
        private System.Windows.Forms.TextBox ip_textbox;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button returnBtn;
    }
}