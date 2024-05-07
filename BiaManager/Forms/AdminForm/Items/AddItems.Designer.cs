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
            this.panelSearchContainer = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelLoginContentContainerChild = new System.Windows.Forms.Panel();
            this.comboBoxItemCategory = new System.Windows.Forms.ComboBox();
            this.textBoxItemPrice = new System.Windows.Forms.TextBox();
            this.labelItemPrice = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ItemCategoryLabel = new System.Windows.Forms.Label();
            this.ItemImgLabel = new System.Windows.Forms.Label();
            this.dataGridViewAddItem = new System.Windows.Forms.DataGridView();
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            this.iconButtonUploadItem = new FontAwesome.Sharp.IconButton();
            this.pictureBoxItem = new System.Windows.Forms.PictureBox();
            this.ButtonDelete = new FontAwesome.Sharp.IconButton();
            this.ButtonUpdate = new FontAwesome.Sharp.IconButton();
            this.ButtonCreate = new FontAwesome.Sharp.IconButton();
            this.panelSearchContainer.SuspendLayout();
            this.panelLoginContentContainerChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearchContainer
            // 
            this.panelSearchContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.panelSearchContainer.Controls.Add(this.iconButtonSearch);
            this.panelSearchContainer.Controls.Add(this.textBoxSearch);
            this.panelSearchContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchContainer.Location = new System.Drawing.Point(0, 441);
            this.panelSearchContainer.Name = "panelSearchContainer";
            this.panelSearchContainer.Size = new System.Drawing.Size(800, 40);
            this.panelSearchContainer.TabIndex = 9;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearch.Location = new System.Drawing.Point(273, 11);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(262, 20);
            this.textBoxSearch.TabIndex = 12;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // panelLoginContentContainerChild
            // 
            this.panelLoginContentContainerChild.AutoScroll = true;
            this.panelLoginContentContainerChild.BackColor = System.Drawing.Color.White;
            this.panelLoginContentContainerChild.Controls.Add(this.iconButtonUploadItem);
            this.panelLoginContentContainerChild.Controls.Add(this.pictureBoxItem);
            this.panelLoginContentContainerChild.Controls.Add(this.comboBoxItemCategory);
            this.panelLoginContentContainerChild.Controls.Add(this.ButtonDelete);
            this.panelLoginContentContainerChild.Controls.Add(this.ButtonUpdate);
            this.panelLoginContentContainerChild.Controls.Add(this.textBoxItemPrice);
            this.panelLoginContentContainerChild.Controls.Add(this.labelItemPrice);
            this.panelLoginContentContainerChild.Controls.Add(this.ButtonCreate);
            this.panelLoginContentContainerChild.Controls.Add(this.textBoxItemName);
            this.panelLoginContentContainerChild.Controls.Add(this.ItemNameLabel);
            this.panelLoginContentContainerChild.Controls.Add(this.ItemCategoryLabel);
            this.panelLoginContentContainerChild.Controls.Add(this.ItemImgLabel);
            this.panelLoginContentContainerChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoginContentContainerChild.Location = new System.Drawing.Point(0, 0);
            this.panelLoginContentContainerChild.Name = "panelLoginContentContainerChild";
            this.panelLoginContentContainerChild.Size = new System.Drawing.Size(800, 441);
            this.panelLoginContentContainerChild.TabIndex = 8;
            // 
            // comboBoxItemCategory
            // 
            this.comboBoxItemCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxItemCategory.FormattingEnabled = true;
            this.comboBoxItemCategory.Location = new System.Drawing.Point(387, 137);
            this.comboBoxItemCategory.Name = "comboBoxItemCategory";
            this.comboBoxItemCategory.Size = new System.Drawing.Size(262, 21);
            this.comboBoxItemCategory.TabIndex = 55;
            this.comboBoxItemCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemCategory_SelectedIndexChanged);
            // 
            // textBoxItemPrice
            // 
            this.textBoxItemPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxItemPrice.Location = new System.Drawing.Point(387, 189);
            this.textBoxItemPrice.Name = "textBoxItemPrice";
            this.textBoxItemPrice.Size = new System.Drawing.Size(262, 20);
            this.textBoxItemPrice.TabIndex = 47;
            this.textBoxItemPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxItemPrice_KeyDown);
            this.textBoxItemPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxItemPrice_KeyPress);
            // 
            // labelItemPrice
            // 
            this.labelItemPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelItemPrice.AutoSize = true;
            this.labelItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemPrice.ForeColor = System.Drawing.Color.Black;
            this.labelItemPrice.Location = new System.Drawing.Point(384, 162);
            this.labelItemPrice.Name = "labelItemPrice";
            this.labelItemPrice.Size = new System.Drawing.Size(103, 24);
            this.labelItemPrice.TabIndex = 52;
            this.labelItemPrice.Text = "Item Price";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxItemName.Location = new System.Drawing.Point(387, 73);
            this.textBoxItemName.Multiline = true;
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(200, 40);
            this.textBoxItemName.TabIndex = 45;
            this.textBoxItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxItemName_KeyDown);
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameLabel.ForeColor = System.Drawing.Color.Black;
            this.ItemNameLabel.Location = new System.Drawing.Point(383, 51);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(110, 24);
            this.ItemNameLabel.TabIndex = 39;
            this.ItemNameLabel.Text = "Item Name";
            // 
            // ItemCategoryLabel
            // 
            this.ItemCategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ItemCategoryLabel.AutoSize = true;
            this.ItemCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCategoryLabel.ForeColor = System.Drawing.Color.Black;
            this.ItemCategoryLabel.Location = new System.Drawing.Point(383, 116);
            this.ItemCategoryLabel.Name = "ItemCategoryLabel";
            this.ItemCategoryLabel.Size = new System.Drawing.Size(138, 24);
            this.ItemCategoryLabel.TabIndex = 40;
            this.ItemCategoryLabel.Text = "Item Category";
            // 
            // ItemImgLabel
            // 
            this.ItemImgLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ItemImgLabel.AutoSize = true;
            this.ItemImgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemImgLabel.ForeColor = System.Drawing.Color.Black;
            this.ItemImgLabel.Location = new System.Drawing.Point(199, 21);
            this.ItemImgLabel.Name = "ItemImgLabel";
            this.ItemImgLabel.Size = new System.Drawing.Size(112, 24);
            this.ItemImgLabel.TabIndex = 41;
            this.ItemImgLabel.Text = "Item Image";
            // 
            // dataGridViewAddItem
            // 
            this.dataGridViewAddItem.AllowUserToAddRows = false;
            this.dataGridViewAddItem.AllowUserToDeleteRows = false;
            this.dataGridViewAddItem.AllowUserToResizeRows = false;
            this.dataGridViewAddItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddItem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAddItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAddItem.Location = new System.Drawing.Point(0, 481);
            this.dataGridViewAddItem.Name = "dataGridViewAddItem";
            this.dataGridViewAddItem.Size = new System.Drawing.Size(800, 42);
            this.dataGridViewAddItem.TabIndex = 10;
            this.dataGridViewAddItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddItem_CellContentClick);
            this.dataGridViewAddItem.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddItem_CellContentClick);
            this.dataGridViewAddItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddItem_CellContentClick);
            this.dataGridViewAddItem.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewAddItem_CellFormatting);
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
            this.iconButtonSearch.Location = new System.Drawing.Point(542, 5);
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
            this.iconButtonUploadItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButtonUploadItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonUploadItem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonUploadItem.IconColor = System.Drawing.Color.Black;
            this.iconButtonUploadItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUploadItem.Location = new System.Drawing.Point(54, 51);
            this.iconButtonUploadItem.Name = "iconButtonUploadItem";
            this.iconButtonUploadItem.Size = new System.Drawing.Size(107, 100);
            this.iconButtonUploadItem.TabIndex = 48;
            this.iconButtonUploadItem.UseVisualStyleBackColor = true;
            this.iconButtonUploadItem.Click += new System.EventHandler(this.iconButtonUploadItem_Click);
            // 
            // pictureBoxItem
            // 
            this.pictureBoxItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxItem.Location = new System.Drawing.Point(189, 51);
            this.pictureBoxItem.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxItem.Name = "pictureBoxItem";
            this.pictureBoxItem.Size = new System.Drawing.Size(136, 107);
            this.pictureBoxItem.TabIndex = 56;
            this.pictureBoxItem.TabStop = false;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonDelete.AutoSize = true;
            this.ButtonDelete.BackColor = System.Drawing.Color.DarkRed;
            this.ButtonDelete.FlatAppearance.BorderSize = 0;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonDelete.IconColor = System.Drawing.Color.Black;
            this.ButtonDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDelete.Location = new System.Drawing.Point(387, 369);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(262, 54);
            this.ButtonDelete.TabIndex = 54;
            this.ButtonDelete.Text = "Delete Item";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonUpdate.AutoSize = true;
            this.ButtonUpdate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ButtonUpdate.FlatAppearance.BorderSize = 0;
            this.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdate.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonUpdate.IconColor = System.Drawing.Color.Black;
            this.ButtonUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonUpdate.Location = new System.Drawing.Point(388, 313);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(262, 54);
            this.ButtonUpdate.TabIndex = 53;
            this.ButtonUpdate.Text = "Update Item";
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonCreate.AutoSize = true;
            this.ButtonCreate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ButtonCreate.FlatAppearance.BorderSize = 0;
            this.ButtonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCreate.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonCreate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonCreate.IconColor = System.Drawing.Color.Black;
            this.ButtonCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonCreate.Location = new System.Drawing.Point(387, 313);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(262, 54);
            this.ButtonCreate.TabIndex = 52;
            this.ButtonCreate.Text = "Create Item";
            this.ButtonCreate.UseVisualStyleBackColor = false;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewAddItem);
            this.Controls.Add(this.panelSearchContainer);
            this.Controls.Add(this.panelLoginContentContainerChild);
            this.Name = "AddItems";
            this.Text = "AddItems";
            this.Load += new System.EventHandler(this.AddItems_Load);
            this.panelSearchContainer.ResumeLayout(false);
            this.panelSearchContainer.PerformLayout();
            this.panelLoginContentContainerChild.ResumeLayout(false);
            this.panelLoginContentContainerChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearchContainer;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panelLoginContentContainerChild;
        private FontAwesome.Sharp.IconButton ButtonDelete;
        private FontAwesome.Sharp.IconButton ButtonUpdate;
        private System.Windows.Forms.TextBox textBoxItemPrice;
        private System.Windows.Forms.Label labelItemPrice;
        private FontAwesome.Sharp.IconButton ButtonCreate;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.Label ItemNameLabel;
        private System.Windows.Forms.Label ItemCategoryLabel;
        private System.Windows.Forms.Label ItemImgLabel;
        private System.Windows.Forms.ComboBox comboBoxItemCategory;
        private FontAwesome.Sharp.IconButton iconButtonUploadItem;
        private System.Windows.Forms.PictureBox pictureBoxItem;
        private System.Windows.Forms.DataGridView dataGridViewAddItem;
    }
}