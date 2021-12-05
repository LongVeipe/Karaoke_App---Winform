
namespace KaraokeApp
{
    partial class FormSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlShazamResult = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRecord = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tbxSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.pnlShazamResult);
            this.guna2Panel1.Controls.Add(this.btnRecord);
            this.guna2Panel1.Controls.Add(this.tbxSearch);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.ForeColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(16, 0, 16, 16);
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(811, 766);
            this.guna2Panel1.TabIndex = 0;
            // 
            // pnlShazamResult
            // 
            this.pnlShazamResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlShazamResult.BackColor = System.Drawing.Color.Transparent;
            this.pnlShazamResult.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlShazamResult.Location = new System.Drawing.Point(43, 62);
            this.pnlShazamResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlShazamResult.Name = "pnlShazamResult";
            this.pnlShazamResult.Size = new System.Drawing.Size(725, 665);
            this.pnlShazamResult.TabIndex = 2;
            this.pnlShazamResult.WrapContents = false;
            // 
            // btnRecord
            // 
            this.btnRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecord.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(64)))), ((int)(((byte)(52)))));
            this.btnRecord.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(64)))), ((int)(((byte)(52)))));
            this.btnRecord.CheckedState.Parent = this.btnRecord;
            this.btnRecord.CustomImages.Parent = this.btnRecord;
            this.btnRecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRecord.DisabledState.Parent = this.btnRecord;
            this.btnRecord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnRecord.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRecord.ForeColor = System.Drawing.Color.White;
            this.btnRecord.HoverState.Parent = this.btnRecord;
            this.btnRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnRecord.Image")));
            this.btnRecord.ImageSize = new System.Drawing.Size(16, 16);
            this.btnRecord.Location = new System.Drawing.Point(731, 2);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(4, 4, 43, 4);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRecord.ShadowDecoration.Parent = this.btnRecord;
            this.btnRecord.Size = new System.Drawing.Size(37, 34);
            this.btnRecord.TabIndex = 1;
            this.btnRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearch.BorderColor = System.Drawing.Color.Black;
            this.tbxSearch.BorderRadius = 5;
            this.tbxSearch.BorderThickness = 2;
            this.tbxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSearch.DefaultText = "";
            this.tbxSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSearch.DisabledState.Parent = this.tbxSearch;
            this.tbxSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxSearch.FocusedState.Parent = this.tbxSearch;
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.ForeColor = System.Drawing.Color.Black;
            this.tbxSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxSearch.HoverState.Parent = this.tbxSearch;
            this.tbxSearch.IconLeftSize = new System.Drawing.Size(28, 28);
            this.tbxSearch.IconRight = ((System.Drawing.Image)(resources.GetObject("tbxSearch.IconRight")));
            this.tbxSearch.IconRightOffset = new System.Drawing.Point(10, 0);
            this.tbxSearch.Location = new System.Drawing.Point(43, 0);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.PasswordChar = '\0';
            this.tbxSearch.PlaceholderText = "";
            this.tbxSearch.SelectedText = "";
            this.tbxSearch.ShadowDecoration.Parent = this.tbxSearch;
            this.tbxSearch.Size = new System.Drawing.Size(672, 39);
            this.tbxSearch.TabIndex = 0;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(811, 766);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox tbxSearch;
        private Guna.UI2.WinForms.Guna2CircleButton btnRecord;
        private System.Windows.Forms.FlowLayoutPanel pnlShazamResult;
    }
}