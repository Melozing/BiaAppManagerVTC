namespace BiaManager.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelTaskbarLogin = new System.Windows.Forms.Label();
            this.PanelTaskbarLogin = new System.Windows.Forms.Panel();
            this.btnmini = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btchangeimg = new System.Windows.Forms.Button();
            this.btnclose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pannel_login = new System.Windows.Forms.Panel();
            this.AvatarGif = new System.Windows.Forms.PictureBox();
            this.btnsingup = new Guna.UI2.WinForms.Guna2Button();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.btnshowpass = new Guna.UI2.WinForms.Guna2Button();
            this.tb_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.tb_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.logi_pic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_running = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelTaskbarLogin.SuspendLayout();
            this.pannel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logi_pic)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelTaskbarLogin
            // 
            this.labelTaskbarLogin.AutoSize = true;
            this.labelTaskbarLogin.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.labelTaskbarLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTaskbarLogin.Location = new System.Drawing.Point(87, 208);
            this.labelTaskbarLogin.Name = "labelTaskbarLogin";
            this.labelTaskbarLogin.Size = new System.Drawing.Size(169, 25);
            this.labelTaskbarLogin.TabIndex = 1;
            this.labelTaskbarLogin.Text = "Quản lí quán bida";
            // 
            // PanelTaskbarLogin
            // 
            this.PanelTaskbarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.PanelTaskbarLogin.Controls.Add(this.btnmini);
            this.PanelTaskbarLogin.Controls.Add(this.btchangeimg);
            this.PanelTaskbarLogin.Controls.Add(this.btnclose);
            this.PanelTaskbarLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTaskbarLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanelTaskbarLogin.ImeMode = System.Windows.Forms.ImeMode.On;
            this.PanelTaskbarLogin.Location = new System.Drawing.Point(0, 0);
            this.PanelTaskbarLogin.Name = "PanelTaskbarLogin";
            this.PanelTaskbarLogin.Size = new System.Drawing.Size(958, 43);
            this.PanelTaskbarLogin.TabIndex = 0;
            this.PanelTaskbarLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTaskbarLogin_MouseDown);
            // 
            // btnmini
            // 
            this.btnmini.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btnmini.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnmini.FillColor = System.Drawing.Color.Transparent;
            this.btnmini.HoverState.Parent = this.btnmini;
            this.btnmini.IconColor = System.Drawing.Color.White;
            this.btnmini.Location = new System.Drawing.Point(868, 0);
            this.btnmini.Name = "btnmini";
            this.btnmini.ShadowDecoration.Parent = this.btnmini;
            this.btnmini.Size = new System.Drawing.Size(45, 43);
            this.btnmini.TabIndex = 13;
            this.btnmini.Click += new System.EventHandler(this.MinimizeIconButton_Click);
            // 
            // btchangeimg
            // 
            this.btchangeimg.BackColor = System.Drawing.Color.Transparent;
            this.btchangeimg.BackgroundImage = global::BiaManager.Properties.Resources.setting;
            this.btchangeimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btchangeimg.Dock = System.Windows.Forms.DockStyle.Left;
            this.btchangeimg.FlatAppearance.BorderSize = 0;
            this.btchangeimg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btchangeimg.ForeColor = System.Drawing.Color.Transparent;
            this.btchangeimg.Location = new System.Drawing.Point(0, 0);
            this.btchangeimg.Name = "btchangeimg";
            this.btchangeimg.Size = new System.Drawing.Size(46, 43);
            this.btchangeimg.TabIndex = 10;
            this.btchangeimg.UseVisualStyleBackColor = false;
            this.btchangeimg.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnclose
            // 
            this.btnclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnclose.FillColor = System.Drawing.Color.Transparent;
            this.btnclose.HoverState.Parent = this.btnclose;
            this.btnclose.IconColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(913, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.ShadowDecoration.Parent = this.btnclose;
            this.btnclose.Size = new System.Drawing.Size(45, 43);
            this.btnclose.TabIndex = 11;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pannel_login
            // 
            this.pannel_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.pannel_login.Controls.Add(this.AvatarGif);
            this.pannel_login.Controls.Add(this.btnsingup);
            this.pannel_login.Controls.Add(this.btnlogin);
            this.pannel_login.Controls.Add(this.guna2ToggleSwitch1);
            this.pannel_login.Controls.Add(this.label1);
            this.pannel_login.Controls.Add(this.labelTaskbarLogin);
            this.pannel_login.Controls.Add(this.btnshowpass);
            this.pannel_login.Controls.Add(this.tb_pass);
            this.pannel_login.Controls.Add(this.tb_username);
            this.pannel_login.Controls.Add(this.logi_pic);
            this.pannel_login.Dock = System.Windows.Forms.DockStyle.Left;
            this.pannel_login.Location = new System.Drawing.Point(0, 0);
            this.pannel_login.Margin = new System.Windows.Forms.Padding(2);
            this.pannel_login.Name = "pannel_login";
            this.pannel_login.Size = new System.Drawing.Size(367, 789);
            this.pannel_login.TabIndex = 11;
            // 
            // AvatarGif
            // 
            this.AvatarGif.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AvatarGif.ErrorImage = ((System.Drawing.Image)(resources.GetObject("AvatarGif.ErrorImage")));
            this.AvatarGif.Image = global::BiaManager.Properties.Resources.gifmaker_me;
            this.AvatarGif.InitialImage = ((System.Drawing.Image)(resources.GetObject("AvatarGif.InitialImage")));
            this.AvatarGif.Location = new System.Drawing.Point(0, 594);
            this.AvatarGif.Name = "AvatarGif";
            this.AvatarGif.Size = new System.Drawing.Size(367, 195);
            this.AvatarGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AvatarGif.TabIndex = 14;
            this.AvatarGif.TabStop = false;
            this.AvatarGif.Click += new System.EventHandler(this.AvatarGif_Click);
            // 
            // btnsingup
            // 
            this.btnsingup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btnsingup.BorderRadius = 9;
            this.btnsingup.BorderThickness = 2;
            this.btnsingup.CheckedState.Parent = this.btnsingup;
            this.btnsingup.CustomImages.Parent = this.btnsingup;
            this.btnsingup.FillColor = System.Drawing.Color.Transparent;
            this.btnsingup.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsingup.ForeColor = System.Drawing.Color.White;
            this.btnsingup.HoverState.Parent = this.btnsingup;
            this.btnsingup.Location = new System.Drawing.Point(160, 465);
            this.btnsingup.Name = "btnsingup";
            this.btnsingup.ShadowDecoration.Parent = this.btnsingup;
            this.btnsingup.Size = new System.Drawing.Size(97, 45);
            this.btnsingup.TabIndex = 8;
            this.btnsingup.Text = "Sign up";
            this.btnsingup.Click += new System.EventHandler(this.btnsingup_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BorderRadius = 9;
            this.btnlogin.CheckedState.Parent = this.btnlogin;
            this.btnlogin.CustomImages.Parent = this.btnlogin;
            this.btnlogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.HoverState.Parent = this.btnlogin;
            this.btnlogin.Location = new System.Drawing.Point(43, 464);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.ShadowDecoration.Parent = this.btnlogin;
            this.btnlogin.Size = new System.Drawing.Size(96, 45);
            this.btnlogin.TabIndex = 7;
            this.btnlogin.Text = "Login";
            this.btnlogin.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.CheckedState.BorderThickness = 2;
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.CheckedState.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(43, 414);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.ShadowDecoration.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(35, 20);
            this.guna2ToggleSwitch1.TabIndex = 6;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.Parent = this.guna2ToggleSwitch1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(85, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Remember";
            // 
            // btnshowpass
            // 
            this.btnshowpass.BorderColor = System.Drawing.Color.Transparent;
            this.btnshowpass.BorderRadius = 7;
            this.btnshowpass.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnshowpass.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnshowpass.CheckedState.Parent = this.btnshowpass;
            this.btnshowpass.CustomImages.Parent = this.btnshowpass;
            this.btnshowpass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.btnshowpass.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowpass.ForeColor = System.Drawing.Color.White;
            this.btnshowpass.HoverState.Parent = this.btnshowpass;
            this.btnshowpass.Location = new System.Drawing.Point(235, 360);
            this.btnshowpass.Name = "btnshowpass";
            this.btnshowpass.ShadowDecoration.Parent = this.btnshowpass;
            this.btnshowpass.Size = new System.Drawing.Size(71, 24);
            this.btnshowpass.TabIndex = 3;
            this.btnshowpass.Text = "show";
            this.btnshowpass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HidePassword_MouseDown);
            this.btnshowpass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HidePassword_MouseUp);
            // 
            // tb_pass
            // 
            this.tb_pass.Animated = true;
            this.tb_pass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.tb_pass.BorderRadius = 7;
            this.tb_pass.BorderThickness = 2;
            this.tb_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_pass.DefaultText = "";
            this.tb_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_pass.DisabledState.Parent = this.tb_pass;
            this.tb_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_pass.FillColor = System.Drawing.Color.Transparent;
            this.tb_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_pass.FocusedState.Parent = this.tb_pass;
            this.tb_pass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tb_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_pass.HoverState.Parent = this.tb_pass;
            this.tb_pass.Location = new System.Drawing.Point(43, 355);
            this.tb_pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '\0';
            this.tb_pass.PlaceholderText = "Password";
            this.tb_pass.SelectedText = "";
            this.tb_pass.ShadowDecoration.Parent = this.tb_pass;
            this.tb_pass.Size = new System.Drawing.Size(267, 47);
            this.tb_pass.TabIndex = 2;
            this.tb_pass.UseSystemPasswordChar = true;
            this.tb_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbpassword_KeyDown);
            // 
            // tb_username
            // 
            this.tb_username.Animated = true;
            this.tb_username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.tb_username.BorderRadius = 7;
            this.tb_username.BorderThickness = 2;
            this.tb_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tb_username.DefaultText = "";
            this.tb_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tb_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tb_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_username.DisabledState.Parent = this.tb_username;
            this.tb_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tb_username.FillColor = System.Drawing.Color.Transparent;
            this.tb_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_username.FocusedState.Parent = this.tb_username;
            this.tb_username.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tb_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tb_username.HoverState.Parent = this.tb_username;
            this.tb_username.Location = new System.Drawing.Point(43, 293);
            this.tb_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_username.Name = "tb_username";
            this.tb_username.PasswordChar = '\0';
            this.tb_username.PlaceholderText = "Username";
            this.tb_username.SelectedText = "";
            this.tb_username.ShadowDecoration.Parent = this.tb_username;
            this.tb_username.Size = new System.Drawing.Size(267, 45);
            this.tb_username.TabIndex = 1;
            this.tb_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbusername_KeyDown);
            // 
            // logi_pic
            // 
            this.logi_pic.Image = global::BiaManager.Properties.Resources.logovtc;
            this.logi_pic.Location = new System.Drawing.Point(32, 4);
            this.logi_pic.Name = "logi_pic";
            this.logi_pic.Size = new System.Drawing.Size(291, 172);
            this.logi_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logi_pic.TabIndex = 0;
            this.logi_pic.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.PanelTaskbarLogin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(364, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 788);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.label_running);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 751);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 37);
            this.panel2.TabIndex = 10;
            // 
            // label_running
            // 
            this.label_running.AutoSize = true;
            this.label_running.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_running.ForeColor = System.Drawing.Color.White;
            this.label_running.Location = new System.Drawing.Point(7, 12);
            this.label_running.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_running.Name = "label_running";
            this.label_running.Size = new System.Drawing.Size(667, 20);
            this.label_running.TabIndex = 0;
            this.label_running.Text = "chào mừng đên với chương trình quản lý quán bi-a của nhóm chúng tôi( Mạnh - Hoàng" +
    "  - Lĩnh )";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(958, 788);
            this.panel3.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BiaManager.Properties.Resources.anhlogin__5_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(958, 788);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1322, 789);
            this.ControlBox = false;
            this.Controls.Add(this.pannel_login);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelTaskbarLogin.ResumeLayout(false);
            this.pannel_login.ResumeLayout(false);
            this.pannel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logi_pic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btchangeimg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox AvatarGif;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTaskbarLogin;
        private System.Windows.Forms.Panel PanelTaskbarLogin;
        private System.Windows.Forms.Panel pannel_login;
        private System.Windows.Forms.PictureBox logi_pic;
        private Guna.UI2.WinForms.Guna2TextBox tb_username;
        private Guna.UI2.WinForms.Guna2Button btnshowpass;
        private Guna.UI2.WinForms.Guna2TextBox tb_pass;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private Guna.UI2.WinForms.Guna2Button btnsingup;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_running;
        private Guna.UI2.WinForms.Guna2ControlBox btnmini;
        private Guna.UI2.WinForms.Guna2ControlBox btnclose;
        private System.Windows.Forms.Panel panel3;
    }
}