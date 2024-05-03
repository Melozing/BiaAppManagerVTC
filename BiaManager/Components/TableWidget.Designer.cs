namespace BiaManager.Components
{
    partial class TableWidget
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableWidget));
            this.PanelTableMain = new System.Windows.Forms.Panel();
            this.IconButtonStartTable = new FontAwesome.Sharp.IconButton();
            this.IconButtonOrder = new FontAwesome.Sharp.IconButton();
            this.PictureBoxTable = new System.Windows.Forms.PictureBox();
            this.PanelTableName = new System.Windows.Forms.Panel();
            this.LabelTableName = new System.Windows.Forms.Label();
            this.pictureBoxStatus = new System.Windows.Forms.PictureBox();
            this.PanelTableMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTable)).BeginInit();
            this.PanelTableName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTableMain
            // 
            this.PanelTableMain.BackColor = System.Drawing.Color.IndianRed;
            this.PanelTableMain.Controls.Add(this.IconButtonStartTable);
            this.PanelTableMain.Controls.Add(this.IconButtonOrder);
            this.PanelTableMain.Controls.Add(this.PictureBoxTable);
            this.PanelTableMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTableMain.Location = new System.Drawing.Point(0, 32);
            this.PanelTableMain.Margin = new System.Windows.Forms.Padding(2);
            this.PanelTableMain.Name = "PanelTableMain";
            this.PanelTableMain.Size = new System.Drawing.Size(150, 118);
            this.PanelTableMain.TabIndex = 3;
            this.PanelTableMain.Click += new System.EventHandler(this.PanelTableMain_Click);
            // 
            // IconButtonStartTable
            // 
            this.IconButtonStartTable.BackColor = System.Drawing.Color.ForestGreen;
            this.IconButtonStartTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IconButtonStartTable.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.IconButtonStartTable.FlatAppearance.BorderSize = 0;
            this.IconButtonStartTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.IconButtonStartTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.IconButtonStartTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconButtonStartTable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IconButtonStartTable.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IconButtonStartTable.IconColor = System.Drawing.Color.Black;
            this.IconButtonStartTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconButtonStartTable.Location = new System.Drawing.Point(0, 89);
            this.IconButtonStartTable.Name = "IconButtonStartTable";
            this.IconButtonStartTable.Size = new System.Drawing.Size(150, 29);
            this.IconButtonStartTable.TabIndex = 2;
            this.IconButtonStartTable.Text = "Start";
            this.IconButtonStartTable.UseVisualStyleBackColor = false;
            this.IconButtonStartTable.Click += new System.EventHandler(this.IconButtonStartTable_Click);
            // 
            // IconButtonOrder
            // 
            this.IconButtonOrder.BackColor = System.Drawing.Color.SeaGreen;
            this.IconButtonOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IconButtonOrder.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.IconButtonOrder.FlatAppearance.BorderSize = 0;
            this.IconButtonOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chartreuse;
            this.IconButtonOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.IconButtonOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconButtonOrder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IconButtonOrder.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IconButtonOrder.IconColor = System.Drawing.Color.Black;
            this.IconButtonOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconButtonOrder.Location = new System.Drawing.Point(0, 89);
            this.IconButtonOrder.Name = "IconButtonOrder";
            this.IconButtonOrder.Size = new System.Drawing.Size(150, 29);
            this.IconButtonOrder.TabIndex = 1;
            this.IconButtonOrder.Text = "Oder";
            this.IconButtonOrder.UseVisualStyleBackColor = false;
            this.IconButtonOrder.Click += new System.EventHandler(this.IconButtonOrder_Click);
            // 
            // PictureBoxTable
            // 
            this.PictureBoxTable.BackColor = System.Drawing.Color.IndianRed;
            this.PictureBoxTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.PictureBoxTable.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxTable.Image")));
            this.PictureBoxTable.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxTable.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBoxTable.Name = "PictureBoxTable";
            this.PictureBoxTable.Size = new System.Drawing.Size(150, 89);
            this.PictureBoxTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxTable.TabIndex = 0;
            this.PictureBoxTable.TabStop = false;
            this.PictureBoxTable.Click += new System.EventHandler(this.PictureBoxTable_Click);
            // 
            // PanelTableName
            // 
            this.PanelTableName.BackColor = System.Drawing.Color.DarkGreen;
            this.PanelTableName.Controls.Add(this.pictureBoxStatus);
            this.PanelTableName.Controls.Add(this.LabelTableName);
            this.PanelTableName.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTableName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelTableName.Location = new System.Drawing.Point(0, 0);
            this.PanelTableName.Margin = new System.Windows.Forms.Padding(2);
            this.PanelTableName.Name = "PanelTableName";
            this.PanelTableName.Size = new System.Drawing.Size(150, 32);
            this.PanelTableName.TabIndex = 2;
            this.PanelTableName.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTableName_Paint);
            // 
            // LabelTableName
            // 
            this.LabelTableName.AutoSize = true;
            this.LabelTableName.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelTableName.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.LabelTableName.Location = new System.Drawing.Point(0, 0);
            this.LabelTableName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTableName.Name = "LabelTableName";
            this.LabelTableName.Size = new System.Drawing.Size(88, 24);
            this.LabelTableName.TabIndex = 0;
            this.LabelTableName.Text = "Table 1";
            // 
            // pictureBoxStatus
            // 
            this.pictureBoxStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxStatus.Image = global::BiaManager.Properties.Resources.Status_Empty;
            this.pictureBoxStatus.Location = new System.Drawing.Point(118, 0);
            this.pictureBoxStatus.Name = "pictureBoxStatus";
            this.pictureBoxStatus.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStatus.TabIndex = 1;
            this.pictureBoxStatus.TabStop = false;
            // 
            // TableWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelTableMain);
            this.Controls.Add(this.PanelTableName);
            this.Name = "TableWidget";
            this.Click += new System.EventHandler(this.TableWidget_Click);
            this.DoubleClick += new System.EventHandler(this.TableWidget_DoubleClick);
            this.PanelTableMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTable)).EndInit();
            this.PanelTableName.ResumeLayout(false);
            this.PanelTableName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTableMain;
        private FontAwesome.Sharp.IconButton IconButtonStartTable;
        private FontAwesome.Sharp.IconButton IconButtonOrder;
        private System.Windows.Forms.PictureBox PictureBoxTable;
        private System.Windows.Forms.Panel PanelTableName;
        private System.Windows.Forms.Label LabelTableName;
        private System.Windows.Forms.PictureBox pictureBoxStatus;
    }
}
