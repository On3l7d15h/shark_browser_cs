namespace WindowsFormsAppSharkBrowser.Forms.Settings
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.gpnl_appbar = new Guna.UI2.WinForms.Guna2Panel();
            this.gbtn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.gdct_settings = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.gpnl_others = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_u = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.gptb_user = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_personalitation_title = new System.Windows.Forms.Label();
            this.lbl_security_title = new System.Windows.Forms.Label();
            this.gpnl_ = new Guna.UI2.WinForms.Guna2Panel();
            this.rbtn_none = new System.Windows.Forms.RadioButton();
            this.rbtn_low = new System.Windows.Forms.RadioButton();
            this.rbtn_strict = new System.Windows.Forms.RadioButton();
            this.rbtn_normal = new System.Windows.Forms.RadioButton();
            this.gpnl_person = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.gcbo_searcher = new Guna.UI2.WinForms.Guna2ComboBox();
            this.chk_startpage = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.rbtn_system = new System.Windows.Forms.RadioButton();
            this.rbtn_dark = new System.Windows.Forms.RadioButton();
            this.rbtn_white = new System.Windows.Forms.RadioButton();
            this.gpnl_confirm = new Guna.UI2.WinForms.Guna2Panel();
            this.gbtn_accept = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_apply = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_account = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.chk_credentials = new System.Windows.Forms.CheckBox();
            this.gtxt_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.gtxt_user = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.gbtn_help = new Guna.UI2.WinForms.Guna2Button();
            this.gpnl_appbar.SuspendLayout();
            this.gpnl_others.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gptb_user)).BeginInit();
            this.gpnl_.SuspendLayout();
            this.gpnl_person.SuspendLayout();
            this.guna2Panel7.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.gpnl_confirm.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpnl_appbar
            // 
            this.gpnl_appbar.BackColor = System.Drawing.Color.LightGray;
            this.gpnl_appbar.Controls.Add(this.gbtn_exit);
            this.gpnl_appbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpnl_appbar.Location = new System.Drawing.Point(0, 0);
            this.gpnl_appbar.Name = "gpnl_appbar";
            this.gpnl_appbar.ShadowDecoration.Parent = this.gpnl_appbar;
            this.gpnl_appbar.Size = new System.Drawing.Size(1258, 43);
            this.gpnl_appbar.TabIndex = 0;
            // 
            // gbtn_exit
            // 
            this.gbtn_exit.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_exit.CheckedState.Parent = this.gbtn_exit;
            this.gbtn_exit.CustomImages.Parent = this.gbtn_exit;
            this.gbtn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbtn_exit.FillColor = System.Drawing.Color.Transparent;
            this.gbtn_exit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtn_exit.ForeColor = System.Drawing.Color.Black;
            this.gbtn_exit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gbtn_exit.HoverState.ForeColor = System.Drawing.Color.White;
            this.gbtn_exit.HoverState.Parent = this.gbtn_exit;
            this.gbtn_exit.Location = new System.Drawing.Point(1196, 0);
            this.gbtn_exit.Name = "gbtn_exit";
            this.gbtn_exit.ShadowDecoration.Parent = this.gbtn_exit;
            this.gbtn_exit.Size = new System.Drawing.Size(62, 43);
            this.gbtn_exit.TabIndex = 2;
            this.gbtn_exit.Text = "X";
            this.gbtn_exit.Click += new System.EventHandler(this.gbtn_exit_Click);
            // 
            // gdct_settings
            // 
            this.gdct_settings.TargetControl = this.gpnl_appbar;
            // 
            // gpnl_others
            // 
            this.gpnl_others.BackColor = System.Drawing.Color.White;
            this.gpnl_others.Controls.Add(this.lbl_u);
            this.gpnl_others.Controls.Add(this.guna2Panel2);
            this.gpnl_others.Controls.Add(this.gbtn_help);
            this.gpnl_others.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpnl_others.Location = new System.Drawing.Point(0, 43);
            this.gpnl_others.Name = "gpnl_others";
            this.gpnl_others.ShadowDecoration.Parent = this.gpnl_others;
            this.gpnl_others.Size = new System.Drawing.Size(215, 556);
            this.gpnl_others.TabIndex = 1;
            // 
            // lbl_u
            // 
            this.lbl_u.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_u.AutoSize = true;
            this.lbl_u.BackColor = System.Drawing.Color.DodgerBlue;
            this.lbl_u.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_u.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_u.ForeColor = System.Drawing.Color.White;
            this.lbl_u.Location = new System.Drawing.Point(52, 221);
            this.lbl_u.Name = "lbl_u";
            this.lbl_u.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_u.Size = new System.Drawing.Size(89, 38);
            this.lbl_u.TabIndex = 6;
            this.lbl_u.Text = "Usuario";
            this.lbl_u.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.gptb_user);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(215, 199);
            this.guna2Panel2.TabIndex = 4;
            // 
            // gptb_user
            // 
            this.gptb_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gptb_user.BackgroundImage")));
            this.gptb_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gptb_user.FillColor = System.Drawing.Color.Transparent;
            this.gptb_user.Location = new System.Drawing.Point(26, 20);
            this.gptb_user.Name = "gptb_user";
            this.gptb_user.ShadowDecoration.Parent = this.gptb_user;
            this.gptb_user.Size = new System.Drawing.Size(161, 159);
            this.gptb_user.TabIndex = 3;
            this.gptb_user.TabStop = false;
            // 
            // lbl_personalitation_title
            // 
            this.lbl_personalitation_title.AutoSize = true;
            this.lbl_personalitation_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_personalitation_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_personalitation_title.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_personalitation_title.Location = new System.Drawing.Point(32, 37);
            this.lbl_personalitation_title.Name = "lbl_personalitation_title";
            this.lbl_personalitation_title.Size = new System.Drawing.Size(146, 28);
            this.lbl_personalitation_title.TabIndex = 16;
            this.lbl_personalitation_title.Text = "Personalización";
            // 
            // lbl_security_title
            // 
            this.lbl_security_title.AutoSize = true;
            this.lbl_security_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_security_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_security_title.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_security_title.Location = new System.Drawing.Point(32, 11);
            this.lbl_security_title.Name = "lbl_security_title";
            this.lbl_security_title.Size = new System.Drawing.Size(102, 28);
            this.lbl_security_title.TabIndex = 1;
            this.lbl_security_title.Text = "Seguridad";
            // 
            // gpnl_
            // 
            this.gpnl_.BackColor = System.Drawing.Color.Transparent;
            this.gpnl_.BorderColor = System.Drawing.Color.DarkGray;
            this.gpnl_.BorderRadius = 3;
            this.gpnl_.BorderThickness = 1;
            this.gpnl_.Controls.Add(this.rbtn_none);
            this.gpnl_.Controls.Add(this.rbtn_low);
            this.gpnl_.Controls.Add(this.rbtn_strict);
            this.gpnl_.Controls.Add(this.rbtn_normal);
            this.gpnl_.Location = new System.Drawing.Point(20, 30);
            this.gpnl_.Name = "gpnl_";
            this.gpnl_.ShadowDecoration.Parent = this.gpnl_;
            this.gpnl_.Size = new System.Drawing.Size(958, 79);
            this.gpnl_.TabIndex = 2;
            // 
            // rbtn_none
            // 
            this.rbtn_none.AutoSize = true;
            this.rbtn_none.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_none.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rbtn_none.Location = new System.Drawing.Point(679, 28);
            this.rbtn_none.Name = "rbtn_none";
            this.rbtn_none.Size = new System.Drawing.Size(97, 27);
            this.rbtn_none.TabIndex = 3;
            this.rbtn_none.Text = "Ninguna";
            this.rbtn_none.UseVisualStyleBackColor = true;
            // 
            // rbtn_low
            // 
            this.rbtn_low.AutoSize = true;
            this.rbtn_low.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_low.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rbtn_low.Location = new System.Drawing.Point(525, 28);
            this.rbtn_low.Name = "rbtn_low";
            this.rbtn_low.Size = new System.Drawing.Size(63, 27);
            this.rbtn_low.TabIndex = 2;
            this.rbtn_low.Text = "Baja";
            this.rbtn_low.UseVisualStyleBackColor = true;
            // 
            // rbtn_strict
            // 
            this.rbtn_strict.AutoSize = true;
            this.rbtn_strict.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_strict.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rbtn_strict.Location = new System.Drawing.Point(346, 28);
            this.rbtn_strict.Name = "rbtn_strict";
            this.rbtn_strict.Size = new System.Drawing.Size(86, 27);
            this.rbtn_strict.TabIndex = 1;
            this.rbtn_strict.Text = "Estrícta";
            this.rbtn_strict.UseVisualStyleBackColor = true;
            // 
            // rbtn_normal
            // 
            this.rbtn_normal.AutoSize = true;
            this.rbtn_normal.Checked = true;
            this.rbtn_normal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_normal.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rbtn_normal.Location = new System.Drawing.Point(176, 28);
            this.rbtn_normal.Name = "rbtn_normal";
            this.rbtn_normal.Size = new System.Drawing.Size(97, 27);
            this.rbtn_normal.TabIndex = 0;
            this.rbtn_normal.TabStop = true;
            this.rbtn_normal.Text = "Estándar";
            this.rbtn_normal.UseVisualStyleBackColor = true;
            // 
            // gpnl_person
            // 
            this.gpnl_person.BackColor = System.Drawing.Color.Transparent;
            this.gpnl_person.BorderColor = System.Drawing.Color.DarkGray;
            this.gpnl_person.BorderRadius = 3;
            this.gpnl_person.BorderThickness = 1;
            this.gpnl_person.Controls.Add(this.label3);
            this.gpnl_person.Controls.Add(this.guna2Panel7);
            this.gpnl_person.Controls.Add(this.label2);
            this.gpnl_person.Controls.Add(this.guna2Panel6);
            this.gpnl_person.Location = new System.Drawing.Point(20, 51);
            this.gpnl_person.Name = "gpnl_person";
            this.gpnl_person.ShadowDecoration.Parent = this.gpnl_person;
            this.gpnl_person.Size = new System.Drawing.Size(588, 284);
            this.gpnl_person.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(46, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Pestaña Inicio";
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel7.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel7.BorderRadius = 3;
            this.guna2Panel7.BorderThickness = 1;
            this.guna2Panel7.Controls.Add(this.gcbo_searcher);
            this.guna2Panel7.Controls.Add(this.chk_startpage);
            this.guna2Panel7.Location = new System.Drawing.Point(35, 158);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.ShadowDecoration.Parent = this.guna2Panel7;
            this.guna2Panel7.Size = new System.Drawing.Size(520, 89);
            this.guna2Panel7.TabIndex = 20;
            // 
            // gcbo_searcher
            // 
            this.gcbo_searcher.BackColor = System.Drawing.Color.Transparent;
            this.gcbo_searcher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcbo_searcher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcbo_searcher.Enabled = false;
            this.gcbo_searcher.FocusedColor = System.Drawing.Color.Empty;
            this.gcbo_searcher.FocusedState.Parent = this.gcbo_searcher;
            this.gcbo_searcher.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gcbo_searcher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gcbo_searcher.FormattingEnabled = true;
            this.gcbo_searcher.HoverState.Parent = this.gcbo_searcher;
            this.gcbo_searcher.ItemHeight = 30;
            this.gcbo_searcher.Items.AddRange(new object[] {
            "Seleccione 1",
            "www.google.com",
            "www.bing.com",
            "www.yandex.com",
            "swisscows.com"});
            this.gcbo_searcher.ItemsAppearance.Parent = this.gcbo_searcher;
            this.gcbo_searcher.Location = new System.Drawing.Point(238, 29);
            this.gcbo_searcher.Name = "gcbo_searcher";
            this.gcbo_searcher.ShadowDecoration.Parent = this.gcbo_searcher;
            this.gcbo_searcher.Size = new System.Drawing.Size(263, 36);
            this.gcbo_searcher.StartIndex = 0;
            this.gcbo_searcher.TabIndex = 2;
            // 
            // chk_startpage
            // 
            this.chk_startpage.AutoSize = true;
            this.chk_startpage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_startpage.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.chk_startpage.Location = new System.Drawing.Point(16, 32);
            this.chk_startpage.Name = "chk_startpage";
            this.chk_startpage.Size = new System.Drawing.Size(107, 29);
            this.chk_startpage.TabIndex = 1;
            this.chk_startpage.Text = "Buscador";
            this.chk_startpage.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tema";
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel6.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel6.BorderRadius = 3;
            this.guna2Panel6.BorderThickness = 1;
            this.guna2Panel6.Controls.Add(this.rbtn_system);
            this.guna2Panel6.Controls.Add(this.rbtn_dark);
            this.guna2Panel6.Controls.Add(this.rbtn_white);
            this.guna2Panel6.Location = new System.Drawing.Point(35, 56);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.ShadowDecoration.Parent = this.guna2Panel6;
            this.guna2Panel6.Size = new System.Drawing.Size(520, 73);
            this.guna2Panel6.TabIndex = 18;
            // 
            // rbtn_system
            // 
            this.rbtn_system.AutoSize = true;
            this.rbtn_system.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_system.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rbtn_system.Location = new System.Drawing.Point(357, 24);
            this.rbtn_system.Name = "rbtn_system";
            this.rbtn_system.Size = new System.Drawing.Size(90, 27);
            this.rbtn_system.TabIndex = 4;
            this.rbtn_system.Text = "Sistema";
            this.rbtn_system.UseVisualStyleBackColor = true;
            // 
            // rbtn_dark
            // 
            this.rbtn_dark.AutoSize = true;
            this.rbtn_dark.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_dark.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rbtn_dark.Location = new System.Drawing.Point(217, 24);
            this.rbtn_dark.Name = "rbtn_dark";
            this.rbtn_dark.Size = new System.Drawing.Size(79, 27);
            this.rbtn_dark.TabIndex = 3;
            this.rbtn_dark.Text = "Negro";
            this.rbtn_dark.UseVisualStyleBackColor = true;
            // 
            // rbtn_white
            // 
            this.rbtn_white.AutoSize = true;
            this.rbtn_white.Checked = true;
            this.rbtn_white.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_white.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.rbtn_white.Location = new System.Drawing.Point(74, 24);
            this.rbtn_white.Name = "rbtn_white";
            this.rbtn_white.Size = new System.Drawing.Size(82, 27);
            this.rbtn_white.TabIndex = 2;
            this.rbtn_white.TabStop = true;
            this.rbtn_white.Text = "Blanco";
            this.rbtn_white.UseVisualStyleBackColor = true;
            // 
            // gpnl_confirm
            // 
            this.gpnl_confirm.BackColor = System.Drawing.Color.DodgerBlue;
            this.gpnl_confirm.BorderRadius = 3;
            this.gpnl_confirm.Controls.Add(this.gbtn_accept);
            this.gpnl_confirm.Controls.Add(this.gbtn_apply);
            this.gpnl_confirm.Location = new System.Drawing.Point(868, 477);
            this.gpnl_confirm.Name = "gpnl_confirm";
            this.gpnl_confirm.ShadowDecoration.Parent = this.gpnl_confirm;
            this.gpnl_confirm.Size = new System.Drawing.Size(378, 108);
            this.gpnl_confirm.TabIndex = 4;
            // 
            // gbtn_accept
            // 
            this.gbtn_accept.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_accept.BorderColor = System.Drawing.Color.White;
            this.gbtn_accept.BorderRadius = 3;
            this.gbtn_accept.BorderThickness = 1;
            this.gbtn_accept.CheckedState.Parent = this.gbtn_accept;
            this.gbtn_accept.CustomImages.Parent = this.gbtn_accept;
            this.gbtn_accept.FillColor = System.Drawing.Color.Transparent;
            this.gbtn_accept.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtn_accept.ForeColor = System.Drawing.SystemColors.Window;
            this.gbtn_accept.HoverState.Parent = this.gbtn_accept;
            this.gbtn_accept.Location = new System.Drawing.Point(234, 31);
            this.gbtn_accept.Name = "gbtn_accept";
            this.gbtn_accept.ShadowDecoration.Parent = this.gbtn_accept;
            this.gbtn_accept.Size = new System.Drawing.Size(126, 52);
            this.gbtn_accept.TabIndex = 1;
            this.gbtn_accept.Text = "Aceptar";
            this.gbtn_accept.Click += new System.EventHandler(this.gbtn_accept_Click);
            // 
            // gbtn_apply
            // 
            this.gbtn_apply.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_apply.BorderColor = System.Drawing.Color.White;
            this.gbtn_apply.BorderRadius = 3;
            this.gbtn_apply.BorderThickness = 1;
            this.gbtn_apply.CheckedState.Parent = this.gbtn_apply;
            this.gbtn_apply.CustomImages.Parent = this.gbtn_apply;
            this.gbtn_apply.FillColor = System.Drawing.Color.Transparent;
            this.gbtn_apply.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtn_apply.ForeColor = System.Drawing.SystemColors.Window;
            this.gbtn_apply.HoverState.Parent = this.gbtn_apply;
            this.gbtn_apply.Location = new System.Drawing.Point(18, 31);
            this.gbtn_apply.Name = "gbtn_apply";
            this.gbtn_apply.ShadowDecoration.Parent = this.gbtn_apply;
            this.gbtn_apply.Size = new System.Drawing.Size(126, 52);
            this.gbtn_apply.TabIndex = 0;
            this.gbtn_apply.Text = "Aplicar";
            this.gbtn_apply.Click += new System.EventHandler(this.gbtn_apply_Click);
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.BackColor = System.Drawing.Color.Transparent;
            this.lbl_account.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_account.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_account.Location = new System.Drawing.Point(33, 20);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(73, 28);
            this.lbl_account.TabIndex = 17;
            this.lbl_account.Text = "Cuenta";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel5.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel5.BorderRadius = 3;
            this.guna2Panel5.BorderThickness = 1;
            this.guna2Panel5.Controls.Add(this.chk_credentials);
            this.guna2Panel5.Controls.Add(this.gtxt_pass);
            this.guna2Panel5.Controls.Add(this.lbl_pass);
            this.guna2Panel5.Controls.Add(this.lbl_user);
            this.guna2Panel5.Controls.Add(this.gtxt_user);
            this.guna2Panel5.Location = new System.Drawing.Point(20, 36);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(340, 190);
            this.guna2Panel5.TabIndex = 16;
            // 
            // chk_credentials
            // 
            this.chk_credentials.AutoSize = true;
            this.chk_credentials.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_credentials.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.chk_credentials.Location = new System.Drawing.Point(18, 28);
            this.chk_credentials.Name = "chk_credentials";
            this.chk_credentials.Size = new System.Drawing.Size(132, 29);
            this.chk_credentials.TabIndex = 4;
            this.chk_credentials.Text = "Credenciales";
            this.chk_credentials.UseVisualStyleBackColor = true;
            // 
            // gtxt_pass
            // 
            this.gtxt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_pass.DefaultText = "";
            this.gtxt_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_pass.DisabledState.Parent = this.gtxt_pass;
            this.gtxt_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_pass.Enabled = false;
            this.gtxt_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_pass.FocusedState.Parent = this.gtxt_pass;
            this.gtxt_pass.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtxt_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_pass.HoverState.Parent = this.gtxt_pass;
            this.gtxt_pass.Location = new System.Drawing.Point(203, 137);
            this.gtxt_pass.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gtxt_pass.Name = "gtxt_pass";
            this.gtxt_pass.PasswordChar = '*';
            this.gtxt_pass.PlaceholderText = "";
            this.gtxt_pass.SelectedText = "";
            this.gtxt_pass.ShadowDecoration.Parent = this.gtxt_pass;
            this.gtxt_pass.Size = new System.Drawing.Size(123, 37);
            this.gtxt_pass.TabIndex = 24;
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.Color.Black;
            this.lbl_pass.Location = new System.Drawing.Point(199, 108);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(97, 23);
            this.lbl_pass.TabIndex = 23;
            this.lbl_pass.Text = "Contraseña";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.Black;
            this.lbl_user.Location = new System.Drawing.Point(199, 28);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(68, 23);
            this.lbl_user.TabIndex = 22;
            this.lbl_user.Text = "Usuario";
            // 
            // gtxt_user
            // 
            this.gtxt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gtxt_user.DefaultText = "";
            this.gtxt_user.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gtxt_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gtxt_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_user.DisabledState.Parent = this.gtxt_user;
            this.gtxt_user.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gtxt_user.Enabled = false;
            this.gtxt_user.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_user.FocusedState.Parent = this.gtxt_user;
            this.gtxt_user.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gtxt_user.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gtxt_user.HoverState.Parent = this.gtxt_user;
            this.gtxt_user.Location = new System.Drawing.Point(203, 57);
            this.gtxt_user.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gtxt_user.Name = "gtxt_user";
            this.gtxt_user.PasswordChar = '\0';
            this.gtxt_user.PlaceholderText = "";
            this.gtxt_user.SelectedText = "";
            this.gtxt_user.ShadowDecoration.Parent = this.gtxt_user;
            this.gtxt_user.Size = new System.Drawing.Size(123, 36);
            this.gtxt_user.TabIndex = 4;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel1.BorderRadius = 3;
            this.guna2Panel1.Controls.Add(this.lbl_security_title);
            this.guna2Panel1.Controls.Add(this.gpnl_);
            this.guna2Panel1.Location = new System.Drawing.Point(236, 63);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1010, 128);
            this.guna2Panel1.TabIndex = 4;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel3.BorderRadius = 3;
            this.guna2Panel3.Controls.Add(this.lbl_personalitation_title);
            this.guna2Panel3.Controls.Add(this.gpnl_person);
            this.guna2Panel3.Location = new System.Drawing.Point(236, 213);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(623, 372);
            this.guna2Panel3.TabIndex = 5;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.White;
            this.guna2Panel4.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Panel4.BorderRadius = 3;
            this.guna2Panel4.Controls.Add(this.lbl_account);
            this.guna2Panel4.Controls.Add(this.guna2Panel5);
            this.guna2Panel4.Location = new System.Drawing.Point(868, 213);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(378, 249);
            this.guna2Panel4.TabIndex = 17;
            // 
            // gbtn_help
            // 
            this.gbtn_help.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbtn_help.BackColor = System.Drawing.Color.Transparent;
            this.gbtn_help.BorderColor = System.Drawing.Color.DodgerBlue;
            this.gbtn_help.BorderRadius = 3;
            this.gbtn_help.BorderThickness = 1;
            this.gbtn_help.CheckedState.Parent = this.gbtn_help;
            this.gbtn_help.CustomImages.Parent = this.gbtn_help;
            this.gbtn_help.FillColor = System.Drawing.Color.Transparent;
            this.gbtn_help.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtn_help.ForeColor = System.Drawing.Color.DodgerBlue;
            this.gbtn_help.HoverState.Parent = this.gbtn_help;
            this.gbtn_help.Location = new System.Drawing.Point(26, 490);
            this.gbtn_help.Name = "gbtn_help";
            this.gbtn_help.ShadowDecoration.Parent = this.gbtn_help;
            this.gbtn_help.Size = new System.Drawing.Size(163, 52);
            this.gbtn_help.TabIndex = 2;
            this.gbtn_help.Text = "Ayuda";
            this.gbtn_help.Click += new System.EventHandler(this.gbtn_help_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1258, 599);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.gpnl_confirm);
            this.Controls.Add(this.gpnl_others);
            this.Controls.Add(this.gpnl_appbar);
            this.Controls.Add(this.guna2Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSettings";
            this.gpnl_appbar.ResumeLayout(false);
            this.gpnl_others.ResumeLayout(false);
            this.gpnl_others.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gptb_user)).EndInit();
            this.gpnl_.ResumeLayout(false);
            this.gpnl_.PerformLayout();
            this.gpnl_person.ResumeLayout(false);
            this.gpnl_person.PerformLayout();
            this.guna2Panel7.ResumeLayout(false);
            this.guna2Panel7.PerformLayout();
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.gpnl_confirm.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel gpnl_appbar;
        private Guna.UI2.WinForms.Guna2Button gbtn_exit;
        private Guna.UI2.WinForms.Guna2DragControl gdct_settings;
        private Guna.UI2.WinForms.Guna2Panel gpnl_others;
        private System.Windows.Forms.Label lbl_personalitation_title;
        private System.Windows.Forms.Label lbl_security_title;
        private Guna.UI2.WinForms.Guna2Panel gpnl_;
        private Guna.UI2.WinForms.Guna2Panel gpnl_person;
        private Guna.UI2.WinForms.Guna2Panel gpnl_confirm;
        private System.Windows.Forms.RadioButton rbtn_none;
        private System.Windows.Forms.RadioButton rbtn_low;
        private System.Windows.Forms.RadioButton rbtn_strict;
        private System.Windows.Forms.RadioButton rbtn_normal;
        private System.Windows.Forms.Label lbl_account;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.CheckBox chk_startpage;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private System.Windows.Forms.RadioButton rbtn_system;
        private System.Windows.Forms.RadioButton rbtn_dark;
        private System.Windows.Forms.RadioButton rbtn_white;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_pass;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_user;
        private Guna.UI2.WinForms.Guna2TextBox gtxt_user;
        private Guna.UI2.WinForms.Guna2Button gbtn_apply;
        private Guna.UI2.WinForms.Guna2Button gbtn_accept;
        private Guna.UI2.WinForms.Guna2PictureBox gptb_user;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.CheckBox chk_credentials;
        private System.Windows.Forms.Label lbl_u;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2ComboBox gcbo_searcher;
        private Guna.UI2.WinForms.Guna2Button gbtn_help;
    }
}