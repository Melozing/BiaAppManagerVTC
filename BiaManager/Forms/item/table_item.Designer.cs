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
            this.pnel_Number_Table = new System.Windows.Forms.Panel();
            this.pnel_Table_Main = new System.Windows.Forms.Panel();
            this.table_name = new System.Windows.Forms.Label();
            this.pic_status = new System.Windows.Forms.PictureBox();
            this.pic_table = new System.Windows.Forms.PictureBox();
            this.Btn_Click_Table = new MetroFramework.Controls.MetroButton();
            this.pnel_Number_Table.SuspendLayout();
            this.pnel_Table_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_table)).BeginInit();
            this.SuspendLayout();
            // 
            // pnel_Number_Table
            // 
            this.pnel_Number_Table.BackColor = System.Drawing.Color.Cornsilk;
            this.pnel_Number_Table.Controls.Add(this.pic_status);
            this.pnel_Number_Table.Controls.Add(this.table_name);
            this.pnel_Number_Table.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnel_Number_Table.Location = new System.Drawing.Point(0, 0);
            this.pnel_Number_Table.Name = "pnel_Number_Table";
            this.pnel_Number_Table.Size = new System.Drawing.Size(200, 40);
            this.pnel_Number_Table.TabIndex = 0;
            // 
            // pnel_Table_Main
            // 
            this.pnel_Table_Main.Controls.Add(this.Btn_Click_Table);
            this.pnel_Table_Main.Controls.Add(this.pic_table);
            this.pnel_Table_Main.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnel_Table_Main.Location = new System.Drawing.Point(0, 37);
            this.pnel_Table_Main.Name = "pnel_Table_Main";
            this.pnel_Table_Main.Size = new System.Drawing.Size(200, 163);
            this.pnel_Table_Main.TabIndex = 1;
            // 
            // table_name
            // 
            this.table_name.AutoSize = true;
            this.table_name.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.table_name.Location = new System.Drawing.Point(40, 5);
            this.table_name.Name = "table_name";
            this.table_name.Size = new System.Drawing.Size(107, 29);
            this.table_name.TabIndex = 0;
            this.table_name.Text = "Table 1";
            // 
            // pic_status
            // 
            this.pic_status.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_status.Image = global::BiaManager.Properties.Resources.Status_Empty;
            this.pic_status.Location = new System.Drawing.Point(164, 0);
            this.pic_status.Name = "pic_status";
            this.pic_status.Size = new System.Drawing.Size(36, 40);
            this.pic_status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_status.TabIndex = 1;
            this.pic_status.TabStop = false;
            this.pic_status.MouseHover += new System.EventHandler(this.PicBoxStatus_MouseHover);
            // 
            // pic_table
            // 
            this.pic_table.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_table.Image = global::BiaManager.Properties.Resources.bida1;
            this.pic_table.Location = new System.Drawing.Point(0, 0);
            this.pic_table.Name = "pic_table";
            this.pic_table.Size = new System.Drawing.Size(200, 110);
            this.pic_table.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_table.TabIndex = 0;
            this.pic_table.TabStop = false;
            // 
            // Btn_Click_Table
            // 
            this.Btn_Click_Table.Location = new System.Drawing.Point(45, 116);
            this.Btn_Click_Table.Name = "Btn_Click_Table";
            this.Btn_Click_Table.Size = new System.Drawing.Size(102, 43);
            this.Btn_Click_Table.TabIndex = 1;
            this.Btn_Click_Table.Text = "Order";
            this.Btn_Click_Table.UseSelectable = true;
            this.Btn_Click_Table.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // table_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnel_Table_Main);
            this.Controls.Add(this.pnel_Number_Table);
            this.Name = "table_item";
            this.Size = new System.Drawing.Size(200, 200);
            this.pnel_Number_Table.ResumeLayout(false);
            this.pnel_Number_Table.PerformLayout();
            this.pnel_Table_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnel_Number_Table;
        private System.Windows.Forms.PictureBox pic_status;
        private System.Windows.Forms.Label table_name;
        private System.Windows.Forms.Panel pnel_Table_Main;
        private MetroFramework.Controls.MetroButton Btn_Click_Table;
        private System.Windows.Forms.PictureBox pic_table;
    }
}
