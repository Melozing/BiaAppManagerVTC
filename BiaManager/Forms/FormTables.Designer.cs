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
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanelTableContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelTables = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
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
            this.flowLayoutPanelTables.AutoScroll = true;
            this.flowLayoutPanelTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.flowLayoutPanelTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelTables.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTables.Name = "flowLayoutPanelTables";
            this.flowLayoutPanelTables.Size = new System.Drawing.Size(973, 611);
            this.flowLayoutPanelTables.TabIndex = 1;
            // 
            // FormTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(973, 611);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanelTables);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTables";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.FormTables_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTableContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTables;
    }
}