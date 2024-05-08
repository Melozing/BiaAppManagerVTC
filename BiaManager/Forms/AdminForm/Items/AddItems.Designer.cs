namespace BiaManager.Forms.AdminForm.Items
{
    partial class AddItems
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelSearchContainer = new System.Windows.Forms.Panel();
            this.panelLoginContentContainerChild = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.textPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboCatelory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnupdate = new Guna.UI2.WinForms.Guna2Button();
            this.btncreate = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            this.iconButtonUploadItem = new FontAwesome.Sharp.IconButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.picboxitem = new Guna.UI2.WinForms.Guna2PictureBox();
            this.texboxSearchitems = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridViewAddItem = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.panelSearchContainer.SuspendLayout();
            this.panelLoginContentContainerChild.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxitem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearchContainer
            // 
            this.panelSearchContainer.BackColor = System.Drawing.Color.CadetBlue;
            this.panelSearchContainer.Controls.Add(this.texboxSearchitems);
            this.panelSearchContainer.Controls.Add(this.iconButtonSearch);
            this.panelSearchContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchContainer.Location = new System.Drawing.Point(0, 441);
            this.panelSearchContainer.Name = "panelSearchContainer";
            this.panelSearchContainer.Size = new System.Drawing.Size(800, 50);
            this.panelSearchContainer.TabIndex = 9;
            // 
            // panelLoginContentContainerChild
            // 
            this.panelLoginContentContainerChild.AutoScroll = true;
            this.panelLoginContentContainerChild.BackColor = System.Drawing.Color.White;
            this.panelLoginContentContainerChild.Controls.Add(this.guna2Panel1);
            this.panelLoginContentContainerChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoginContentContainerChild.Location = new System.Drawing.Point(0, 0);
            this.panelLoginContentContainerChild.Name = "panelLoginContentContainerChild";
            this.panelLoginContentContainerChild.Size = new System.Drawing.Size(800, 441);
            this.panelLoginContentContainerChild.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboCatelory);
            this.panel1.Controls.Add(this.textPrice);
            this.panel1.Controls.Add(this.textName);
            this.panel1.Controls.Add(this.btncreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(277, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 415);
            this.panel1.TabIndex = 57;
            // 
            // textName
            // 
            this.textName.BorderColor = System.Drawing.Color.Black;
            this.textName.BorderRadius = 8;
            this.textName.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.textName.BorderThickness = 2;
            this.textName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textName.DefaultText = "";
            this.textName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textName.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.textName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textName.Location = new System.Drawing.Point(70, 84);
            this.textName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textName.Name = "textName";
            this.textName.PasswordChar = '\0';
            this.textName.PlaceholderText = "Name Items";
            this.textName.SelectedText = "";
            this.textName.Size = new System.Drawing.Size(261, 49);
            this.textName.TabIndex = 53;
            this.textName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxItemName_KeyDown);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.picboxitem);
            this.guna2Panel1.Controls.Add(this.iconButtonUploadItem);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Location = new System.Drawing.Point(44, 20);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(725, 415);
            this.guna2Panel1.TabIndex = 58;
            // 
            // textPrice
            // 
            this.textPrice.BorderColor = System.Drawing.Color.Black;
            this.textPrice.BorderRadius = 8;
            this.textPrice.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.textPrice.BorderThickness = 2;
            this.textPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPrice.DefaultText = "";
            this.textPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.textPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPrice.Location = new System.Drawing.Point(74, 254);
            this.textPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPrice.Name = "textPrice";
            this.textPrice.PasswordChar = '\0';
            this.textPrice.PlaceholderText = "Price (  $ VND )";
            this.textPrice.SelectedText = "";
            this.textPrice.Size = new System.Drawing.Size(261, 51);
            this.textPrice.TabIndex = 56;
            this.textPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxItemPrice_KeyDown);
            this.textPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxItemPrice_KeyPress);
            // 
            // comboCatelory
            // 
            this.comboCatelory.BackColor = System.Drawing.Color.Transparent;
            this.comboCatelory.BorderColor = System.Drawing.Color.Black;
            this.comboCatelory.BorderRadius = 8;
            this.comboCatelory.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.comboCatelory.BorderThickness = 2;
            this.comboCatelory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboCatelory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCatelory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboCatelory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboCatelory.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.comboCatelory.ForeColor = System.Drawing.Color.Black;
            this.comboCatelory.ItemHeight = 30;
            this.comboCatelory.Location = new System.Drawing.Point(74, 171);
            this.comboCatelory.Name = "comboCatelory";
            this.comboCatelory.Size = new System.Drawing.Size(140, 36);
            this.comboCatelory.TabIndex = 57;
            this.comboCatelory.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Info Item";
            // 
            // btnupdate
            // 
            this.btnupdate.BorderRadius = 7;
            this.btnupdate.BorderThickness = 1;
            this.btnupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(262, 351);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(170, 47);
            this.btnupdate.TabIndex = 59;
            this.btnupdate.Text = "Update";
            this.btnupdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // btncreate
            // 
            this.btncreate.BorderRadius = 7;
            this.btncreate.BorderThickness = 1;
            this.btncreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncreate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreate.ForeColor = System.Drawing.Color.White;
            this.btncreate.Location = new System.Drawing.Point(262, 351);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(170, 47);
            this.btncreate.TabIndex = 60;
            this.btncreate.Text = "Create new";
            this.btncreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 7;
            this.btnDelete.BorderThickness = 1;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(74, 351);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(170, 47);
            this.btnDelete.TabIndex = 61;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // iconButtonSearch
            // 
            this.iconButtonSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonSearch.FlatAppearance.BorderSize = 0;
            this.iconButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSearch.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.iconButtonSearch.IconColor = System.Drawing.Color.White;
            this.iconButtonSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearch.IconSize = 30;
            this.iconButtonSearch.Location = new System.Drawing.Point(237, 11);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Size = new System.Drawing.Size(33, 30);
            this.iconButtonSearch.TabIndex = 13;
            this.iconButtonSearch.UseVisualStyleBackColor = true;
            this.iconButtonSearch.Click += new System.EventHandler(this.iconButtonSearch_Click);
            // 
            // iconButtonUploadItem
            // 
            this.iconButtonUploadItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonUploadItem.AutoSize = true;
            this.iconButtonUploadItem.BackgroundImage = global::BiaManager.Properties.Resources.Add_Imageitem;
            this.iconButtonUploadItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconButtonUploadItem.FlatAppearance.BorderSize = 0;
            this.iconButtonUploadItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonUploadItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonUploadItem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonUploadItem.IconColor = System.Drawing.Color.Black;
            this.iconButtonUploadItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUploadItem.Location = new System.Drawing.Point(105, 171);
            this.iconButtonUploadItem.Name = "iconButtonUploadItem";
            this.iconButtonUploadItem.Size = new System.Drawing.Size(54, 54);
            this.iconButtonUploadItem.TabIndex = 48;
            this.iconButtonUploadItem.UseVisualStyleBackColor = true;
            this.iconButtonUploadItem.Click += new System.EventHandler(this.iconButtonUploadItem_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Image = global::BiaManager.Properties.Resources.Reset;
            this.btnReset.Location = new System.Drawing.Point(389, 84);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(30, 30);
            this.btnReset.TabIndex = 62;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // picboxitem
            // 
            this.picboxitem.BorderRadius = 7;
            this.picboxitem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboxitem.Image = global::BiaManager.Properties.Resources.snooker_10489347;
            this.picboxitem.ImageRotate = 0F;
            this.picboxitem.Location = new System.Drawing.Point(22, 11);
            this.picboxitem.Name = "picboxitem";
            this.picboxitem.Size = new System.Drawing.Size(234, 156);
            this.picboxitem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxitem.TabIndex = 58;
            this.picboxitem.TabStop = false;
            // 
            // texboxSearchitems
            // 
            this.texboxSearchitems.BorderColor = System.Drawing.Color.Black;
            this.texboxSearchitems.BorderRadius = 8;
            this.texboxSearchitems.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.texboxSearchitems.BorderThickness = 2;
            this.texboxSearchitems.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.texboxSearchitems.DefaultText = "";
            this.texboxSearchitems.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.texboxSearchitems.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.texboxSearchitems.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texboxSearchitems.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.texboxSearchitems.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texboxSearchitems.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold);
            this.texboxSearchitems.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texboxSearchitems.Location = new System.Drawing.Point(28, 10);
            this.texboxSearchitems.Name = "texboxSearchitems";
            this.texboxSearchitems.PasswordChar = '\0';
            this.texboxSearchitems.PlaceholderText = "Search Item";
            this.texboxSearchitems.SelectedText = "";
            this.texboxSearchitems.Size = new System.Drawing.Size(203, 31);
            this.texboxSearchitems.TabIndex = 54;
            // 
            // dataGridViewAddItem
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridViewAddItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAddItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAddItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAddItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAddItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAddItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewAddItem.Location = new System.Drawing.Point(0, 491);
            this.dataGridViewAddItem.Name = "dataGridViewAddItem";
            this.dataGridViewAddItem.RowHeadersVisible = false;
            this.dataGridViewAddItem.Size = new System.Drawing.Size(800, 84);
            this.dataGridViewAddItem.TabIndex = 11;
            this.dataGridViewAddItem.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewAddItem.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridViewAddItem.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridViewAddItem.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridViewAddItem.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridViewAddItem.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewAddItem.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewAddItem.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridViewAddItem.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewAddItem.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewAddItem.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewAddItem.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddItem.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridViewAddItem.ThemeStyle.ReadOnly = false;
            this.dataGridViewAddItem.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewAddItem.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewAddItem.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewAddItem.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewAddItem.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridViewAddItem.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridViewAddItem.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewAddItem);
            this.Controls.Add(this.panelSearchContainer);
            this.Controls.Add(this.panelLoginContentContainerChild);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddItems";
            this.Text = "AddItems";
            this.Load += new System.EventHandler(this.AddItems_Load);
            this.panelSearchContainer.ResumeLayout(false);
            this.panelLoginContentContainerChild.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxitem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearchContainer;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private System.Windows.Forms.Panel panelLoginContentContainerChild;
        private FontAwesome.Sharp.IconButton iconButtonUploadItem;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox textName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox comboCatelory;
        private Guna.UI2.WinForms.Guna2TextBox textPrice;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btncreate;
        private Guna.UI2.WinForms.Guna2Button btnupdate;
        private System.Windows.Forms.Button btnReset;
        private Guna.UI2.WinForms.Guna2PictureBox picboxitem;
        private Guna.UI2.WinForms.Guna2TextBox texboxSearchitems;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridViewAddItem;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
    }
}