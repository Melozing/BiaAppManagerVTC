using BiaManager.Forms;
using BiaManager.Forms.AdminForm.Items;
using BiaManager.Forms.AdminForm.Staff;
using BiaManager.Forms.AdminForm.Tables;
using BiaManager.Script;
using FontAwesome.Sharp;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BiaManager
{
    public partial class HomePage : Form
    {
        private static HomePage instance;

        private int currentUserRole;

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        private bool sidebarExpand = true;

        private Timer transitionTimer;

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

            flowLayoutPanelMenu.AutoScroll = false;
            btnHome.SizeMode = PictureBoxSizeMode.Zoom;

            flowLayoutPanelTable.Tag = false;
            flowLayoutPanelMenuItem.Tag = false;

            transitionTimer = new Timer();
            transitionTimer.Interval = 10;
            transitionTimer.Tick += TransitionTimer_Tick;

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
            this.Text = string.Empty;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public static HomePage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HomePage();
                }
                return instance;
            }
        }

        public void GetUserRole(int role)
        {
            currentUserRole = role;
        }

        public void ShowDetailPanel(string query, string idTarget)
        {
            FormBill form = new FormBill();

            DataTable table = DatabaseService.Instance.LoadDataTable(query);
            form.LoadDataGridView(table);

            form.TopLevel = false;
            panelDetail.Dock = DockStyle.Right;
            ShowPanelDetail();
            panelDetail.Controls.Add(form);
            panelContent.Tag = form;
            panelContent.Width = 400;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            form.Show();
        }
        private void ShowPanelDetail()
        {
            panelDetail.Show();
        }

        public void HidePanelDetail()
        {
            panelDetail.Hide();
        }

        public int ResizePanelDetail(int num)
        {
            panelDetail.Width += num;
            return panelDetail.Width;
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
                tittleOfChildForm.Text = currentBtn.Text;
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
        }

        private void Home_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
            panelDetail.Hide();
        }

        private void Tables_Click(object sender, System.EventArgs e)
        {
            try
            {
                ActivateButton(sender, RGBColor.color2);
                panelDetail.Hide();
                OpenChildForm(new FormTables());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening child form: " + ex.Message);
            }
        }

        private void Menu_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColor.color3);
            panelDetail.Hide();
            OpenChildForm(new FormMenu());
        }

        private void Bills_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColor.color4);
            panelDetail.Show();
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
            panelDetail.Hide();
            OpenChildForm(new StaffManager());
        }

        private void MenuManagement_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColor.color8);
            PerformFlowLayoutTransition(flowLayoutPanelMenuItem);
        }

        private void TablesManagement_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColor.color9);
            PerformFlowLayoutTransition(flowLayoutPanelTable);
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

        private void TransitionTimer_Tick(object sender, EventArgs e)
        {
            var panel = (FlowLayoutPanel)transitionTimer.Tag;
            if (panel != null && panel.Tag != null) // Kiểm tra xem panel và Tag của nó có null không
            {
                var expanding = (bool)panel.Tag;
                if (!expanding)
                {
                    panel.Height += 10;
                    int maxHeight = 60 * panel.Controls.Count;
                    if (panel.Height >= maxHeight)
                    {
                        transitionTimer.Stop();
                        panel.Tag = true; // Đánh dấu rằng panel đã mở rộng
                    }
                }
                else
                {
                    panel.Height -= 10;
                    if (panel.Height <= 0)
                    {
                        transitionTimer.Stop();
                        panel.Tag = false; // Đánh dấu rằng panel đã thu nhỏ
                    }
                }
            }
            else
            {
                // Xử lý trường hợp panel hoặc Tag của nó là null
            }
        }

        private void PerformFlowLayoutTransition(FlowLayoutPanel panel)
        {
            if (!transitionTimer.Enabled)
            {
                transitionTimer.Tag = panel;
                transitionTimer.Start();
            }
        }

        private void sidebarTransition_Tick(object sender, System.EventArgs e)
        {
            if (sidebarExpand)
            {
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

        private void ItemCategory_Click(object sender, EventArgs e)
        {
            ActivateButton(MenuManagement, RGBColor.color3);
            panelDetail.Hide();
            OpenChildForm(new ItemCategory());
        }

        private void TablesDetail_Click(object sender, EventArgs e)
        {
            ActivateButton(TablesManagement, RGBColor.color9);
            panelDetail.Hide();
            OpenChildForm(new AddTables());
        }

        private void TablesType_Click(object sender, EventArgs e)
        {
            ActivateButton(TablesManagement, RGBColor.color9);
            panelDetail.Hide();
            OpenChildForm(new TableTypeManager());
        }

        private void ItemMenu_Click(object sender, EventArgs e)
        {
            ActivateButton(MenuManagement, RGBColor.color3);
            panelDetail.Hide();
            OpenChildForm(new AddItems());
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            if (currentUserRole == 0)
            {
                Home.Show();
                Tables.Show();
                Menu.Show();
                Bills.Show();
                UserManagement.Show();
                MenuManagement.Show();
                TablesManagement.Show();
                Setting.Show();
                User.Hide();
            }
            else
            {
                Home.Show();
                Tables.Show();
                Menu.Show();
                Bills.Show();
                UserManagement.Hide();
                MenuManagement.Hide();
                TablesManagement.Hide();
                Setting.Show();
                User.Show();
            }
        }
    }
}
