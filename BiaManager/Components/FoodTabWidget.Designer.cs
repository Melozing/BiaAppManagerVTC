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
            this.TypeFoodBtn = new FontAwesome.Sharp.IconButton();
            this.ShowFoodTransition = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.foodWidget1 = new BiaManager.Components.FoodWidget();
            this.foodWidget2 = new BiaManager.Components.FoodWidget();
            this.foodWidget3 = new BiaManager.Components.FoodWidget();
            this.foodWidget4 = new BiaManager.Components.FoodWidget();
            this.foodWidget5 = new BiaManager.Components.FoodWidget();
            this.foodWidget6 = new BiaManager.Components.FoodWidget();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTypeFoodContainer.SuspendLayout();
            this.panelFoodContentContainer.SuspendLayout();
            this.flowLayoutPanelFoodContent.SuspendLayout();
            this.panelTypeFood.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTypeFoodContainer
            // 
            this.panelTypeFoodContainer.Controls.Add(this.panelFoodContentContainer);
            this.panelTypeFoodContainer.Controls.Add(this.panelTypeFood);
            this.panelTypeFoodContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTypeFoodContainer.Location = new System.Drawing.Point(0, 0);
            this.panelTypeFoodContainer.Name = "panelTypeFoodContainer";
            this.panelTypeFoodContainer.Size = new System.Drawing.Size(120, 40);
            this.panelTypeFoodContainer.TabIndex = 3;
            // 
            // panelFoodContentContainer
            // 
            this.panelFoodContentContainer.Controls.Add(this.flowLayoutPanelFoodContent);
            this.panelFoodContentContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFoodContentContainer.Location = new System.Drawing.Point(0, 40);
            this.panelFoodContentContainer.Name = "panelFoodContentContainer";
            this.panelFoodContentContainer.Size = new System.Drawing.Size(120, 0);
            this.panelFoodContentContainer.TabIndex = 3;
            // 
            // flowLayoutPanelFoodContent
            // 
            this.flowLayoutPanelFoodContent.AutoScroll = true;
            this.flowLayoutPanelFoodContent.Controls.Add(this.foodWidget1);
            this.flowLayoutPanelFoodContent.Controls.Add(this.foodWidget2);
            this.flowLayoutPanelFoodContent.Controls.Add(this.foodWidget3);
            this.flowLayoutPanelFoodContent.Controls.Add(this.foodWidget4);
            this.flowLayoutPanelFoodContent.Controls.Add(this.foodWidget5);
            this.flowLayoutPanelFoodContent.Controls.Add(this.foodWidget6);
            this.flowLayoutPanelFoodContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelFoodContent.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelFoodContent.Name = "flowLayoutPanelFoodContent";
            this.flowLayoutPanelFoodContent.Size = new System.Drawing.Size(120, 0);
            this.flowLayoutPanelFoodContent.TabIndex = 2;
            // 
            // panelTypeFood
            // 
            this.panelTypeFood.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panelTypeFood.Controls.Add(this.TypeFoodBtn);
            this.panelTypeFood.Controls.Add(this.panel1);
            this.panelTypeFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTypeFood.Location = new System.Drawing.Point(0, 0);
            this.panelTypeFood.Name = "panelTypeFood";
            this.panelTypeFood.Size = new System.Drawing.Size(120, 40);
            this.panelTypeFood.TabIndex = 0;
            // 
            // TypeFoodBtn
            // 
            this.TypeFoodBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.TypeFoodBtn.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.TypeFoodBtn.Size = new System.Drawing.Size(120, 40);
            this.TypeFoodBtn.TabIndex = 0;
            this.TypeFoodBtn.Text = "Đồ ăn";
            this.TypeFoodBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TypeFoodBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TypeFoodBtn.UseVisualStyleBackColor = false;
            this.TypeFoodBtn.Click += new System.EventHandler(this.TypeFoodBtn_Click);
            // 
            // ShowFoodTransition
            // 
            this.ShowFoodTransition.Interval = 10;
            this.ShowFoodTransition.Tick += new System.EventHandler(this.ShowFoodTransition_Tick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 7;
            this.guna2Elipse1.TargetControl = this;
            // 
            // foodWidget1
            // 
            this.foodWidget1.BackColor = System.Drawing.Color.White;
            this.foodWidget1.Location = new System.Drawing.Point(3, 3);
            this.foodWidget1.Name = "foodWidget1";
            this.foodWidget1.Size = new System.Drawing.Size(296, 131);
            this.foodWidget1.TabIndex = 0;
            // 
            // foodWidget2
            // 
            this.foodWidget2.BackColor = System.Drawing.Color.White;
            this.foodWidget2.Location = new System.Drawing.Point(3, 140);
            this.foodWidget2.Name = "foodWidget2";
            this.foodWidget2.Size = new System.Drawing.Size(296, 131);
            this.foodWidget2.TabIndex = 1;
            // 
            // foodWidget3
            // 
            this.foodWidget3.BackColor = System.Drawing.Color.White;
            this.foodWidget3.Location = new System.Drawing.Point(3, 277);
            this.foodWidget3.Name = "foodWidget3";
            this.foodWidget3.Size = new System.Drawing.Size(296, 131);
            this.foodWidget3.TabIndex = 2;
            // 
            // foodWidget4
            // 
            this.foodWidget4.BackColor = System.Drawing.Color.White;
            this.foodWidget4.Location = new System.Drawing.Point(3, 414);
            this.foodWidget4.Name = "foodWidget4";
            this.foodWidget4.Size = new System.Drawing.Size(296, 131);
            this.foodWidget4.TabIndex = 3;
            // 
            // foodWidget5
            // 
            this.foodWidget5.BackColor = System.Drawing.Color.White;
            this.foodWidget5.Location = new System.Drawing.Point(3, 551);
            this.foodWidget5.Name = "foodWidget5";
            this.foodWidget5.Size = new System.Drawing.Size(296, 131);
            this.foodWidget5.TabIndex = 4;
            // 
            // foodWidget6
            // 
            this.foodWidget6.BackColor = System.Drawing.Color.White;
            this.foodWidget6.Location = new System.Drawing.Point(3, 688);
            this.foodWidget6.Name = "foodWidget6";
            this.foodWidget6.Size = new System.Drawing.Size(296, 131);
            this.foodWidget6.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 37);
            this.panel1.TabIndex = 1;
            // 
            // FoodTabWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panelTypeFoodContainer);
            this.Name = "FoodTabWidget";
            this.Size = new System.Drawing.Size(120, 40);
            this.panelTypeFoodContainer.ResumeLayout(false);
            this.panelFoodContentContainer.ResumeLayout(false);
            this.flowLayoutPanelFoodContent.ResumeLayout(false);
            this.panelTypeFood.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTypeFoodContainer;
        private System.Windows.Forms.Panel panelFoodContentContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelFoodContent;
        private FoodWidget foodWidget1;
        private FoodWidget foodWidget2;
        private FoodWidget foodWidget3;
        private FoodWidget foodWidget4;
        private FoodWidget foodWidget5;
        private FoodWidget foodWidget6;
        private System.Windows.Forms.Panel panelTypeFood;
        private FontAwesome.Sharp.IconButton TypeFoodBtn;
        private System.Windows.Forms.Timer ShowFoodTransition;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel panel1;
    }
}
