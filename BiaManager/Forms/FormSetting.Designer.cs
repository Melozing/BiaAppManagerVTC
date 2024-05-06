namespace BiaManager.Forms
{
    partial class FormSetting
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
            this.panelSettingContainer = new System.Windows.Forms.Panel();
            this.toggleButtonMuteSound = new BiaManager.Script.UI.ToggleButton();
            this.ButtonSignOut = new FontAwesome.Sharp.IconButton();
            this.DarkThemeLabel = new System.Windows.Forms.Label();
            this.panelSettingContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSettingContainer
            // 
            this.panelSettingContainer.Controls.Add(this.toggleButtonMuteSound);
            this.panelSettingContainer.Controls.Add(this.ButtonSignOut);
            this.panelSettingContainer.Controls.Add(this.DarkThemeLabel);
            this.panelSettingContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSettingContainer.Location = new System.Drawing.Point(0, 0);
            this.panelSettingContainer.Name = "panelSettingContainer";
            this.panelSettingContainer.Size = new System.Drawing.Size(800, 450);
            this.panelSettingContainer.TabIndex = 0;
            // 
            // toggleButtonMuteSound
            // 
            this.toggleButtonMuteSound.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toggleButtonMuteSound.AutoSize = true;
            this.toggleButtonMuteSound.Location = new System.Drawing.Point(340, 30);
            this.toggleButtonMuteSound.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleButtonMuteSound.Name = "toggleButtonMuteSound";
            this.toggleButtonMuteSound.OffBackColor = System.Drawing.Color.Gray;
            this.toggleButtonMuteSound.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.toggleButtonMuteSound.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.toggleButtonMuteSound.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.toggleButtonMuteSound.Size = new System.Drawing.Size(45, 22);
            this.toggleButtonMuteSound.TabIndex = 63;
            this.toggleButtonMuteSound.UseVisualStyleBackColor = true;
            // 
            // ButtonSignOut
            // 
            this.ButtonSignOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonSignOut.AutoSize = true;
            this.ButtonSignOut.BackColor = System.Drawing.Color.DarkRed;
            this.ButtonSignOut.FlatAppearance.BorderSize = 0;
            this.ButtonSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonSignOut.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ButtonSignOut.IconColor = System.Drawing.Color.Black;
            this.ButtonSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonSignOut.Location = new System.Drawing.Point(340, 72);
            this.ButtonSignOut.Name = "ButtonSignOut";
            this.ButtonSignOut.Size = new System.Drawing.Size(262, 54);
            this.ButtonSignOut.TabIndex = 62;
            this.ButtonSignOut.Text = "Sign Out";
            this.ButtonSignOut.UseVisualStyleBackColor = false;
            this.ButtonSignOut.Click += new System.EventHandler(this.ButtonSignOut_Click);
            // 
            // DarkThemeLabel
            // 
            this.DarkThemeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DarkThemeLabel.AutoSize = true;
            this.DarkThemeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DarkThemeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.DarkThemeLabel.Location = new System.Drawing.Point(105, 30);
            this.DarkThemeLabel.Name = "DarkThemeLabel";
            this.DarkThemeLabel.Size = new System.Drawing.Size(124, 24);
            this.DarkThemeLabel.TabIndex = 61;
            this.DarkThemeLabel.Text = "Dark Theme";
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSettingContainer);
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            this.panelSettingContainer.ResumeLayout(false);
            this.panelSettingContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSettingContainer;
        private Script.UI.ToggleButton toggleButtonMuteSound;
        private FontAwesome.Sharp.IconButton ButtonSignOut;
        private System.Windows.Forms.Label DarkThemeLabel;
    }
}