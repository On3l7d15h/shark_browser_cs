namespace WindowsFormsAppSharkBrowser
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.gpnl_topbar = new Guna.UI2.WinForms.Guna2Panel();
            this.gpir_main = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.gbtn_settings = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_downloads = new Guna.UI2.WinForms.Guna2Button();
            this.gtxt_searcher = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbtn_update = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_home = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_forward = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_back = new Guna.UI2.WinForms.Guna2Button();
            this.gpnl_main = new Guna.UI2.WinForms.Guna2Panel();
            this.gpnl_topbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpnl_topbar
            // 
            this.gpnl_topbar.BackColor = System.Drawing.Color.White;
            this.gpnl_topbar.Controls.Add(this.gpir_main);
            this.gpnl_topbar.Controls.Add(this.gbtn_settings);
            this.gpnl_topbar.Controls.Add(this.gbtn_downloads);
            this.gpnl_topbar.Controls.Add(this.gtxt_searcher);
            this.gpnl_topbar.Controls.Add(this.gbtn_update);
            this.gpnl_topbar.Controls.Add(this.gbtn_home);
            this.gpnl_topbar.Controls.Add(this.gbtn_forward);
            this.gpnl_topbar.Controls.Add(this.gbtn_back);
            this.gpnl_topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpnl_topbar.Location = new System.Drawing.Point(0, 0);
            this.gpnl_topbar.Name = "gpnl_topbar";
            this.gpnl_topbar.ShadowDecoration.Parent = this.gpnl_topbar;
            this.gpnl_topbar.Size = new System.Drawing.Size(1109, 65);
            this.gpnl_topbar.TabIndex = 0;
            // 
            // gpir_main
            // 
            this.gpir_main.AutoStart = true;
            this.gpir_main.CircleSize = 1F;
            this.gpir_main.Location = new System.Drawing.Point(162, 12);
            this.gpir_main.Name = "gpir_main";
            this.gpir_main.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.gpir_main.Size = new System.Drawing.Size(46, 46);
            this.gpir_main.TabIndex = 0;
            this.gpir_main.Visible = false;
            // 
            // gbtn_settings
            // 
            this.gbtn_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbtn_settings.BorderRadius = 3;
            this.gbtn_settings.CheckedState.Parent = this.gbtn_settings;
            this.gbtn_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtn_settings.CustomImages.Parent = this.gbtn_settings;
            this.gbtn_settings.FillColor = System.Drawing.Color.Transparent;
            this.gbtn_settings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtn_settings.ForeColor = System.Drawing.Color.White;
            this.gbtn_settings.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.gbtn_settings.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbtn_settings.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.gbtn_settings.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.gbtn_settings.HoverState.Parent = this.gbtn_settings;
            this.gbtn_settings.Image = ((System.Drawing.Image)(resources.GetObject("gbtn_settings.Image")));
            this.gbtn_settings.ImageOffset = new System.Drawing.Point(1, 0);
            this.gbtn_settings.ImageSize = new System.Drawing.Size(31, 31);
            this.gbtn_settings.Location = new System.Drawing.Point(1060, 12);
            this.gbtn_settings.Name = "gbtn_settings";
            this.gbtn_settings.PressedColor = System.Drawing.Color.Transparent;
            this.gbtn_settings.ShadowDecoration.Parent = this.gbtn_settings;
            this.gbtn_settings.Size = new System.Drawing.Size(46, 43);
            this.gbtn_settings.TabIndex = 6;
            this.gbtn_settings.Click += new System.EventHandler(this.gbtn_settings_Click);
            // 
            // gbtn_downloads
            // 
            this.gbtn_downloads.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbtn_downloads.BorderRadius = 3;
            this.gbtn_downloads.CheckedState.Parent = this.gbtn_downloads;
            this.gbtn_downloads.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtn_downloads.CustomImages.Parent = this.gbtn_downloads;
            this.gbtn_downloads.FillColor = System.Drawing.Color.Transparent;
            this.gbtn_downloads.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtn_downloads.ForeColor = System.Drawing.Color.White;
            this.gbtn_downloads.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.gbtn_downloads.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbtn_downloads.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.gbtn_downloads.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.gbtn_downloads.HoverState.Parent = this.gbtn_downloads;
            this.gbtn_downloads.Image = ((System.Drawing.Image)(resources.GetObject("gbtn_downloads.Image")));
            this.gbtn_downloads.ImageOffset = new System.Drawing.Point(1, 0);
            this.gbtn_downloads.ImageSize = new System.Drawing.Size(27, 27);
            this.gbtn_downloads.Location = new System.Drawing.Point(1008, 12);
            this.gbtn_downloads.Name = "gbtn_downloads";
            this.gbtn_downloads.PressedColor = System.Drawing.Color.Transparent;
            this.gbtn_downloads.ShadowDecoration.Parent = this.gbtn_downloads;
            this.gbtn_downloads.Size = new System.Drawing.Size(46, 43);
            this.gbtn_downloads.TabIndex = 5;
            // 
            // gtxt_searcher
            // 
            this.gtxt_searcher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gtxt_searcher.BackColor = System.Drawing.Color.Transparent;
            this.gtxt_searcher.BorderRadius = 3;
            this.gtxt_searcher.BorderThickness = 0;
            this.gtxt_searcher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_searcher.DefaultText = "";
            this.gtxt_searcher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_searcher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_searcher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_searcher.DisabledState.Parent = this.gtxt_searcher;
            this.gtxt_searcher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_searcher.FillColor = System.Drawing.Color.DodgerBlue;
            this.gtxt_searcher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_searcher.FocusedState.Parent = this.gtxt_searcher;
            this.gtxt_searcher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtxt_searcher.ForeColor = System.Drawing.Color.White;
            this.gtxt_searcher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_searcher.HoverState.Parent = this.gtxt_searcher;
            this.gtxt_searcher.Location = new System.Drawing.Point(253, 12);
            this.gtxt_searcher.Margin = new System.Windows.Forms.Padding(4);
            this.gtxt_searcher.Name = "gtxt_searcher";
            this.gtxt_searcher.PasswordChar = '\0';
            this.gtxt_searcher.PlaceholderText = "";
            this.gtxt_searcher.SelectedText = "";
            this.gtxt_searcher.ShadowDecoration.Parent = this.gtxt_searcher;
            this.gtxt_searcher.Size = new System.Drawing.Size(699, 43);
            this.gtxt_searcher.TabIndex = 4;
            this.gtxt_searcher.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gtxt_searcher_KeyUp);
            // 
            // gbtn_update
            // 
            this.gbtn_update.BorderRadius = 3;
            this.gbtn_update.CheckedState.Parent = this.gbtn_update;
            this.gbtn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtn_update.CustomImages.Parent = this.gbtn_update;
            this.gbtn_update.FillColor = System.Drawing.Color.Transparent;
            this.gbtn_update.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtn_update.ForeColor = System.Drawing.Color.White;
            this.gbtn_update.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.gbtn_update.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbtn_update.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.gbtn_update.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.gbtn_update.HoverState.Parent = this.gbtn_update;
            this.gbtn_update.Image = ((System.Drawing.Image)(resources.GetObject("gbtn_update.Image")));
            this.gbtn_update.ImageOffset = new System.Drawing.Point(1, 0);
            this.gbtn_update.ImageSize = new System.Drawing.Size(25, 25);
            this.gbtn_update.Location = new System.Drawing.Point(162, 12);
            this.gbtn_update.Name = "gbtn_update";
            this.gbtn_update.PressedColor = System.Drawing.Color.Transparent;
            this.gbtn_update.ShadowDecoration.Parent = this.gbtn_update;
            this.gbtn_update.Size = new System.Drawing.Size(46, 43);
            this.gbtn_update.TabIndex = 3;
            this.gbtn_update.Click += new System.EventHandler(this.gbtn_update_Click_1);
            // 
            // gbtn_home
            // 
            this.gbtn_home.BorderRadius = 3;
            this.gbtn_home.CheckedState.Parent = this.gbtn_home;
            this.gbtn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtn_home.CustomImages.Parent = this.gbtn_home;
            this.gbtn_home.FillColor = System.Drawing.Color.Transparent;
            this.gbtn_home.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtn_home.ForeColor = System.Drawing.Color.White;
            this.gbtn_home.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.gbtn_home.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbtn_home.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.gbtn_home.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.gbtn_home.HoverState.Parent = this.gbtn_home;
            this.gbtn_home.Image = ((System.Drawing.Image)(resources.GetObject("gbtn_home.Image")));
            this.gbtn_home.ImageOffset = new System.Drawing.Point(1, 0);
            this.gbtn_home.ImageSize = new System.Drawing.Size(27, 27);
            this.gbtn_home.Location = new System.Drawing.Point(110, 12);
            this.gbtn_home.Name = "gbtn_home";
            this.gbtn_home.PressedColor = System.Drawing.Color.Transparent;
            this.gbtn_home.ShadowDecoration.Parent = this.gbtn_home;
            this.gbtn_home.Size = new System.Drawing.Size(46, 43);
            this.gbtn_home.TabIndex = 2;
            this.gbtn_home.Click += new System.EventHandler(this.gbtn_home_Click);
            // 
            // gbtn_forward
            // 
            this.gbtn_forward.BorderRadius = 3;
            this.gbtn_forward.CheckedState.Parent = this.gbtn_forward;
            this.gbtn_forward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtn_forward.CustomImages.Parent = this.gbtn_forward;
            this.gbtn_forward.FillColor = System.Drawing.Color.Transparent;
            this.gbtn_forward.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtn_forward.ForeColor = System.Drawing.Color.White;
            this.gbtn_forward.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.gbtn_forward.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbtn_forward.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.gbtn_forward.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.gbtn_forward.HoverState.Parent = this.gbtn_forward;
            this.gbtn_forward.Image = ((System.Drawing.Image)(resources.GetObject("gbtn_forward.Image")));
            this.gbtn_forward.ImageOffset = new System.Drawing.Point(1, 0);
            this.gbtn_forward.Location = new System.Drawing.Point(58, 12);
            this.gbtn_forward.Name = "gbtn_forward";
            this.gbtn_forward.PressedColor = System.Drawing.Color.Transparent;
            this.gbtn_forward.ShadowDecoration.Parent = this.gbtn_forward;
            this.gbtn_forward.Size = new System.Drawing.Size(46, 43);
            this.gbtn_forward.TabIndex = 1;
            this.gbtn_forward.Click += new System.EventHandler(this.gbtn_forward_Click);
            // 
            // gbtn_back
            // 
            this.gbtn_back.BorderRadius = 3;
            this.gbtn_back.CheckedState.Parent = this.gbtn_back;
            this.gbtn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gbtn_back.CustomImages.Parent = this.gbtn_back;
            this.gbtn_back.FillColor = System.Drawing.Color.Transparent;
            this.gbtn_back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbtn_back.ForeColor = System.Drawing.Color.White;
            this.gbtn_back.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.gbtn_back.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbtn_back.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.gbtn_back.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.gbtn_back.HoverState.Parent = this.gbtn_back;
            this.gbtn_back.Image = ((System.Drawing.Image)(resources.GetObject("gbtn_back.Image")));
            this.gbtn_back.ImageOffset = new System.Drawing.Point(1, 0);
            this.gbtn_back.Location = new System.Drawing.Point(6, 12);
            this.gbtn_back.Name = "gbtn_back";
            this.gbtn_back.PressedColor = System.Drawing.Color.Transparent;
            this.gbtn_back.ShadowDecoration.Parent = this.gbtn_back;
            this.gbtn_back.Size = new System.Drawing.Size(46, 43);
            this.gbtn_back.TabIndex = 0;
            this.gbtn_back.Click += new System.EventHandler(this.gbtn_back_Click);
            // 
            // gpnl_main
            // 
            this.gpnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpnl_main.Location = new System.Drawing.Point(0, 65);
            this.gpnl_main.Name = "gpnl_main";
            this.gpnl_main.ShadowDecoration.Parent = this.gpnl_main;
            this.gpnl_main.Size = new System.Drawing.Size(1109, 506);
            this.gpnl_main.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1109, 571);
            this.Controls.Add(this.gpnl_main);
            this.Controls.Add(this.gpnl_topbar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Shark Browser";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gpnl_topbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel gpnl_topbar;
        private Guna.UI2.WinForms.Guna2Button gbtn_back;
        private Guna.UI2.WinForms.Guna2Button gbtn_settings;
        private Guna.UI2.WinForms.Guna2Button gbtn_downloads;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_searcher;
        private Guna.UI2.WinForms.Guna2Button gbtn_update;
        private Guna.UI2.WinForms.Guna2Button gbtn_home;
        private Guna.UI2.WinForms.Guna2Button gbtn_forward;
        private Guna.UI2.WinForms.Guna2Panel gpnl_main;
        private Guna.UI2.WinForms.Guna2ProgressIndicator gpir_main;
    }
}

