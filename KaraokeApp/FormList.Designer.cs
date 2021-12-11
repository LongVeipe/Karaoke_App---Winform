
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.flowPNLListSong = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSeach = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbType);
            this.panel1.Controls.Add(this.flowPNLListSong);
            this.panel1.Controls.Add(this.txtSeach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 622);
            this.panel1.TabIndex = 0;
            // 
            // cbType
            // 
            this.cbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Both (Except Record)",
            "Song",
            "Karaoke",
            "Record"});
            this.cbType.Location = new System.Drawing.Point(455, 7);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 2;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // flowPNLListSong
            // 
            this.flowPNLListSong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowPNLListSong.AutoScroll = true;
            this.flowPNLListSong.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowPNLListSong.Location = new System.Drawing.Point(32, 50);
            this.flowPNLListSong.Name = "flowPNLListSong";
            this.flowPNLListSong.Size = new System.Drawing.Size(544, 540);
            this.flowPNLListSong.TabIndex = 1;
            this.flowPNLListSong.WrapContents = false;
            // 
            // txtSeach
            // 
            this.txtSeach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSeach.BorderColor = System.Drawing.Color.Black;
            this.txtSeach.BorderRadius = 5;
            this.txtSeach.BorderThickness = 2;
            this.txtSeach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeach.DefaultText = "";
            this.txtSeach.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSeach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSeach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeach.DisabledState.Parent = this.txtSeach;
            this.txtSeach.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeach.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeach.FocusedState.Parent = this.txtSeach;
            this.txtSeach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSeach.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeach.HoverState.Parent = this.txtSeach;
            this.txtSeach.IconRight = global::KaraokeApp.Properties.Resources.search_40px;
            this.txtSeach.Location = new System.Drawing.Point(32, 0);
            this.txtSeach.Name = "txtSeach";
            this.txtSeach.PasswordChar = '\0';
            this.txtSeach.PlaceholderText = "";
            this.txtSeach.SelectedText = "";
            this.txtSeach.ShadowDecoration.Parent = this.txtSeach;
            this.txtSeach.Size = new System.Drawing.Size(400, 32);
            this.txtSeach.TabIndex = 0;
            this.txtSeach.TextChanged += new System.EventHandler(this.txtSeach_TextChanged);
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(608, 622);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormList";
            this.Text = "FormList";
            this.Load += new System.EventHandler(this.FormList_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSeach;
        private System.Windows.Forms.FlowLayoutPanel flowPNLListSong;
        private System.Windows.Forms.ComboBox cbType;
    }
}