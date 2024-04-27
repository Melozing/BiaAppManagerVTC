namespace BiaManager.Forms
{
    partial class FormTables
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
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableEmptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.table_item1 = new BiaManager.Forms.item.table_item();
            this.table_item2 = new BiaManager.Forms.item.table_item();
            this.table_item3 = new BiaManager.Forms.item.table_item();
            this.table_item4 = new BiaManager.Forms.item.table_item();
            this.metroContextMenu1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroContextMenu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkToolStripMenuItem,
            this.addTablesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(167, 82);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.Image = global::BiaManager.Properties.Resources.Add;
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.checkToolStripMenuItem.Text = "Add Table";
            this.checkToolStripMenuItem.Click += new System.EventHandler(this.AddTableToolStripMenuItem_Click);
            // 
            // addTablesToolStripMenuItem
            // 
            this.addTablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableEmptyToolStripMenuItem,
            this.playingToolStripMenuItem,
            this.repairToolStripMenuItem});
            this.addTablesToolStripMenuItem.Image = global::BiaManager.Properties.Resources.Check_Mark;
            this.addTablesToolStripMenuItem.Name = "addTablesToolStripMenuItem";
            this.addTablesToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.addTablesToolStripMenuItem.Text = "Check Tables";
            this.addTablesToolStripMenuItem.Click += new System.EventHandler(this.CheckTableToolStripMenuItem_Click);
            // 
            // tableEmptyToolStripMenuItem
            // 
            this.tableEmptyToolStripMenuItem.Image = global::BiaManager.Properties.Resources.Billiard_Ball;
            this.tableEmptyToolStripMenuItem.Name = "tableEmptyToolStripMenuItem";
            this.tableEmptyToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.tableEmptyToolStripMenuItem.Text = "Empty";
            // 
            // playingToolStripMenuItem
            // 
            this.playingToolStripMenuItem.Image = global::BiaManager.Properties.Resources.Online;
            this.playingToolStripMenuItem.Name = "playingToolStripMenuItem";
            this.playingToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.playingToolStripMenuItem.Text = "Playing";
            // 
            // repairToolStripMenuItem
            // 
            this.repairToolStripMenuItem.Image = global::BiaManager.Properties.Resources.Maintenance;
            this.repairToolStripMenuItem.Name = "repairToolStripMenuItem";
            this.repairToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.repairToolStripMenuItem.Text = "Repair";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::BiaManager.Properties.Resources.Exit_Sign;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 30);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1257, 702);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPage1.Controls.Add(this.flowLayoutPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1249, 660);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Area 1";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.table_item1);
            this.flowLayoutPanel1.Controls.Add(this.table_item2);
            this.flowLayoutPanel1.Controls.Add(this.table_item3);
            this.flowLayoutPanel1.Controls.Add(this.table_item4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1247, 658);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1107, 377);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Area 2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // table_item1
            // 
            this.table_item1.Location = new System.Drawing.Point(3, 3);
            this.table_item1.Name = "table_item1";
            this.table_item1.Size = new System.Drawing.Size(200, 200);
            this.table_item1.TabIndex = 3;
            this.table_item1.TableStatus = null;
            this.table_item1.UseSelectable = true;
            // 
            // table_item2
            // 
            this.table_item2.Location = new System.Drawing.Point(209, 3);
            this.table_item2.Name = "table_item2";
            this.table_item2.Size = new System.Drawing.Size(200, 200);
            this.table_item2.TabIndex = 4;
            this.table_item2.TableStatus = null;
            this.table_item2.UseSelectable = true;
            // 
            // table_item3
            // 
            this.table_item3.Location = new System.Drawing.Point(415, 3);
            this.table_item3.Name = "table_item3";
            this.table_item3.Size = new System.Drawing.Size(200, 200);
            this.table_item3.TabIndex = 5;
            this.table_item3.TableStatus = null;
            this.table_item3.UseSelectable = true;
            // 
            // table_item4
            // 
            this.table_item4.Location = new System.Drawing.Point(621, 3);
            this.table_item4.Name = "table_item4";
            this.table_item4.Size = new System.Drawing.Size(200, 200);
            this.table_item4.TabIndex = 6;
            this.table_item4.TableStatus = null;
            this.table_item4.UseSelectable = true;
            // 
            // FormTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 752);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControl1);
            this.DisplayHeader = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FormTables";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.metroContextMenu1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem addTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableEmptyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairToolStripMenuItem;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private item.table_item table_item1;
        private item.table_item table_item2;
        private item.table_item table_item3;
        private item.table_item table_item4;
    }
}