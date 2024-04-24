using BiaManager.Forms;
using BiaManager.Script;
using FontAwesome.Sharp;
using System.Drawing;
using System.Windows.Forms;

namespace BiaManager
{
    public partial class HomePage : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        private bool menuExpand = false;
        private bool sidebarExpand = true;

        private string tempHideIconMenuText;
        private string tempHomeText;
        private string tempTablesText;
        private string tempMenuText;
        private string tempBillsText;
        private string tempUserText;
        private string tempUserManagementText;
        private string tempMenuManagementText;
        private string tempTablesManagementText;
        private string tempSettingText;

        public HomePage()
        {
            InitializeComponent();

            tempHideIconMenuText = HideMenuIcon.Text;
            tempHomeText = Home.Text;
            tempTablesText = Tables.Text;
            tempMenuText = Menu.Text;
            tempBillsText = Bills.Text;
            tempUserText = User.Text;
            tempUserManagementText = UserManagement.Text;
            tempMenuManagementText = MenuManagement.Text;
            tempTablesManagementText = TablesManagement.Text;
            tempSettingText = Setting.Text;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(5, Home.Height);
            panelSidebarMenu.Controls.Add(leftBorderBtn);

            //Form
            //this.Text = string.Empty;
            //this.ControlBox = false;
            //this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Struct Color

        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(255, 105, 180);
            public static Color color2 = Color.FromArgb(255, 248, 220);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(0, 255, 255);
            public static Color color8 = Color.FromArgb(210, 105, 30);
            public static Color color9 = Color.FromArgb(173, 255, 47);
        }

        private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();
                currentBtn = (IconButton)sender;
                currentBtn.BackColor = Color.FromArgb(38, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = currentBtn.Width <= 60 ? TextImageRelation.Overlay : TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = currentBtn.Width <= 60 ? ContentAlignment.MiddleLeft : ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y + panelLogo.Size.Height + PanelHideMenu.Size.Height);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            tittleOfChildForm.Text = childForm.Text;
        }

        private void Home_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
        }

        private void Tables_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColor.color2);
        }

        private void Menu_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColor.color3);
            OpenChildForm(new FormMenu());
        }

        private void Bills_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColor.color4);
        }

        private void User_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColor.color5);
        }

        private void Setting_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColor.color6);
        }

        private void UserManagement_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColor.color7);
        }

        private void MenuManagement_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColor.color8);
        }

        private void TablesManagement_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColor.color9);
        }

        private void btnHome_Click(object sender, System.EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
        }

        private void panelTittleBar_MouseDown(object sender, MouseEventArgs e)
        {
            WindowSizeCtrl.MoveWindow(this.Handle);
        }

        private void ExitBtn_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizeBtn_Click(object sender, System.EventArgs e)
        {
            this.WindowState = WindowSizeCtrl.MinimizeAndScale(this.WindowState);
        }

        private void MinimizedIcon_Click(object sender, System.EventArgs e)
        {
            this.WindowState = WindowSizeCtrl.MinimizeAndScale(this.WindowState);
        }
        private void HideMenuIcon_Click(object sender, System.EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void menuTransition_Tick(object sender, System.EventArgs e)
        {
            if (!menuExpand)
            {
                panelMenuParent.Dock = DockStyle.None;
                panelMenuParent.Height += 10;
                if (panelMenuParent.Height >= 165)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
            else
            {
                panelMenuParent.Height -= 10;
                if (panelMenuParent.Height <= 50)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void sidebarTransition_Tick(object sender, System.EventArgs e)
        {
            if (sidebarExpand)
            {
                flowLayoutPanelMenu.AutoScroll = false;
                btnHome.SizeMode = PictureBoxSizeMode.Zoom;

                HideMenuIcon.Text = null;
                Home.Text = null;
                Tables.Text = null;
                Menu.Text = null;
                Bills.Text = null;
                User.Text = null;
                UserManagement.Text = null;
                MenuManagement.Text = null;
                TablesManagement.Text = null;
                Setting.Text = null;

                panelSidebarMenu.Width -= 5;
                if (panelSidebarMenu.Width <= 50)
                {
                    btnHome.Size = new Size(24, 24);
                    btnHome.Padding = new Padding(0, 0, 0, 0);
                    btnHome.Dock = DockStyle.Fill;

                    Home.Width = panelSidebarMenu.Width;
                    Tables.Width = panelSidebarMenu.Width;
                    Menu.Width = panelSidebarMenu.Width;
                    Bills.Width = panelSidebarMenu.Width;
                    User.Width = panelSidebarMenu.Width;
                    UserManagement.Width = panelSidebarMenu.Width;
                    MenuManagement.Width = panelSidebarMenu.Width;
                    TablesManagement.Width = panelSidebarMenu.Width;
                    Setting.Width = panelSidebarMenu.Width;

                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                flowLayoutPanelMenu.AutoScroll = true;
                btnHome.SizeMode = PictureBoxSizeMode.Zoom;
                btnHome.SizeMode = PictureBoxSizeMode.StretchImage;

                panelSidebarMenu.Width += 5;

                Home.Width = panelSidebarMenu.Width;
                Tables.Width = panelSidebarMenu.Width;
                Menu.Width = panelSidebarMenu.Width;
                Bills.Width = panelSidebarMenu.Width;
                User.Width = panelSidebarMenu.Width;
                UserManagement.Width = panelSidebarMenu.Width;
                MenuManagement.Width = panelSidebarMenu.Width;
                TablesManagement.Width = panelSidebarMenu.Width;
                Setting.Width = panelSidebarMenu.Width;

                if (panelSidebarMenu.Width >= 229)
                {
                    btnHome.Padding = new Padding(80, 40, 80, 40);
                    btnHome.Dock = DockStyle.Fill;

                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    HideMenuIcon.Text = tempHideIconMenuText;
                    Home.Text = tempHomeText;
                    Tables.Text = tempTablesText;
                    Menu.Text = tempMenuText;
                    Bills.Text = tempBillsText;
                    User.Text = tempUserText;
                    UserManagement.Text = tempUserManagementText;
                    MenuManagement.Text = tempMenuManagementText;
                    TablesManagement.Text = tempTablesManagementText;
                    Setting.Text = tempSettingText;
                }
            }
        }
    }
}
