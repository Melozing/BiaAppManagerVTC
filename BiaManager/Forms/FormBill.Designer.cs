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
<<<<<<< HEAD
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewBill = new System.Windows.Forms.DataGridView();
            this.panelTopControl = new System.Windows.Forms.Panel();
            this.timerMinimize = new System.Windows.Forms.Timer(this.components);
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnPay = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.service_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_items = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.note_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost_items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_cartitem = new System.Windows.Forms.Panel();
            this.panel_buttonpay = new System.Windows.Forms.Panel();
            this.btnmaximize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnclose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.numberbill = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).BeginInit();
            this.panelTopControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.panel_cartitem.SuspendLayout();
=======
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
>>>>>>> main
            this.SuspendLayout();
            // 
            // panelBillContainer
            // 
<<<<<<< HEAD
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel_cartitem);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnPay);
            this.panel1.Controls.Add(this.dataGridViewBill);
            this.panel1.Controls.Add(this.panelTopControl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 608);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewBill
            // 
            this.dataGridViewBill.AllowUserToAddRows = false;
            this.dataGridViewBill.AllowUserToDeleteRows = false;
            this.dataGridViewBill.AllowUserToResizeColumns = false;
            this.dataGridViewBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridViewBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(16)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(16)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewBill.ColumnHeadersHeight = 43;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBill.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewBill.EnableHeadersVisualStyles = false;
            this.dataGridViewBill.Location = new System.Drawing.Point(0, 35);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewBill.RowTemplate.Height = 25;
            this.dataGridViewBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBill.Size = new System.Drawing.Size(342, 414);
            this.dataGridViewBill.TabIndex = 9;
            // 
            // panelTopControl
            // 
            this.panelTopControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelTopControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTopControl.Controls.Add(this.numberbill);
            this.panelTopControl.Controls.Add(this.btnclose);
            this.panelTopControl.Controls.Add(this.btnmaximize);
            this.panelTopControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopControl.Location = new System.Drawing.Point(0, 0);
            this.panelTopControl.Name = "panelTopControl";
            this.panelTopControl.Size = new System.Drawing.Size(342, 35);
            this.panelTopControl.TabIndex = 5;
