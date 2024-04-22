namespace BiaManager.Forms
{
    partial class FormMenu
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
            this.ShowFoodTransition = new System.Windows.Forms.Timer(this.components);
            this.foodTabWidget1 = new BiaManager.Components.FoodTabWidget();
            this.foodTabWidget2 = new BiaManager.Components.FoodTabWidget();
            this.foodTabWidget3 = new BiaManager.Components.FoodTabWidget();
            this.foodTabWidget4 = new BiaManager.Components.FoodTabWidget();
            this.foodTabWidget5 = new BiaManager.Components.FoodTabWidget();
            this.SuspendLayout();
            // 
            // foodTabWidget1
            // 
            this.foodTabWidget1.AutoSize = true;
            this.foodTabWidget1.Dock = System.Windows.Forms.DockStyle.Top;
            this.foodTabWidget1.Location = new System.Drawing.Point(0, 0);
            this.foodTabWidget1.Name = "foodTabWidget1";
            this.foodTabWidget1.Size = new System.Drawing.Size(800, 40);
            this.foodTabWidget1.TabIndex = 0;
            // 
            // foodTabWidget2
            // 
            this.foodTabWidget2.AutoSize = true;
            this.foodTabWidget2.Dock = System.Windows.Forms.DockStyle.Top;
            this.foodTabWidget2.Location = new System.Drawing.Point(0, 40);
            this.foodTabWidget2.Name = "foodTabWidget2";
            this.foodTabWidget2.Size = new System.Drawing.Size(800, 40);
            this.foodTabWidget2.TabIndex = 1;
            // 
            // foodTabWidget3
            // 
            this.foodTabWidget3.AutoSize = true;
            this.foodTabWidget3.Dock = System.Windows.Forms.DockStyle.Top;
            this.foodTabWidget3.Location = new System.Drawing.Point(0, 80);
            this.foodTabWidget3.Name = "foodTabWidget3";
            this.foodTabWidget3.Size = new System.Drawing.Size(800, 40);
            this.foodTabWidget3.TabIndex = 2;
            // 
            // foodTabWidget4
            // 
            this.foodTabWidget4.AutoSize = true;
            this.foodTabWidget4.Dock = System.Windows.Forms.DockStyle.Top;
            this.foodTabWidget4.Location = new System.Drawing.Point(0, 120);
            this.foodTabWidget4.Name = "foodTabWidget4";
            this.foodTabWidget4.Size = new System.Drawing.Size(800, 40);
            this.foodTabWidget4.TabIndex = 3;
            // 
            // foodTabWidget5
            // 
            this.foodTabWidget5.AutoSize = true;
            this.foodTabWidget5.Dock = System.Windows.Forms.DockStyle.Top;
            this.foodTabWidget5.Location = new System.Drawing.Point(0, 160);
            this.foodTabWidget5.Name = "foodTabWidget5";
            this.foodTabWidget5.Size = new System.Drawing.Size(800, 40);
            this.foodTabWidget5.TabIndex = 4;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.foodTabWidget5);
            this.Controls.Add(this.foodTabWidget4);
            this.Controls.Add(this.foodTabWidget3);
            this.Controls.Add(this.foodTabWidget2);
            this.Controls.Add(this.foodTabWidget1);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer ShowFoodTransition;
        private Components.FoodTabWidget foodTabWidget1;
        private Components.FoodTabWidget foodTabWidget2;
        private Components.FoodTabWidget foodTabWidget3;
        private Components.FoodTabWidget foodTabWidget4;
        private Components.FoodTabWidget foodTabWidget5;
    }
}