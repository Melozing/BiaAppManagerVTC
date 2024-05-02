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
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableEmptyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabControlTable = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPageTables = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanelTableContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroContextMenuTables.SuspendLayout();
            this.metroTabControlTable.SuspendLayout();
            this.metroTabPageTables.SuspendLayout();
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
            this.metroContextMenuTables.Size = new System.Drawing.Size(167, 82);
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
            // metroTabControlTable
            // 
            this.metroTabControlTable.Controls.Add(this.metroTabPageTables);
            this.metroTabControlTable.Controls.Add(this.metroTabPage2);
            this.metroTabControlTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControlTable.Location = new System.Drawing.Point(20, 60);
            this.metroTabControlTable.Name = "metroTabControlTable";
            this.metroTabControlTable.SelectedIndex = 0;
            this.metroTabControlTable.Size = new System.Drawing.Size(1257, 672);
            this.metroTabControlTable.TabIndex = 2;
            this.metroTabControlTable.UseSelectable = true;
            // 
            // metroTabPageTables
            // 
            this.metroTabPageTables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroTabPageTables.Controls.Add(this.flowLayoutPanelTableContainer);
            this.metroTabPageTables.HorizontalScrollbarBarColor = true;
            this.metroTabPageTables.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPageTables.HorizontalScrollbarSize = 10;
            this.metroTabPageTables.Location = new System.Drawing.Point(4, 38);
            this.metroTabPageTables.Name = "metroTabPageTables";
            this.metroTabPageTables.Size = new System.Drawing.Size(1249, 630);
            this.metroTabPageTables.TabIndex = 0;
            this.metroTabPageTables.Text = "Area 1";
            this.metroTabPageTables.VerticalScrollbarBarColor = true;
            this.metroTabPageTables.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPageTables.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanelTableContainer
            // 
            this.flowLayoutPanelTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTableContainer.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTableContainer.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelTableContainer.Name = "flowLayoutPanelTableContainer";
            this.flowLayoutPanelTableContainer.Size = new System.Drawing.Size(1247, 628);
            this.flowLayoutPanelTableContainer.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1249, 660);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Area 2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // FormTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1297, 752);
            this.ControlBox = false;
            this.Controls.Add(this.metroTabControlTable);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //this.Movable = false;
            this.Name = "FormTables";
            //this.Resizable = false;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.metroContextMenuTables.ResumeLayout(false);
            this.metroTabControlTable.ResumeLayout(false);
            this.metroTabPageTables.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroTabControl metroTabControlTable;
        private MetroFramework.Controls.MetroTabPage metroTabPageTables;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTableContainer;
    }
}