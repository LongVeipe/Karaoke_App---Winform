
namespace KaraokeApp
{
    partial class FormList
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
            this.flowPNLListSong = new System.Windows.Forms.Panel();
            this.pnlListContent = new System.Windows.Forms.Panel();
            this.rainSplashLoading = new KaraokeApp.userControl.RainSplash();
            this.cbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSeach = new Guna.UI2.WinForms.Guna2TextBox();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.pnlListBorder = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlListContent.SuspendLayout();
            this.pnlListBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPNLListSong
            // 
            this.flowPNLListSong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPNLListSong.BackColor = System.Drawing.Color.Transparent;
            this.flowPNLListSong.Location = new System.Drawing.Point(32, 63);
            this.flowPNLListSong.Name = "flowPNLListSong";
            this.flowPNLListSong.Size = new System.Drawing.Size(534, 530);
            this.flowPNLListSong.TabIndex = 4;
            this.flowPNLListSong.Visible = false;
            // 
            // pnlListContent
            // 
            this.pnlListContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.pnlListContent.Controls.Add(this.rainSplashLoading);
            this.pnlListContent.Controls.Add(this.flowPNLListSong);
            this.pnlListContent.Controls.Add(this.cbType);
            this.pnlListContent.Controls.Add(this.txtSeach);
            this.pnlListContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListContent.Location = new System.Drawing.Point(5, 5);
            this.pnlListContent.Name = "pnlListContent";
            this.pnlListContent.Size = new System.Drawing.Size(598, 612);
            this.pnlListContent.TabIndex = 0;
            // 
            // rainSplashLoading
            // 
            this.rainSplashLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rainSplashLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.rainSplashLoading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rainSplashLoading.Location = new System.Drawing.Point(3, 58);
            this.rainSplashLoading.Name = "rainSplashLoading";
            this.rainSplashLoading.Size = new System.Drawing.Size(588, 547);
            this.rainSplashLoading.TabIndex = 5;
            // 
            // cbType
            // 
            this.cbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbType.BackColor = System.Drawing.Color.Transparent;
            this.cbType.BorderRadius = 5;
            this.cbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbType.FocusedState.Parent = this.cbType;
            this.cbType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbType.HoverState.Parent = this.cbType;
            this.cbType.ItemHeight = 30;
            this.cbType.Items.AddRange(new object[] {
            "Both (Except Record)",
            "Song",
            "Karaoke",
            "Record"});
            this.cbType.ItemsAppearance.Parent = this.cbType;
            this.cbType.Location = new System.Drawing.Point(316, 16);
            this.cbType.Name = "cbType";
            this.cbType.ShadowDecoration.Parent = this.cbType;
            this.cbType.Size = new System.Drawing.Size(250, 36);
            this.cbType.TabIndex = 3;
            this.cbType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // txtSeach
            // 
            this.txtSeach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeach.BorderColor = System.Drawing.Color.Black;
            this.txtSeach.BorderRadius = 5;
            this.txtSeach.BorderThickness = 0;
            this.txtSeach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeach.DefaultText = "";
            this.txtSeach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSeach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSeach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeach.DisabledState.Parent = this.txtSeach;
            this.txtSeach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeach.FocusedState.Parent = this.txtSeach;
            this.txtSeach.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeach.HoverState.Parent = this.txtSeach;
            this.txtSeach.IconRight = global::KaraokeApp.Properties.Resources.search_40px;
            this.txtSeach.Location = new System.Drawing.Point(32, 16);
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.PasswordChar = '\0';
            this.txtSeach.PlaceholderText = "";
            this.txtSeach.SelectedText = "";
            this.txtSeach.ShadowDecoration.Parent = this.txtSeach;
            this.txtSeach.Size = new System.Drawing.Size(278, 36);
            this.txtSeach.TabIndex = 0;
            this.txtSeach.TextChanged += new System.EventHandler(this.txtSeach_TextChanged);
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 2000;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // pnlListBorder
            // 
            this.pnlListBorder.BackColor = System.Drawing.Color.Transparent;
            this.pnlListBorder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(71)))));
            this.pnlListBorder.BorderRadius = 5;
            this.pnlListBorder.BorderThickness = 5;
            this.pnlListBorder.Controls.Add(this.pnlListContent);
            this.pnlListBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlListBorder.Name = "pnlListBorder";
            this.pnlListBorder.Padding = new System.Windows.Forms.Padding(5);
            this.pnlListBorder.ShadowDecoration.Parent = this.pnlListBorder;
            this.pnlListBorder.Size = new System.Drawing.Size(608, 622);
            this.pnlListBorder.TabIndex = 5;
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(608, 622);
            this.Controls.Add(this.pnlListBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormList";
            this.Text = "FormList";
            this.Load += new System.EventHandler(this.FormList_Load);
            this.pnlListContent.ResumeLayout(false);
            this.pnlListBorder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlListContent;
        private Guna.UI2.WinForms.Guna2TextBox txtSeach;
        private Guna.UI2.WinForms.Guna2ComboBox cbType;
        private System.Windows.Forms.Panel flowPNLListSong;
        private System.Windows.Forms.Timer timerLoading;
        private Guna.UI2.WinForms.Guna2Panel pnlListBorder;
        private userControl.RainSplash rainSplashLoading;
    }
}