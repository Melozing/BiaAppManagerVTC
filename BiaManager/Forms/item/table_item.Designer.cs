namespace BiaManager.Forms.item
{
    partial class table_item
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
            this.components = new System.ComponentModel.Container();
            this.pnel_Number_Table = new System.Windows.Forms.Panel();
            this.statusPic = new System.Windows.Forms.PictureBox();
            this.table_name = new System.Windows.Forms.Label();
            this.pnel_Table_Main = new System.Windows.Forms.Panel();
            this.StartTable = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pic_table = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.pnel_Number_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusPic)).BeginInit();
            this.pnel_Table_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_table)).BeginInit();
            this.SuspendLayout();
            // 
            // pnel_Number_Table
            // 
            this.pnel_Number_Table.BackColor = System.Drawing.Color.White;
            this.pnel_Number_Table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnel_Number_Table.Controls.Add(this.statusPic);
            this.pnel_Number_Table.Controls.Add(this.table_name);
            this.pnel_Number_Table.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnel_Number_Table.Location = new System.Drawing.Point(0, 0);
            this.pnel_Number_Table.Margin = new System.Windows.Forms.Padding(2);
            this.pnel_Number_Table.Name = "pnel_Number_Table";
            this.pnel_Number_Table.Size = new System.Drawing.Size(150, 32);
            this.pnel_Number_Table.TabIndex = 0;
            // 
            // statusPic
            // 
            this.statusPic.Image = global::BiaManager.Properties.Resources.Status_Empty;
            this.statusPic.Location = new System.Drawing.Point(121, 4);
            this.statusPic.Name = "statusPic";
            this.statusPic.Size = new System.Drawing.Size(24, 21);
            this.statusPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.statusPic.TabIndex = 1;
            this.statusPic.TabStop = false;
            // 
            // table_name
            // 
            this.table_name.AutoSize = true;
            this.table_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.table_name.Location = new System.Drawing.Point(19, 3);
            this.table_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.table_name.Name = "table_name";
            this.table_name.Size = new System.Drawing.Size(80, 24);
            this.table_name.TabIndex = 0;
            this.table_name.Text = "Table 1";
            // 
            // pnel_Table_Main
            // 
            this.pnel_Table_Main.BackColor = System.Drawing.Color.White;
            this.pnel_Table_Main.Controls.Add(this.StartTable);
            this.pnel_Table_Main.Controls.Add(this.iconButton1);
            this.pnel_Table_Main.Controls.Add(this.pic_table);
            this.pnel_Table_Main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnel_Table_Main.Location = new System.Drawing.Point(0, 31);
            this.pnel_Table_Main.Margin = new System.Windows.Forms.Padding(2);
            this.pnel_Table_Main.Name = "pnel_Table_Main";
            this.pnel_Table_Main.Size = new System.Drawing.Size(150, 131);
            this.pnel_Table_Main.TabIndex = 1;
            // 
            // StartTable
            // 
            this.StartTable.BackColor = System.Drawing.Color.ForestGreen;
            this.StartTable.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.StartTable.FlatAppearance.BorderSize = 0;
            this.StartTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chartreuse;
            this.StartTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.StartTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StartTable.IconChar = FontAwesome.Sharp.IconChar.None;
            this.StartTable.IconColor = System.Drawing.Color.Black;
            this.StartTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.StartTable.Location = new System.Drawing.Point(34, 94);
            this.StartTable.Name = "StartTable";
            this.StartTable.Size = new System.Drawing.Size(84, 35);
            this.StartTable.TabIndex = 2;
            this.StartTable.Text = "Start";
            this.StartTable.UseVisualStyleBackColor = false;
            this.StartTable.Click += new System.EventHandler(this.StartTable_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chartreuse;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(34, 94);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(84, 35);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Oder";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pic_table
            // 
            this.pic_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_table.Image = global::BiaManager.Properties.Resources.caromBilliardsplay;
            this.pic_table.Location = new System.Drawing.Point(0, 0);
            this.pic_table.Margin = new System.Windows.Forms.Padding(2);
            this.pic_table.Name = "pic_table";
            this.pic_table.Size = new System.Drawing.Size(150, 89);
            this.pic_table.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_table.TabIndex = 0;
            this.pic_table.TabStop = false;
            this.pic_table.MouseLeave += new System.EventHandler(this.pic_table_MouseLeave);
            this.pic_table.MouseHover += new System.EventHandler(this.pic_table_MouseHover);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 9;
            this.guna2Elipse1.TargetControl = this;
            // 
            // iconDropDownButton1
            // 
            this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton1.Name = "iconDropDownButton1";
            this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // table_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnel_Table_Main);
            this.Controls.Add(this.pnel_Number_Table);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "table_item";
            this.Size = new System.Drawing.Size(150, 162);
            this.pnel_Number_Table.ResumeLayout(false);
            this.pnel_Number_Table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusPic)).EndInit();
            this.pnel_Table_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnel_Number_Table;
        private System.Windows.Forms.Label table_name;
        private System.Windows.Forms.Panel pnel_Table_Main;
        private System.Windows.Forms.PictureBox pic_table;
        private FontAwesome.Sharp.IconButton StartTable;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.PictureBox statusPic;
        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}
