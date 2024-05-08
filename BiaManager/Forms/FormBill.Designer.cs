namespace BiaManager.Forms
{
    partial class FormBill
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonCancelBill = new FontAwesome.Sharp.IconButton();
            this.iconButtonPay = new FontAwesome.Sharp.IconButton();
            this.timerMinimize = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanelTopControl = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.iconButtonMinimize = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.flowLayoutPanelTopControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.dataGridViewBill);
            this.panel1.Controls.Add(this.flowLayoutPanelTopControl);
            this.panel1.Controls.Add(this.iconButtonCancelBill);
            this.panel1.Controls.Add(this.iconButtonPay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 608);
            this.panel1.TabIndex = 0;
            // 
            // iconButtonCancelBill
            // 
            this.iconButtonCancelBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonCancelBill.AutoSize = true;
            this.iconButtonCancelBill.BackColor = System.Drawing.Color.DarkRed;
            this.iconButtonCancelBill.FlatAppearance.BorderSize = 0;
            this.iconButtonCancelBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCancelBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonCancelBill.IconChar = FontAwesome.Sharp.IconChar.FileCircleMinus;
            this.iconButtonCancelBill.IconColor = System.Drawing.Color.Gold;
            this.iconButtonCancelBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCancelBill.IconSize = 30;
            this.iconButtonCancelBill.Location = new System.Drawing.Point(154, 516);
            this.iconButtonCancelBill.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonCancelBill.Name = "iconButtonCancelBill";
            this.iconButtonCancelBill.Size = new System.Drawing.Size(133, 61);
            this.iconButtonCancelBill.TabIndex = 8;
            this.iconButtonCancelBill.Text = "Cancel bill";
            this.iconButtonCancelBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCancelBill.UseVisualStyleBackColor = false;
            // 
            // iconButtonPay
            // 
            this.iconButtonPay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonPay.AutoSize = true;
            this.iconButtonPay.BackColor = System.Drawing.Color.SeaGreen;
            this.iconButtonPay.FlatAppearance.BorderSize = 0;
            this.iconButtonPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButtonPay.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.iconButtonPay.IconColor = System.Drawing.Color.Gold;
            this.iconButtonPay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonPay.IconSize = 30;
            this.iconButtonPay.Location = new System.Drawing.Point(9, 516);
            this.iconButtonPay.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonPay.Name = "iconButtonPay";
            this.iconButtonPay.Size = new System.Drawing.Size(133, 61);
            this.iconButtonPay.TabIndex = 7;
            this.iconButtonPay.Text = "Pay now";
            this.iconButtonPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonPay.UseVisualStyleBackColor = false;
            // 
            // timerMinimize
            // 
            this.timerMinimize.Interval = 10;
            this.timerMinimize.Tick += new System.EventHandler(this.timerMinimize_Tick);
            // 
            // flowLayoutPanelTopControl
            // 
            this.flowLayoutPanelTopControl.Controls.Add(this.iconButtonClose);
            this.flowLayoutPanelTopControl.Controls.Add(this.iconButtonMinimize);
            this.flowLayoutPanelTopControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelTopControl.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelTopControl.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTopControl.Name = "flowLayoutPanelTopControl";
            this.flowLayoutPanelTopControl.Size = new System.Drawing.Size(307, 35);
            this.flowLayoutPanelTopControl.TabIndex = 10;
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.AllowUserToAddRows = false;
            this.dataGridViewBill.AllowUserToDeleteRows = false;
            this.dataGridViewBill.AllowUserToResizeColumns = false;
            this.dataGridViewBill.AllowUserToResizeRows = false;
            this.dataGridViewBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewBill.Location = new System.Drawing.Point(0, 35);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.Size = new System.Drawing.Size(307, 460);
            this.dataGridViewBill.TabIndex = 11;
            // 
            // iconButtonClose
            // 
            this.iconButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButtonClose.FlatAppearance.BorderSize = 0;
            this.iconButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconButtonClose.IconColor = System.Drawing.Color.White;
            this.iconButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonClose.IconSize = 20;
            this.iconButtonClose.Location = new System.Drawing.Point(258, 3);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(46, 35);
            this.iconButtonClose.TabIndex = 0;
            this.iconButtonClose.UseVisualStyleBackColor = true;
            this.iconButtonClose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // iconButtonMinimize
            // 
            this.iconButtonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconButtonMinimize.FlatAppearance.BorderSize = 0;
            this.iconButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconButtonMinimize.IconColor = System.Drawing.Color.White;
            this.iconButtonMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonMinimize.IconSize = 20;
            this.iconButtonMinimize.Location = new System.Drawing.Point(206, 3);
            this.iconButtonMinimize.Name = "iconButtonMinimize";
            this.iconButtonMinimize.Size = new System.Drawing.Size(46, 35);
            this.iconButtonMinimize.TabIndex = 2;
            this.iconButtonMinimize.UseVisualStyleBackColor = true;
            this.iconButtonMinimize.Click += new System.EventHandler(this.iconButtonMinimize_Click);
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(307, 608);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "FormBill";
            this.Text = "FormBill";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanelTopControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonCancelBill;
        private FontAwesome.Sharp.IconButton iconButtonPay;
        private System.Windows.Forms.Timer timerMinimize;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTopControl;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private FontAwesome.Sharp.IconButton iconButtonMinimize;
    }
}