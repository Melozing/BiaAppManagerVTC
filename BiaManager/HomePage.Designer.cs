namespace BiaManager
{
    partial class HomePage
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelMenuParent = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.Home = new FontAwesome.Sharp.IconButton();
            this.Tables = new FontAwesome.Sharp.IconButton();
            this.Menu = new FontAwesome.Sharp.IconButton();
            this.Bills = new FontAwesome.Sharp.IconButton();
            this.User = new FontAwesome.Sharp.IconButton();
            this.UserManagement = new FontAwesome.Sharp.IconButton();
            this.MenuManagement = new FontAwesome.Sharp.IconButton();
            this.TablesManagement = new FontAwesome.Sharp.IconButton();
            this.Setting = new FontAwesome.Sharp.IconButton();
            this.PanelHideMenu = new System.Windows.Forms.Panel();
            this.HideMenuIcon = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTittleBar = new System.Windows.Forms.Panel();
            this.MaximizeBtn = new FontAwesome.Sharp.IconButton();
            this.MinimizeIconButton = new FontAwesome.Sharp.IconButton();
            this.ExitBtn = new FontAwesome.Sharp.IconButton();
            this.tittleOfChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.PanelContentParent = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.LogoContent = new System.Windows.Forms.PictureBox();
            this.paneDetail = new System.Windows.Forms.Panel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelMenu.SuspendLayout();
            this.panelMenuParent.SuspendLayout();
            this.flowLayoutPanelMenu.SuspendLayout();
            this.PanelHideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTittleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.PanelContentParent.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.panelMenuParent);
            this.panelMenu.Controls.Add(this.PanelHideMenu);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(229, 600);
            this.panelMenu.TabIndex = 0;
            // 
            // panelMenuParent
            // 
            this.panelMenuParent.Controls.Add(this.flowLayoutPanelMenu);
            this.panelMenuParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenuParent.Location = new System.Drawing.Point(0, 188);
            this.panelMenuParent.Name = "panelMenuParent";
            this.panelMenuParent.Size = new System.Drawing.Size(229, 412);
            this.panelMenuParent.TabIndex = 2;
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.AutoScroll = true;
            this.flowLayoutPanelMenu.Controls.Add(this.Home);
            this.flowLayoutPanelMenu.Controls.Add(this.Tables);
            this.flowLayoutPanelMenu.Controls.Add(this.Menu);
            this.flowLayoutPanelMenu.Controls.Add(this.Bills);
            this.flowLayoutPanelMenu.Controls.Add(this.User);
            this.flowLayoutPanelMenu.Controls.Add(this.UserManagement);
            this.flowLayoutPanelMenu.Controls.Add(this.MenuManagement);
            this.flowLayoutPanelMenu.Controls.Add(this.TablesManagement);
            this.flowLayoutPanelMenu.Controls.Add(this.Setting);
            this.flowLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(229, 412);
            this.flowLayoutPanelMenu.TabIndex = 6;
            // 
            // Home
            // 
            this.Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.Gainsboro;
            this.Home.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            this.Home.IconColor = System.Drawing.Color.Gainsboro;
            this.Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Home.IconSize = 32;
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(3, 3);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Home.Size = new System.Drawing.Size(162, 60);
            this.Home.TabIndex = 9;
            this.Home.Text = "Home";
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Tables
            // 
            this.Tables.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tables.FlatAppearance.BorderSize = 0;
            this.Tables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tables.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tables.ForeColor = System.Drawing.Color.Gainsboro;
            this.Tables.IconChar = FontAwesome.Sharp.IconChar.HockeyPuck;
            this.Tables.IconColor = System.Drawing.Color.Gainsboro;
            this.Tables.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Tables.IconSize = 32;
            this.Tables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tables.Location = new System.Drawing.Point(3, 69);
            this.Tables.Name = "Tables";
            this.Tables.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Tables.Size = new System.Drawing.Size(162, 60);
            this.Tables.TabIndex = 10;
            this.Tables.Text = "Tables";
            this.Tables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Tables.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Tables.UseVisualStyleBackColor = true;
            this.Tables.Click += new System.EventHandler(this.Tables_Click);
            // 
            // Menu
            // 
            this.Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Menu.FlatAppearance.BorderSize = 0;
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.Color.Gainsboro;
            this.Menu.IconChar = FontAwesome.Sharp.IconChar.TableList;
            this.Menu.IconColor = System.Drawing.Color.Gainsboro;
            this.Menu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Menu.IconSize = 32;
            this.Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu.Location = new System.Drawing.Point(3, 135);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Menu.Size = new System.Drawing.Size(162, 60);
            this.Menu.TabIndex = 11;
            this.Menu.Text = "Menu";
            this.Menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Menu.UseVisualStyleBackColor = true;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // Bills
            // 
            this.Bills.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bills.FlatAppearance.BorderSize = 0;
            this.Bills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bills.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bills.ForeColor = System.Drawing.Color.Gainsboro;
            this.Bills.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.Bills.IconColor = System.Drawing.Color.Gainsboro;
            this.Bills.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Bills.IconSize = 32;
            this.Bills.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bills.Location = new System.Drawing.Point(3, 201);
            this.Bills.Name = "Bills";
            this.Bills.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Bills.Size = new System.Drawing.Size(162, 60);
            this.Bills.TabIndex = 13;
            this.Bills.Text = "Bills";
            this.Bills.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Bills.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bills.UseVisualStyleBackColor = true;
            this.Bills.Click += new System.EventHandler(this.Bills_Click);
            // 
            // User
            // 
            this.User.Dock = System.Windows.Forms.DockStyle.Top;
            this.User.FlatAppearance.BorderSize = 0;
            this.User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.Gainsboro;
            this.User.IconChar = FontAwesome.Sharp.IconChar.User;
            this.User.IconColor = System.Drawing.Color.Gainsboro;
            this.User.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.User.IconSize = 32;
            this.User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.User.Location = new System.Drawing.Point(3, 267);
            this.User.Name = "User";
            this.User.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.User.Size = new System.Drawing.Size(162, 60);
            this.User.TabIndex = 14;
            this.User.Text = "User";
            this.User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.User.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.User.UseVisualStyleBackColor = true;
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // UserManagement
            // 
            this.UserManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserManagement.FlatAppearance.BorderSize = 0;
            this.UserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.UserManagement.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.UserManagement.IconColor = System.Drawing.Color.Gainsboro;
            this.UserManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UserManagement.IconSize = 32;
            this.UserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserManagement.Location = new System.Drawing.Point(3, 333);
            this.UserManagement.Name = "UserManagement";
            this.UserManagement.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.UserManagement.Size = new System.Drawing.Size(162, 60);
            this.UserManagement.TabIndex = 15;
            this.UserManagement.Text = "Users Management";
            this.UserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UserManagement.UseVisualStyleBackColor = true;
            this.UserManagement.Click += new System.EventHandler(this.Setting_Click);
            // 
            // MenuManagement
            // 
            this.MenuManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuManagement.FlatAppearance.BorderSize = 0;
            this.MenuManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.MenuManagement.IconChar = FontAwesome.Sharp.IconChar.Nutritionix;
            this.MenuManagement.IconColor = System.Drawing.Color.Gainsboro;
            this.MenuManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MenuManagement.IconSize = 32;
            this.MenuManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuManagement.Location = new System.Drawing.Point(3, 399);
            this.MenuManagement.Name = "MenuManagement";
            this.MenuManagement.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.MenuManagement.Size = new System.Drawing.Size(162, 60);
            this.MenuManagement.TabIndex = 16;
            this.MenuManagement.Text = "Menu Management";
            this.MenuManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MenuManagement.UseVisualStyleBackColor = true;
            // 
            // TablesManagement
            // 
            this.TablesManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.TablesManagement.FlatAppearance.BorderSize = 0;
            this.TablesManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TablesManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablesManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.TablesManagement.IconChar = FontAwesome.Sharp.IconChar.Dumpster;
            this.TablesManagement.IconColor = System.Drawing.Color.Gainsboro;
            this.TablesManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TablesManagement.IconSize = 32;
            this.TablesManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TablesManagement.Location = new System.Drawing.Point(3, 465);
            this.TablesManagement.Name = "TablesManagement";
            this.TablesManagement.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.TablesManagement.Size = new System.Drawing.Size(162, 60);
            this.TablesManagement.TabIndex = 17;
            this.TablesManagement.Text = "Tables Management";
            this.TablesManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TablesManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TablesManagement.UseVisualStyleBackColor = true;
            // 
            // Setting
            // 
            this.Setting.Dock = System.Windows.Forms.DockStyle.Top;
            this.Setting.FlatAppearance.BorderSize = 0;
            this.Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Setting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setting.ForeColor = System.Drawing.Color.Gainsboro;
            this.Setting.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.Setting.IconColor = System.Drawing.Color.Gainsboro;
            this.Setting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Setting.IconSize = 32;
            this.Setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Setting.Location = new System.Drawing.Point(3, 531);
            this.Setting.Name = "Setting";
            this.Setting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Setting.Size = new System.Drawing.Size(162, 60);
            this.Setting.TabIndex = 18;
            this.Setting.Text = "Setting";
            this.Setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Setting.UseVisualStyleBackColor = true;
            // 
            // PanelHideMenu
            // 
            this.PanelHideMenu.Controls.Add(this.HideMenuIcon);
            this.PanelHideMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHideMenu.Location = new System.Drawing.Point(0, 140);
            this.PanelHideMenu.Name = "PanelHideMenu";
            this.PanelHideMenu.Size = new System.Drawing.Size(229, 48);
            this.PanelHideMenu.TabIndex = 1;
            // 
            // HideMenuIcon
            // 
            this.HideMenuIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.HideMenuIcon.FlatAppearance.BorderSize = 0;
            this.HideMenuIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HideMenuIcon.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideMenuIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.HideMenuIcon.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.HideMenuIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.HideMenuIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HideMenuIcon.IconSize = 40;
            this.HideMenuIcon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HideMenuIcon.Location = new System.Drawing.Point(0, 0);
            this.HideMenuIcon.Name = "HideMenuIcon";
            this.HideMenuIcon.Size = new System.Drawing.Size(229, 48);
            this.HideMenuIcon.TabIndex = 0;
            this.HideMenuIcon.Text = "Bia Manager";
            this.HideMenuIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HideMenuIcon.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(229, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::BiaManager.Properties.Resources.attachment_145244312;
            this.btnHome.Location = new System.Drawing.Point(42, 31);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(112, 88);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTittleBar
            // 
            this.panelTittleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTittleBar.Controls.Add(this.MaximizeBtn);
            this.panelTittleBar.Controls.Add(this.MinimizeIconButton);
            this.panelTittleBar.Controls.Add(this.ExitBtn);
            this.panelTittleBar.Controls.Add(this.tittleOfChildForm);
            this.panelTittleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTittleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittleBar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelTittleBar.Location = new System.Drawing.Point(229, 0);
            this.panelTittleBar.Name = "panelTittleBar";
            this.panelTittleBar.Size = new System.Drawing.Size(571, 75);
            this.panelTittleBar.TabIndex = 1;
            this.panelTittleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTittleBar_MouseDown);
            // 
            // MaximizeBtn
            // 
            this.MaximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeBtn.FlatAppearance.BorderSize = 0;
            this.MaximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeBtn.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            this.MaximizeBtn.IconColor = System.Drawing.Color.White;
            this.MaximizeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MaximizeBtn.IconSize = 23;
            this.MaximizeBtn.Location = new System.Drawing.Point(507, 12);
            this.MaximizeBtn.Name = "MaximizeBtn";
            this.MaximizeBtn.Size = new System.Drawing.Size(23, 23);
            this.MaximizeBtn.TabIndex = 4;
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
            this.MinimizeIconButton.IconColor = System.Drawing.Color.White;
            this.MinimizeIconButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinimizeIconButton.IconSize = 23;
            this.MinimizeIconButton.Location = new System.Drawing.Point(478, 12);
            this.MinimizeIconButton.Name = "MinimizeIconButton";
            this.MinimizeIconButton.Size = new System.Drawing.Size(23, 23);
            this.MinimizeIconButton.TabIndex = 3;
            this.MinimizeIconButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MinimizeIconButton.UseVisualStyleBackColor = true;
            this.MinimizeIconButton.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.IconChar = FontAwesome.Sharp.IconChar.X;
            this.ExitBtn.IconColor = System.Drawing.Color.White;
            this.ExitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ExitBtn.IconSize = 23;
            this.ExitBtn.Location = new System.Drawing.Point(536, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(23, 23);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // tittleOfChildForm
            // 
            this.tittleOfChildForm.AutoSize = true;
            this.tittleOfChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.tittleOfChildForm.Location = new System.Drawing.Point(68, 40);
            this.tittleOfChildForm.Name = "tittleOfChildForm";
            this.tittleOfChildForm.Size = new System.Drawing.Size(35, 13);
            this.tittleOfChildForm.TabIndex = 1;
            this.tittleOfChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(30, 31);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(229, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(571, 10);
            this.panelShadow.TabIndex = 2;
            // 
            // PanelContentParent
            // 
            this.PanelContentParent.Controls.Add(this.panelContent);
            this.PanelContentParent.Controls.Add(this.paneDetail);
            this.PanelContentParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContentParent.Location = new System.Drawing.Point(229, 85);
            this.PanelContentParent.Name = "PanelContentParent";
            this.PanelContentParent.Size = new System.Drawing.Size(571, 515);
            this.PanelContentParent.TabIndex = 3;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelContent.Controls.Add(this.LogoContent);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(328, 515);
            this.panelContent.TabIndex = 1;
            // 
            // LogoContent
            // 
            this.LogoContent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoContent.Image = global::BiaManager.Properties.Resources.attachment_145244312;
            this.LogoContent.Location = new System.Drawing.Point(107, 169);
            this.LogoContent.Name = "LogoContent";
            this.LogoContent.Size = new System.Drawing.Size(112, 88);
            this.LogoContent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoContent.TabIndex = 1;
            this.LogoContent.TabStop = false;
            // 
            // paneDetail
            // 
            this.paneDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(85)))));
            this.paneDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneDetail.Location = new System.Drawing.Point(328, 0);
            this.paneDetail.Name = "paneDetail";
            this.paneDetail.Size = new System.Drawing.Size(243, 515);
            this.paneDetail.TabIndex = 0;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.PanelContentParent);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTittleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "HomePage";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenuParent.ResumeLayout(false);
            this.flowLayoutPanelMenu.ResumeLayout(false);
            this.PanelHideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTittleBar.ResumeLayout(false);
            this.panelTittleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.PanelContentParent.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private FontAwesome.Sharp.IconButton Home;
        private FontAwesome.Sharp.IconButton Tables;
        private FontAwesome.Sharp.IconButton Menu;
        private FontAwesome.Sharp.IconButton Bills;
        private FontAwesome.Sharp.IconButton User;
        private FontAwesome.Sharp.IconButton UserManagement;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTittleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label tittleOfChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel PanelContentParent;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel paneDetail;
        private System.Windows.Forms.PictureBox LogoContent;
        private FontAwesome.Sharp.IconButton ExitBtn;
        private FontAwesome.Sharp.IconButton MaximizeBtn;
        private FontAwesome.Sharp.IconButton MinimizeIconButton;
        private FontAwesome.Sharp.IconButton MenuManagement;
        private FontAwesome.Sharp.IconButton TablesManagement;
        private FontAwesome.Sharp.IconButton Setting;
        private System.Windows.Forms.Panel PanelHideMenu;
        private FontAwesome.Sharp.IconButton HideMenuIcon;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelMenuParent;
    }
}

