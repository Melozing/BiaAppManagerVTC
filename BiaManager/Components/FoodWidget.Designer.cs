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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodWidget));
            this.panelFoodWidgetContainer = new System.Windows.Forms.Panel();
            this.pictureBoxMinus = new System.Windows.Forms.PictureBox();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.pictureBoxFood = new System.Windows.Forms.PictureBox();
            this.MoneyQuantity = new FontAwesome.Sharp.IconButton();
            this.FoodNameLabel = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panelFoodWidgetContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFoodWidgetContainer
            // 
            this.panelFoodWidgetContainer.Controls.Add(this.pictureBoxMinus);
            this.panelFoodWidgetContainer.Controls.Add(this.pictureBoxAdd);
            this.panelFoodWidgetContainer.Controls.Add(this.pictureBoxFood);
            this.panelFoodWidgetContainer.Controls.Add(this.MoneyQuantity);
            this.panelFoodWidgetContainer.Controls.Add(this.FoodNameLabel);
            this.panelFoodWidgetContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFoodWidgetContainer.Location = new System.Drawing.Point(0, 0);
            this.panelFoodWidgetContainer.Name = "panelFoodWidgetContainer";
            this.panelFoodWidgetContainer.Size = new System.Drawing.Size(297, 131);
            this.panelFoodWidgetContainer.TabIndex = 0;
            // 
            // pictureBoxMinus
            // 
            this.pictureBoxMinus.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMinus.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinus.Image")));
            this.pictureBoxMinus.Location = new System.Drawing.Point(158, 0);
            this.pictureBoxMinus.Name = "pictureBoxMinus";
            this.pictureBoxMinus.Size = new System.Drawing.Size(32, 30);
            this.pictureBoxMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinus.TabIndex = 4;
            this.pictureBoxMinus.TabStop = false;
            this.pictureBoxMinus.Click += new System.EventHandler(this.pictureBoxMinus_Click);
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAdd.Image = global::BiaManager.Properties.Resources.Add;
            this.pictureBoxAdd.Location = new System.Drawing.Point(265, 0);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(32, 30);
            this.pictureBoxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxAdd.TabIndex = 3;
            this.pictureBoxAdd.TabStop = false;
            this.pictureBoxAdd.Click += new System.EventHandler(this.pictureBoxAdd_Click);
            // 
            // pictureBoxFood
            // 
            this.pictureBoxFood.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxFood.Image = global::BiaManager.Properties.Resources.com_tam;
            this.pictureBoxFood.Location = new System.Drawing.Point(158, 0);
            this.pictureBoxFood.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxFood.Name = "pictureBoxFood";
            this.pictureBoxFood.Size = new System.Drawing.Size(139, 131);
            this.pictureBoxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFood.TabIndex = 2;
            this.pictureBoxFood.TabStop = false;
            // 
            // MoneyQuantity
            // 
            this.MoneyQuantity.AutoSize = true;
            this.MoneyQuantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MoneyQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MoneyQuantity.FlatAppearance.BorderSize = 0;
            this.MoneyQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoneyQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.MoneyQuantity.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.MoneyQuantity.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(119)))), ((int)(((byte)(18)))));
            this.MoneyQuantity.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.MoneyQuantity.IconSize = 24;
            this.MoneyQuantity.Location = new System.Drawing.Point(0, 83);
            this.MoneyQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.MoneyQuantity.Name = "MoneyQuantity";
            this.MoneyQuantity.Size = new System.Drawing.Size(159, 48);
            this.MoneyQuantity.TabIndex = 1;
            this.MoneyQuantity.Text = "30.000";
            this.MoneyQuantity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MoneyQuantity.UseVisualStyleBackColor = true;
            // 
            // FoodNameLabel
            // 
            this.FoodNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FoodNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
            this.FoodNameLabel.Location = new System.Drawing.Point(0, 0);
            this.FoodNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.FoodNameLabel.Name = "FoodNameLabel";
            this.FoodNameLabel.Size = new System.Drawing.Size(159, 80);
            this.FoodNameLabel.TabIndex = 0;
            this.FoodNameLabel.Text = "Cơm tấm";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FoodWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelFoodWidgetContainer);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Name = "FoodWidget";
            this.Size = new System.Drawing.Size(297, 131);
            this.Load += new System.EventHandler(this.FoodWidget_Load);
            this.panelFoodWidgetContainer.ResumeLayout(false);
            this.panelFoodWidgetContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFoodWidgetContainer;
        private FontAwesome.Sharp.IconButton MoneyQuantity;
        private System.Windows.Forms.Label FoodNameLabel;
        private System.Windows.Forms.PictureBox pictureBoxFood;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox pictureBoxMinus;
    }
}
