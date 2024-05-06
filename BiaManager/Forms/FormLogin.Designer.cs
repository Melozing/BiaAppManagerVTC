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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelTaskbarLogin = new System.Windows.Forms.Label();
            this.MaximizeBtn = new FontAwesome.Sharp.IconButton();
            this.MinimizeIconButton = new FontAwesome.Sharp.IconButton();
            this.btclose = new FontAwesome.Sharp.IconButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnsignup = new Guna.UI2.WinForms.Guna2Button();
            this.btnlogin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.forgotpassword = new System.Windows.Forms.LinkLabel();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.textbox_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.AvatarGif = new System.Windows.Forms.PictureBox();
            this.btchangeimg = new System.Windows.Forms.Button();
            this.textbox_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.labelTaskbarLogin.Location = new System.Drawing.Point(37, 191);
            this.labelTaskbarLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTaskbarLogin.Name = "labelTaskbarLogin";
            this.labelTaskbarLogin.Size = new System.Drawing.Size(320, 30);
            this.labelTaskbarLogin.TabIndex = 1;
            this.labelTaskbarLogin.Text = "Phần mềm quản lí quán bida";
            // 
            // MaximizeBtn
            // 
            this.MaximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeBtn.FlatAppearance.BorderSize = 0;
            this.MaximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeBtn.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            this.MaximizeBtn.IconColor = System.Drawing.Color.Transparent;
            this.MaximizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaximizeBtn.IconSize = 23;
            this.MaximizeBtn.Location = new System.Drawing.Point(1219, 26);
            this.MaximizeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBtn.Name = "MaximizeBtn";
            this.MaximizeBtn.Size = new System.Drawing.Size(31, 28);
            this.MaximizeBtn.TabIndex = 13;
            this.MaximizeBtn.UseVisualStyleBackColor = true;
            this.MaximizeBtn.Click += new System.EventHandler(this.MaximizeBtn_Click);
            // 
            // MinimizeIconButton
            // 
            this.MinimizeIconButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeIconButton.FlatAppearance.BorderSize = 0;
            this.MinimizeIconButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeIconButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimizeIconButton.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.MinimizeIconButton.IconColor = System.Drawing.Color.Transparent;
            this.MinimizeIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeIconButton.IconSize = 23;
            this.MinimizeIconButton.Location = new System.Drawing.Point(1132, 26);
            this.MinimizeIconButton.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeIconButton.Name = "MinimizeIconButton";
            this.MinimizeIconButton.Size = new System.Drawing.Size(31, 28);
            this.MinimizeIconButton.TabIndex = 12;
            this.MinimizeIconButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MinimizeIconButton.UseVisualStyleBackColor = true;
            this.MinimizeIconButton.Click += new System.EventHandler(this.MinimizeIconButton_Click);
            // 
            // btclose
            // 
            this.btclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btclose.FlatAppearance.BorderSize = 0;
            this.btclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btclose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btclose.IconColor = System.Drawing.Color.Transparent;
            this.btclose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btclose.IconSize = 23;
            this.btclose.Location = new System.Drawing.Point(1280, 27);
            this.btclose.Margin = new System.Windows.Forms.Padding(4);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(31, 28);
            this.btclose.TabIndex = 11;
            this.btclose.UseVisualStyleBackColor = true;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 8;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2Panel1.BorderRadius = 8;
            this.guna2Panel1.Controls.Add(this.btnsignup);
            this.guna2Panel1.Controls.Add(this.btnlogin);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.forgotpassword);
            this.guna2Panel1.Controls.Add(this.labelTaskbarLogin);
            this.guna2Panel1.Controls.Add(this.guna2ToggleSwitch1);
            this.guna2Panel1.Controls.Add(this.textbox_username);
            this.guna2Panel1.Controls.Add(this.AvatarGif);
            this.guna2Panel1.Controls.Add(this.textbox_pass);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(399, 829);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnsignup
            // 
            this.btnsignup.Animated = true;
            this.btnsignup.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btnsignup.BorderRadius = 8;
            this.btnsignup.BorderThickness = 2;
            this.btnsignup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsignup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsignup.FillColor = System.Drawing.Color.Transparent;
            this.btnsignup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnsignup.ForeColor = System.Drawing.Color.White;
            this.btnsignup.Location = new System.Drawing.Point(179, 485);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(116, 50);
            this.btnsignup.TabIndex = 19;
            this.btnsignup.Text = "sign up";
            // 
            // btnlogin
            // 
            this.btnlogin.Animated = true;
            this.btnlogin.BorderRadius = 8;
            this.btnlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(20)))), ((int)(((byte)(137)))));
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(54, 485);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(116, 50);
            this.btnlogin.TabIndex = 18;
            this.btnlogin.Text = "login";
            this.btnlogin.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 7;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Location = new System.Drawing.Point(259, 333);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button1.PressedDepth = 0;
            this.guna2Button1.Size = new System.Drawing.Size(86, 25);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "show";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HidePassword_MouseDown);
            this.guna2Button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HidePassword_MouseUp);
            // 
            // forgotpassword
            // 
            this.forgotpassword.AutoSize = true;
            this.forgotpassword.LinkColor = System.Drawing.Color.White;
            this.forgotpassword.Location = new System.Drawing.Point(236, 396);
            this.forgotpassword.Name = "forgotpassword";
            this.forgotpassword.Size = new System.Drawing.Size(109, 16);
            this.forgotpassword.TabIndex = 17;
            this.forgotpassword.TabStop = true;
            this.forgotpassword.Text = "Forgot Password";
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(54, 392);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(35, 20);
            this.guna2ToggleSwitch1.TabIndex = 16;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.BorderThickness = 2;
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            // 
            // textbox_username
            // 
            this.textbox_username.Animated = true;
            this.textbox_username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.textbox_username.BorderRadius = 7;
            this.textbox_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_username.DefaultText = "";
            this.textbox_username.FillColor = System.Drawing.Color.Transparent;
            this.textbox_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_username.Location = new System.Drawing.Point(54, 249);
            this.textbox_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_username.Name = "textbox_username";
            this.textbox_username.PasswordChar = '\0';
            this.textbox_username.PlaceholderText = "Username";
            this.textbox_username.SelectedText = "";
            this.textbox_username.Size = new System.Drawing.Size(291, 48);
            this.textbox_username.TabIndex = 0;
            this.textbox_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbusername_KeyDown);
            // 
            // AvatarGif
            // 
            this.AvatarGif.ErrorImage = ((System.Drawing.Image)(resources.GetObject("AvatarGif.ErrorImage")));
            this.AvatarGif.Image = ((System.Drawing.Image)(resources.GetObject("AvatarGif.Image")));
            this.AvatarGif.InitialImage = ((System.Drawing.Image)(resources.GetObject("AvatarGif.InitialImage")));
            this.AvatarGif.Location = new System.Drawing.Point(74, 13);
            this.AvatarGif.Margin = new System.Windows.Forms.Padding(4);
            this.AvatarGif.Name = "AvatarGif";
            this.AvatarGif.Size = new System.Drawing.Size(241, 174);
            this.AvatarGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AvatarGif.TabIndex = 14;
            this.AvatarGif.TabStop = false;
            this.AvatarGif.Click += new System.EventHandler(this.AvatarGif_Click);
            // 
            // btchangeimg
            // 
            this.btchangeimg.BackColor = System.Drawing.Color.White;
            this.btchangeimg.BackgroundImage = global::BiaManager.Properties.Resources.Photo_Gallery;
            this.btchangeimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btchangeimg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btchangeimg.Location = new System.Drawing.Point(395, 27);
            this.btchangeimg.Margin = new System.Windows.Forms.Padding(4);
            this.btchangeimg.Name = "btchangeimg";
            this.btchangeimg.Size = new System.Drawing.Size(30, 22);
            this.btchangeimg.TabIndex = 10;
            this.btchangeimg.UseVisualStyleBackColor = false;
            this.btchangeimg.Click += new System.EventHandler(this.button4_Click);
            // 
            // textbox_pass
            // 
            this.textbox_pass.Animated = true;
            this.textbox_pass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.textbox_pass.BorderRadius = 7;
            this.textbox_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_pass.DefaultText = "Password";
            this.textbox_pass.FillColor = System.Drawing.Color.Transparent;
            this.textbox_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textbox_pass.Location = new System.Drawing.Point(54, 324);
            this.textbox_pass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textbox_pass.Name = "textbox_pass";
            this.textbox_pass.PasswordChar = '●';
            this.textbox_pass.PlaceholderText = "";
            this.textbox_pass.SelectedText = "";
            this.textbox_pass.Size = new System.Drawing.Size(291, 48);
            this.textbox_pass.TabIndex = 15;
            this.textbox_pass.UseSystemPasswordChar = true;
            this.textbox_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbpassword_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BiaManager.Properties.Resources.anhlogin;
            this.pictureBox1.Location = new System.Drawing.Point(395, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1075, 739);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1412, 13);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 14;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1361, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(922, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "chào mừng đên với chương trình quản lý quán cafe của nhóm chúng tôi( Mạnh - Hoàng" +
    "  - Lĩnh )";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(395, 792);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1075, 37);
            this.panel1.TabIndex = 17;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1469, 829);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.MinimizeIconButton);
            this.Controls.Add(this.MaximizeBtn);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btchangeimg);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btchangeimg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox AvatarGif;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTaskbarLogin;
        private FontAwesome.Sharp.IconButton MaximizeBtn;
        private FontAwesome.Sharp.IconButton MinimizeIconButton;
        private FontAwesome.Sharp.IconButton btclose;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox textbox_username;
        private Guna.UI2.WinForms.Guna2TextBox textbox_pass;
        private System.Windows.Forms.LinkLabel forgotpassword;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnsignup;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}