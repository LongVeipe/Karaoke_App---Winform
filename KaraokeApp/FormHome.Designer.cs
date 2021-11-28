namespace KaraokeApp
{
    partial class FormHome
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonAlbumRight = new KaraokeApp.RoundedButton();
            this.buttonAlbumLeft = new KaraokeApp.RoundedButton();
            this.panelAlbums = new System.Windows.Forms.FlowLayoutPanel();
            this.labelScreenName = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRecently = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLovely = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.buttonAlbumRight);
            this.guna2Panel1.Controls.Add(this.buttonAlbumLeft);
            this.guna2Panel1.Controls.Add(this.panelAlbums);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(865, 233);
            this.guna2Panel1.TabIndex = 2;
            // 
            // buttonAlbumRight
            // 
            this.buttonAlbumRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAlbumRight.BackColor = System.Drawing.Color.White;
            this.buttonAlbumRight.BackgroundColor = System.Drawing.Color.White;
            this.buttonAlbumRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAlbumRight.BorderColor = System.Drawing.Color.White;
            this.buttonAlbumRight.BorderRadius = 20;
            this.buttonAlbumRight.BorderSize = 1;
            this.buttonAlbumRight.FlatAppearance.BorderSize = 0;
            this.buttonAlbumRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlbumRight.ForeColor = System.Drawing.Color.White;
            this.buttonAlbumRight.Location = new System.Drawing.Point(795, 93);
            this.buttonAlbumRight.Name = "buttonAlbumRight";
            this.buttonAlbumRight.Size = new System.Drawing.Size(40, 40);
            this.buttonAlbumRight.TabIndex = 1;
            this.buttonAlbumRight.TextColor = System.Drawing.Color.White;
            this.buttonAlbumRight.UseVisualStyleBackColor = false;
            this.buttonAlbumRight.Click += new System.EventHandler(this.buttonAlbumRight_Click);
            // 
            // buttonAlbumLeft
            // 
            this.buttonAlbumLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonAlbumLeft.BackColor = System.Drawing.Color.White;
            this.buttonAlbumLeft.BackgroundColor = System.Drawing.Color.White;
            this.buttonAlbumLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAlbumLeft.BorderColor = System.Drawing.Color.White;
            this.buttonAlbumLeft.BorderRadius = 20;
            this.buttonAlbumLeft.BorderSize = 1;
            this.buttonAlbumLeft.FlatAppearance.BorderSize = 0;
            this.buttonAlbumLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlbumLeft.ForeColor = System.Drawing.Color.White;
            this.buttonAlbumLeft.Location = new System.Drawing.Point(30, 93);
            this.buttonAlbumLeft.Name = "buttonAlbumLeft";
            this.buttonAlbumLeft.Size = new System.Drawing.Size(40, 40);
            this.buttonAlbumLeft.TabIndex = 0;
            this.buttonAlbumLeft.TextColor = System.Drawing.Color.White;
            this.buttonAlbumLeft.UseVisualStyleBackColor = false;
            this.buttonAlbumLeft.Click += new System.EventHandler(this.buttonAlbumLeft_Click);
            // 
            // panelAlbums
            // 
            this.panelAlbums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlbums.Location = new System.Drawing.Point(0, 0);
            this.panelAlbums.Name = "panelAlbums";
            this.panelAlbums.Size = new System.Drawing.Size(865, 233);
            this.panelAlbums.TabIndex = 2;
            this.panelAlbums.WrapContents = false;
            // 
            // labelScreenName
            // 
            this.labelScreenName.AutoSize = true;
            this.labelScreenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScreenName.ForeColor = System.Drawing.Color.White;
            this.labelScreenName.Location = new System.Drawing.Point(25, 269);
            this.labelScreenName.Name = "labelScreenName";
            this.labelScreenName.Size = new System.Drawing.Size(185, 26);
            this.labelScreenName.TabIndex = 3;
            this.labelScreenName.Text = "Recently Played";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.Controls.Add(this.panelRecently);
            this.guna2Panel2.Location = new System.Drawing.Point(30, 313);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(392, 325);
            this.guna2Panel2.TabIndex = 4;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.Controls.Add(this.panelLovely);
            this.guna2Panel3.Location = new System.Drawing.Point(465, 313);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(388, 325);
            this.guna2Panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(460, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your Lovely Playlist";
            // 
            // panelRecently
            // 
            this.panelRecently.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelRecently.BackColor = System.Drawing.Color.Transparent;
            this.panelRecently.Location = new System.Drawing.Point(0, 0);
            this.panelRecently.Name = "panelRecently";
            this.panelRecently.Size = new System.Drawing.Size(392, 325);
            this.panelRecently.TabIndex = 0;
            // 
            // panelLovely
            // 
            this.panelLovely.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLovely.BackColor = System.Drawing.Color.Transparent;
            this.panelLovely.Location = new System.Drawing.Point(3, 0);
            this.panelLovely.Name = "panelLovely";
            this.panelLovely.Size = new System.Drawing.Size(385, 322);
            this.panelLovely.TabIndex = 1;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(865, 650);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.labelScreenName);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private RoundedButton buttonAlbumLeft;
        private RoundedButton buttonAlbumRight;
        private System.Windows.Forms.FlowLayoutPanel panelAlbums;
        private System.Windows.Forms.Label labelScreenName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.FlowLayoutPanel panelRecently;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panelLovely;
    }
}