namespace KaraokeApp
{
    partial class UCAlbumItem
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.pictureBoxBgr = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBgr)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.BorderRadius = 50;
            this.guna2Panel1.Controls.Add(this.labelTitle);
            this.guna2Panel1.Controls.Add(this.labelArtist);
            this.guna2Panel1.Controls.Add(this.pictureBoxBgr);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(20, 10);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(280, 186);
            this.guna2Panel1.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(27, 87);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(226, 89);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Mercury: Act1";
            // 
            // labelArtist
            // 
            this.labelArtist.AutoSize = true;
            this.labelArtist.BackColor = System.Drawing.Color.Transparent;
            this.labelArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtist.ForeColor = System.Drawing.Color.White;
            this.labelArtist.Location = new System.Drawing.Point(30, 50);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(101, 17);
            this.labelArtist.TabIndex = 1;
            this.labelArtist.Text = "New Album by ";
            // 
            // pictureBoxBgr
            // 
            this.pictureBoxBgr.BorderRadius = 20;
            this.pictureBoxBgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBgr.Image = global::KaraokeApp.Properties.Resources.fullClrBgr1;
            this.pictureBoxBgr.ImageRotate = 0F;
            this.pictureBoxBgr.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBgr.Name = "pictureBoxBgr";
            this.pictureBoxBgr.ShadowDecoration.Parent = this.pictureBoxBgr;
            this.pictureBoxBgr.Size = new System.Drawing.Size(280, 186);
            this.pictureBoxBgr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBgr.TabIndex = 3;
            this.pictureBoxBgr.TabStop = false;
            // 
            // UCAlbumItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UCAlbumItem";
            this.Padding = new System.Windows.Forms.Padding(20, 10, 0, 10);
            this.Size = new System.Drawing.Size(300, 206);
            this.Load += new System.EventHandler(this.AlbumItem_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBgr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelArtist;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxBgr;
    }
}
