namespace KaraokeApp
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelPlaying = new Guna.UI2.WinForms.Guna2Panel();
            this.panelQueue = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonRepeat = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonNext = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonBack = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.buttonShuffle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.trackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.labelPlayingArtist = new System.Windows.Forms.Label();
            this.labelPlayingTitle = new System.Windows.Forms.Label();
            this.pictureBoxPlayingArtwork = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelTopPlaying = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSelectSongs = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelScreenName = new System.Windows.Forms.Label();
            this.panelChildForm = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.buttonLyric = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonSettings = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonPlayList = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonHome = new Guna.UI2.WinForms.Guna2CircleButton();
            this.timerMusic = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            this.panelPlaying.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayingArtwork)).BeginInit();
            this.panelTopPlaying.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 10;
            this.guna2Panel1.Controls.Add(this.panelPlaying);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(5, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1290, 690);
            this.guna2Panel1.TabIndex = 0;
            // 
            // panelPlaying
            // 
            this.panelPlaying.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.panelPlaying.Controls.Add(this.panelQueue);
            this.panelPlaying.Controls.Add(this.label2);
            this.panelPlaying.Controls.Add(this.guna2Panel5);
            this.panelPlaying.Controls.Add(this.guna2Panel4);
            this.panelPlaying.Controls.Add(this.trackBar);
            this.panelPlaying.Controls.Add(this.player);
            this.panelPlaying.Controls.Add(this.labelPlayingArtist);
            this.panelPlaying.Controls.Add(this.labelPlayingTitle);
            this.panelPlaying.Controls.Add(this.pictureBoxPlayingArtwork);
            this.panelPlaying.Controls.Add(this.panelTopPlaying);
            this.panelPlaying.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPlaying.Location = new System.Drawing.Point(981, 0);
            this.panelPlaying.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.panelPlaying.Name = "panelPlaying";
            this.panelPlaying.ShadowDecoration.Parent = this.panelPlaying;
            this.panelPlaying.Size = new System.Drawing.Size(309, 690);
            this.panelPlaying.TabIndex = 2;
            // 
            // panelQueue
            // 
            this.panelQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQueue.Location = new System.Drawing.Point(8, 500);
            this.panelQueue.Name = "panelQueue";
            this.panelQueue.ShadowDecoration.Parent = this.panelQueue;
            this.panelQueue.Size = new System.Drawing.Size(291, 178);
            this.panelQueue.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Queue";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.guna2Panel5.Location = new System.Drawing.Point(2, 434);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(307, 2);
            this.guna2Panel5.TabIndex = 9;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Panel4.Controls.Add(this.buttonRepeat);
            this.guna2Panel4.Controls.Add(this.buttonNext);
            this.guna2Panel4.Controls.Add(this.buttonBack);
            this.guna2Panel4.Controls.Add(this.buttonPlay);
            this.guna2Panel4.Controls.Add(this.buttonShuffle);
            this.guna2Panel4.Location = new System.Drawing.Point(32, 334);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(245, 67);
            this.guna2Panel4.TabIndex = 8;
            // 
            // buttonRepeat
            // 
            this.buttonRepeat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRepeat.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.buttonRepeat.CheckedState.Parent = this.buttonRepeat;
            this.buttonRepeat.CustomImages.Parent = this.buttonRepeat;
            this.buttonRepeat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonRepeat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonRepeat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonRepeat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonRepeat.DisabledState.Parent = this.buttonRepeat;
            this.buttonRepeat.FillColor = System.Drawing.Color.Transparent;
            this.buttonRepeat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRepeat.ForeColor = System.Drawing.Color.White;
            this.buttonRepeat.HoverState.Parent = this.buttonRepeat;
            this.buttonRepeat.Image = ((System.Drawing.Image)(resources.GetObject("buttonRepeat.Image")));
            this.buttonRepeat.ImageSize = new System.Drawing.Size(15, 15);
            this.buttonRepeat.Location = new System.Drawing.Point(186, 17);
            this.buttonRepeat.Name = "buttonRepeat";
            this.buttonRepeat.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonRepeat.ShadowDecoration.Parent = this.buttonRepeat;
            this.buttonRepeat.Size = new System.Drawing.Size(30, 30);
            this.buttonRepeat.TabIndex = 4;
            this.buttonRepeat.Click += new System.EventHandler(this.buttonRepeat_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonNext.CheckedState.Parent = this.buttonNext;
            this.buttonNext.CustomImages.Parent = this.buttonNext;
            this.buttonNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonNext.DisabledState.Parent = this.buttonNext;
            this.buttonNext.FillColor = System.Drawing.Color.Transparent;
            this.buttonNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.HoverState.Parent = this.buttonNext;
            this.buttonNext.Image = ((System.Drawing.Image)(resources.GetObject("buttonNext.Image")));
            this.buttonNext.ImageSize = new System.Drawing.Size(15, 15);
            this.buttonNext.Location = new System.Drawing.Point(150, 17);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonNext.ShadowDecoration.Parent = this.buttonNext;
            this.buttonNext.Size = new System.Drawing.Size(30, 30);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBack.CheckedState.Parent = this.buttonBack;
            this.buttonBack.CustomImages.Parent = this.buttonBack;
            this.buttonBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonBack.DisabledState.Parent = this.buttonBack;
            this.buttonBack.FillColor = System.Drawing.Color.Transparent;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.HoverState.Parent = this.buttonBack;
            this.buttonBack.Image = ((System.Drawing.Image)(resources.GetObject("buttonBack.Image")));
            this.buttonBack.ImageSize = new System.Drawing.Size(15, 15);
            this.buttonBack.Location = new System.Drawing.Point(68, 17);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonBack.ShadowDecoration.Parent = this.buttonBack;
            this.buttonBack.Size = new System.Drawing.Size(30, 30);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPlay.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.buttonPlay.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.buttonPlay.CheckedState.Parent = this.buttonPlay;
            this.buttonPlay.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonPlay.HoverState.Parent = this.buttonPlay;
            this.buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlay.Image")));
            this.buttonPlay.ImageOffset = new System.Drawing.Point(0, 0);
            this.buttonPlay.ImageRotate = 0F;
            this.buttonPlay.ImageSize = new System.Drawing.Size(40, 40);
            this.buttonPlay.Location = new System.Drawing.Point(104, 12);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.buttonPlay.PressedState.Parent = this.buttonPlay;
            this.buttonPlay.ShadowDecoration.Parent = this.buttonPlay;
            this.buttonPlay.Size = new System.Drawing.Size(40, 40);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonShuffle
            // 
            this.buttonShuffle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonShuffle.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.buttonShuffle.CheckedState.Parent = this.buttonShuffle;
            this.buttonShuffle.CustomImages.Parent = this.buttonShuffle;
            this.buttonShuffle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonShuffle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonShuffle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonShuffle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonShuffle.DisabledState.Parent = this.buttonShuffle;
            this.buttonShuffle.FillColor = System.Drawing.Color.Transparent;
            this.buttonShuffle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonShuffle.ForeColor = System.Drawing.Color.White;
            this.buttonShuffle.HoverState.Parent = this.buttonShuffle;
            this.buttonShuffle.Image = ((System.Drawing.Image)(resources.GetObject("buttonShuffle.Image")));
            this.buttonShuffle.ImageSize = new System.Drawing.Size(15, 15);
            this.buttonShuffle.Location = new System.Drawing.Point(32, 17);
            this.buttonShuffle.Name = "buttonShuffle";
            this.buttonShuffle.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonShuffle.ShadowDecoration.Parent = this.buttonShuffle;
            this.buttonShuffle.Size = new System.Drawing.Size(30, 30);
            this.buttonShuffle.TabIndex = 0;
            this.buttonShuffle.Click += new System.EventHandler(this.buttonShuffle_Click);
            // 
            // trackBar
            // 
            this.trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar.HoverState.Parent = this.trackBar;
            this.trackBar.Location = new System.Drawing.Point(37, 305);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(235, 23);
            this.trackBar.TabIndex = 7;
            this.trackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.trackBar.Value = 0;
            this.trackBar.ValueChanged += new System.EventHandler(this.trackBar_ValueChanged);
            this.trackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackBar_Scroll);
            // 
            // player
            // 
            this.player.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(157, 312);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(0, 10);
            this.player.TabIndex = 6;
            // 
            // labelPlayingArtist
            // 
            this.labelPlayingArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlayingArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayingArtist.ForeColor = System.Drawing.Color.White;
            this.labelPlayingArtist.Location = new System.Drawing.Point(3, 279);
            this.labelPlayingArtist.Name = "labelPlayingArtist";
            this.labelPlayingArtist.Size = new System.Drawing.Size(303, 23);
            this.labelPlayingArtist.TabIndex = 5;
            this.labelPlayingArtist.Text = "...";
            this.labelPlayingArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayingTitle
            // 
            this.labelPlayingTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlayingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayingTitle.ForeColor = System.Drawing.Color.White;
            this.labelPlayingTitle.Location = new System.Drawing.Point(3, 256);
            this.labelPlayingTitle.Name = "labelPlayingTitle";
            this.labelPlayingTitle.Size = new System.Drawing.Size(303, 23);
            this.labelPlayingTitle.TabIndex = 4;
            this.labelPlayingTitle.Text = "...";
            this.labelPlayingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxPlayingArtwork
            // 
            this.pictureBoxPlayingArtwork.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxPlayingArtwork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPlayingArtwork.BorderRadius = 15;
            this.pictureBoxPlayingArtwork.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayingArtwork.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlayingArtwork.Image")));
            this.pictureBoxPlayingArtwork.ImageRotate = 0F;
            this.pictureBoxPlayingArtwork.Location = new System.Drawing.Point(79, 84);
            this.pictureBoxPlayingArtwork.Name = "pictureBoxPlayingArtwork";
            this.pictureBoxPlayingArtwork.ShadowDecoration.Parent = this.pictureBoxPlayingArtwork;
            this.pictureBoxPlayingArtwork.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxPlayingArtwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayingArtwork.TabIndex = 3;
            this.pictureBoxPlayingArtwork.TabStop = false;
            // 
            // panelTopPlaying
            // 
            this.panelTopPlaying.Controls.Add(this.btnSelectSongs);
            this.panelTopPlaying.Controls.Add(this.label1);
            this.panelTopPlaying.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopPlaying.Location = new System.Drawing.Point(0, 0);
            this.panelTopPlaying.Name = "panelTopPlaying";
            this.panelTopPlaying.ShadowDecoration.Parent = this.panelTopPlaying;
            this.panelTopPlaying.Size = new System.Drawing.Size(309, 78);
            this.panelTopPlaying.TabIndex = 2;
            // 
            // btnSelectSongs
            // 
            this.btnSelectSongs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSelectSongs.CheckedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnSelectSongs.CheckedState.Parent = this.btnSelectSongs;
            this.btnSelectSongs.HoverState.ImageRotate = 360F;
            this.btnSelectSongs.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSelectSongs.HoverState.Parent = this.btnSelectSongs;
            this.btnSelectSongs.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectSongs.Image")));
            this.btnSelectSongs.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSelectSongs.ImageRotate = 0F;
            this.btnSelectSongs.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSelectSongs.Location = new System.Drawing.Point(257, 26);
            this.btnSelectSongs.Name = "btnSelectSongs";
            this.btnSelectSongs.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnSelectSongs.PressedState.Parent = this.btnSelectSongs;
            this.btnSelectSongs.ShadowDecoration.Parent = this.btnSelectSongs;
            this.btnSelectSongs.Size = new System.Drawing.Size(26, 26);
            this.btnSelectSongs.TabIndex = 1;
            this.btnSelectSongs.Click += new System.EventHandler(this.btnSelectSongs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Playing";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.guna2Panel2.Controls.Add(this.guna2Panel6);
            this.guna2Panel2.Controls.Add(this.panelChildForm);
            this.guna2Panel2.Location = new System.Drawing.Point(72, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(911, 690);
            this.guna2Panel2.TabIndex = 4;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel6.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel6.BorderRadius = 15;
            this.guna2Panel6.BorderThickness = 5;
            this.guna2Panel6.Controls.Add(this.labelScreenName);
            this.guna2Panel6.Location = new System.Drawing.Point(20, 0);
            this.guna2Panel6.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.ShadowDecoration.Parent = this.guna2Panel6;
            this.guna2Panel6.Size = new System.Drawing.Size(870, 32);
            this.guna2Panel6.TabIndex = 4;
            this.guna2Panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag_MouseDown);
            // 
            // labelScreenName
            // 
            this.labelScreenName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelScreenName.AutoSize = true;
            this.labelScreenName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScreenName.ForeColor = System.Drawing.Color.White;
            this.labelScreenName.Location = new System.Drawing.Point(405, 2);
            this.labelScreenName.Name = "labelScreenName";
            this.labelScreenName.Size = new System.Drawing.Size(68, 30);
            this.labelScreenName.TabIndex = 0;
            this.labelScreenName.Text = "Home";
            // 
            // panelChildForm
            // 
            this.panelChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChildForm.BackColor = System.Drawing.Color.Transparent;
            this.panelChildForm.BorderRadius = 15;
            this.panelChildForm.Location = new System.Drawing.Point(0, 32);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Padding = new System.Windows.Forms.Padding(20, 10, 20, 15);
            this.panelChildForm.ShadowDecoration.Parent = this.panelChildForm;
            this.panelChildForm.Size = new System.Drawing.Size(911, 658);
            this.panelChildForm.TabIndex = 3;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.guna2Panel3.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel3.Controls.Add(this.buttonLyric);
            this.guna2Panel3.Controls.Add(this.buttonSettings);
            this.guna2Panel3.Controls.Add(this.buttonPlayList);
            this.guna2Panel3.Controls.Add(this.buttonHome);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(72, 690);
            this.guna2Panel3.TabIndex = 3;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(6, 6);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(60, 60);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 7;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // buttonLyric
            // 
            this.buttonLyric.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLyric.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.buttonLyric.BorderThickness = 1;
            this.buttonLyric.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.buttonLyric.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.buttonLyric.CheckedState.Image = global::KaraokeApp.Properties.Resources.micro_48px;
            this.buttonLyric.CheckedState.Parent = this.buttonLyric;
            this.buttonLyric.CustomImages.Parent = this.buttonLyric;
            this.buttonLyric.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLyric.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLyric.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLyric.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLyric.DisabledState.Parent = this.buttonLyric;
            this.buttonLyric.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.buttonLyric.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLyric.ForeColor = System.Drawing.Color.White;
            this.buttonLyric.HoverState.Parent = this.buttonLyric;
            this.buttonLyric.Image = global::KaraokeApp.Properties.Resources.microw_48px;
            this.buttonLyric.Location = new System.Drawing.Point(16, 222);
            this.buttonLyric.Name = "buttonLyric";
            this.buttonLyric.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonLyric.ShadowDecoration.Parent = this.buttonLyric;
            this.buttonLyric.Size = new System.Drawing.Size(40, 40);
            this.buttonLyric.TabIndex = 6;
            this.buttonLyric.Tag = "Lyric";
            this.buttonLyric.Click += new System.EventHandler(this.buttonLyric_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.buttonSettings.BorderThickness = 1;
            this.buttonSettings.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.buttonSettings.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.buttonSettings.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.buttonSettings.CheckedState.Parent = this.buttonSettings;
            this.buttonSettings.CustomImages.Parent = this.buttonSettings;
            this.buttonSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSettings.DisabledState.Parent = this.buttonSettings;
            this.buttonSettings.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.buttonSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.HoverState.Parent = this.buttonSettings;
            this.buttonSettings.Image = global::KaraokeApp.Properties.Resources.icons8_settings_48;
            this.buttonSettings.Location = new System.Drawing.Point(16, 638);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonSettings.ShadowDecoration.Parent = this.buttonSettings;
            this.buttonSettings.Size = new System.Drawing.Size(40, 40);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.Tag = "Settings";
            this.buttonSettings.Click += new System.EventHandler(this.ActivateButton);
            // 
            // buttonPlayList
            // 
            this.buttonPlayList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPlayList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.buttonPlayList.BorderThickness = 1;
            this.buttonPlayList.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.buttonPlayList.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.buttonPlayList.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.buttonPlayList.CheckedState.Parent = this.buttonPlayList;
            this.buttonPlayList.CustomImages.Parent = this.buttonPlayList;
            this.buttonPlayList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPlayList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonPlayList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPlayList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonPlayList.DisabledState.Parent = this.buttonPlayList;
            this.buttonPlayList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.buttonPlayList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonPlayList.ForeColor = System.Drawing.Color.White;
            this.buttonPlayList.HoverState.Parent = this.buttonPlayList;
            this.buttonPlayList.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlayList.Image")));
            this.buttonPlayList.Location = new System.Drawing.Point(16, 158);
            this.buttonPlayList.Name = "buttonPlayList";
            this.buttonPlayList.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonPlayList.ShadowDecoration.Parent = this.buttonPlayList;
            this.buttonPlayList.Size = new System.Drawing.Size(40, 40);
            this.buttonPlayList.TabIndex = 3;
            this.buttonPlayList.Tag = "List";
            this.buttonPlayList.Click += new System.EventHandler(this.ActivateButton);
            // 
            // buttonHome
            // 
            this.buttonHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonHome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.buttonHome.BorderThickness = 1;
            this.buttonHome.Checked = true;
            this.buttonHome.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.buttonHome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.buttonHome.CheckedState.Parent = this.buttonHome;
            this.buttonHome.CustomImages.Parent = this.buttonHome;
            this.buttonHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonHome.DisabledState.Parent = this.buttonHome;
            this.buttonHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.buttonHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.HoverState.Parent = this.buttonHome;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.Location = new System.Drawing.Point(16, 94);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonHome.ShadowDecoration.Parent = this.buttonHome;
            this.buttonHome.Size = new System.Drawing.Size(40, 40);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Tag = "Home";
            this.buttonHome.Click += new System.EventHandler(this.ActivateButton);
            // 
            // timerMusic
            // 
            this.timerMusic.Enabled = true;
            this.timerMusic.Tick += new System.EventHandler(this.timerMusic_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(339, 440);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.panelPlaying.ResumeLayout(false);
            this.panelPlaying.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayingArtwork)).EndInit();
            this.panelTopPlaying.ResumeLayout(false);
            this.panelTopPlaying.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelPlaying;
        private Guna.UI2.WinForms.Guna2Panel panelQueue;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2CircleButton buttonRepeat;
        private Guna.UI2.WinForms.Guna2CircleButton buttonNext;
        private Guna.UI2.WinForms.Guna2CircleButton buttonBack;
        private Guna.UI2.WinForms.Guna2ImageButton buttonPlay;
        private Guna.UI2.WinForms.Guna2CircleButton buttonShuffle;
        private Guna.UI2.WinForms.Guna2TrackBar trackBar;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Label labelPlayingArtist;
        private System.Windows.Forms.Label labelPlayingTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxPlayingArtwork;
        private Guna.UI2.WinForms.Guna2Panel panelTopPlaying;
        private Guna.UI2.WinForms.Guna2ImageButton btnSelectSongs;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel panelChildForm;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton buttonLyric;
        private Guna.UI2.WinForms.Guna2CircleButton buttonSettings;
        private Guna.UI2.WinForms.Guna2CircleButton buttonPlayList;
        private Guna.UI2.WinForms.Guna2CircleButton buttonHome;
        private System.Windows.Forms.Timer timerMusic;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private System.Windows.Forms.Label labelScreenName;
    }
}

