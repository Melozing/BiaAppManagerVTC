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
            this.metroContextMenuTables = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanelTableContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelTables = new System.Windows.Forms.FlowLayoutPanel();
            this.table_item1 = new BiaManager.Forms.item.table_item();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableEmptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.table_item2 = new BiaManager.Forms.item.table_item();
            this.metroContextMenuTables.SuspendLayout();
            this.flowLayoutPanelTables.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroContextMenuTables
            // 
            this.metroContextMenuTables.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroContextMenuTables.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.metroContextMenuTables.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkToolStripMenuItem,
            this.addTablesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.metroContextMenuTables.Name = "metroContextMenu1";
            this.metroContextMenuTables.Size = new System.Drawing.Size(147, 82);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(0, 0);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(200, 100);
            this.metroTabPage2.TabIndex = 0;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanelTableContainer
            // 
            this.flowLayoutPanelTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTableContainer.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTableContainer.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelTableContainer.Name = "flowLayoutPanelTableContainer";
            this.flowLayoutPanelTableContainer.Size = new System.Drawing.Size(963, 570);
            this.flowLayoutPanelTableContainer.TabIndex = 2;
            // 
            // flowLayoutPanelTables
            // 
            this.flowLayoutPanelTables.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanelTables.Controls.Add(this.table_item1);
            this.flowLayoutPanelTables.Controls.Add(this.table_item2);
            this.flowLayoutPanelTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTables.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTables.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelTables.Name = "flowLayoutPanelTables";
            this.flowLayoutPanelTables.Size = new System.Drawing.Size(973, 611);
            this.flowLayoutPanelTables.TabIndex = 1;
            // 
            // table_item1
            // 
            this.table_item1.BackColor = System.Drawing.Color.Transparent;
            this.table_item1.Location = new System.Drawing.Point(2, 2);
            this.table_item1.Margin = new System.Windows.Forms.Padding(2);
            this.table_item1.Name = "table_item1";
            this.table_item1.Size = new System.Drawing.Size(150, 162);
            this.table_item1.TabIndex = 0;
            this.table_item1.TableStatus = null;
            this.table_item1.UseSelectable = true;
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.Image = global::BiaManager.Properties.Resources.Add;
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
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
            this.addTablesToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.addTablesToolStripMenuItem.Text = "Check Tables";
            this.addTablesToolStripMenuItem.Click += new System.EventHandler(this.CheckTableToolStripMenuItem_Click);
            // 
            // tableEmptyToolStripMenuItem
            // 
            this.tableEmptyToolStripMenuItem.Image = global::BiaManager.Properties.Resources.Billiard_Ball;
            this.tableEmptyToolStripMenuItem.Name = "tableEmptyToolStripMenuItem";
            this.tableEmptyToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.tableEmptyToolStripMenuItem.Text = "Empty";
            // 
            // playingToolStripMenuItem
            // 
            this.playingToolStripMenuItem.Image = global::BiaManager.Properties.Resources.Online;
            this.playingToolStripMenuItem.Name = "playingToolStripMenuItem";
            this.playingToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.playingToolStripMenuItem.Text = "Playing";
            // 
            // repairToolStripMenuItem
            // 
            this.repairToolStripMenuItem.Image = global::BiaManager.Properties.Resources.Maintenance;
            this.repairToolStripMenuItem.Name = "repairToolStripMenuItem";
            this.repairToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.repairToolStripMenuItem.Text = "Repair";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::BiaManager.Properties.Resources.Exit_Sign;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // table_item2
            // 
            this.table_item2.BackColor = System.Drawing.Color.Transparent;
            this.table_item2.Location = new System.Drawing.Point(156, 2);
            this.table_item2.Margin = new System.Windows.Forms.Padding(2);
            this.table_item2.Name = "table_item2";
            this.table_item2.Size = new System.Drawing.Size(150, 162);
            this.table_item2.TabIndex = 1;
            this.table_item2.TableStatus = null;
            this.table_item2.UseSelectable = true;
            // 
            // FormTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(973, 611);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanelTables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTables";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.FormTables_Load);
            this.metroContextMenuTables.ResumeLayout(false);
            this.flowLayoutPanelTables.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroContextMenu metroContextMenuTables;
        private System.Windows.Forms.ToolStripMenuItem addTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableEmptyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repairToolStripMenuItem;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTableContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTables;
        private item.table_item table_item1;
        private item.table_item table_item2;
    }
}