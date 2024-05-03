namespace BiaManager.Forms.AdminForm.Staff
{
    partial class StaffManager
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
            this.panelSearchContainer = new System.Windows.Forms.Panel();
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelDataContainer = new System.Windows.Forms.Panel();
            this.dataGridViewStaffInfo = new System.Windows.Forms.DataGridView();
            this.panelAddContainer = new System.Windows.Forms.Panel();
            this.panelLoginContentContainerChild = new System.Windows.Forms.Panel();
            this.ButtonDeleteStaffManager = new FontAwesome.Sharp.IconButton();
            this.ButtonUpdateStaffManager = new FontAwesome.Sharp.IconButton();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.ButtonCreateStaffManager = new FontAwesome.Sharp.IconButton();
            this.textBoxBankName = new System.Windows.Forms.TextBox();
            this.textBoxBankNumber = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxFullname = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.BankNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.BankNumberLabel = new System.Windows.Forms.Label();
            this.FullnameLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.panelSearchContainer.SuspendLayout();
            this.panelDataContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaffInfo)).BeginInit();
            this.panelAddContainer.SuspendLayout();
            this.panelLoginContentContainerChild.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearchContainer
            // 
            this.panelSearchContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.panelSearchContainer.Controls.Add(this.iconButtonSearch);
            this.panelSearchContainer.Controls.Add(this.textBoxSearch);
            this.panelSearchContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchContainer.Location = new System.Drawing.Point(0, 383);
            this.panelSearchContainer.Name = "panelSearchContainer";
            this.panelSearchContainer.Size = new System.Drawing.Size(528, 30);
            this.panelSearchContainer.TabIndex = 7;
            // 
            // iconButtonSearch
            // 
            this.iconButtonSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonSearch.FlatAppearance.BorderSize = 0;
            this.iconButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconButtonSearch.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearch.IconSize = 30;
            this.iconButtonSearch.Location = new System.Drawing.Point(406, 0);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Size = new System.Drawing.Size(33, 30);
            this.iconButtonSearch.TabIndex = 13;
            this.iconButtonSearch.UseVisualStyleBackColor = true;
            this.iconButtonSearch.Click += new System.EventHandler(this.iconButtonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearch.Location = new System.Drawing.Point(137, 6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(262, 20);
            this.textBoxSearch.TabIndex = 12;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // panelDataContainer
            // 
            this.panelDataContainer.Controls.Add(this.dataGridViewStaffInfo);
            this.panelDataContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataContainer.Location = new System.Drawing.Point(0, 413);
            this.panelDataContainer.Name = "panelDataContainer";
            this.panelDataContainer.Size = new System.Drawing.Size(528, 0);
            this.panelDataContainer.TabIndex = 8;
            // 
            // dataGridViewStaffInfo
            // 
            this.dataGridViewStaffInfo.AllowUserToAddRows = false;
            this.dataGridViewStaffInfo.AllowUserToResizeColumns = false;
            this.dataGridViewStaffInfo.AllowUserToResizeRows = false;
            this.dataGridViewStaffInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStaffInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewStaffInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaffInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStaffInfo.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStaffInfo.MultiSelect = false;
            this.dataGridViewStaffInfo.Name = "dataGridViewStaffInfo";
            this.dataGridViewStaffInfo.RowHeadersWidth = 51;
            this.dataGridViewStaffInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewStaffInfo.Size = new System.Drawing.Size(528, 0);
            this.dataGridViewStaffInfo.TabIndex = 0;
            this.dataGridViewStaffInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStaffInfo_CellContentClick);
            // 
            // panelAddContainer
            // 
            this.panelAddContainer.AutoScroll = true;
            this.panelAddContainer.AutoSize = true;
            this.panelAddContainer.Controls.Add(this.panelLoginContentContainerChild);
            this.panelAddContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddContainer.Location = new System.Drawing.Point(0, 0);
            this.panelAddContainer.Name = "panelAddContainer";
            this.panelAddContainer.Size = new System.Drawing.Size(528, 383);
            this.panelAddContainer.TabIndex = 6;
            // 
            // panelLoginContentContainerChild
            // 
            this.panelLoginContentContainerChild.AutoScroll = true;
            this.panelLoginContentContainerChild.AutoSize = true;
            this.panelLoginContentContainerChild.Controls.Add(this.ButtonDeleteStaffManager);
            this.panelLoginContentContainerChild.Controls.Add(this.ButtonUpdateStaffManager);
            this.panelLoginContentContainerChild.Controls.Add(this.textBoxConfirmPassword);
            this.panelLoginContentContainerChild.Controls.Add(this.labelConfirmPassword);
            this.panelLoginContentContainerChild.Controls.Add(this.ButtonCreateStaffManager);
            this.panelLoginContentContainerChild.Controls.Add(this.textBoxBankName);
            this.panelLoginContentContainerChild.Controls.Add(this.textBoxBankNumber);
            this.panelLoginContentContainerChild.Controls.Add(this.textBoxPhone);
            this.panelLoginContentContainerChild.Controls.Add(this.textBoxFullname);
            this.panelLoginContentContainerChild.Controls.Add(this.textBoxPassword);
            this.panelLoginContentContainerChild.Controls.Add(this.textBoxUsername);
            this.panelLoginContentContainerChild.Controls.Add(this.UsernameLabel);
            this.panelLoginContentContainerChild.Controls.Add(this.BankNameLabel);
            this.panelLoginContentContainerChild.Controls.Add(this.PasswordLabel);
            this.panelLoginContentContainerChild.Controls.Add(this.BankNumberLabel);
            this.panelLoginContentContainerChild.Controls.Add(this.FullnameLabel);
            this.panelLoginContentContainerChild.Controls.Add(this.PhoneLabel);
            this.panelLoginContentContainerChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoginContentContainerChild.Location = new System.Drawing.Point(0, 0);
            this.panelLoginContentContainerChild.Name = "panelLoginContentContainerChild";
            this.panelLoginContentContainerChild.Size = new System.Drawing.Size(528, 383);
            this.panelLoginContentContainerChild.TabIndex = 0;
            // 
            // ButtonDeleteStaffManager
            // 
            this.ButtonDeleteStaffManager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonDeleteStaffManager.AutoSize = true;
            this.ButtonDeleteStaffManager.BackColor = System.Drawing.Color.DarkRed;
            this.ButtonDeleteStaffManager.FlatAppearance.BorderSize = 0;
            this.ButtonDeleteStaffManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteStaffManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteStaffManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonDeleteStaffManager.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonDeleteStaffManager.IconColor = System.Drawing.Color.Black;
            this.ButtonDeleteStaffManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDeleteStaffManager.Location = new System.Drawing.Point(250, 326);
            this.ButtonDeleteStaffManager.Name = "ButtonDeleteStaffManager";
            this.ButtonDeleteStaffManager.Size = new System.Drawing.Size(262, 54);
            this.ButtonDeleteStaffManager.TabIndex = 54;
            this.ButtonDeleteStaffManager.Text = "Delete Account";
            this.ButtonDeleteStaffManager.UseVisualStyleBackColor = false;
            this.ButtonDeleteStaffManager.Click += new System.EventHandler(this.ButtonDeleteStaffManager_Click);
            // 
            // ButtonUpdateStaffManager
            // 
            this.ButtonUpdateStaffManager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonUpdateStaffManager.AutoSize = true;
            this.ButtonUpdateStaffManager.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ButtonUpdateStaffManager.FlatAppearance.BorderSize = 0;
            this.ButtonUpdateStaffManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdateStaffManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdateStaffManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonUpdateStaffManager.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonUpdateStaffManager.IconColor = System.Drawing.Color.Black;
            this.ButtonUpdateStaffManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonUpdateStaffManager.Location = new System.Drawing.Point(250, 270);
            this.ButtonUpdateStaffManager.Name = "ButtonUpdateStaffManager";
            this.ButtonUpdateStaffManager.Size = new System.Drawing.Size(262, 54);
            this.ButtonUpdateStaffManager.TabIndex = 53;
            this.ButtonUpdateStaffManager.Text = "Update Account";
            this.ButtonUpdateStaffManager.UseVisualStyleBackColor = false;
            this.ButtonUpdateStaffManager.Click += new System.EventHandler(this.ButtonUpdateStaffManager_Click);
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(251, 107);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(262, 20);
            this.textBoxConfirmPassword.TabIndex = 47;
            this.textBoxConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxConfirmPassword_KeyDown);
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelConfirmPassword.Location = new System.Drawing.Point(16, 103);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(177, 24);
            this.labelConfirmPassword.TabIndex = 52;
            this.labelConfirmPassword.Text = "Confirm password";
            // 
            // ButtonCreateStaffManager
            // 
            this.ButtonCreateStaffManager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonCreateStaffManager.AutoSize = true;
            this.ButtonCreateStaffManager.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ButtonCreateStaffManager.FlatAppearance.BorderSize = 0;
            this.ButtonCreateStaffManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreateStaffManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCreateStaffManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonCreateStaffManager.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonCreateStaffManager.IconColor = System.Drawing.Color.Black;
            this.ButtonCreateStaffManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonCreateStaffManager.Location = new System.Drawing.Point(251, 270);
            this.ButtonCreateStaffManager.Name = "ButtonCreateStaffManager";
            this.ButtonCreateStaffManager.Size = new System.Drawing.Size(262, 54);
            this.ButtonCreateStaffManager.TabIndex = 52;
            this.ButtonCreateStaffManager.Text = "Create Account";
            this.ButtonCreateStaffManager.UseVisualStyleBackColor = false;
            this.ButtonCreateStaffManager.Click += new System.EventHandler(this.ButtonStaffManager_Click);
            // 
            // textBoxBankName
            // 
            this.textBoxBankName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxBankName.Location = new System.Drawing.Point(251, 237);
            this.textBoxBankName.Name = "textBoxBankName";
            this.textBoxBankName.Size = new System.Drawing.Size(262, 20);
            this.textBoxBankName.TabIndex = 51;
            this.textBoxBankName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBankName_KeyDown);
            // 
            // textBoxBankNumber
            // 
            this.textBoxBankNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxBankNumber.Location = new System.Drawing.Point(251, 205);
            this.textBoxBankNumber.MaxLength = 12;
            this.textBoxBankNumber.Name = "textBoxBankNumber";
            this.textBoxBankNumber.Size = new System.Drawing.Size(262, 20);
            this.textBoxBankNumber.TabIndex = 50;
            this.textBoxBankNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBankNumber_KeyDown);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPhone.Location = new System.Drawing.Point(251, 172);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(262, 20);
            this.textBoxPhone.TabIndex = 49;
            this.textBoxPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPhone_KeyDown);
            // 
            // textBoxFullname
            // 
            this.textBoxFullname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxFullname.Location = new System.Drawing.Point(251, 140);
            this.textBoxFullname.Name = "textBoxFullname";
            this.textBoxFullname.Size = new System.Drawing.Size(262, 20);
            this.textBoxFullname.TabIndex = 48;
            this.textBoxFullname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxFullname_KeyDown);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Location = new System.Drawing.Point(251, 75);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(262, 20);
            this.textBoxPassword.TabIndex = 46;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPassword_KeyDown);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsername.Location = new System.Drawing.Point(251, 42);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(262, 20);
            this.textBoxUsername.TabIndex = 45;
            this.textBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUsername_KeyDown);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.UsernameLabel.Location = new System.Drawing.Point(16, 38);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(105, 24);
            this.UsernameLabel.TabIndex = 39;
            this.UsernameLabel.Text = "Username";
            // 
            // BankNameLabel
            // 
            this.BankNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BankNameLabel.AutoSize = true;
            this.BankNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankNameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.BankNameLabel.Location = new System.Drawing.Point(16, 233);
            this.BankNameLabel.Name = "BankNameLabel";
            this.BankNameLabel.Size = new System.Drawing.Size(114, 24);
            this.BankNameLabel.TabIndex = 44;
            this.BankNameLabel.Text = "Bank name";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.PasswordLabel.Location = new System.Drawing.Point(16, 71);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(100, 24);
            this.PasswordLabel.TabIndex = 40;
            this.PasswordLabel.Text = "Password";
            // 
            // BankNumberLabel
            // 
            this.BankNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BankNumberLabel.AutoSize = true;
            this.BankNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankNumberLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.BankNumberLabel.Location = new System.Drawing.Point(16, 201);
            this.BankNumberLabel.Name = "BankNumberLabel";
            this.BankNumberLabel.Size = new System.Drawing.Size(136, 24);
            this.BankNumberLabel.TabIndex = 43;
            this.BankNumberLabel.Text = "Bank account";
            // 
            // FullnameLabel
            // 
            this.FullnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FullnameLabel.AutoSize = true;
            this.FullnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullnameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.FullnameLabel.Location = new System.Drawing.Point(16, 136);
            this.FullnameLabel.Name = "FullnameLabel";
            this.FullnameLabel.Size = new System.Drawing.Size(103, 24);
            this.FullnameLabel.TabIndex = 41;
            this.FullnameLabel.Text = "Full name";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.PhoneLabel.Location = new System.Drawing.Point(16, 168);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(71, 24);
            this.PhoneLabel.TabIndex = 42;
            this.PhoneLabel.Text = "Phone";
            // 
            // StaffManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(528, 407);
            this.Controls.Add(this.panelDataContainer);
            this.Controls.Add(this.panelSearchContainer);
            this.Controls.Add(this.panelAddContainer);
            this.Name = "StaffManager";
            this.Text = "AddStaff";
            this.panelSearchContainer.ResumeLayout(false);
            this.panelSearchContainer.PerformLayout();
            this.panelDataContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaffInfo)).EndInit();
            this.panelAddContainer.ResumeLayout(false);
            this.panelAddContainer.PerformLayout();
            this.panelLoginContentContainerChild.ResumeLayout(false);
            this.panelLoginContentContainerChild.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelSearchContainer;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private System.Windows.Forms.Panel panelDataContainer;
        private System.Windows.Forms.DataGridView dataGridViewStaffInfo;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panelAddContainer;
        private System.Windows.Forms.Panel panelLoginContentContainerChild;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private FontAwesome.Sharp.IconButton ButtonCreateStaffManager;
        private System.Windows.Forms.TextBox textBoxBankName;
        private System.Windows.Forms.TextBox textBoxBankNumber;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxFullname;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label BankNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label BankNumberLabel;
        private System.Windows.Forms.Label FullnameLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private FontAwesome.Sharp.IconButton ButtonUpdateStaffManager;
        private FontAwesome.Sharp.IconButton ButtonDeleteStaffManager;
    }
}