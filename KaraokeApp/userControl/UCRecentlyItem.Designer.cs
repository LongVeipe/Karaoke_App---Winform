namespace KaraokeApp
{
    partial class UCRecentlyItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRecentlyItem));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.buttonPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnRemove = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBoxArtwork = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtwork)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(76, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(176, 20);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title";
            // 
            // labelArtist
            // 
            this.labelArtist.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArtist.ForeColor = System.Drawing.Color.White;
            this.labelArtist.Location = new System.Drawing.Point(78, 46);
            this.labelArtist.Name = "labelArtist";
            this.labelArtist.Size = new System.Drawing.Size(174, 15);
            this.labelArtist.TabIndex = 2;
            this.labelArtist.Text = "Artist";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPlay.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonPlay.CheckedState.Parent = this.buttonPlay;
            this.buttonPlay.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonPlay.HoverState.Parent = this.buttonPlay;
            this.buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlay.Image")));
            this.buttonPlay.ImageOffset = new System.Drawing.Point(0, 0);
            this.buttonPlay.ImageRotate = 0F;
            this.buttonPlay.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonPlay.Location = new System.Drawing.Point(275, 29);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.PressedState.ImageSize = new System.Drawing.Size(28, 28);
            this.buttonPlay.PressedState.Parent = this.buttonPlay;
            this.buttonPlay.ShadowDecoration.Parent = this.buttonPlay;
            this.buttonPlay.Size = new System.Drawing.Size(30, 30);
            this.buttonPlay.TabIndex = 6;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(275, 28);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 5;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRemove.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnRemove.CheckedState.Parent = this.btnRemove;
            this.btnRemove.HoverState.ImageSize = new System.Drawing.Size(21, 21);
            this.btnRemove.HoverState.Parent = this.btnRemove;
            this.btnRemove.Image = global::KaraokeApp.Properties.Resources.Close_52px;
            this.btnRemove.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnRemove.ImageRotate = 0F;
            this.btnRemove.ImageSize = new System.Drawing.Size(21, 21);
            this.btnRemove.Location = new System.Drawing.Point(335, 31);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.PressedState.ImageSize = new System.Drawing.Size(18, 18);
            this.btnRemove.PressedState.Parent = this.btnRemove;
            this.btnRemove.ShadowDecoration.Parent = this.btnRemove;
            this.btnRemove.Size = new System.Drawing.Size(25, 25);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // pictureBoxArtwork
            // 
            this.pictureBoxArtwork.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxArtwork.BorderRadius = 10;
            this.pictureBoxArtwork.Image = global::KaraokeApp.Properties.Resources.fullClrBgr3;
            this.pictureBoxArtwork.ImageRotate = 0F;
            this.pictureBoxArtwork.Location = new System.Drawing.Point(0, 13);
            this.pictureBoxArtwork.Name = "pictureBoxArtwork";
            this.pictureBoxArtwork.ShadowDecoration.Parent = this.pictureBoxArtwork;
            this.pictureBoxArtwork.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxArtwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArtwork.TabIndex = 0;
            this.pictureBoxArtwork.TabStop = false;
            // 
            // UCRecentlyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.labelArtist);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxArtwork);
            this.Name = "UCRecentlyItem";
            this.Size = new System.Drawing.Size(358, 85);
            this.Load += new System.EventHandler(this.UCRecentlyItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtwork)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxArtwork;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelArtist;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2ImageButton buttonPlay;
        private Guna.UI2.WinForms.Guna2ImageButton btnRemove;
    }
}
