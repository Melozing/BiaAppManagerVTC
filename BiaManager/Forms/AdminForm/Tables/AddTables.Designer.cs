namespace BiaManager.Forms.AdminForm.Tables
{
    partial class AddTables
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
            this.comboBoxTableType = new System.Windows.Forms.ComboBox();
            this.ButtonDelete = new FontAwesome.Sharp.IconButton();
            this.ButtonUpdate = new FontAwesome.Sharp.IconButton();
            this.ButtonCreate = new FontAwesome.Sharp.IconButton();
            this.textBoxTableName = new System.Windows.Forms.TextBox();
            this.TableNameLabel = new System.Windows.Forms.Label();
            this.TableTypeLabel = new System.Windows.Forms.Label();
            this.dataGridViewTablesAdd = new System.Windows.Forms.DataGridView();
            this.panelSearchContainer.SuspendLayout();
            this.panelLoginContentContainerChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablesAdd)).BeginInit();
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
            this.panelSearchContainer.Size = new System.Drawing.Size(800, 30);
            this.panelSearchContainer.TabIndex = 12;
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
            this.iconButtonSearch.Location = new System.Drawing.Point(542, 0);
            this.iconButtonSearch.Name = "iconButtonSearch";
            this.iconButtonSearch.Size = new System.Drawing.Size(33, 30);
            this.iconButtonSearch.TabIndex = 13;
            this.iconButtonSearch.UseVisualStyleBackColor = true;
            this.iconButtonSearch.Click += new System.EventHandler(this.iconButtonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSearch.Location = new System.Drawing.Point(273, 6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(262, 20);
            this.textBoxSearch.TabIndex = 12;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // panelLoginContentContainerChild
            // 
            this.panelLoginContentContainerChild.AutoScroll = true;
            this.panelLoginContentContainerChild.Controls.Add(this.comboBoxTableType);
            this.panelLoginContentContainerChild.Controls.Add(this.ButtonDelete);
            this.panelLoginContentContainerChild.Controls.Add(this.ButtonUpdate);
            this.panelLoginContentContainerChild.Controls.Add(this.ButtonCreate);
            this.panelLoginContentContainerChild.Controls.Add(this.textBoxTableName);
            this.panelLoginContentContainerChild.Controls.Add(this.TableNameLabel);
            this.panelLoginContentContainerChild.Controls.Add(this.TableTypeLabel);
            this.panelLoginContentContainerChild.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoginContentContainerChild.Location = new System.Drawing.Point(0, 0);
            this.panelLoginContentContainerChild.Name = "panelLoginContentContainerChild";
            this.panelLoginContentContainerChild.Size = new System.Drawing.Size(800, 243);
            this.panelLoginContentContainerChild.TabIndex = 11;
            // 
            // comboBoxTableType
            // 
            this.comboBoxTableType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxTableType.FormattingEnabled = true;
            this.comboBoxTableType.Location = new System.Drawing.Point(386, 88);
            this.comboBoxTableType.Name = "comboBoxTableType";
            this.comboBoxTableType.Size = new System.Drawing.Size(262, 21);
            this.comboBoxTableType.TabIndex = 55;
            this.comboBoxTableType.SelectedIndexChanged += new System.EventHandler(this.comboBoxTableType_SelectedIndexChanged);
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
            this.ButtonDelete.Location = new System.Drawing.Point(386, 181);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(262, 54);
            this.ButtonDelete.TabIndex = 54;
            this.ButtonDelete.Text = "Delete Table Type";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDeleteTableTypeManager_Click);
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
            this.ButtonUpdate.Location = new System.Drawing.Point(386, 124);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(262, 54);
            this.ButtonUpdate.TabIndex = 53;
            this.ButtonUpdate.Text = "Update Table Type";
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdateTableTypeManager_Click);
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
            this.ButtonCreate.Location = new System.Drawing.Point(386, 124);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(262, 54);
            this.ButtonCreate.TabIndex = 52;
            this.ButtonCreate.Text = "Create Table Type";
            this.ButtonCreate.UseVisualStyleBackColor = false;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreateTableTypeManager_Click);
            // 
            // textBoxTableName
            // 
            this.textBoxTableName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTableName.Location = new System.Drawing.Point(387, 58);
            this.textBoxTableName.Name = "textBoxTableName";
            this.textBoxTableName.Size = new System.Drawing.Size(262, 20);
            this.textBoxTableName.TabIndex = 45;
            this.textBoxTableName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTableName_KeyDown);
            this.textBoxTableName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTableName_KeyPress);
            // 
            // TableNameLabel
            // 
            this.TableNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableNameLabel.AutoSize = true;
            this.TableNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableNameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.TableNameLabel.Location = new System.Drawing.Point(152, 54);
            this.TableNameLabel.Name = "TableNameLabel";
            this.TableNameLabel.Size = new System.Drawing.Size(134, 24);
            this.TableNameLabel.TabIndex = 39;
            this.TableNameLabel.Text = "Tables Name";
            // 
            // TableTypeLabel
            // 
            this.TableTypeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TableTypeLabel.AutoSize = true;
            this.TableTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableTypeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.TableTypeLabel.Location = new System.Drawing.Point(152, 87);
            this.TableTypeLabel.Name = "TableTypeLabel";
            this.TableTypeLabel.Size = new System.Drawing.Size(116, 24);
            this.TableTypeLabel.TabIndex = 40;
            this.TableTypeLabel.Text = "Table Type";
            // 
            // dataGridViewTablesAdd
            // 
            this.dataGridViewTablesAdd.AllowUserToAddRows = false;
            this.dataGridViewTablesAdd.AllowUserToDeleteRows = false;
            this.dataGridViewTablesAdd.AllowUserToResizeRows = false;
            this.dataGridViewTablesAdd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTablesAdd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTablesAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTablesAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTablesAdd.Location = new System.Drawing.Point(0, 273);
            this.dataGridViewTablesAdd.Name = "dataGridViewTablesAdd";
            this.dataGridViewTablesAdd.Size = new System.Drawing.Size(800, 177);
            this.dataGridViewTablesAdd.TabIndex = 13;
            this.dataGridViewTablesAdd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTablesAdd_CellContentClick);
            this.dataGridViewTablesAdd.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTablesAdd_CellContentClick);
            this.dataGridViewTablesAdd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTablesAdd_CellContentClick);
            // 
            // AddTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewTablesAdd);
            this.Controls.Add(this.panelSearchContainer);
            this.Controls.Add(this.panelLoginContentContainerChild);
            this.Name = "AddTables";
            this.Text = "AddTables";
            this.Load += new System.EventHandler(this.AddTables_Load);
            this.panelSearchContainer.ResumeLayout(false);
            this.panelSearchContainer.PerformLayout();
            this.panelLoginContentContainerChild.ResumeLayout(false);
            this.panelLoginContentContainerChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTablesAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearchContainer;
        private FontAwesome.Sharp.IconButton iconButtonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panelLoginContentContainerChild;
        private FontAwesome.Sharp.IconButton ButtonDelete;
        private FontAwesome.Sharp.IconButton ButtonUpdate;
        private FontAwesome.Sharp.IconButton ButtonCreate;
        private System.Windows.Forms.TextBox textBoxTableName;
        private System.Windows.Forms.Label TableNameLabel;
        private System.Windows.Forms.Label TableTypeLabel;
        private System.Windows.Forms.ComboBox comboBoxTableType;
        private System.Windows.Forms.DataGridView dataGridViewTablesAdd;
    }
}