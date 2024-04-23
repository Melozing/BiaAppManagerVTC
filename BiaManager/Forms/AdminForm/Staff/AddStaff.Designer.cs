namespace BiaManager.Forms.AdminForm.Staff
{
    partial class AddStaff
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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.FullnameLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.BankNumberLabel = new System.Windows.Forms.Label();
            this.BankNameLabel = new System.Windows.Forms.Label();
            this.panelAddContainer = new System.Windows.Forms.Panel();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxFullname = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxBankNumber = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelSearchContainer = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            this.panelDataContainer = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelAddContainer.SuspendLayout();
            this.panelSearchContainer.SuspendLayout();
            this.panelDataContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.UsernameLabel.Location = new System.Drawing.Point(38, 46);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(105, 24);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.PasswordLabel.Location = new System.Drawing.Point(38, 86);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(100, 24);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Password";
            // 
            // FullnameLabel
            // 
            this.FullnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FullnameLabel.AutoSize = true;
            this.FullnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullnameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.FullnameLabel.Location = new System.Drawing.Point(38, 126);
            this.FullnameLabel.Name = "FullnameLabel";
            this.FullnameLabel.Size = new System.Drawing.Size(103, 24);
            this.FullnameLabel.TabIndex = 2;
            this.FullnameLabel.Text = "Full name";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.PhoneLabel.Location = new System.Drawing.Point(38, 166);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(71, 24);
            this.PhoneLabel.TabIndex = 3;
            this.PhoneLabel.Text = "Phone";
            // 
            // BankNumberLabel
            // 
            this.BankNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BankNumberLabel.AutoSize = true;
            this.BankNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankNumberLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.BankNumberLabel.Location = new System.Drawing.Point(38, 206);
            this.BankNumberLabel.Name = "BankNumberLabel";
            this.BankNumberLabel.Size = new System.Drawing.Size(214, 24);
            this.BankNumberLabel.TabIndex = 4;
            this.BankNumberLabel.Text = "Bank account number";
            // 
            // BankNameLabel
            // 
            this.BankNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BankNameLabel.AutoSize = true;
            this.BankNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankNameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.BankNameLabel.Location = new System.Drawing.Point(38, 246);
            this.BankNameLabel.Name = "BankNameLabel";
            this.BankNameLabel.Size = new System.Drawing.Size(114, 24);
            this.BankNameLabel.TabIndex = 5;
            this.BankNameLabel.Text = "Bank name";
            // 
            // panelAddContainer
            // 
            this.panelAddContainer.Controls.Add(this.textBox1);
            this.panelAddContainer.Controls.Add(this.textBoxBankNumber);
            this.panelAddContainer.Controls.Add(this.textBoxPhone);
            this.panelAddContainer.Controls.Add(this.textBoxFullname);
            this.panelAddContainer.Controls.Add(this.textBoxPassword);
            this.panelAddContainer.Controls.Add(this.textBoxUsername);
            this.panelAddContainer.Controls.Add(this.UsernameLabel);
            this.panelAddContainer.Controls.Add(this.BankNameLabel);
            this.panelAddContainer.Controls.Add(this.PasswordLabel);
            this.panelAddContainer.Controls.Add(this.BankNumberLabel);
            this.panelAddContainer.Controls.Add(this.FullnameLabel);
            this.panelAddContainer.Controls.Add(this.PhoneLabel);
            this.panelAddContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddContainer.Location = new System.Drawing.Point(0, 0);
            this.panelAddContainer.Name = "panelAddContainer";
            this.panelAddContainer.Size = new System.Drawing.Size(800, 298);
            this.panelAddContainer.TabIndex = 6;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(273, 51);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(262, 20);
            this.textBoxUsername.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(273, 91);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(262, 20);
            this.textBoxPassword.TabIndex = 7;
            // 
            // textBoxFullname
            // 
            this.textBoxFullname.Location = new System.Drawing.Point(273, 131);
            this.textBoxFullname.Name = "textBoxFullname";
            this.textBoxFullname.Size = new System.Drawing.Size(262, 20);
            this.textBoxFullname.TabIndex = 8;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(273, 171);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(262, 20);
            this.textBoxPhone.TabIndex = 9;
            // 
            // textBoxBankNumber
            // 
            this.textBoxBankNumber.Location = new System.Drawing.Point(273, 211);
            this.textBoxBankNumber.Name = "textBoxBankNumber";
            this.textBoxBankNumber.Size = new System.Drawing.Size(262, 20);
            this.textBoxBankNumber.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(273, 251);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 20);
            this.textBox1.TabIndex = 11;
            // 
            // panelSearchContainer
            // 
            this.panelSearchContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.panelSearchContainer.Controls.Add(this.iconButtonSearch);
            this.panelSearchContainer.Controls.Add(this.textBoxSearch);
            this.panelSearchContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchContainer.Location = new System.Drawing.Point(0, 298);
            this.panelSearchContainer.Name = "panelSearchContainer";
            this.panelSearchContainer.Size = new System.Drawing.Size(800, 30);
            this.panelSearchContainer.TabIndex = 7;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Location = new System.Drawing.Point(273, 6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(262, 20);
            this.textBoxSearch.TabIndex = 12;
            // 
            // iconButtonSearch
            // 
            this.iconButtonSearch.FlatAppearance.BorderSize = 0;
            this.iconButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconButtonSearch.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearch.IconSize = 30;
            this.iconButtonSearch.Location = new System.Drawing.Point(542, 0);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Size = new System.Drawing.Size(33, 30);
            this.iconButtonSearch.TabIndex = 13;
            this.iconButtonSearch.UseVisualStyleBackColor = true;
            // 
            // panelDataContainer
            // 
            this.panelDataContainer.Controls.Add(this.dataGridView1);
            this.panelDataContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataContainer.Location = new System.Drawing.Point(0, 328);
            this.panelDataContainer.Name = "panelDataContainer";
            this.panelDataContainer.Size = new System.Drawing.Size(800, 122);
            this.panelDataContainer.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 122);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDataContainer);
            this.Controls.Add(this.panelSearchContainer);
            this.Controls.Add(this.panelAddContainer);
            this.Name = "AddStaff";
            this.Text = "AddStaff";
            this.panelAddContainer.ResumeLayout(false);
            this.panelAddContainer.PerformLayout();
            this.panelSearchContainer.ResumeLayout(false);
            this.panelSearchContainer.PerformLayout();
            this.panelDataContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label FullnameLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label BankNumberLabel;
        private System.Windows.Forms.Label BankNameLabel;
        private System.Windows.Forms.Panel panelAddContainer;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxBankNumber;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxFullname;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panelSearchContainer;
        private System.Windows.Forms.TextBox textBoxSearch;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private System.Windows.Forms.Panel panelDataContainer;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}