=======
            this.panelBillContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(85)))));
            this.panelBillContainer.Controls.Add(this.panelTotalMoney);
            this.panelBillContainer.Controls.Add(this.dataGridViewBill);
            this.panelBillContainer.Controls.Add(this.panelTittleInfo);
            this.panelBillContainer.Controls.Add(this.flowLayoutPanelTopControl);
            this.panelBillContainer.Controls.Add(this.iconButtonCancelBill);
            this.panelBillContainer.Controls.Add(this.iconButtonPay);
            this.panelBillContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBillContainer.Location = new System.Drawing.Point(0, 0);
            this.panelBillContainer.Name = "panelBillContainer";
            this.panelBillContainer.Size = new System.Drawing.Size(307, 608);
            this.panelBillContainer.TabIndex = 0;
            // 
            // panelTotalMoney
            // 
            this.panelTotalMoney.Controls.Add(this.panelTotalMoneyBill);
            this.panelTotalMoney.Controls.Add(this.panelTextTotal);
            this.panelTotalMoney.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTotalMoney.Location = new System.Drawing.Point(0, 447);
            this.panelTotalMoney.Name = "panelTotalMoney";
            this.panelTotalMoney.Size = new System.Drawing.Size(307, 33);
            this.panelTotalMoney.TabIndex = 14;
            // 
            // panelTotalMoneyBill
            // 
            this.panelTotalMoneyBill.Controls.Add(this.MoneyQuantity);
            this.panelTotalMoneyBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTotalMoneyBill.Location = new System.Drawing.Point(104, 0);
            this.panelTotalMoneyBill.Name = "panelTotalMoneyBill";
            this.panelTotalMoneyBill.Size = new System.Drawing.Size(203, 33);
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
            this.MoneyQuantity.Size = new System.Drawing.Size(203, 33);
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
            this.labelTextTotalDue.ForeColor = System.Drawing.Color.Gold;
            this.labelTextTotalDue.Location = new System.Drawing.Point(0, 0);
            this.labelTextTotalDue.Name = "labelTextTotalDue";
            this.labelTextTotalDue.Size = new System.Drawing.Size(104, 36);
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
            this.dataGridViewBill.Location = new System.Drawing.Point(0, 125);
            this.dataGridViewBill.Name = "dataGridViewBill";
            this.dataGridViewBill.Size = new System.Drawing.Size(307, 322);
            this.dataGridViewBill.TabIndex = 13;
            // 
            // panelTittleInfo
            // 
            this.panelTittleInfo.Controls.Add(this.labelTime);
            this.panelTittleInfo.Controls.Add(this.labelTableName);
            this.panelTittleInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittleInfo.Location = new System.Drawing.Point(0, 35);
            this.panelTittleInfo.Name = "panelTittleInfo";
            this.panelTittleInfo.Size = new System.Drawing.Size(307, 90);
            this.panelTittleInfo.TabIndex = 12;
            // 
            // labelTime
            // 
            this.labelTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTime.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Gold;
            this.labelTime.Location = new System.Drawing.Point(0, 36);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(307, 36);
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
            this.labelTableName.Name = "labelTableName";
            this.labelTableName.Size = new System.Drawing.Size(307, 36);
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
            this.flowLayoutPanelTopControl.Name = "flowLayoutPanelTopControl";
            this.flowLayoutPanelTopControl.Size = new System.Drawing.Size(307, 35);
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
            this.iconButtonCancelBill.Location = new System.Drawing.Point(159, 511);
            this.iconButtonCancelBill.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonCancelBill.Name = "iconButtonCancelBill";
            this.iconButtonCancelBill.Size = new System.Drawing.Size(133, 61);
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
            this.iconButtonPay.Location = new System.Drawing.Point(14, 511);
            this.iconButtonPay.Margin = new System.Windows.Forms.Padding(0);
            this.iconButtonPay.Name = "iconButtonPay";
            this.iconButtonPay.Size = new System.Drawing.Size(133, 61);
            this.iconButtonPay.TabIndex = 7;
            this.iconButtonPay.Text = "Pay now";
            this.iconButtonPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonPay.UseVisualStyleBackColor = false;
            this.iconButtonPay.Click += new System.EventHandler(this.iconButtonPay_Click);
