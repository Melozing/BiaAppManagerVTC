namespace BiaManager.Forms.AdminForm.Tables
{
    partial class TableTypeManager
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
            this.ButtonDeleteTableTypeManager = new FontAwesome.Sharp.IconButton();
            this.ButtonUpdateTableTypeManager = new FontAwesome.Sharp.IconButton();
            this.ButtonCreateTableTypeManager = new FontAwesome.Sharp.IconButton();
            this.textBoxTablePrice = new System.Windows.Forms.TextBox();
            this.textBoxTableName = new System.Windows.Forms.TextBox();
            this.TableNameLabel = new System.Windows.Forms.Label();
            this.TablePriceLabel = new System.Windows.Forms.Label();
            this.dataGridViewTableTypeInfo = new System.Windows.Forms.DataGridView();
            this.panelSearchContainer.SuspendLayout();
            this.panelLoginContentContainerChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableTypeInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearchContainer
            // 
            this.panelSearchContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(74)))));
            this.panelSearchContainer.Controls.Add(this.iconButtonSearch);
            this.panelSearchContainer.Controls.Add(this.textBoxSearch);
            this.panelSearchContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchContainer.Location = new System.Drawing.Point(0, 243);
            this.panelSearchContainer.Name = "panelSearchContainer";
            this.panelSearchContainer.Size = new System.Drawing.Size(608, 30);
            this.panelSearchContainer.TabIndex = 10;
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
            this.iconButtonSearch.Location = new System.Drawing.Point(446, 0);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Size = new System.Drawing.Size(33, 30);
            this.iconButtonSearch.TabIndex = 13;
            this.iconButtonSearch.UseVisualStyleBackColor = true;
            this.iconButtonSearch.Click += new System.EventHandler(this.iconButtonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearch.Location = new System.Drawing.Point(177, 6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(262, 20);
            this.textBoxSearch.TabIndex = 12;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // panelLoginContentContainerChild
            // 
            this.panelLoginContentContainerChild.AutoScroll = true;
            this.panelLoginContentContainerChild.Controls.Add(this.ButtonDeleteTableTypeManager);
            this.panelLoginContentContainerChild.Controls.Add(this.ButtonUpdateTableTypeManager);
            this.panelLoginContentContainerChild.Controls.Add(this.ButtonCreateTableTypeManager);
            this.panelLoginContentContainerChild.Controls.Add(this.textBoxTablePrice);
            this.panelLoginContentContainerChild.Controls.Add(this.textBoxTableName);
            this.panelLoginContentContainerChild.Controls.Add(this.TableNameLabel);
            this.panelLoginContentContainerChild.Controls.Add(this.TablePriceLabel);
            this.panelLoginContentContainerChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoginContentContainerChild.Location = new System.Drawing.Point(0, 0);
            this.panelLoginContentContainerChild.Name = "panelLoginContentContainerChild";
            this.panelLoginContentContainerChild.Size = new System.Drawing.Size(608, 243);
            this.panelLoginContentContainerChild.TabIndex = 9;
            // 
            // ButtonDeleteTableTypeManager
            // 
            this.ButtonDeleteTableTypeManager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonDeleteTableTypeManager.AutoSize = true;
            this.ButtonDeleteTableTypeManager.BackColor = System.Drawing.Color.DarkRed;
            this.ButtonDeleteTableTypeManager.FlatAppearance.BorderSize = 0;
            this.ButtonDeleteTableTypeManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDeleteTableTypeManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDeleteTableTypeManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonDeleteTableTypeManager.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonDeleteTableTypeManager.IconColor = System.Drawing.Color.Black;
            this.ButtonDeleteTableTypeManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonDeleteTableTypeManager.Location = new System.Drawing.Point(290, 181);
            this.ButtonDeleteTableTypeManager.Name = "ButtonDeleteTableTypeManager";
            this.ButtonDeleteTableTypeManager.Size = new System.Drawing.Size(262, 54);
            this.ButtonDeleteTableTypeManager.TabIndex = 54;
            this.ButtonDeleteTableTypeManager.Text = "Delete Table Type";
            this.ButtonDeleteTableTypeManager.UseVisualStyleBackColor = false;
            this.ButtonDeleteTableTypeManager.Click += new System.EventHandler(this.ButtonDeleteTableTypeManager_Click);
            // 
            // ButtonUpdateTableTypeManager
            // 
            this.ButtonUpdateTableTypeManager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonUpdateTableTypeManager.AutoSize = true;
            this.ButtonUpdateTableTypeManager.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ButtonUpdateTableTypeManager.FlatAppearance.BorderSize = 0;
            this.ButtonUpdateTableTypeManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUpdateTableTypeManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdateTableTypeManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonUpdateTableTypeManager.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonUpdateTableTypeManager.IconColor = System.Drawing.Color.Black;
            this.ButtonUpdateTableTypeManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonUpdateTableTypeManager.Location = new System.Drawing.Point(290, 124);
            this.ButtonUpdateTableTypeManager.Name = "ButtonUpdateTableTypeManager";
            this.ButtonUpdateTableTypeManager.Size = new System.Drawing.Size(262, 54);
            this.ButtonUpdateTableTypeManager.TabIndex = 53;
            this.ButtonUpdateTableTypeManager.Text = "Update Table Type";
            this.ButtonUpdateTableTypeManager.UseVisualStyleBackColor = false;
            this.ButtonUpdateTableTypeManager.Click += new System.EventHandler(this.ButtonUpdateTableTypeManager_Click);
            // 
            // ButtonCreateTableTypeManager
            // 
            this.ButtonCreateTableTypeManager.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonCreateTableTypeManager.AutoSize = true;
            this.ButtonCreateTableTypeManager.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ButtonCreateTableTypeManager.FlatAppearance.BorderSize = 0;
            this.ButtonCreateTableTypeManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreateTableTypeManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCreateTableTypeManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonCreateTableTypeManager.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonCreateTableTypeManager.IconColor = System.Drawing.Color.Black;
            this.ButtonCreateTableTypeManager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonCreateTableTypeManager.Location = new System.Drawing.Point(290, 124);
            this.ButtonCreateTableTypeManager.Name = "ButtonCreateTableTypeManager";
            this.ButtonCreateTableTypeManager.Size = new System.Drawing.Size(262, 54);
            this.ButtonCreateTableTypeManager.TabIndex = 52;
            this.ButtonCreateTableTypeManager.Text = "Create Table Type";
            this.ButtonCreateTableTypeManager.UseVisualStyleBackColor = false;
            this.ButtonCreateTableTypeManager.Click += new System.EventHandler(this.ButtonCreateTableTypeManager_Click);
            // 
            // textBoxTablePrice
            // 
            this.textBoxTablePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTablePrice.Location = new System.Drawing.Point(291, 91);
            this.textBoxTablePrice.Name = "textBoxTablePrice";
            this.textBoxTablePrice.Size = new System.Drawing.Size(262, 20);
            this.textBoxTablePrice.TabIndex = 46;
            this.textBoxTablePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTablePrice_KeyDown);
            this.textBoxTablePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTablePrice_KeyPress);
            // 
            // textBoxTableName
            // 
            this.textBoxTableName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTableName.Location = new System.Drawing.Point(291, 58);
            this.textBoxTableName.Name = "textBoxTableName";
            this.textBoxTableName.Size = new System.Drawing.Size(262, 20);
            this.textBoxTableName.TabIndex = 45;
            this.textBoxTableName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTableName_KeyDown);
            // 
            // TableNameLabel
            // 
            this.TableNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableNameLabel.AutoSize = true;
            this.TableNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.TableNameLabel.Location = new System.Drawing.Point(56, 54);
            this.TableNameLabel.Name = "TableNameLabel";
            this.TableNameLabel.Size = new System.Drawing.Size(177, 24);
            this.TableNameLabel.TabIndex = 39;
            this.TableNameLabel.Text = "Table Type Name";
            // 
            // TablePriceLabel
            // 
            this.TablePriceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TablePriceLabel.AutoSize = true;
            this.TablePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablePriceLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.TablePriceLabel.Location = new System.Drawing.Point(56, 87);
            this.TablePriceLabel.Name = "TablePriceLabel";
            this.TablePriceLabel.Size = new System.Drawing.Size(170, 24);
            this.TablePriceLabel.TabIndex = 40;
            this.TablePriceLabel.Text = "Table Type Price";
            // 
            // dataGridViewTableTypeInfo
            // 
            this.dataGridViewTableTypeInfo.AllowUserToAddRows = false;
            this.dataGridViewTableTypeInfo.AllowUserToResizeRows = false;
            this.dataGridViewTableTypeInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTableTypeInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTableTypeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTableTypeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTableTypeInfo.Location = new System.Drawing.Point(0, 273);
            this.dataGridViewTableTypeInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTableTypeInfo.Name = "dataGridViewTableTypeInfo";
            this.dataGridViewTableTypeInfo.RowHeadersWidth = 51;
            this.dataGridViewTableTypeInfo.RowTemplate.Height = 24;
            this.dataGridViewTableTypeInfo.Size = new System.Drawing.Size(608, 14);
            this.dataGridViewTableTypeInfo.TabIndex = 11;
            this.dataGridViewTableTypeInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTableTypeInfo_CellContentClick);
            this.dataGridViewTableTypeInfo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTableTypeInfo_CellContentClick);
            this.dataGridViewTableTypeInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTableTypeInfo_CellContentClick);
            // 
            // TableTypeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(608, 287);
            this.Controls.Add(this.dataGridViewTableTypeInfo);
            this.Controls.Add(this.panelSearchContainer);
            this.Controls.Add(this.panelLoginContentContainerChild);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TableTypeManager";
            this.Text = "TablesManager";
            this.panelSearchContainer.ResumeLayout(false);
            this.panelSearchContainer.PerformLayout();
            this.panelLoginContentContainerChild.ResumeLayout(false);
            this.panelLoginContentContainerChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableTypeInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSearchContainer;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panelLoginContentContainerChild;
        private FontAwesome.Sharp.IconButton ButtonDeleteTableTypeManager;
        private FontAwesome.Sharp.IconButton ButtonUpdateTableTypeManager;
        private FontAwesome.Sharp.IconButton ButtonCreateTableTypeManager;
        private System.Windows.Forms.TextBox textBoxTablePrice;
        private System.Windows.Forms.TextBox textBoxTableName;
        private System.Windows.Forms.Label TableNameLabel;
        private System.Windows.Forms.Label TablePriceLabel;
        private System.Windows.Forms.DataGridView dataGridViewTableTypeInfo;
    }
}