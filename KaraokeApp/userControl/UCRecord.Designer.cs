
namespace KaraokeApp.userControl
{
    partial class UCRecord
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
            this.lblRecordName = new System.Windows.Forms.Label();
            this.btnPlayStream = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPlayStream);
            this.panel1.Controls.Add(this.lblRecordName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 64);
            this.panel1.TabIndex = 0;
            // 
            // lblRecordName
            // 
            this.lblRecordName.AutoSize = true;
            this.lblRecordName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordName.ForeColor = System.Drawing.Color.White;
            this.lblRecordName.Location = new System.Drawing.Point(3, 17);
            this.lblRecordName.MaximumSize = new System.Drawing.Size(450, 35);
            this.lblRecordName.Name = "lblRecordName";
            this.lblRecordName.Size = new System.Drawing.Size(64, 25);
            this.lblRecordName.TabIndex = 2;
            this.lblRecordName.Text = "Name";
            // 
            // btnPlayStream
            // 
            this.btnPlayStream.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPlayStream.CheckedState.Parent = this.btnPlayStream;
            this.btnPlayStream.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnPlayStream.HoverState.Parent = this.btnPlayStream;
            this.btnPlayStream.Image = global::KaraokeApp.Properties.Resources.icons8_circled_play_48;
            this.btnPlayStream.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPlayStream.ImageRotate = 0F;
            this.btnPlayStream.ImageSize = new System.Drawing.Size(35, 35);
            this.btnPlayStream.Location = new System.Drawing.Point(467, 17);
            this.btnPlayStream.Name = "btnPlayStream";
            this.btnPlayStream.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPlayStream.PressedState.Parent = this.btnPlayStream;
            this.btnPlayStream.ShadowDecoration.Parent = this.btnPlayStream;
            this.btnPlayStream.Size = new System.Drawing.Size(30, 30);
            this.btnPlayStream.TabIndex = 5;
            this.btnPlayStream.Click += new System.EventHandler(this.btnPlayStream_Click);
            // 
            // UCRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCRecord";
            this.Size = new System.Drawing.Size(500, 64);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRecordName;
        private Guna.UI2.WinForms.Guna2ImageButton btnPlayStream;
    }
}
