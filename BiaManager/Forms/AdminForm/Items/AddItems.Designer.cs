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
            this.iconButtonSearch = new FontAwesome.Sharp.IconButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelLoginContentContainerChild = new System.Windows.Forms.Panel();
            this.iconButtonUploadItem = new FontAwesome.Sharp.IconButton();
            this.pictureBoxItem = new System.Windows.Forms.PictureBox();
            this.comboBoxItemCategory = new System.Windows.Forms.ComboBox();
            this.ButtonDelete = new FontAwesome.Sharp.IconButton();
            this.ButtonUpdate = new FontAwesome.Sharp.IconButton();
            this.textBoxItemPrice = new System.Windows.Forms.TextBox();
            this.labelItemPrice = new System.Windows.Forms.Label();
            this.ButtonCreate = new FontAwesome.Sharp.IconButton();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.ItemNameLabel = new System.Windows.Forms.Label();
            this.ItemCategoryLabel = new System.Windows.Forms.Label();
            this.ItemImgLabel = new System.Windows.Forms.Label();
            this.dataGridViewAddItem = new System.Windows.Forms.DataGridView();
            this.panelSearchContainer.SuspendLayout();
            this.panelLoginContentContainerChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearchContainer
            // 
            this.panelSearchContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.panelSearchContainer.Controls.Add(this.iconButtonSearch);
            this.panelSearchContainer.Controls.Add(this.textBoxSearch);
            this.panelSearchContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchContainer.Location = new System.Drawing.Point(0, 543);
            this.panelSearchContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelSearchContainer.Name = "panelSearchContainer";
            this.panelSearchContainer.Size = new System.Drawing.Size(1067, 49);
            this.panelSearchContainer.TabIndex = 9;
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
            this.iconButtonSearch.Location = new System.Drawing.Point(723, 6);
            this.iconButtonSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Size = new System.Drawing.Size(44, 37);
            this.iconButtonSearch.TabIndex = 13;
            this.iconButtonSearch.UseVisualStyleBackColor = true;
            this.iconButtonSearch.Click += new System.EventHandler(this.iconButtonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearch.Location = new System.Drawing.Point(364, 14);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(348, 22);
            this.textBoxSearch.TabIndex = 12;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // panelLoginContentContainerChild
            // 
            this.panelLoginContentContainerChild.AutoScroll = true;
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
            this.panelLoginContentContainerChild.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLoginContentContainerChild.Name = "panelLoginContentContainerChild";
            this.panelLoginContentContainerChild.Size = new System.Drawing.Size(1067, 543);
            this.panelLoginContentContainerChild.TabIndex = 8;
            // 
            // iconButtonUploadItem
            // 
            this.iconButtonUploadItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonUploadItem.AutoSize = true;
            this.iconButtonUploadItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonUploadItem.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonUploadItem.IconColor = System.Drawing.Color.Black;
            this.iconButtonUploadItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonUploadItem.Location = new System.Drawing.Point(516, 172);
            this.iconButtonUploadItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonUploadItem.Name = "iconButtonUploadItem";
            this.iconButtonUploadItem.Size = new System.Drawing.Size(349, 66);
            this.iconButtonUploadItem.TabIndex = 48;
            this.iconButtonUploadItem.Text = "Upload Image";
            this.iconButtonUploadItem.UseVisualStyleBackColor = true;
            this.iconButtonUploadItem.Click += new System.EventHandler(this.iconButtonUploadItem_Click);
            // 
            // pictureBoxItem
            // 
            this.pictureBoxItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxItem.Location = new System.Drawing.Point(600, 246);
            this.pictureBoxItem.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxItem.Name = "pictureBoxItem";
            this.pictureBoxItem.Size = new System.Drawing.Size(181, 131);
            this.pictureBoxItem.TabIndex = 56;
            this.pictureBoxItem.TabStop = false;
            // 
            // comboBoxItemCategory
            // 
            this.comboBoxItemCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxItemCategory.FormattingEnabled = true;
            this.comboBoxItemCategory.Location = new System.Drawing.Point(516, 100);
            this.comboBoxItemCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxItemCategory.Name = "comboBoxItemCategory";
            this.comboBoxItemCategory.Size = new System.Drawing.Size(348, 24);
            this.comboBoxItemCategory.TabIndex = 55;
            this.comboBoxItemCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxItemCategory_SelectedIndexChanged);
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
            this.ButtonDelete.Location = new System.Drawing.Point(516, 454);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(349, 66);
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
            this.ButtonUpdate.Location = new System.Drawing.Point(516, 385);
            this.ButtonUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(349, 66);
            this.ButtonUpdate.TabIndex = 53;
            this.ButtonUpdate.Text = "Update Item";
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // textBoxItemPrice
            // 
            this.textBoxItemPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxItemPrice.Location = new System.Drawing.Point(516, 139);
            this.textBoxItemPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxItemPrice.Name = "textBoxItemPrice";
            this.textBoxItemPrice.Size = new System.Drawing.Size(348, 22);
            this.textBoxItemPrice.TabIndex = 47;
            this.textBoxItemPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxItemPrice_KeyDown);
            this.textBoxItemPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxItemPrice_KeyPress);
            // 
            // labelItemPrice
            // 
            this.labelItemPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelItemPrice.AutoSize = true;
            this.labelItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemPrice.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelItemPrice.Location = new System.Drawing.Point(203, 134);
            this.labelItemPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelItemPrice.Name = "labelItemPrice";
            this.labelItemPrice.Size = new System.Drawing.Size(131, 29);
            this.labelItemPrice.TabIndex = 52;
            this.labelItemPrice.Text = "Item Price";
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
            this.ButtonCreate.Location = new System.Drawing.Point(516, 385);
            this.ButtonCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(349, 66);
            this.ButtonCreate.TabIndex = 52;
            this.ButtonCreate.Text = "Create Item";
            this.ButtonCreate.UseVisualStyleBackColor = false;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxItemName.Location = new System.Drawing.Point(516, 59);
            this.textBoxItemName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(348, 22);
            this.textBoxItemName.TabIndex = 45;
            this.textBoxItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxItemName_KeyDown);
            // 
            // ItemNameLabel
            // 
            this.ItemNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ItemNameLabel.AutoSize = true;
            this.ItemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ItemNameLabel.Location = new System.Drawing.Point(203, 54);
            this.ItemNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemNameLabel.Name = "ItemNameLabel";
            this.ItemNameLabel.Size = new System.Drawing.Size(139, 29);
            this.ItemNameLabel.TabIndex = 39;
            this.ItemNameLabel.Text = "Item Name";
            // 
            // ItemCategoryLabel
            // 
            this.ItemCategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ItemCategoryLabel.AutoSize = true;
            this.ItemCategoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCategoryLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ItemCategoryLabel.Location = new System.Drawing.Point(203, 95);
            this.ItemCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemCategoryLabel.Name = "ItemCategoryLabel";
            this.ItemCategoryLabel.Size = new System.Drawing.Size(175, 29);
            this.ItemCategoryLabel.TabIndex = 40;
            this.ItemCategoryLabel.Text = "Item Category";
            // 
            // ItemImgLabel
            // 
            this.ItemImgLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ItemImgLabel.AutoSize = true;
            this.ItemImgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemImgLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ItemImgLabel.Location = new System.Drawing.Point(203, 175);
            this.ItemImgLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemImgLabel.Name = "ItemImgLabel";
            this.ItemImgLabel.Size = new System.Drawing.Size(142, 29);
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
            this.dataGridViewAddItem.Location = new System.Drawing.Point(0, 592);
            this.dataGridViewAddItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewAddItem.Name = "dataGridViewAddItem";
            this.dataGridViewAddItem.RowHeadersWidth = 51;
            this.dataGridViewAddItem.Size = new System.Drawing.Size(1067, 52);
            this.dataGridViewAddItem.TabIndex = 10;
            this.dataGridViewAddItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddItem_CellContentClick);
            this.dataGridViewAddItem.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddItem_CellContentClick);
            this.dataGridViewAddItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddItem_CellContentClick);
            this.dataGridViewAddItem.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewAddItem_CellFormatting);
            // 
            // AddItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1067, 644);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewAddItem);
            this.Controls.Add(this.panelSearchContainer);
            this.Controls.Add(this.panelLoginContentContainerChild);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddItems";
            this.Text = "AddItems";
            this.Load += new System.EventHandler(this.AddItems_Load);
            this.panelSearchContainer.ResumeLayout(false);
            this.panelSearchContainer.PerformLayout();
            this.panelLoginContentContainerChild.ResumeLayout(false);
            this.panelLoginContentContainerChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddItem)).EndInit();
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