namespace BiaManager.Forms
{
    partial class FormExportBill
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelTableName = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTotalMoney = new System.Windows.Forms.Panel();
            this.panelTotalMoneyBill = new System.Windows.Forms.Panel();
            this.MoneyQuantity = new FontAwesome.Sharp.IconButton();
            this.panelTextTotal = new System.Windows.Forms.Panel();
            this.labelTextTotalDue = new System.Windows.Forms.Label();
            this.billDetailItemsTop = new BiaManager.Components.BillDetailItems();
            this.panelContentContainer = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTotalMoney.SuspendLayout();
            this.panelTotalMoneyBill.SuspendLayout();
            this.panelTextTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelTime);
            this.panelTop.Controls.Add(this.labelTableName);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(480, 111);
            this.panelTop.TabIndex = 0;
            // 
            // labelTime
            // 
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTime.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelTime.Location = new System.Drawing.Point(0, 36);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(480, 36);
            this.labelTime.TabIndex = 16;
            this.labelTime.Text = "05/07/2024";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTableName
            // 
            this.labelTableName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTableName.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelTableName.Location = new System.Drawing.Point(0, 0);
            this.labelTableName.Name = "labelTableName";
            this.labelTableName.Size = new System.Drawing.Size(480, 36);
            this.labelTableName.TabIndex = 15;
            this.labelTableName.Text = "Table 1";
            this.labelTableName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panelTotalMoney);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 537);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(0);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(480, 118);
            this.panelBottom.TabIndex = 2;
            // 
            // panelTotalMoney
            // 
            this.panelTotalMoney.Controls.Add(this.panelTotalMoneyBill);
            this.panelTotalMoney.Controls.Add(this.panelTextTotal);
            this.panelTotalMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTotalMoney.Location = new System.Drawing.Point(0, 0);
            this.panelTotalMoney.Margin = new System.Windows.Forms.Padding(0);
            this.panelTotalMoney.Name = "panelTotalMoney";
            this.panelTotalMoney.Size = new System.Drawing.Size(480, 33);
            this.panelTotalMoney.TabIndex = 18;
            // 
            // panelTotalMoneyBill
            // 
            this.panelTotalMoneyBill.Controls.Add(this.MoneyQuantity);
            this.panelTotalMoneyBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTotalMoneyBill.Location = new System.Drawing.Point(104, 0);
            this.panelTotalMoneyBill.Margin = new System.Windows.Forms.Padding(0);
            this.panelTotalMoneyBill.Name = "panelTotalMoneyBill";
            this.panelTotalMoneyBill.Size = new System.Drawing.Size(376, 33);
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
            this.MoneyQuantity.ForeColor = System.Drawing.Color.SaddleBrown;
            this.MoneyQuantity.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.MoneyQuantity.IconColor = System.Drawing.Color.SaddleBrown;
            this.MoneyQuantity.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.MoneyQuantity.IconSize = 24;
            this.MoneyQuantity.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MoneyQuantity.Location = new System.Drawing.Point(0, 0);
            this.MoneyQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.MoneyQuantity.Name = "MoneyQuantity";
            this.MoneyQuantity.Size = new System.Drawing.Size(376, 33);
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
            this.panelTextTotal.Name = "panelTextTotal";
            this.panelTextTotal.Size = new System.Drawing.Size(104, 33);
            this.panelTextTotal.TabIndex = 15;
            // 
            // labelTextTotalDue
            // 
            this.labelTextTotalDue.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTextTotalDue.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextTotalDue.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelTextTotalDue.Location = new System.Drawing.Point(0, 0);
            this.labelTextTotalDue.Margin = new System.Windows.Forms.Padding(0);
            this.labelTextTotalDue.Name = "labelTextTotalDue";
            this.labelTextTotalDue.Size = new System.Drawing.Size(104, 36);
            this.labelTextTotalDue.TabIndex = 2;
            this.labelTextTotalDue.Text = "Total due :";
            this.labelTextTotalDue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // billDetailItemsTop
            // 
            this.billDetailItemsTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.billDetailItemsTop.Location = new System.Drawing.Point(0, 111);
            this.billDetailItemsTop.Name = "billDetailItemsTop";
            this.billDetailItemsTop.Size = new System.Drawing.Size(480, 38);
            this.billDetailItemsTop.TabIndex = 0;
            // 
            // panelContentContainer
            // 
            this.panelContentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentContainer.Location = new System.Drawing.Point(0, 149);
            this.panelContentContainer.Name = "panelContentContainer";
            this.panelContentContainer.Size = new System.Drawing.Size(480, 388);
            this.panelContentContainer.TabIndex = 4;
            // 
            // FormExportBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 655);
            this.Controls.Add(this.panelContentContainer);
            this.Controls.Add(this.billDetailItemsTop);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "FormExportBill";
            this.Text = "FormExportBill";
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelTotalMoney.ResumeLayout(false);
            this.panelTotalMoneyBill.ResumeLayout(false);
            this.panelTotalMoneyBill.PerformLayout();
            this.panelTextTotal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private Components.BillDetailItems billDetailItemsTop;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelTableName;
        private System.Windows.Forms.Panel panelTotalMoney;
        private System.Windows.Forms.Panel panelTotalMoneyBill;
        private FontAwesome.Sharp.IconButton MoneyQuantity;
        private System.Windows.Forms.Panel panelTextTotal;
        private System.Windows.Forms.Label labelTextTotalDue;
        private System.Windows.Forms.Panel panelContentContainer;
    }
}