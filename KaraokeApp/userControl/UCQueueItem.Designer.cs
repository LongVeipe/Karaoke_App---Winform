namespace KaraokeApp.userControl
{
    partial class UCQueueItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCQueueItem));
            this.labelArtist = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonLovely = new Guna.UI2.WinForms.Guna2ImageButton();
            this.buttonPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.buttonMenu = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBoxArtwork = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtwork)).BeginInit();
            this.SuspendLayout();
            // 
            // labelArtist
            // 
            this.labelArtist.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtist.ForeColor = System.Drawing.Color.White;
            this.labelArtist.Location = new System.Drawing.Point(63, 31);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(134, 15);
            this.labelArtist.TabIndex = 9;
            this.labelArtist.Text = "Artist";
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(63, 11);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(147, 18);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Title";
            // 
            // buttonLovely
            // 
            this.buttonLovely.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLovely.CheckedState.Image = global::KaraokeApp.Properties.Resources.icons8_heart_48_red;
            this.buttonLovely.CheckedState.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonLovely.CheckedState.Parent = this.buttonLovely;
            this.buttonLovely.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonLovely.HoverState.Parent = this.buttonLovely;
            this.buttonLovely.Image = global::KaraokeApp.Properties.Resources.icons8_heart_48__1_;
            this.buttonLovely.ImageOffset = new System.Drawing.Point(0, 0);
            this.buttonLovely.ImageRotate = 0F;
            this.buttonLovely.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonLovely.Location = new System.Drawing.Point(345, 11);
            this.buttonLovely.Name = "buttonLovely";
            this.buttonLovely.PressedState.ImageSize = new System.Drawing.Size(23, 23);
            this.buttonLovely.PressedState.Parent = this.buttonLovely;
            this.buttonLovely.ShadowDecoration.Parent = this.buttonLovely;
            this.buttonLovely.Size = new System.Drawing.Size(25, 25);
            this.buttonLovely.TabIndex = 12;
            this.buttonLovely.CheckedChanged += new System.EventHandler(this.buttonLovely_CheckedChanged);
            this.buttonLovely.Click += new System.EventHandler(this.buttonLovely_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlay.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonPlay.CheckedState.Parent = this.buttonPlay;
            this.buttonPlay.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonPlay.HoverState.Parent = this.buttonPlay;
            this.buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlay.Image")));
            this.buttonPlay.ImageOffset = new System.Drawing.Point(0, 0);
            this.buttonPlay.ImageRotate = 0F;
            this.buttonPlay.ImageSize = new System.Drawing.Size(25, 25);
            this.buttonPlay.Location = new System.Drawing.Point(311, 11);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.PressedState.ImageSize = new System.Drawing.Size(23, 23);
            this.buttonPlay.PressedState.Parent = this.buttonPlay;
            this.buttonPlay.ShadowDecoration.Parent = this.buttonPlay;
            this.buttonPlay.Size = new System.Drawing.Size(25, 25);
            this.buttonPlay.TabIndex = 11;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonMenu.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonMenu.CheckedState.Parent = this.buttonMenu;
            this.buttonMenu.HoverState.ImageSize = new System.Drawing.Size(21, 21);
            this.buttonMenu.HoverState.Parent = this.buttonMenu;
            this.buttonMenu.Image = global::KaraokeApp.Properties.Resources.icons8_ellipsis_48;
            this.buttonMenu.ImageOffset = new System.Drawing.Point(0, 0);
            this.buttonMenu.ImageRotate = 0F;
            this.buttonMenu.ImageSize = new System.Drawing.Size(21, 21);
            this.buttonMenu.Location = new System.Drawing.Point(389, 16);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.PressedState.ImageSize = new System.Drawing.Size(18, 18);
            this.buttonMenu.PressedState.Parent = this.buttonMenu;
            this.buttonMenu.ShadowDecoration.Parent = this.buttonMenu;
            this.buttonMenu.Size = new System.Drawing.Size(25, 25);
            this.buttonMenu.TabIndex = 10;
            // 
            // pictureBoxArtwork
            // 
            this.pictureBoxArtwork.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxArtwork.BorderRadius = 10;
            this.pictureBoxArtwork.Image = global::KaraokeApp.Properties.Resources.fullClrBgr3;
            this.pictureBoxArtwork.ImageRotate = 0F;
            this.pictureBoxArtwork.Location = new System.Drawing.Point(7, 5);
            this.pictureBoxArtwork.Name = "pictureBoxArtwork";
            this.pictureBoxArtwork.ShadowDecoration.Parent = this.pictureBoxArtwork;
            this.pictureBoxArtwork.Size = new System.Drawing.Size(45, 45);
            this.pictureBoxArtwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArtwork.TabIndex = 7;
            this.pictureBoxArtwork.TabStop = false;
            // 
            // UCQueueItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonLovely);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.labelArtist);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxArtwork);
            this.Name = "UCQueueItem";
            this.Size = new System.Drawing.Size(384, 57);
            this.Load += new System.EventHandler(this.UCQueueItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtwork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton buttonPlay;
        private Guna.UI2.WinForms.Guna2ImageButton buttonMenu;
        private System.Windows.Forms.Label labelArtist;
        private System.Windows.Forms.Label labelTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxArtwork;
        private Guna.UI2.WinForms.Guna2ImageButton buttonLovely;
    }
}
