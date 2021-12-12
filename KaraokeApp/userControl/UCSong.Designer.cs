
namespace KaraokeApp.userControl
{
    partial class UCSong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlayKaraoke = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnPlayStream = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblSongName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnPlayKaraoke);
            this.panel1.Controls.Add(this.btnPlayStream);
            this.panel1.Controls.Add(this.lblSongName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 64);
            this.panel1.TabIndex = 0;
            // 
            // btnPlayKaraoke
            // 
            this.btnPlayKaraoke.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPlayKaraoke.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPlayKaraoke.CheckedState.Parent = this.btnPlayKaraoke;
            this.btnPlayKaraoke.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnPlayKaraoke.HoverState.Parent = this.btnPlayKaraoke;
            this.btnPlayKaraoke.Image = global::KaraokeApp.Properties.Resources.microw_48px;
            this.btnPlayKaraoke.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPlayKaraoke.ImageRotate = 0F;
            this.btnPlayKaraoke.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPlayKaraoke.Location = new System.Drawing.Point(646, 16);
            this.btnPlayKaraoke.Name = "btnPlayKaraoke";
            this.btnPlayKaraoke.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPlayKaraoke.PressedState.Parent = this.btnPlayKaraoke;
            this.btnPlayKaraoke.ShadowDecoration.Parent = this.btnPlayKaraoke;
            this.btnPlayKaraoke.Size = new System.Drawing.Size(30, 30);
            this.btnPlayKaraoke.TabIndex = 5;
            this.btnPlayKaraoke.Click += new System.EventHandler(this.btnPlayKaraoke_Click);
            // 
            // btnPlayStream
            // 
            this.btnPlayStream.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPlayStream.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPlayStream.CheckedState.Parent = this.btnPlayStream;
            this.btnPlayStream.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnPlayStream.HoverState.Parent = this.btnPlayStream;
            this.btnPlayStream.Image = global::KaraokeApp.Properties.Resources.add_30px1;
            this.btnPlayStream.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPlayStream.ImageRotate = 0F;
            this.btnPlayStream.ImageSize = new System.Drawing.Size(35, 35);
            this.btnPlayStream.Location = new System.Drawing.Point(697, 15);
            this.btnPlayStream.Name = "btnPlayStream";
            this.btnPlayStream.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPlayStream.PressedState.Parent = this.btnPlayStream;
            this.btnPlayStream.ShadowDecoration.Parent = this.btnPlayStream;
            this.btnPlayStream.Size = new System.Drawing.Size(30, 30);
            this.btnPlayStream.TabIndex = 4;
            this.btnPlayStream.Click += new System.EventHandler(this.btnPlayStream_Click);
            // 
            // lblSongName
            // 
            this.lblSongName.AutoSize = true;
            this.lblSongName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongName.ForeColor = System.Drawing.Color.White;
            this.lblSongName.Location = new System.Drawing.Point(3, 17);
            this.lblSongName.MaximumSize = new System.Drawing.Size(450, 35);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(64, 25);
            this.lblSongName.TabIndex = 1;
            this.lblSongName.Text = "Name";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(8, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(736, 1);
            this.panel2.TabIndex = 6;
            // 
            // UCSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.Name = "UCSong";
            this.Size = new System.Drawing.Size(748, 64);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSongName;
        private Guna.UI2.WinForms.Guna2ImageButton btnPlayStream;
        private Guna.UI2.WinForms.Guna2ImageButton btnPlayKaraoke;
        private System.Windows.Forms.Panel panel2;
    }
}
