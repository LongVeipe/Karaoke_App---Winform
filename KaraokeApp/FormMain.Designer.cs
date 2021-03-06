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
            this.timerMusic = new System.Windows.Forms.Timer(this.components);
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlNav = new Guna.UI2.WinForms.Guna2Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnDark = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.buttonLyric = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLanguage = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonPlayList = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonHome = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnlContent = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelScreenName = new System.Windows.Forms.Label();
            this.panelChildForm = new Guna.UI2.WinForms.Guna2Panel();
            this.panelPlaying = new Guna.UI2.WinForms.Guna2Panel();
            this.panelQueue = new Guna.UI2.WinForms.Guna2Panel();
            this.lblQueue = new System.Windows.Forms.Label();
            this.pnlLine = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlControl = new Guna.UI2.WinForms.Guna2Panel();
            this.buttonRepeat = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonNext = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonBack = new Guna.UI2.WinForms.Guna2CircleButton();
            this.buttonPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.buttonShuffle = new Guna.UI2.WinForms.Guna2CircleButton();
            this.trackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.labelPlayingArtist = new System.Windows.Forms.Label();
            this.labelPlayingTitle = new System.Windows.Forms.Label();
            this.pictureBoxPlayingArtwork = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panelTopPlaying = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSelectSongs = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblPlaying = new System.Windows.Forms.Label();
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.pnlNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.panelPlaying.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayingArtwork)).BeginInit();
            this.panelTopPlaying.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerMusic
            // 
            this.timerMusic.Enabled = true;
            this.timerMusic.Tick += new System.EventHandler(this.timerMusic_Tick);
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
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.pnlNav.Controls.Add(this.btnClose);
            this.pnlNav.Controls.Add(this.btnDark);
            this.pnlNav.Controls.Add(this.guna2CirclePictureBox1);
            this.pnlNav.Controls.Add(this.buttonLyric);
            this.pnlNav.Controls.Add(this.btnLanguage);
            this.pnlNav.Controls.Add(this.buttonPlayList);
            this.pnlNav.Controls.Add(this.buttonHome);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.ShadowDecoration.Parent = this.pnlNav;
            this.pnlNav.Size = new System.Drawing.Size(72, 690);
            this.pnlNav.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.btnClose.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnClose.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.CheckedState.Image = global::KaraokeApp.Properties.Resources.vietnam_96px;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.DisabledState.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Image = global::KaraokeApp.Properties.Resources.close;
            this.btnClose.ImageSize = new System.Drawing.Size(22, 22);
            this.btnClose.Location = new System.Drawing.Point(16, 643);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 9;
            this.btnClose.Tag = "";
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDark
            // 
            this.btnDark.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDark.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.btnDark.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDark.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnDark.CheckedState.Image = global::KaraokeApp.Properties.Resources.dark11;
            this.btnDark.CheckedState.Parent = this.btnDark;
            this.btnDark.CustomImages.Parent = this.btnDark;
            this.btnDark.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDark.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDark.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDark.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDark.DisabledState.Parent = this.btnDark;
            this.btnDark.FillColor = System.Drawing.Color.Transparent;
            this.btnDark.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDark.ForeColor = System.Drawing.Color.White;
            this.btnDark.HoverState.Parent = this.btnDark;
            this.btnDark.Image = global::KaraokeApp.Properties.Resources.light;
            this.btnDark.ImageSize = new System.Drawing.Size(28, 28);
            this.btnDark.Location = new System.Drawing.Point(16, 551);
            this.btnDark.Name = "btnDark";
            this.btnDark.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDark.ShadowDecoration.Parent = this.btnDark;
            this.btnDark.Size = new System.Drawing.Size(40, 40);
            this.btnDark.TabIndex = 8;
            this.btnDark.Tag = "Settings";
            this.btnDark.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnDark.Click += new System.EventHandler(this.btnDark_Click);
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
            this.buttonLyric.FillColor = System.Drawing.Color.Transparent;
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
            this.buttonLyric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonLyric.Click += new System.EventHandler(this.ActivateButton);
            // 
            // btnLanguage
            // 
            this.btnLanguage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLanguage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.btnLanguage.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLanguage.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnLanguage.CheckedState.Image = global::KaraokeApp.Properties.Resources.vietnam_96px;
            this.btnLanguage.CheckedState.Parent = this.btnLanguage;
            this.btnLanguage.CustomImages.Parent = this.btnLanguage;
            this.btnLanguage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLanguage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLanguage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLanguage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLanguage.DisabledState.Parent = this.btnLanguage;
            this.btnLanguage.FillColor = System.Drawing.Color.Transparent;
            this.btnLanguage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLanguage.ForeColor = System.Drawing.Color.White;
            this.btnLanguage.HoverState.Parent = this.btnLanguage;
            this.btnLanguage.Image = global::KaraokeApp.Properties.Resources.england_96px;
            this.btnLanguage.Location = new System.Drawing.Point(16, 597);
            this.btnLanguage.Name = "btnLanguage";
            this.btnLanguage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLanguage.ShadowDecoration.Parent = this.btnLanguage;
            this.btnLanguage.Size = new System.Drawing.Size(40, 40);
            this.btnLanguage.TabIndex = 5;
            this.btnLanguage.Tag = "";
            this.btnLanguage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnLanguage.Click += new System.EventHandler(this.btnLanguage_Click);
            // 
            // buttonPlayList
            // 
            this.buttonPlayList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPlayList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.buttonPlayList.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(94)))), ((int)(((byte)(124)))));
            this.buttonPlayList.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.buttonPlayList.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.buttonPlayList.CheckedState.Parent = this.buttonPlayList;
            this.buttonPlayList.CustomImages.Parent = this.buttonPlayList;
            this.buttonPlayList.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPlayList.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonPlayList.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonPlayList.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonPlayList.DisabledState.Parent = this.buttonPlayList;
            this.buttonPlayList.FillColor = System.Drawing.Color.Transparent;
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
            this.buttonPlayList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonPlayList.Click += new System.EventHandler(this.ActivateButton);
            // 
            // buttonHome
            // 
            this.buttonHome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonHome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
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
            this.buttonHome.FillColor = System.Drawing.Color.Transparent;
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
            this.buttonHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.buttonHome.Click += new System.EventHandler(this.ActivateButton);
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlContent.Controls.Add(this.guna2Panel6);
            this.pnlContent.Controls.Add(this.panelChildForm);
            this.pnlContent.Location = new System.Drawing.Point(72, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.ShadowDecoration.Parent = this.pnlContent;
            this.pnlContent.Size = new System.Drawing.Size(911, 690);
            this.pnlContent.TabIndex = 4;
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
            this.labelScreenName.AutoSize = true;
            this.labelScreenName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelScreenName.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScreenName.ForeColor = System.Drawing.Color.White;
            this.labelScreenName.Location = new System.Drawing.Point(0, 0);
            this.labelScreenName.Name = "labelScreenName";
            this.labelScreenName.Size = new System.Drawing.Size(88, 38);
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
            // panelPlaying
            // 
            this.panelPlaying.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(38)))), ((int)(((byte)(62)))));
            this.panelPlaying.Controls.Add(this.panelQueue);
            this.panelPlaying.Controls.Add(this.lblQueue);
            this.panelPlaying.Controls.Add(this.pnlLine);
            this.panelPlaying.Controls.Add(this.pnlControl);
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
            this.panelQueue.BackColor = System.Drawing.Color.Transparent;
            this.panelQueue.Location = new System.Drawing.Point(8, 500);
            this.panelQueue.Name = "panelQueue";
            this.panelQueue.ShadowDecoration.Parent = this.panelQueue;
            this.panelQueue.Size = new System.Drawing.Size(291, 185);
            this.panelQueue.TabIndex = 11;
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.lblQueue.ForeColor = System.Drawing.Color.White;
            this.lblQueue.Location = new System.Drawing.Point(22, 459);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(86, 33);
            this.lblQueue.TabIndex = 10;
            this.lblQueue.Text = "Queue";
            // 
            // pnlLine
            // 
            this.pnlLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.pnlLine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(75)))));
            this.pnlLine.Location = new System.Drawing.Point(15, 434);
            this.pnlLine.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pnlLine.Name = "pnlLine";
            this.pnlLine.ShadowDecoration.Parent = this.pnlLine;
            this.pnlLine.Size = new System.Drawing.Size(277, 2);
            this.pnlLine.TabIndex = 9;
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlControl.Controls.Add(this.buttonRepeat);
            this.pnlControl.Controls.Add(this.buttonNext);
            this.pnlControl.Controls.Add(this.buttonBack);
            this.pnlControl.Controls.Add(this.buttonPlay);
            this.pnlControl.Controls.Add(this.buttonShuffle);
            this.pnlControl.Location = new System.Drawing.Point(32, 334);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.ShadowDecoration.Parent = this.pnlControl;
            this.pnlControl.Size = new System.Drawing.Size(245, 67);
            this.pnlControl.TabIndex = 8;
            // 
            // buttonRepeat
            // 
            this.buttonRepeat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRepeat.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
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
            this.buttonPlay.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
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
            this.buttonShuffle.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
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
            this.panelTopPlaying.Controls.Add(this.lblPlaying);
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
            // lblPlaying
            // 
            this.lblPlaying.AutoSize = true;
            this.lblPlaying.Font = new System.Drawing.Font("Comic Sans MS", 14.25F);
            this.lblPlaying.ForeColor = System.Drawing.Color.White;
            this.lblPlaying.Location = new System.Drawing.Point(22, 26);
            this.lblPlaying.Name = "lblPlaying";
            this.lblPlaying.Size = new System.Drawing.Size(93, 33);
            this.lblPlaying.TabIndex = 0;
            this.lblPlaying.Text = "Playing";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.pnlMain.Controls.Add(this.panelPlaying);
            this.pnlMain.Controls.Add(this.pnlContent);
            this.pnlMain.Controls.Add(this.pnlNav);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(5, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShadowDecoration.Parent = this.pnlMain;
            this.pnlMain.Size = new System.Drawing.Size(1290, 690);
            this.pnlMain.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.pnlMain);
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
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.pnlNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.panelPlaying.ResumeLayout(false);
            this.panelPlaying.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayingArtwork)).EndInit();
            this.panelTopPlaying.ResumeLayout(false);
            this.panelTopPlaying.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerMusic;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private Guna.UI2.WinForms.Guna2Panel pnlNav;
        private Guna.UI2.WinForms.Guna2CircleButton btnDark;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton buttonLyric;
        private Guna.UI2.WinForms.Guna2CircleButton btnLanguage;
        private Guna.UI2.WinForms.Guna2CircleButton buttonPlayList;
        private Guna.UI2.WinForms.Guna2CircleButton buttonHome;
        private Guna.UI2.WinForms.Guna2Panel pnlContent;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private System.Windows.Forms.Label labelScreenName;
        private Guna.UI2.WinForms.Guna2Panel panelChildForm;
        private Guna.UI2.WinForms.Guna2Panel panelPlaying;
        private Guna.UI2.WinForms.Guna2Panel panelQueue;
        private System.Windows.Forms.Label lblQueue;
        private Guna.UI2.WinForms.Guna2Panel pnlLine;
        private Guna.UI2.WinForms.Guna2Panel pnlControl;
        private Guna.UI2.WinForms.Guna2CircleButton buttonRepeat;
        private Guna.UI2.WinForms.Guna2CircleButton buttonNext;
        private Guna.UI2.WinForms.Guna2CircleButton buttonBack;
        private Guna.UI2.WinForms.Guna2ImageButton buttonPlay;
        private Guna.UI2.WinForms.Guna2CircleButton buttonShuffle;
        private Guna.UI2.WinForms.Guna2TrackBar trackBar;
        private System.Windows.Forms.Label labelPlayingArtist;
        private System.Windows.Forms.Label labelPlayingTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxPlayingArtwork;
        private Guna.UI2.WinForms.Guna2Panel panelTopPlaying;
        private Guna.UI2.WinForms.Guna2ImageButton btnSelectSongs;
        private System.Windows.Forms.Label lblPlaying;
        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2CircleButton btnClose;
    }
}

