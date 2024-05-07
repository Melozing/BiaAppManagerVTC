namespace BiaManager.Components
{
    partial class FoodTabWidget
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
            this.panelTypeFoodContainer = new System.Windows.Forms.Panel();
            this.panelFoodContentContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanelFoodContent = new System.Windows.Forms.FlowLayoutPanel();
            this.panelTypeFood = new System.Windows.Forms.Panel();
            this.labelNum = new System.Windows.Forms.Label();
            this.pictureBoxNum = new System.Windows.Forms.PictureBox();
            this.TypeFoodBtn = new FontAwesome.Sharp.IconButton();
            this.ShowFoodTransition = new System.Windows.Forms.Timer(this.components);
            this.panelTypeFoodContainer.SuspendLayout();
            this.panelFoodContentContainer.SuspendLayout();
            this.panelTypeFood.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNum)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTypeFoodContainer
            // 
            this.panelTypeFoodContainer.Controls.Add(this.panelFoodContentContainer);
            this.panelTypeFoodContainer.Controls.Add(this.panelTypeFood);
            this.panelTypeFoodContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTypeFoodContainer.Location = new System.Drawing.Point(0, 0);
            this.panelTypeFoodContainer.Name = "panelTypeFoodContainer";
            this.panelTypeFoodContainer.Size = new System.Drawing.Size(820, 40);
            this.panelTypeFoodContainer.TabIndex = 3;
            // 
            // panelFoodContentContainer
            // 
            this.panelFoodContentContainer.Controls.Add(this.flowLayoutPanelFoodContent);
            this.panelFoodContentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFoodContentContainer.Location = new System.Drawing.Point(0, 40);
            this.panelFoodContentContainer.Name = "panelFoodContentContainer";
            this.panelFoodContentContainer.Size = new System.Drawing.Size(820, 0);
            this.panelFoodContentContainer.TabIndex = 3;
            // 
            // flowLayoutPanelFoodContent
            // 
            this.flowLayoutPanelFoodContent.AutoScroll = true;
            this.flowLayoutPanelFoodContent.BackColor = System.Drawing.Color.MidnightBlue;
            this.flowLayoutPanelFoodContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelFoodContent.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelFoodContent.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.flowLayoutPanelFoodContent.Name = "flowLayoutPanelFoodContent";
            this.flowLayoutPanelFoodContent.Size = new System.Drawing.Size(820, 0);
            this.flowLayoutPanelFoodContent.TabIndex = 2;
            // 
            // panelTypeFood
            // 
            this.panelTypeFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTypeFood.Controls.Add(this.labelNum);
            this.panelTypeFood.Controls.Add(this.pictureBoxNum);
            this.panelTypeFood.Controls.Add(this.TypeFoodBtn);
            this.panelTypeFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTypeFood.Location = new System.Drawing.Point(0, 0);
            this.panelTypeFood.Name = "panelTypeFood";
            this.panelTypeFood.Size = new System.Drawing.Size(820, 40);
            this.panelTypeFood.TabIndex = 0;
            // 
            // labelNum
            // 
            this.labelNum.BackColor = System.Drawing.Color.DarkRed;
            this.labelNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNum.ForeColor = System.Drawing.Color.Gold;
            this.labelNum.Location = new System.Drawing.Point(0, 0);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(52, 40);
            this.labelNum.TabIndex = 6;
            this.labelNum.Text = "1";
            this.labelNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxNum
            // 
            this.pictureBoxNum.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNum.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxNum.Image = global::BiaManager.Properties.Resources.Status_Repair;
            this.pictureBoxNum.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxNum.Name = "pictureBoxNum";
            this.pictureBoxNum.Size = new System.Drawing.Size(52, 40);
            this.pictureBoxNum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNum.TabIndex = 5;
            this.pictureBoxNum.TabStop = false;
            // 
            // TypeFoodBtn
            // 
            this.TypeFoodBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeFoodBtn.FlatAppearance.BorderSize = 0;
            this.TypeFoodBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeFoodBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeFoodBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.TypeFoodBtn.IconChar = FontAwesome.Sharp.IconChar.Hamburger;
            this.TypeFoodBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.TypeFoodBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TypeFoodBtn.IconSize = 30;
            this.TypeFoodBtn.Location = new System.Drawing.Point(0, 0);
            this.TypeFoodBtn.Name = "TypeFoodBtn";
            this.TypeFoodBtn.Size = new System.Drawing.Size(820, 40);
            this.TypeFoodBtn.TabIndex = 4;
            this.TypeFoodBtn.Text = "Đồ ăn";
            this.TypeFoodBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TypeFoodBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TypeFoodBtn.UseVisualStyleBackColor = true;
            this.TypeFoodBtn.Click += new System.EventHandler(this.TypeFoodBtn_Click);
            // 
            // ShowFoodTransition
            // 
            this.ShowFoodTransition.Interval = 10;
            this.ShowFoodTransition.Tick += new System.EventHandler(this.ShowFoodTransition_Tick);
            // 
            // FoodTabWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panelTypeFoodContainer);
            this.Name = "FoodTabWidget";
            this.Size = new System.Drawing.Size(820, 40);
            this.Load += new System.EventHandler(this.FoodTabWidget_Load);
            this.panelTypeFoodContainer.ResumeLayout(false);
            this.panelFoodContentContainer.ResumeLayout(false);
            this.panelTypeFood.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTypeFoodContainer;
        private System.Windows.Forms.Panel panelFoodContentContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFoodContent;
        private System.Windows.Forms.Panel panelTypeFood;
        private System.Windows.Forms.Timer ShowFoodTransition;
        private FontAwesome.Sharp.IconButton TypeFoodBtn;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.PictureBox pictureBoxNum;
    }
}
