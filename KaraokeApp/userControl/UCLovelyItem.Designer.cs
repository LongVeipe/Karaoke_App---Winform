namespace KaraokeApp
{
    partial class UCLovelyItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLovelyItem));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelArtist = new System.Windows.Forms.Label();
            this.buttonLovely = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pictureBoxArtwork = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtwork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
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
            // buttonLovely
            // 
            this.buttonLovely.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonLovely.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonLovely.CheckedState.Parent = this.buttonLovely;
            this.buttonLovely.HoverState.ImageSize = new System.Drawing.Size(21, 21);
            this.buttonLovely.HoverState.Parent = this.buttonLovely;
            this.buttonLovely.Image = global::KaraokeApp.Properties.Resources.icons8_heart_48_red;
            this.buttonLovely.ImageOffset = new System.Drawing.Point(0, 0);
            this.buttonLovely.ImageRotate = 0F;
            this.buttonLovely.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonLovely.Location = new System.Drawing.Point(328, 29);
            this.buttonLovely.Name = "buttonLovely";
            this.buttonLovely.PressedState.ImageSize = new System.Drawing.Size(28, 28);
            this.buttonLovely.PressedState.Parent = this.buttonLovely;
            this.buttonLovely.ShadowDecoration.Parent = this.buttonLovely;
            this.buttonLovely.Size = new System.Drawing.Size(30, 30);
            this.buttonLovely.TabIndex = 4;
            this.buttonLovely.Click += new System.EventHandler(this.buttonLovely_Click);
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
            // buttonPlay
            // 
            this.buttonPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPlay.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonPlay.CheckedState.Parent = this.buttonPlay;
            this.buttonPlay.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.buttonPlay.HoverState.Parent = this.buttonPlay;
            this.buttonPlay.Image = global::KaraokeApp.Properties.Resources.add_30px;
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
            // UCLovelyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.buttonLovely);
            this.Controls.Add(this.labelArtist);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBoxArtwork);
            this.Name = "UCLovelyItem";
            this.Size = new System.Drawing.Size(358, 85);
            this.Load += new System.EventHandler(this.UCRecentlyItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArtwork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxArtwork;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelArtist;
        private Guna.UI2.WinForms.Guna2ImageButton buttonLovely;
        private Guna.UI2.WinForms.Guna2ImageButton buttonPlay;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}
