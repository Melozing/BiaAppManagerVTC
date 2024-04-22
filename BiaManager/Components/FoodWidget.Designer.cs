namespace BiaManager.Components
{
    partial class FoodWidget
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
            this.panelFoodWidgetContainer = new System.Windows.Forms.Panel();
            this.FoodNameLabel = new System.Windows.Forms.Label();
            this.pictureBoxFood = new System.Windows.Forms.PictureBox();
            this.MoneyQuantity = new FontAwesome.Sharp.IconButton();
            this.panelFoodWidgetContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFoodWidgetContainer
            // 
            this.panelFoodWidgetContainer.Controls.Add(this.pictureBoxFood);
            this.panelFoodWidgetContainer.Controls.Add(this.MoneyQuantity);
            this.panelFoodWidgetContainer.Controls.Add(this.FoodNameLabel);
            this.panelFoodWidgetContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFoodWidgetContainer.Location = new System.Drawing.Point(0, 0);
            this.panelFoodWidgetContainer.Name = "panelFoodWidgetContainer";
            this.panelFoodWidgetContainer.Size = new System.Drawing.Size(297, 131);
            this.panelFoodWidgetContainer.TabIndex = 0;
            // 
            // FoodNameLabel
            // 
            this.FoodNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FoodNameLabel.AutoSize = true;
            this.FoodNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
            this.FoodNameLabel.Location = new System.Drawing.Point(39, 14);
            this.FoodNameLabel.Name = "FoodNameLabel";
            this.FoodNameLabel.Size = new System.Drawing.Size(92, 24);
            this.FoodNameLabel.TabIndex = 0;
            this.FoodNameLabel.Text = "Cơm tấm";
            // 
            // pictureBoxFood
            // 
            this.pictureBoxFood.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxFood.Image = global::BiaManager.Properties.Resources.com_tam;
            this.pictureBoxFood.Location = new System.Drawing.Point(158, 0);
            this.pictureBoxFood.Name = "pictureBoxFood";
            this.pictureBoxFood.Size = new System.Drawing.Size(139, 131);
            this.pictureBoxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFood.TabIndex = 2;
            this.pictureBoxFood.TabStop = false;
            // 
            // MoneyQuantity
            // 
            this.MoneyQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MoneyQuantity.FlatAppearance.BorderSize = 0;
            this.MoneyQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoneyQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.MoneyQuantity.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.MoneyQuantity.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.MoneyQuantity.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.MoneyQuantity.IconSize = 24;
            this.MoneyQuantity.Location = new System.Drawing.Point(31, 85);
            this.MoneyQuantity.Name = "MoneyQuantity";
            this.MoneyQuantity.Size = new System.Drawing.Size(118, 37);
            this.MoneyQuantity.TabIndex = 1;
            this.MoneyQuantity.Text = "30.000";
            this.MoneyQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MoneyQuantity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MoneyQuantity.UseVisualStyleBackColor = true;
            // 
            // FoodWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelFoodWidgetContainer);
            this.Name = "FoodWidget";
            this.Size = new System.Drawing.Size(297, 131);
            this.panelFoodWidgetContainer.ResumeLayout(false);
            this.panelFoodWidgetContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFoodWidgetContainer;
        private FontAwesome.Sharp.IconButton MoneyQuantity;
        private System.Windows.Forms.Label FoodNameLabel;
        private System.Windows.Forms.PictureBox pictureBoxFood;
    }
}