>>>>>>> main
            // 
            // timerMinimize
            // 
            this.timerMinimize.Interval = 1;
            this.timerMinimize.Tick += new System.EventHandler(this.timerMinimize_Tick);
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.DimGray;
            this.btnCancel.BorderRadius = 7;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.LightGray;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = global::BiaManager.Properties.Resources.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(181, 516);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 61);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            // 
            // btnPay
            // 
            this.btnPay.Animated = true;
            this.btnPay.BorderColor = System.Drawing.Color.DimGray;
            this.btnPay.BorderRadius = 7;
            this.btnPay.BorderThickness = 1;
            this.btnPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(145)))), ((int)(((byte)(39)))));
            this.btnPay.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Image = global::BiaManager.Properties.Resources.paynow1;
            this.btnPay.Location = new System.Drawing.Point(30, 516);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(133, 61);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Pay Now";
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(16)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(16)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 43;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.service_item,
            this.type_item,
            this.quantity_items,
            this.note_item,
            this.cost_items});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowTemplate.Height = 25;
            this.guna2DataGridView1.Size = new System.Drawing.Size(336, 443);
            this.guna2DataGridView1.TabIndex = 12;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(16)))), ((int)(((byte)(117)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 43;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Yellow;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // service_item
            // 
            this.service_item.HeaderText = "Service";
            this.service_item.Name = "service_item";
            // 
            // type_item
            // 
            this.type_item.HeaderText = "Type";
            this.type_item.Name = "type_item";
            // 
            // quantity_items
            // 
            this.quantity_items.HeaderText = "Quantity";
            this.quantity_items.Name = "quantity_items";
            // 
            // note_item
            // 
            this.note_item.HeaderText = "Note";
            this.note_item.Name = "note_item";
            // 
            // cost_items
            // 
            this.cost_items.HeaderText = "Cost";
            this.cost_items.Name = "cost_items";
            // 
            // panel_cartitem
            // 
            this.panel_cartitem.BackColor = System.Drawing.Color.White;
            this.panel_cartitem.Controls.Add(this.guna2DataGridView1);
            this.panel_cartitem.Controls.Add(this.panel_buttonpay);
            this.panel_cartitem.Location = new System.Drawing.Point(0, 41);
            this.panel_cartitem.Name = "panel_cartitem";
            this.panel_cartitem.Size = new System.Drawing.Size(336, 453);
            this.panel_cartitem.TabIndex = 13;
            // 
            // panel_buttonpay
            // 
            this.panel_buttonpay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_buttonpay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_buttonpay.Location = new System.Drawing.Point(0, 443);
            this.panel_buttonpay.Name = "panel_buttonpay";
            this.panel_buttonpay.Size = new System.Drawing.Size(336, 10);
            this.panel_buttonpay.TabIndex = 14;
            // 
            // btnmaximize
            // 
            this.btnmaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnmaximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.btnmaximize.FillColor = System.Drawing.Color.Transparent;
            this.btnmaximize.IconColor = System.Drawing.Color.Black;
            this.btnmaximize.Location = new System.Drawing.Point(253, 3);
            this.btnmaximize.Name = "btnmaximize";
            this.btnmaximize.Size = new System.Drawing.Size(45, 29);
            this.btnmaximize.TabIndex = 2;
            this.btnmaximize.Click += new System.EventHandler(this.iconButtonMinimize_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.FillColor = System.Drawing.Color.Transparent;
            this.btnclose.IconColor = System.Drawing.Color.Black;
            this.btnclose.Location = new System.Drawing.Point(293, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(45, 29);
            this.btnclose.TabIndex = 3;
            this.btnclose.Click += new System.EventHandler(this.iconButtonClose_Click);
            // 
            // numberbill
            // 
            this.numberbill.AutoSize = true;
            this.numberbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberbill.Location = new System.Drawing.Point(3, 9);
            this.numberbill.Name = "numberbill";
            this.numberbill.Size = new System.Drawing.Size(48, 20);
            this.numberbill.TabIndex = 4;
            this.numberbill.Text = "Bill : ";
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(336, 608);
            this.ControlBox = false;
            this.Controls.Add(this.panelBillContainer);
            this.Name = "FormBill";
            this.Text = "FormBill";
<<<<<<< HEAD
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            this.panelTopControl.ResumeLayout(false);
            this.panelTopControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.panel_cartitem.ResumeLayout(false);
=======
            this.panelBillContainer.ResumeLayout(false);
            this.panelBillContainer.PerformLayout();
            this.panelTotalMoney.ResumeLayout(false);
            this.panelTotalMoneyBill.ResumeLayout(false);
            this.panelTotalMoneyBill.PerformLayout();
            this.panelTextTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBill)).EndInit();
            this.panelTittleInfo.ResumeLayout(false);
            this.flowLayoutPanelTopControl.ResumeLayout(false);
>>>>>>> main
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewBill;
        private System.Windows.Forms.Panel panelTopControl;
        private System.Windows.Forms.Timer timerMinimize;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn service_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_item;
        private System.Windows.Forms.DataGridViewComboBoxColumn quantity_items;
        private System.Windows.Forms.DataGridViewTextBoxColumn note_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost_items;
        private System.Windows.Forms.Panel panel_cartitem;
        private System.Windows.Forms.Panel panel_buttonpay;
        private Guna.UI2.WinForms.Guna2ControlBox btnclose;
        private Guna.UI2.WinForms.Guna2ControlBox btnmaximize;
        private System.Windows.Forms.Label numberbill;
=======
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
>>>>>>> main
    }
}