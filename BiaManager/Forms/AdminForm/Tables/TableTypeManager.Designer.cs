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
            this.panelSearchContainer.Location = new System.Drawing.Point(0, 465);
            this.panelSearchContainer.Margin = new System.Windows.Forms.Padding(4);
            this.panelSearchContainer.Name = "panelSearchContainer";
            this.panelSearchContainer.Size = new System.Drawing.Size(810, 37);
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
            this.iconButtonSearch.Location = new System.Drawing.Point(594, 0);
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
            this.textBoxSearch.Location = new System.Drawing.Point(236, 7);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(348, 22);
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
            this.panelLoginContentContainerChild.Margin = new System.Windows.Forms.Padding(4);
            this.panelLoginContentContainerChild.Name = "panelLoginContentContainerChild";
            this.panelLoginContentContainerChild.Size = new System.Drawing.Size(810, 465);
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
            this.ButtonDeleteTableTypeManager.Location = new System.Drawing.Point(387, 200);
            this.ButtonDeleteTableTypeManager.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonDeleteTableTypeManager.Name = "ButtonDeleteTableTypeManager";
            this.ButtonDeleteTableTypeManager.Size = new System.Drawing.Size(349, 54);
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
            this.ButtonUpdateTableTypeManager.Location = new System.Drawing.Point(387, 130);
            this.ButtonUpdateTableTypeManager.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonUpdateTableTypeManager.Name = "ButtonUpdateTableTypeManager";
            this.ButtonUpdateTableTypeManager.Size = new System.Drawing.Size(349, 54);
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
            this.ButtonCreateTableTypeManager.Location = new System.Drawing.Point(387, 130);
            this.ButtonCreateTableTypeManager.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCreateTableTypeManager.Name = "ButtonCreateTableTypeManager";
            this.ButtonCreateTableTypeManager.Size = new System.Drawing.Size(349, 54);
            this.ButtonCreateTableTypeManager.TabIndex = 52;
            this.ButtonCreateTableTypeManager.Text = "Create Table Type";
            this.ButtonCreateTableTypeManager.UseVisualStyleBackColor = false;
            this.ButtonCreateTableTypeManager.Click += new System.EventHandler(this.ButtonCreateTableTypeManager_Click);
            // 
            // textBoxTablePrice
            // 
            this.textBoxTablePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTablePrice.Location = new System.Drawing.Point(388, 89);
            this.textBoxTablePrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTablePrice.Name = "textBoxTablePrice";
            this.textBoxTablePrice.Size = new System.Drawing.Size(348, 22);
            this.textBoxTablePrice.TabIndex = 46;
            this.textBoxTablePrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTablePrice_KeyDown);
            this.textBoxTablePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTablePrice_KeyPress);
            // 
            // textBoxTableName
            // 
            this.textBoxTableName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTableName.Location = new System.Drawing.Point(388, 49);
            this.textBoxTableName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTableName.Name = "textBoxTableName";
            this.textBoxTableName.Size = new System.Drawing.Size(348, 22);
            this.textBoxTableName.TabIndex = 45;
            this.textBoxTableName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTableName_KeyDown);
            // 
            // TableNameLabel
            // 
            this.TableNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableNameLabel.AutoSize = true;
            this.TableNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.TableNameLabel.Location = new System.Drawing.Point(75, 44);
            this.TableNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TableNameLabel.Name = "TableNameLabel";
            this.TableNameLabel.Size = new System.Drawing.Size(223, 29);
            this.TableNameLabel.TabIndex = 39;
            this.TableNameLabel.Text = "Table Type Name";
            // 
            // TablePriceLabel
            // 
            this.TablePriceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TablePriceLabel.AutoSize = true;
            this.TablePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablePriceLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.TablePriceLabel.Location = new System.Drawing.Point(75, 84);
            this.TablePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TablePriceLabel.Name = "TablePriceLabel";
            this.TablePriceLabel.Size = new System.Drawing.Size(215, 29);
            this.TablePriceLabel.TabIndex = 40;
            this.TablePriceLabel.Text = "Table Type Price";
            // 
            // dataGridViewTableTypeInfo
            // 
            this.dataGridViewTableTypeInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTableTypeInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTableTypeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTableTypeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTableTypeInfo.Location = new System.Drawing.Point(0, 502);
            this.dataGridViewTableTypeInfo.Name = "dataGridViewTableTypeInfo";
            this.dataGridViewTableTypeInfo.RowHeadersWidth = 51;
            this.dataGridViewTableTypeInfo.RowTemplate.Height = 24;
            this.dataGridViewTableTypeInfo.Size = new System.Drawing.Size(810, 35);
            this.dataGridViewTableTypeInfo.TabIndex = 11;
            this.dataGridViewTableTypeInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTableTypeInfo_CellContentClick);
            // 
            // TableTypeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(810, 537);
            this.Controls.Add(this.dataGridViewTableTypeInfo);
            this.Controls.Add(this.panelSearchContainer);
            this.Controls.Add(this.panelLoginContentContainerChild);
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