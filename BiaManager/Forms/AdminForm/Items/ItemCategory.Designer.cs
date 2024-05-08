namespace BiaManager.Forms.AdminForm.Items
{
    partial class ItemCategory
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
            this.ButtonDeleteItemCategoryManager = new FontAwesome.Sharp.IconButton();
            this.ButtonUpdateItemCategoryManager = new FontAwesome.Sharp.IconButton();
            this.ButtonCreateItemCategoryManager = new FontAwesome.Sharp.IconButton();
            this.textBoxItemCategoryName = new System.Windows.Forms.TextBox();
            this.ItemCategoryNameLabel = new System.Windows.Forms.Label();
            this.dataGridViewItemsCategory = new System.Windows.Forms.DataGridView();
            this.panelSearchContainer.SuspendLayout();
            this.panelLoginContentContainerChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemsCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearchContainer
            // 
            this.panelSearchContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.panelSearchContainer.Controls.Add(this.iconButtonSearch);
            this.panelSearchContainer.Controls.Add(this.textBoxSearch);
            this.panelSearchContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchContainer.Location = new System.Drawing.Point(0, 255);
            this.panelSearchContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelSearchContainer.Name = "panelSearchContainer";
            this.panelSearchContainer.Size = new System.Drawing.Size(800, 37);
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
            this.iconButtonSearch.Location = new System.Drawing.Point(589, 0);
            this.iconButtonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Size = new System.Drawing.Size(44, 37);
            this.iconButtonSearch.TabIndex = 13;
            this.iconButtonSearch.UseVisualStyleBackColor = true;
            this.iconButtonSearch.Click += new System.EventHandler(this.iconButtonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearch.Location = new System.Drawing.Point(231, 7);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(348, 22);
            this.textBoxSearch.TabIndex = 12;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // panelLoginContentContainerChild
            // 
            this.panelLoginContentContainerChild.AutoScroll = true;
            this.panelLoginContentContainerChild.Controls.Add(this.ButtonDeleteItemCategoryManager);
            this.panelLoginContentContainerChild.Controls.Add(this.ButtonUpdateItemCategoryManager);
            this.panelLoginContentContainerChild.Controls.Add(this.ButtonCreateItemCategoryManager);
            this.panelLoginContentContainerChild.Controls.Add(this.textBoxItemCategoryName);
            this.panelLoginContentContainerChild.Controls.Add(this.ItemCategoryNameLabel);
            this.panelLoginContentContainerChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoginContentContainerChild.Location = new System.Drawing.Point(0, 0);
            this.panelLoginContentContainerChild.Margin = new System.Windows.Forms.Padding(4);
            this.panelLoginContentContainerChild.Name = "panelLoginContentContainerChild";
            this.panelLoginContentContainerChild.Size = new System.Drawing.Size(800, 255);
            this.panelLoginContentContainerChild.TabIndex = 8;
            // 
            // ButtonDeleteItemCategoryManager
            // 
            this.ButtonDeleteItemCategoryManager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonDeleteItemCategoryManager.AutoSize = true;
            this.ButtonDeleteItemCategoryManager.BackColor = System.Drawing.Color.DarkRed;
            this.ButtonDeleteItemCategoryManager.FlatAppearance.BorderSize = 0;
            this.ButtonDeleteItemCategoryManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteItemCategoryManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteItemCategoryManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonDeleteItemCategoryManager.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonDeleteItemCategoryManager.IconColor = System.Drawing.Color.Black;
            this.ButtonDeleteItemCategoryManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDeleteItemCategoryManager.Location = new System.Drawing.Point(383, 167);
            this.ButtonDeleteItemCategoryManager.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonDeleteItemCategoryManager.Name = "ButtonDeleteItemCategoryManager";
            this.ButtonDeleteItemCategoryManager.Size = new System.Drawing.Size(349, 54);
            this.ButtonDeleteItemCategoryManager.TabIndex = 54;
            this.ButtonDeleteItemCategoryManager.Text = "Delete Category";
            this.ButtonDeleteItemCategoryManager.UseVisualStyleBackColor = false;
            this.ButtonDeleteItemCategoryManager.Click += new System.EventHandler(this.ButtonDeleteItemCategoryManager_Click);
            // 
            // ButtonUpdateItemCategoryManager
            // 
            this.ButtonUpdateItemCategoryManager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonUpdateItemCategoryManager.AutoSize = true;
            this.ButtonUpdateItemCategoryManager.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ButtonUpdateItemCategoryManager.FlatAppearance.BorderSize = 0;
            this.ButtonUpdateItemCategoryManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdateItemCategoryManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdateItemCategoryManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonUpdateItemCategoryManager.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonUpdateItemCategoryManager.IconColor = System.Drawing.Color.Black;
            this.ButtonUpdateItemCategoryManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonUpdateItemCategoryManager.Location = new System.Drawing.Point(383, 97);
            this.ButtonUpdateItemCategoryManager.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonUpdateItemCategoryManager.Name = "ButtonUpdateItemCategoryManager";
            this.ButtonUpdateItemCategoryManager.Size = new System.Drawing.Size(349, 54);
            this.ButtonUpdateItemCategoryManager.TabIndex = 53;
            this.ButtonUpdateItemCategoryManager.Text = "Update Category";
            this.ButtonUpdateItemCategoryManager.UseVisualStyleBackColor = false;
            this.ButtonUpdateItemCategoryManager.Click += new System.EventHandler(this.ButtonUpdateItemCategoryManager_Click);
            // 
            // ButtonCreateItemCategoryManager
            // 
            this.ButtonCreateItemCategoryManager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonCreateItemCategoryManager.AutoSize = true;
            this.ButtonCreateItemCategoryManager.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ButtonCreateItemCategoryManager.FlatAppearance.BorderSize = 0;
            this.ButtonCreateItemCategoryManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreateItemCategoryManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCreateItemCategoryManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonCreateItemCategoryManager.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonCreateItemCategoryManager.IconColor = System.Drawing.Color.Black;
            this.ButtonCreateItemCategoryManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonCreateItemCategoryManager.Location = new System.Drawing.Point(383, 97);
            this.ButtonCreateItemCategoryManager.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCreateItemCategoryManager.Name = "ButtonCreateItemCategoryManager";
            this.ButtonCreateItemCategoryManager.Size = new System.Drawing.Size(349, 54);
            this.ButtonCreateItemCategoryManager.TabIndex = 52;
            this.ButtonCreateItemCategoryManager.Text = "Create Category";
            this.ButtonCreateItemCategoryManager.UseVisualStyleBackColor = false;
            this.ButtonCreateItemCategoryManager.Click += new System.EventHandler(this.ButtonCreateItemCategoryManager_Click);
            // 
            // textBoxItemCategoryName
            // 
            this.textBoxItemCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxItemCategoryName.Location = new System.Drawing.Point(384, 57);
            this.textBoxItemCategoryName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxItemCategoryName.Name = "textBoxItemCategoryName";
            this.textBoxItemCategoryName.Size = new System.Drawing.Size(348, 22);
            this.textBoxItemCategoryName.TabIndex = 45;
            this.textBoxItemCategoryName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxItemCategoryName_KeyDown);
            // 
            // ItemCategoryNameLabel
            // 
            this.ItemCategoryNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ItemCategoryNameLabel.AutoSize = true;
            this.ItemCategoryNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCategoryNameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.ItemCategoryNameLabel.Location = new System.Drawing.Point(33, 50);
            this.ItemCategoryNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ItemCategoryNameLabel.Name = "ItemCategoryNameLabel";
            this.ItemCategoryNameLabel.Size = new System.Drawing.Size(251, 29);
            this.ItemCategoryNameLabel.TabIndex = 39;
            this.ItemCategoryNameLabel.Text = "Item Category Name";
            // 
            // dataGridViewItemsCategory
            // 
            this.dataGridViewItemsCategory.AllowUserToAddRows = false;
            this.dataGridViewItemsCategory.AllowUserToResizeRows = false;
            this.dataGridViewItemsCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewItemsCategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewItemsCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemsCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewItemsCategory.Location = new System.Drawing.Point(0, 292);
            this.dataGridViewItemsCategory.Name = "dataGridViewItemsCategory";
            this.dataGridViewItemsCategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewItemsCategory.RowTemplate.Height = 24;
            this.dataGridViewItemsCategory.Size = new System.Drawing.Size(800, 31);
            this.dataGridViewItemsCategory.TabIndex = 10;
            this.dataGridViewItemsCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItemsCategory_CellContentClick);
            this.dataGridViewItemsCategory.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItemsCategory_CellContentClick);
            this.dataGridViewItemsCategory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItemsCategory_CellContentClick);
            // 
            // ItemCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 323);
            this.Controls.Add(this.dataGridViewItemsCategory);
            this.Controls.Add(this.panelSearchContainer);
            this.Controls.Add(this.panelLoginContentContainerChild);
            this.Name = "ItemCategory";
            this.Text = "ItemCategory";
            this.panelSearchContainer.ResumeLayout(false);
            this.panelSearchContainer.PerformLayout();
            this.panelLoginContentContainerChild.ResumeLayout(false);
            this.panelLoginContentContainerChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemsCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearchContainer;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panelLoginContentContainerChild;
        private FontAwesome.Sharp.IconButton ButtonDeleteItemCategoryManager;
        private FontAwesome.Sharp.IconButton ButtonUpdateItemCategoryManager;
        private FontAwesome.Sharp.IconButton ButtonCreateItemCategoryManager;
        private System.Windows.Forms.TextBox textBoxItemCategoryName;
        private System.Windows.Forms.Label ItemCategoryNameLabel;
        private System.Windows.Forms.DataGridView dataGridViewItemsCategory;
    }
}