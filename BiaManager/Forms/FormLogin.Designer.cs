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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btclose = new System.Windows.Forms.Button();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonHidePassword = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.PictureBox();
            this.linkLabelForgerPassword = new System.Windows.Forms.LinkLabel();
            this.UserBox = new System.Windows.Forms.PictureBox();
            this.labelTittleLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.btchangeimg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AvatarGif = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarGif)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btclose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 30);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phần mềm quản lí quán bida";
            // 
            // btclose
            // 
            this.btclose.BackColor = System.Drawing.Color.White;
            this.btclose.BackgroundImage = global::BiaManager.Properties.Resources.Close;
            this.btclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btclose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btclose.Location = new System.Drawing.Point(890, 0);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(30, 30);
            this.btclose.TabIndex = 1;
            this.btclose.UseVisualStyleBackColor = false;
            this.btclose.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.LightGray;
            this.panelLogin.Controls.Add(this.AvatarGif);
            this.panelLogin.Controls.Add(this.panel2);
            this.panelLogin.Location = new System.Drawing.Point(81, 74);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(286, 408);
            this.panelLogin.TabIndex = 1;
            // 
            // buttonHidePassword
            // 
            this.buttonHidePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHidePassword.BackColor = System.Drawing.Color.White;
            this.buttonHidePassword.BackgroundImage = global::BiaManager.Properties.Resources.Anonymous_Mask;
            this.buttonHidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHidePassword.Location = new System.Drawing.Point(225, 122);
            this.buttonHidePassword.Name = "buttonHidePassword";
            this.buttonHidePassword.Size = new System.Drawing.Size(20, 20);
            this.buttonHidePassword.TabIndex = 10;
            this.buttonHidePassword.UseVisualStyleBackColor = false;
            this.buttonHidePassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            this.buttonHidePassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button3_MouseUp);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordBox.Image = global::BiaManager.Properties.Resources.Password;
            this.PasswordBox.Location = new System.Drawing.Point(42, 112);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(30, 30);
            this.PasswordBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PasswordBox.TabIndex = 12;
            this.PasswordBox.TabStop = false;
            // 
            // linkLabelForgerPassword
            // 
            this.linkLabelForgerPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelForgerPassword.AutoSize = true;
            this.linkLabelForgerPassword.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(68)))), ((int)(((byte)(87)))));
            this.linkLabelForgerPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkLabelForgerPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linkLabelForgerPassword.LinkColor = System.Drawing.Color.Black;
            this.linkLabelForgerPassword.Location = new System.Drawing.Point(81, 145);
            this.linkLabelForgerPassword.Name = "linkLabelForgerPassword";
            this.linkLabelForgerPassword.Size = new System.Drawing.Size(87, 15);
            this.linkLabelForgerPassword.TabIndex = 3;
            this.linkLabelForgerPassword.TabStop = true;
            this.linkLabelForgerPassword.Text = "quên mật khẩu";
            // 
            // UserBox
            // 
            this.UserBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserBox.Image = global::BiaManager.Properties.Resources.Male_User;
            this.UserBox.Location = new System.Drawing.Point(42, 57);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(30, 30);
            this.UserBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserBox.TabIndex = 11;
            this.UserBox.TabStop = false;
            // 
            // labelTittleLogin
            // 
            this.labelTittleLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTittleLogin.AutoSize = true;
            this.labelTittleLogin.BackColor = System.Drawing.Color.LightGray;
            this.labelTittleLogin.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelTittleLogin.ForeColor = System.Drawing.Color.Black;
            this.labelTittleLogin.Location = new System.Drawing.Point(79, 18);
            this.labelTittleLogin.Name = "labelTittleLogin";
            this.labelTittleLogin.Size = new System.Drawing.Size(123, 26);
            this.labelTittleLogin.TabIndex = 3;
            this.labelTittleLogin.Text = "Đăng nhập";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelPassword.Location = new System.Drawing.Point(80, 102);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(68, 19);
            this.labelPassword.TabIndex = 7;
            this.labelPassword.Text = "Mật khẩu";
            // 
            // tbusername
            // 
            this.tbusername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbusername.Location = new System.Drawing.Point(84, 79);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(161, 20);
            this.tbusername.TabIndex = 2;
            // 
            // tbpassword
            // 
            this.tbpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbpassword.Location = new System.Drawing.Point(84, 122);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(161, 20);
            this.tbpassword.TabIndex = 6;
            this.tbpassword.UseSystemPasswordChar = true;
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.labelUsername.Location = new System.Drawing.Point(80, 57);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(102, 19);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Tên đăng nhập";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.ForeColor = System.Drawing.Color.Black;
            this.buttonLogin.Location = new System.Drawing.Point(84, 163);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(161, 48);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "Đăng nhập";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button2_Click);
            // 
            // btchangeimg
            // 
            this.btchangeimg.BackColor = System.Drawing.Color.White;
            this.btchangeimg.BackgroundImage = global::BiaManager.Properties.Resources.Photo_Gallery;
            this.btchangeimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btchangeimg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btchangeimg.Location = new System.Drawing.Point(8, 525);
            this.btchangeimg.Name = "btchangeimg";
            this.btchangeimg.Size = new System.Drawing.Size(30, 23);
            this.btchangeimg.TabIndex = 10;
            this.btchangeimg.UseVisualStyleBackColor = false;
            this.btchangeimg.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(920, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTittleLogin);
            this.panel2.Controls.Add(this.buttonHidePassword);
            this.panel2.Controls.Add(this.buttonLogin);
            this.panel2.Controls.Add(this.PasswordBox);
            this.panel2.Controls.Add(this.labelUsername);
            this.panel2.Controls.Add(this.linkLabelForgerPassword);
            this.panel2.Controls.Add(this.tbpassword);
            this.panel2.Controls.Add(this.UserBox);
            this.panel2.Controls.Add(this.tbusername);
            this.panel2.Controls.Add(this.labelPassword);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 225);
            this.panel2.TabIndex = 13;
            // 
            // AvatarGif
            // 
            this.AvatarGif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AvatarGif.ErrorImage = ((System.Drawing.Image)(resources.GetObject("AvatarGif.ErrorImage")));
            this.AvatarGif.Image = ((System.Drawing.Image)(resources.GetObject("AvatarGif.Image")));
            this.AvatarGif.InitialImage = ((System.Drawing.Image)(resources.GetObject("AvatarGif.InitialImage")));
            this.AvatarGif.Location = new System.Drawing.Point(0, 0);
            this.AvatarGif.Name = "AvatarGif";
            this.AvatarGif.Size = new System.Drawing.Size(286, 183);
            this.AvatarGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AvatarGif.TabIndex = 14;
            this.AvatarGif.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 560);
            this.Controls.Add(this.btchangeimg);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cmd";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PasswordBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.LinkLabel linkLabelForgerPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelTittleLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonHidePassword;
        private System.Windows.Forms.PictureBox UserBox;
        private System.Windows.Forms.PictureBox PasswordBox;
        private System.Windows.Forms.Button btchangeimg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox AvatarGif;
    }
}