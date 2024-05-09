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
            this.panelBillContainer = new System.Windows.Forms.Panel();
            this.panelTotalMoney = new System.Windows.Forms.Panel();
            this.panelTotalMoneyBill = new System.Windows.Forms.Panel();
            this.MoneyQuantity = new FontAwesome.Sharp.IconButton();
            this.panelTextTotal = new System.Windows.Forms.Panel();
            this.labelTextTotalDue = new System.Windows.Forms.Label();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.panelTittleInfo = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTableName = new System.Windows.Forms.Label();
            this.flowLayoutPanelTopControl = new System.Windows.Forms.FlowLayoutPanel();
            this.iconButtonClose = new FontAwesome.Sharp.IconButton();
            this.iconButtonMinimize = new FontAwesome.Sharp.IconButton();
            this.iconButtonCancelBill = new FontAwesome.Sharp.IconButton();
            this.iconButtonPay = new FontAwesome.Sharp.IconButton();
            this.timerMinimize = new System.Windows.Forms.Timer(this.components);
            this.panelBillContainer.SuspendLayout();
            this.panelTotalMoney.SuspendLayout();
            this.panelTotalMoneyBill.SuspendLayout();
            this.panelTextTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            this.panelTittleInfo.SuspendLayout();
            this.flowLayoutPanelTopControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBillContainer
            // 
            this.panelBillContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(85)))));
            this.panelBillContainer.Controls.Add(this.panelTotalMoney);
            this.panelBillContainer.Controls.Add(this.dataGridViewBill);
            this.panelBillContainer.Controls.Add(this.panelTittleInfo);
            this.panelBillContainer.Controls.Add(this.flowLayoutPanelTopControl);
            this.panelBillContainer.Controls.Add(this.iconButtonCancelBill);
            this.panelBillContainer.Controls.Add(this.iconButtonPay);
            this.panelBillContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBillContainer.Location = new System.Drawing.Point(0, 0);
            this.panelBillContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBillContainer.Name = "panelBillContainer";
            this.panelBillContainer.Size = new System.Drawing.Size(409, 748);
            this.panelBillContainer.TabIndex = 0;
            // 
            // panelTotalMoney
            // 
            this.panelTotalMoney.Controls.Add(this.panelTotalMoneyBill);
            this.panelTotalMoney.Controls.Add(this.panelTextTotal);
            this.panelTotalMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTotalMoney.Location = new System.Drawing.Point(0, 550);
            this.panelTotalMoney.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTotalMoney.Name = "panelTotalMoney";
            this.panelTotalMoney.Size = new System.Drawing.Size(409, 41);
            this.panelTotalMoney.TabIndex = 14;
            // 
            // panelTotalMoneyBill
            // 
            this.panelTotalMoneyBill.Controls.Add(this.MoneyQuantity);
            this.panelTotalMoneyBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTotalMoneyBill.Location = new System.Drawing.Point(139, 0);
            this.panelTotalMoneyBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTotalMoneyBill.Name = "panelTotalMoneyBill";
            this.panelTotalMoneyBill.Size = new System.Drawing.Size(270, 41);
            this.panelTotalMoneyBill.TabIndex = 16;
            // 
            // MoneyQuantity
            // 
            this.MoneyQuantity.AutoSize = true;
            this.MoneyQuantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MoneyQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MoneyQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoneyQuantity.FlatAppearance.BorderSize = 0;
            this.MoneyQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoneyQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyQuantity.ForeColor = System.Drawing.Color.Gold;
            this.MoneyQuantity.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.MoneyQuantity.IconColor = System.Drawing.Color.Gold;
            this.MoneyQuantity.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.MoneyQuantity.IconSize = 24;
            this.MoneyQuantity.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MoneyQuantity.Location = new System.Drawing.Point(0, 0);
            this.MoneyQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.MoneyQuantity.Name = "MoneyQuantity";
            this.MoneyQuantity.Size = new System.Drawing.Size(270, 41);
            this.MoneyQuantity.TabIndex = 2;
            this.MoneyQuantity.Text = "30.000";
            this.MoneyQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MoneyQuantity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MoneyQuantity.UseVisualStyleBackColor = true;
            // 
            // panelTextTotal
            // 
            this.panelTextTotal.Controls.Add(this.labelTextTotalDue);
            this.panelTextTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTextTotal.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTextTotal.Location = new System.Drawing.Point(0, 0);
            this.panelTextTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTextTotal.Name = "panelTextTotal";
            this.panelTextTotal.Size = new System.Drawing.Size(139, 41);
            this.panelTextTotal.TabIndex = 15;
            // 
            // labelTextTotalDue
            // 
            this.labelTextTotalDue.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTextTotalDue.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextTotalDue.ForeColor = System.Drawing.Color.Gold;
            this.labelTextTotalDue.Location = new System.Drawing.Point(0, 0);
            this.labelTextTotalDue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTextTotalDue.Name = "labelTextTotalDue";
            this.labelTextTotalDue.Size = new System.Drawing.Size(139, 44);
            this.labelTextTotalDue.TabIndex = 2;
            this.labelTextTotalDue.Text = "Total due :";
            this.labelTextTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.dataGridViewBill.Location = new System.Drawing.Point(0, 154);
            this.dataGridViewBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.RowHeadersWidth = 51;
            this.dataGridViewBill.Size = new System.Drawing.Size(409, 396);
            this.dataGridViewBill.TabIndex = 13;
            // 
            // panelTittleInfo
            // 
            this.panelTittleInfo.Controls.Add(this.labelTime);
            this.panelTittleInfo.Controls.Add(this.labelTableName);
            this.panelTittleInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittleInfo.Location = new System.Drawing.Point(0, 43);
            this.panelTittleInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTittleInfo.Name = "panelTittleInfo";
            this.panelTittleInfo.Size = new System.Drawing.Size(409, 111);
            this.panelTittleInfo.TabIndex = 12;
            // 
            // labelTime
            // 
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTime.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Gold;
            this.labelTime.Location = new System.Drawing.Point(0, 44);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(409, 44);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "05/07/2024";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTableName
            // 
            this.labelTableName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTableName.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableName.ForeColor = System.Drawing.Color.Gold;
            this.labelTableName.Location = new System.Drawing.Point(0, 0);
            this.labelTableName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTableName.Name = "labelTableName";
            this.labelTableName.Size = new System.Drawing.Size(409, 44);
            this.labelTableName.TabIndex = 0;
            this.labelTableName.Text = "Table 1";
            this.labelTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelTopControl
            // 
            this.flowLayoutPanelTopControl.Controls.Add(this.iconButtonClose);
            this.flowLayoutPanelTopControl.Controls.Add(this.iconButtonMinimize);
            this.flowLayoutPanelTopControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelTopControl.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelTopControl.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelTopControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanelTopControl.Name = "flowLayoutPanelTopControl";
            this.flowLayoutPanelTopControl.Size = new System.Drawing.Size(409, 43);
            this.flowLayoutPanelTopControl.TabIndex = 10;
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
            this.iconButtonClose.Location = new System.Drawing.Point(344, 4);
            this.iconButtonClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonClose.Name = "iconButtonClose";
            this.iconButtonClose.Size = new System.Drawing.Size(61, 43);
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
            this.iconButtonMinimize.Location = new System.Drawing.Point(275, 4);
            this.iconButtonMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButtonMinimize.Name = "iconButtonMinimize";
            this.iconButtonMinimize.Size = new System.Drawing.Size(61, 43);
            this.iconButtonMinimize.TabIndex = 2;
            this.iconButtonMinimize.UseVisualStyleBackColor = true;
            this.iconButtonMinimize.Click += new System.EventHandler(this.iconButtonMinimize_Click);
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
            this.iconButtonCancelBill.Location = new System.Drawing.Point(212, 629);
            this.iconButtonCancelBill.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonCancelBill.Name = "iconButtonCancelBill";
            this.iconButtonCancelBill.Size = new System.Drawing.Size(204, 75);
            this.iconButtonCancelBill.TabIndex = 8;
            this.iconButtonCancelBill.Text = "Cancel bill";
            this.iconButtonCancelBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCancelBill.UseVisualStyleBackColor = false;
            this.iconButtonCancelBill.Click += new System.EventHandler(this.iconButtonCancelBill_Click);
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
            this.iconButtonPay.Location = new System.Drawing.Point(19, 629);
            this.iconButtonPay.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonPay.Name = "iconButtonPay";
            this.iconButtonPay.Size = new System.Drawing.Size(179, 75);
            this.iconButtonPay.TabIndex = 7;
            this.iconButtonPay.Text = "Pay now";
            this.iconButtonPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonPay.UseVisualStyleBackColor = false;
            this.iconButtonPay.Click += new System.EventHandler(this.iconButtonPay_Click);
            // 
            // timerMinimize
            // 
            this.timerMinimize.Interval = 1;
            this.timerMinimize.Tick += new System.EventHandler(this.timerMinimize_Tick);
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(85)))));
            this.ClientSize = new System.Drawing.Size(409, 748);
            this.ControlBox = false;
            this.Controls.Add(this.panelBillContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBill";
            this.Text = "FormBill";
            this.panelBillContainer.ResumeLayout(false);
            this.panelBillContainer.PerformLayout();
            this.panelTotalMoney.ResumeLayout(false);
            this.panelTotalMoneyBill.ResumeLayout(false);
            this.panelTotalMoneyBill.PerformLayout();
            this.panelTextTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            this.panelTittleInfo.ResumeLayout(false);
            this.flowLayoutPanelTopControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBillContainer;
        private FontAwesome.Sharp.IconButton iconButtonCancelBill;
        private FontAwesome.Sharp.IconButton iconButtonPay;
        private System.Windows.Forms.Timer timerMinimize;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTopControl;
        private FontAwesome.Sharp.IconButton iconButtonClose;
        private FontAwesome.Sharp.IconButton iconButtonMinimize;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.Panel panelTittleInfo;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTableName;
        private System.Windows.Forms.Panel panelTotalMoney;
        private System.Windows.Forms.Panel panelTotalMoneyBill;
        private System.Windows.Forms.Panel panelTextTotal;
        private System.Windows.Forms.Label labelTextTotalDue;
        private FontAwesome.Sharp.IconButton MoneyQuantity;
    }
}