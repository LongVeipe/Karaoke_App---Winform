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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelChildForm = new Guna.UI2.WinForms.Guna2Panel();
            this.panelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.labelScreenName = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelPlaying = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.trackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.labelPlayingArtist = new System.Windows.Forms.Label();
            this.labelPlayingTitle = new System.Windows.Forms.Label();
            this.panelTopPlaying = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timerMusic = new System.Windows.Forms.Timer(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.buttonRepeat = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonNext = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonBack = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.buttonShuffle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pictureBoxPlayingArtwork = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.buttonLyric = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonSettings = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pictureBoxAvatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.buttonPlayList = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonFavorite = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonHome = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelPlaying.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panelTopPlaying.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayingArtwork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Controls.Add(this.buttonLyric);
            this.guna2Panel1.Controls.Add(this.buttonSettings);
            this.guna2Panel1.Controls.Add(this.pictureBoxAvatar);
            this.guna2Panel1.Controls.Add(this.buttonPlayList);
            this.guna2Panel1.Controls.Add(this.buttonFavorite);
            this.guna2Panel1.Controls.Add(this.buttonSearch);
            this.guna2Panel1.Controls.Add(this.buttonHome);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(72, 700);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.panelChildForm);
            this.guna2Panel2.Controls.Add(this.panelTop);
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(72, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(928, 700);
            this.guna2Panel2.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.Transparent;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 78);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.ShadowDecoration.Parent = this.panelChildForm;
            this.panelChildForm.Size = new System.Drawing.Size(609, 622);
            this.panelChildForm.TabIndex = 3;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelScreenName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.ShadowDecoration.Parent = this.panelTop;
            this.panelTop.Size = new System.Drawing.Size(609, 78);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // labelScreenName
            // 
            this.labelScreenName.AutoSize = true;
            this.labelScreenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScreenName.ForeColor = System.Drawing.Color.White;
            this.labelScreenName.Location = new System.Drawing.Point(25, 26);
            this.labelScreenName.Name = "labelScreenName";
            this.labelScreenName.Size = new System.Drawing.Size(75, 26);
            this.labelScreenName.TabIndex = 0;
            this.labelScreenName.Text = "Home";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel3.Location = new System.Drawing.Point(609, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(319, 700);
            this.guna2Panel3.TabIndex = 2;
            // 
            // panelPlaying
            // 
            this.panelPlaying.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPlaying.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.panelPlaying.Controls.Add(this.label2);
            this.panelPlaying.Controls.Add(this.guna2Panel5);
            this.panelPlaying.Controls.Add(this.guna2Panel4);
            this.panelPlaying.Controls.Add(this.trackBar);
            this.panelPlaying.Controls.Add(this.player);
            this.panelPlaying.Controls.Add(this.labelPlayingArtist);
            this.panelPlaying.Controls.Add(this.labelPlayingTitle);
            this.panelPlaying.Controls.Add(this.pictureBoxPlayingArtwork);
            this.panelPlaying.Controls.Add(this.panelTopPlaying);
            this.panelPlaying.Location = new System.Drawing.Point(679, 0);
            this.panelPlaying.Name = "panelPlaying";
            this.panelPlaying.ShadowDecoration.Parent = this.panelPlaying;
            this.panelPlaying.Size = new System.Drawing.Size(319, 700);
            this.panelPlaying.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Your Queue";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.guna2Panel5.Location = new System.Drawing.Point(2, 434);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(317, 2);
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
            this.guna2Panel4.Location = new System.Drawing.Point(37, 334);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(245, 67);
            this.guna2Panel4.TabIndex = 8;
            // 
            // trackBar
            // 
            this.trackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar.HoverState.Parent = this.trackBar;
            this.trackBar.Location = new System.Drawing.Point(37, 305);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(245, 23);
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
            this.player.Size = new System.Drawing.Size(10, 10);
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
            this.labelPlayingArtist.Size = new System.Drawing.Size(313, 23);
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
            this.labelPlayingTitle.Size = new System.Drawing.Size(313, 23);
            this.labelPlayingTitle.TabIndex = 4;
            this.labelPlayingTitle.Text = "...";
            this.labelPlayingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTopPlaying
            // 
            this.panelTopPlaying.Controls.Add(this.guna2ImageButton1);
            this.panelTopPlaying.Controls.Add(this.label1);
            this.panelTopPlaying.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopPlaying.Location = new System.Drawing.Point(0, 0);
            this.panelTopPlaying.Name = "panelTopPlaying";
            this.panelTopPlaying.ShadowDecoration.Parent = this.panelTopPlaying;
            this.panelTopPlaying.Size = new System.Drawing.Size(319, 78);
            this.panelTopPlaying.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Now Playing";
            // 
            // timerMusic
            // 
            this.timerMusic.Enabled = true;
            this.timerMusic.Tick += new System.EventHandler(this.timerMusic_Tick);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panelTop;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // buttonRepeat
            // 
            this.buttonRepeat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRepeat.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
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
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPlay.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
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
            // 
            // pictureBoxPlayingArtwork
            // 
            this.pictureBoxPlayingArtwork.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBoxPlayingArtwork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPlayingArtwork.BorderRadius = 15;
            this.pictureBoxPlayingArtwork.FillColor = System.Drawing.Color.Transparent;
            this.pictureBoxPlayingArtwork.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlayingArtwork.Image")));
            this.pictureBoxPlayingArtwork.ImageRotate = 0F;
            this.pictureBoxPlayingArtwork.Location = new System.Drawing.Point(84, 84);
            this.pictureBoxPlayingArtwork.Name = "pictureBoxPlayingArtwork";
            this.pictureBoxPlayingArtwork.ShadowDecoration.Parent = this.pictureBoxPlayingArtwork;
            this.pictureBoxPlayingArtwork.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxPlayingArtwork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlayingArtwork.TabIndex = 3;
            this.pictureBoxPlayingArtwork.TabStop = false;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(22, 22);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.ImageRotate = 360F;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.guna2ImageButton1.Location = new System.Drawing.Point(267, 26);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.ShadowDecoration.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(26, 26);
            this.guna2ImageButton1.TabIndex = 1;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(6, 12);
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
            this.buttonLyric.Location = new System.Drawing.Point(16, 312);
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
            this.buttonSettings.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
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
            this.buttonSettings.Location = new System.Drawing.Point(16, 573);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonSettings.ShadowDecoration.Parent = this.buttonSettings;
            this.buttonSettings.Size = new System.Drawing.Size(40, 40);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.Tag = "Settings";
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBoxAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar.Image")));
            this.pictureBoxAvatar.ImageRotate = 0F;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(14, 631);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureBoxAvatar.ShadowDecoration.Parent = this.pictureBoxAvatar;
            this.pictureBoxAvatar.Size = new System.Drawing.Size(45, 45);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar.TabIndex = 4;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // buttonPlayList
            // 
            this.buttonPlayList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPlayList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.buttonPlayList.BorderThickness = 1;
            this.buttonPlayList.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.buttonPlayList.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.buttonPlayList.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
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
            this.buttonPlayList.Location = new System.Drawing.Point(16, 264);
            this.buttonPlayList.Name = "buttonPlayList";
            this.buttonPlayList.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonPlayList.ShadowDecoration.Parent = this.buttonPlayList;
            this.buttonPlayList.Size = new System.Drawing.Size(40, 40);
            this.buttonPlayList.TabIndex = 3;
            this.buttonPlayList.Tag = "List";
            this.buttonPlayList.Click += new System.EventHandler(this.buttonPlayList_Click);
            // 
            // buttonFavorite
            // 
            this.buttonFavorite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonFavorite.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.buttonFavorite.BorderThickness = 1;
            this.buttonFavorite.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.buttonFavorite.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.buttonFavorite.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.buttonFavorite.CheckedState.Parent = this.buttonFavorite;
            this.buttonFavorite.CustomImages.Parent = this.buttonFavorite;
            this.buttonFavorite.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonFavorite.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonFavorite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonFavorite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonFavorite.DisabledState.Parent = this.buttonFavorite;
            this.buttonFavorite.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.buttonFavorite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonFavorite.ForeColor = System.Drawing.Color.White;
            this.buttonFavorite.HoverState.Parent = this.buttonFavorite;
            this.buttonFavorite.Image = ((System.Drawing.Image)(resources.GetObject("buttonFavorite.Image")));
            this.buttonFavorite.Location = new System.Drawing.Point(16, 218);
            this.buttonFavorite.Name = "buttonFavorite";
            this.buttonFavorite.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonFavorite.ShadowDecoration.Parent = this.buttonFavorite;
            this.buttonFavorite.Size = new System.Drawing.Size(40, 40);
            this.buttonFavorite.TabIndex = 2;
            this.buttonFavorite.Tag = "Favorite";
            this.buttonFavorite.Click += new System.EventHandler(this.buttonFavorite_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.buttonSearch.BorderThickness = 1;
            this.buttonSearch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.buttonSearch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.buttonSearch.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.buttonSearch.CheckedState.Parent = this.buttonSearch;
            this.buttonSearch.CustomImages.Parent = this.buttonSearch;
            this.buttonSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSearch.DisabledState.Parent = this.buttonSearch;
            this.buttonSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.HoverState.Parent = this.buttonSearch;
            this.buttonSearch.Image = ((System.Drawing.Image)(resources.GetObject("buttonSearch.Image")));
            this.buttonSearch.Location = new System.Drawing.Point(16, 158);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonSearch.ShadowDecoration.Parent = this.buttonSearch;
            this.buttonSearch.Size = new System.Drawing.Size(40, 40);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Tag = "Search";
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonHome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.buttonHome.BorderThickness = 1;
            this.buttonHome.Checked = true;
            this.buttonHome.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.buttonHome.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.buttonHome.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
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
            this.buttonHome.Location = new System.Drawing.Point(16, 98);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.buttonHome.ShadowDecoration.Parent = this.buttonHome;
            this.buttonHome.Size = new System.Drawing.Size(40, 40);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Tag = "Home";
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.ControlBox = false;
            this.Controls.Add(this.panelPlaying);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(339, 440);
            this.Name = "FormMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelPlaying.ResumeLayout(false);
            this.panelPlaying.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panelTopPlaying.ResumeLayout(false);
            this.panelTopPlaying.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayingArtwork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CircleButton buttonHome;
        private Guna.UI2.WinForms.Guna2CircleButton buttonPlayList;
        private Guna.UI2.WinForms.Guna2CircleButton buttonFavorite;
        private Guna.UI2.WinForms.Guna2CircleButton buttonSearch;
        private Guna.UI2.WinForms.Guna2Panel panelTop;
        private System.Windows.Forms.Label labelScreenName;
        private Guna.UI2.WinForms.Guna2Panel panelPlaying;
        private Guna.UI2.WinForms.Guna2Panel panelTopPlaying;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPlayingArtist;
        private System.Windows.Forms.Label labelPlayingTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxPlayingArtwork;
        private Guna.UI2.WinForms.Guna2TrackBar trackBar;
        private System.Windows.Forms.Timer timerMusic;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2ImageButton buttonPlay;
        private Guna.UI2.WinForms.Guna2CircleButton buttonShuffle;
        private Guna.UI2.WinForms.Guna2CircleButton buttonBack;
        private Guna.UI2.WinForms.Guna2CircleButton buttonRepeat;
        private Guna.UI2.WinForms.Guna2CircleButton buttonNext;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel panelChildForm;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureBoxAvatar;
        private Guna.UI2.WinForms.Guna2CircleButton buttonLyric;
        private Guna.UI2.WinForms.Guna2CircleButton buttonSettings;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}

