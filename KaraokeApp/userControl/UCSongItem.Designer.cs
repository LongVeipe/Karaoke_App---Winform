
namespace KaraokeApp.userControl
{
    partial class UCSongItem
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
            this.ptbSzResult = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlSong = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSong = new System.Windows.Forms.Label();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSz = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnYoutube = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSzResult)).BeginInit();
            this.pnlSong.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbSzResult
            // 
            this.ptbSzResult.BackColor = System.Drawing.Color.Transparent;
            this.ptbSzResult.BorderRadius = 15;
            this.ptbSzResult.ImageRotate = 0F;
            this.ptbSzResult.Location = new System.Drawing.Point(0, 0);
            this.ptbSzResult.Margin = new System.Windows.Forms.Padding(0);
            this.ptbSzResult.Name = "ptbSzResult";
            this.ptbSzResult.ShadowDecoration.Parent = this.ptbSzResult;
            this.ptbSzResult.Size = new System.Drawing.Size(48, 48);
            this.ptbSzResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSzResult.TabIndex = 6;
            this.ptbSzResult.TabStop = false;
            // 
            // pnlSong
            // 
            this.pnlSong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSong.Controls.Add(this.lblSong);
            this.pnlSong.Location = new System.Drawing.Point(51, 0);
            this.pnlSong.Name = "pnlSong";
            this.pnlSong.ShadowDecoration.Parent = this.pnlSong;
            this.pnlSong.Size = new System.Drawing.Size(167, 48);
            this.pnlSong.TabIndex = 7;
            // 
            // lblSong
            // 
            this.lblSong.BackColor = System.Drawing.Color.Transparent;
            this.lblSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSong.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSong.ForeColor = System.Drawing.Color.White;
            this.lblSong.Location = new System.Drawing.Point(0, 0);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(167, 48);
            this.lblSong.TabIndex = 0;
            this.lblSong.Text = "label1";
            this.lblSong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoSize = true;
            this.pnlMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMain.Controls.Add(this.btnYoutube);
            this.pnlMain.Controls.Add(this.btnSz);
            this.pnlMain.Controls.Add(this.pnlSong);
            this.pnlMain.Controls.Add(this.ptbSzResult);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShadowDecoration.Parent = this.pnlMain;
            this.pnlMain.Size = new System.Drawing.Size(248, 60);
            this.pnlMain.TabIndex = 6;
            // 
            // btnSz
            // 
            this.btnSz.CheckedState.Parent = this.btnSz;
            this.btnSz.CustomImages.Parent = this.btnSz;
            this.btnSz.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSz.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSz.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSz.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSz.DisabledState.Parent = this.btnSz;
            this.btnSz.FillColor = System.Drawing.Color.Transparent;
            this.btnSz.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSz.ForeColor = System.Drawing.Color.White;
            this.btnSz.HoverState.Parent = this.btnSz;
            this.btnSz.Image = global::KaraokeApp.Properties.Resources.shazam_48px;
            this.btnSz.ImageSize = new System.Drawing.Size(24, 24);
            this.btnSz.Location = new System.Drawing.Point(224, 0);
            this.btnSz.Name = "btnSz";
            this.btnSz.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSz.ShadowDecoration.Parent = this.btnSz;
            this.btnSz.Size = new System.Drawing.Size(24, 24);
            this.btnSz.TabIndex = 1;
            this.btnSz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSz.Click += new System.EventHandler(this.goTo_Click);
            // 
            // btnYoutube
            // 
            this.btnYoutube.CheckedState.Parent = this.btnYoutube;
            this.btnYoutube.CustomImages.Parent = this.btnYoutube;
            this.btnYoutube.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYoutube.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYoutube.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYoutube.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYoutube.DisabledState.Parent = this.btnYoutube;
            this.btnYoutube.FillColor = System.Drawing.Color.Transparent;
            this.btnYoutube.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYoutube.ForeColor = System.Drawing.Color.White;
            this.btnYoutube.HoverState.Parent = this.btnYoutube;
            this.btnYoutube.Image = global::KaraokeApp.Properties.Resources.YouTube_60px;
            this.btnYoutube.ImageSize = new System.Drawing.Size(24, 24);
            this.btnYoutube.Location = new System.Drawing.Point(224, 26);
            this.btnYoutube.Name = "btnYoutube";
            this.btnYoutube.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnYoutube.ShadowDecoration.Parent = this.btnYoutube;
            this.btnYoutube.Size = new System.Drawing.Size(24, 24);
            this.btnYoutube.TabIndex = 8;
            this.btnYoutube.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnYoutube.Click += new System.EventHandler(this.goTo_Click);
            // 
            // UCSongItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlMain);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCSongItem";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(248, 60);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSzResult)).EndInit();
            this.pnlSong.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox ptbSzResult;
        private Guna.UI2.WinForms.Guna2Panel pnlSong;
        private System.Windows.Forms.Label lblSong;
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2CircleButton btnSz;
        private Guna.UI2.WinForms.Guna2CircleButton btnYoutube;
    }
}
