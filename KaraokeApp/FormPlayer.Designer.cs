
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
            this.pnlRecord = new System.Windows.Forms.Panel();
            this.btnRecord = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnStopRecording = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lyricViewPanel = new KaraokeApp.customControl.LyricView();
            this.backgroundButtonPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLyric = new Guna.UI2.WinForms.Guna2Button();
            this.btnKaraoke = new Guna.UI2.WinForms.Guna2Button();
            this.backgroundPanel.SuspendLayout();
            this.pnlRecord.SuspendLayout();
            this.backgroundButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backgroundPanel.Controls.Add(this.pnlRecord);
            this.backgroundPanel.Controls.Add(this.lyricViewPanel);
            this.backgroundPanel.Controls.Add(this.backgroundButtonPanel);
            this.backgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(849, 611);
            this.backgroundPanel.TabIndex = 0;
            // 
            // pnlRecord
            // 
            this.pnlRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlRecord.BackColor = System.Drawing.Color.Transparent;
            this.pnlRecord.Controls.Add(this.btnRecord);
            this.pnlRecord.Controls.Add(this.btnStopRecording);
            this.pnlRecord.Location = new System.Drawing.Point(301, 538);
            this.pnlRecord.Name = "pnlRecord";
            this.pnlRecord.Size = new System.Drawing.Size(200, 61);
            this.pnlRecord.TabIndex = 4;
            // 
            // btnRecord
            // 
            this.btnRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRecord.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnRecord.CheckedState.Image = global::KaraokeApp.Properties.Resources.pause_50px;
            this.btnRecord.CheckedState.Parent = this.btnRecord;
            this.btnRecord.CustomImages.Parent = this.btnRecord;
            this.btnRecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRecord.DisabledState.Parent = this.btnRecord;
            this.btnRecord.FillColor = System.Drawing.Color.White;
            this.btnRecord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRecord.ForeColor = System.Drawing.Color.White;
            this.btnRecord.HoverState.Parent = this.btnRecord;
            this.btnRecord.Image = global::KaraokeApp.Properties.Resources.record_48px;
            this.btnRecord.ImageSize = new System.Drawing.Size(48, 48);
            this.btnRecord.Location = new System.Drawing.Point(118, 6);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRecord.ShadowDecoration.Parent = this.btnRecord;
            this.btnRecord.Size = new System.Drawing.Size(50, 50);
            this.btnRecord.TabIndex = 2;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnStopRecording
            // 
            this.btnStopRecording.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStopRecording.CheckedState.Parent = this.btnStopRecording;
            this.btnStopRecording.CustomImages.Parent = this.btnStopRecording;
            this.btnStopRecording.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStopRecording.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStopRecording.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStopRecording.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStopRecording.DisabledState.Parent = this.btnStopRecording;
            this.btnStopRecording.FillColor = System.Drawing.Color.White;
            this.btnStopRecording.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStopRecording.ForeColor = System.Drawing.Color.White;
            this.btnStopRecording.HoverState.Parent = this.btnStopRecording;
            this.btnStopRecording.Image = global::KaraokeApp.Properties.Resources.rectangle_32px;
            this.btnStopRecording.Location = new System.Drawing.Point(48, 10);
            this.btnStopRecording.Name = "btnStopRecording";
            this.btnStopRecording.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnStopRecording.ShadowDecoration.Parent = this.btnStopRecording;
            this.btnStopRecording.Size = new System.Drawing.Size(40, 40);
            this.btnStopRecording.TabIndex = 3;
            this.btnStopRecording.Click += new System.EventHandler(this.btnStopRecording_Click);
            // 
            // lyricViewPanel
            // 
            this.lyricViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lyricViewPanel.BackColor = System.Drawing.Color.Transparent;
            this.lyricViewPanel.Location = new System.Drawing.Point(55, 54);
            this.lyricViewPanel.Name = "lyricViewPanel";
            this.lyricViewPanel.Size = new System.Drawing.Size(742, 483);
            this.lyricViewPanel.TabIndex = 1;
            // 
            // backgroundButtonPanel
            // 
            this.backgroundButtonPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backgroundButtonPanel.BackColor = System.Drawing.Color.Transparent;
            this.backgroundButtonPanel.BorderRadius = 10;
            this.backgroundButtonPanel.Controls.Add(this.btnLyric);
            this.backgroundButtonPanel.Controls.Add(this.btnKaraoke);
            this.backgroundButtonPanel.Location = new System.Drawing.Point(261, 0);
            this.backgroundButtonPanel.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
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
            this.pnlRecord.ResumeLayout(false);
            this.backgroundButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgroundPanel;
        private Guna.UI2.WinForms.Guna2Panel backgroundButtonPanel;
        private Guna.UI2.WinForms.Guna2Button btnLyric;
        private Guna.UI2.WinForms.Guna2Button btnKaraoke;
        private customControl.LyricView lyricViewPanel;
        private Guna.UI2.WinForms.Guna2CircleButton btnRecord;
        private System.Windows.Forms.Panel pnlRecord;
        private Guna.UI2.WinForms.Guna2CircleButton btnStopRecording;
    }
}