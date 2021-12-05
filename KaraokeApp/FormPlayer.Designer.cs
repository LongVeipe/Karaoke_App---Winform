
namespace KaraokeApp
{
    partial class FormPlayer
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
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.lyricViewPanel = new KaraokeApp.customControl.LyricView();
            this.backgroundButtonPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLyric = new Guna.UI2.WinForms.Guna2Button();
            this.btnKaraoke = new Guna.UI2.WinForms.Guna2Button();
            this.backgroundPanel.SuspendLayout();
            this.backgroundButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPanel.Controls.Add(this.lyricViewPanel);
            this.backgroundPanel.Controls.Add(this.backgroundButtonPanel);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(849, 611);
            this.backgroundPanel.TabIndex = 0;
            // 
            // lyricViewPanel
            // 
            this.lyricViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lyricViewPanel.BackColor = System.Drawing.Color.Transparent;
            this.lyricViewPanel.Location = new System.Drawing.Point(55, 46);
            this.lyricViewPanel.Name = "lyricViewPanel";
            this.lyricViewPanel.Size = new System.Drawing.Size(742, 490);
            this.lyricViewPanel.TabIndex = 1;
            // 
            // backgroundButtonPanel
            // 
            this.backgroundButtonPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backgroundButtonPanel.BackColor = System.Drawing.Color.Transparent;
            this.backgroundButtonPanel.BorderRadius = 10;
            this.backgroundButtonPanel.Controls.Add(this.btnLyric);
            this.backgroundButtonPanel.Controls.Add(this.btnKaraoke);
            this.backgroundButtonPanel.Location = new System.Drawing.Point(279, 563);
            this.backgroundButtonPanel.Name = "backgroundButtonPanel";
            this.backgroundButtonPanel.ShadowDecoration.Parent = this.backgroundButtonPanel;
            this.backgroundButtonPanel.Size = new System.Drawing.Size(304, 45);
            this.backgroundButtonPanel.TabIndex = 0;
            // 
            // btnLyric
            // 
            this.btnLyric.BorderRadius = 5;
            this.btnLyric.CheckedState.Parent = this.btnLyric;
            this.btnLyric.CustomImages.Parent = this.btnLyric;
            this.btnLyric.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLyric.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLyric.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLyric.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLyric.DisabledState.Parent = this.btnLyric;
            this.btnLyric.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(86)))), ((int)(((byte)(101)))));
            this.btnLyric.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLyric.ForeColor = System.Drawing.Color.White;
            this.btnLyric.HoverState.Parent = this.btnLyric;
            this.btnLyric.Location = new System.Drawing.Point(157, 3);
            this.btnLyric.Name = "btnLyric";
            this.btnLyric.ShadowDecoration.Parent = this.btnLyric;
            this.btnLyric.Size = new System.Drawing.Size(144, 37);
            this.btnLyric.TabIndex = 2;
            this.btnLyric.Text = "Lyric";
            this.btnLyric.Click += new System.EventHandler(this.btnLyric_Click);
            // 
            // btnKaraoke
            // 
            this.btnKaraoke.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKaraoke.BorderRadius = 5;
            this.btnKaraoke.CheckedState.Parent = this.btnKaraoke;
            this.btnKaraoke.CustomImages.Parent = this.btnKaraoke;
            this.btnKaraoke.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKaraoke.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKaraoke.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKaraoke.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKaraoke.DisabledState.Parent = this.btnKaraoke;
            this.btnKaraoke.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(86)))), ((int)(((byte)(101)))));
            this.btnKaraoke.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaraoke.ForeColor = System.Drawing.Color.White;
            this.btnKaraoke.HoverState.Parent = this.btnKaraoke;
            this.btnKaraoke.Location = new System.Drawing.Point(3, 3);
            this.btnKaraoke.Name = "btnKaraoke";
            this.btnKaraoke.ShadowDecoration.Parent = this.btnKaraoke;
            this.btnKaraoke.Size = new System.Drawing.Size(144, 37);
            this.btnKaraoke.TabIndex = 1;
            this.btnKaraoke.Text = "Karaoke";
            this.btnKaraoke.Click += new System.EventHandler(this.btnKaraoke_Click);
            // 
            // FormPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(849, 611);
            this.Controls.Add(this.backgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPlayer";
            this.Text = "FormPlayer";
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private Guna.UI2.WinForms.Guna2Panel backgroundButtonPanel;
        private Guna.UI2.WinForms.Guna2Button btnLyric;
        private Guna.UI2.WinForms.Guna2Button btnKaraoke;
        private customControl.LyricView lyricViewPanel;
    }
}