namespace Diagnostic_Center_Management_System
{
    partial class LoggedOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggedOut));
            this.BackToLoginBtn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackToLoginBtn
            // 
            this.BackToLoginBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackToLoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.BackToLoginBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.BackToLoginBtn.FlatAppearance.BorderSize = 0;
            this.BackToLoginBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToLoginBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackToLoginBtn.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltRight;
            this.BackToLoginBtn.IconColor = System.Drawing.Color.DimGray;
            this.BackToLoginBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BackToLoginBtn.IconSize = 35;
            this.BackToLoginBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackToLoginBtn.Location = new System.Drawing.Point(172, 322);
            this.BackToLoginBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BackToLoginBtn.Name = "BackToLoginBtn";
            this.BackToLoginBtn.Padding = new System.Windows.Forms.Padding(11, 0, 19, 0);
            this.BackToLoginBtn.Size = new System.Drawing.Size(235, 32);
            this.BackToLoginBtn.TabIndex = 28;
            this.BackToLoginBtn.Text = "Go back to login page";
            this.BackToLoginBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BackToLoginBtn.UseVisualStyleBackColor = false;
            this.BackToLoginBtn.Click += new System.EventHandler(this.BackToLoginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(56, 247);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 44);
            this.label1.TabIndex = 27;
            this.label1.Text = "Logged out successfully";
            // 
            // LoggedOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(574, 609);
            this.Controls.Add(this.BackToLoginBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoggedOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logged Out";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoggedOut_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton BackToLoginBtn;
        private System.Windows.Forms.Label label1;
    }
}