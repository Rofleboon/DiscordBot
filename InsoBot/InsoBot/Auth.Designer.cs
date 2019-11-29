namespace InsoBot
{
    partial class Auth
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
            this.linkDiscordAcc = new System.Windows.Forms.LinkLabel();
            this.btnDiscordAuth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkDiscordAcc
            // 
            this.linkDiscordAcc.AutoSize = true;
            this.linkDiscordAcc.Location = new System.Drawing.Point(39, 397);
            this.linkDiscordAcc.Name = "linkDiscordAcc";
            this.linkDiscordAcc.Size = new System.Drawing.Size(132, 13);
            this.linkDiscordAcc.TabIndex = 0;
            this.linkDiscordAcc.TabStop = true;
            this.linkDiscordAcc.Text = "Link your Discord Account";
            this.linkDiscordAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDiscordAcc_LinkClicked);
            // 
            // btnDiscordAuth
            // 
            this.btnDiscordAuth.Location = new System.Drawing.Point(276, 155);
            this.btnDiscordAuth.Name = "btnDiscordAuth";
            this.btnDiscordAuth.Size = new System.Drawing.Size(167, 97);
            this.btnDiscordAuth.TabIndex = 1;
            this.btnDiscordAuth.Text = "button1";
            this.btnDiscordAuth.UseVisualStyleBackColor = true;
            this.btnDiscordAuth.Click += new System.EventHandler(this.btnDiscordAuth_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDiscordAuth);
            this.Controls.Add(this.linkDiscordAcc);
            this.Name = "Auth";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkDiscordAcc;
        private System.Windows.Forms.Button btnDiscordAuth;
    }
}

