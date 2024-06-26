﻿using BiaManager.Components;
using BiaManager.Forms;
using BiaManager.Forms.AdminForm.Bills;
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

            Home.PerformClick();
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

        public void ShowDetailPanel(string query, string TableID)
        {
            FormBill form = new FormBill();

            DataTable invoiceTable = DatabaseService.Instance.LoadDataTable(query);
            if (invoiceTable.Rows.Count > 0)
            {
                Invoice invoice = new Invoice();
                string invoiceTimeStr = invoiceTable.Rows[0]["Invoice_time"].ToString();
                invoice.InvoiceTime = DateTime.Parse(invoiceTimeStr);
                invoice.TableID = TableID;

                string tableNumberQuery = "SELECT TableNumber FROM table_detail WHERE TableID = '" + TableID + "'";
                DataTable tableNumberData = DatabaseService.Instance.LoadDataTable(tableNumberQuery);
                string tableNumber = "";
                if (tableNumberData.Rows.Count > 0)
                {
                    tableNumber = tableNumberData.Rows[0]["TableNumber"].ToString();
                }

                string tableNumberText = "Table " + tableNumber;
                string timeText = invoice.InvoiceTime.ToString("dd/MM/yyyy HH:mm:ss");
                form.SetTittleBill(tableNumberText, timeText);
                form.SetInvoiceInfo(TableID);
                FormExportBill.Instance.SetTittleBill(tableNumberText, timeText);

                query = "SELECT " +
                    "SUM(CASE WHEN item.IdItem = 'IHour' " +
                    "THEN inv_det.Invoice_TotalAmount * tbl_typ.TableType_Price " +
                    "ELSE item.item_Price * inv_det.Invoice_TotalAmount END) AS TotalAmount " +
                    "FROM invoice AS inv " +
                    "JOIN invoice_detail AS inv_det " +
                    "ON inv.IdInvoice = inv_det.IdInvoice " +
                    "JOIN items_menu AS item " +
                    "ON inv_det.IdItem = item.IdItem " +
                    "JOIN table_detail AS tbl_det " +
                    "ON inv.TableID = tbl_det.TableID " +
                    "JOIN table_type AS tbl_typ " +
                    "ON tbl_det.TableIDType = tbl_typ.TableIDType " +
                    "WHERE inv.TableID = '" + invoice.TableID + "' " +
                    "AND inv.Invoice_Status = 0;";

                DataTable amoutDue = DatabaseService.Instance.LoadDataTable(query);
                string amoutDueText = amoutDue.Rows[0]["TotalAmount"].ToString();
                form.SetTotalDueText(amoutDueText);
                FormExportBill.Instance.SetPriceBill(amoutDueText);
            }

            form.LoadDataGridView(invoiceTable);

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
            int numItem = 0;
            foreach (DataRow row in invoiceTable.Rows)
            {
                numItem++;
                int invoiceTotalAmount = Convert.ToInt32(row["Invoice_TotalAmount"]);
                DateTime invoiceTime = Convert.ToDateTime(row["Invoice_time"]);
                int itemPrice = Convert.ToInt32(row["item_Price"]);
                string itemName = row["item_Name"].ToString();
                BillDetailItems billDetailItems = new BillDetailItems();
                billDetailItems.SetInfoItems(numItem, itemName, invoiceTotalAmount, itemPrice);
            }
        }
        public void ShowPanelDetail()
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

        public void SetPanelDetailWidth(int width)
        {
            panelDetail.Width = width;
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
            public static Color color10 = Color.FromArgb(255, 165, 0);
            public static Color color11 = Color.FromArgb(218, 112, 214);
            public static Color color12 = Color.FromArgb(0, 128, 0);
            public static Color color13 = Color.FromArgb(255, 0, 0);
            public static Color color14 = Color.FromArgb(0, 0, 255);
            public static Color color15 = Color.FromArgb(128, 0, 128);
            public static Color color16 = Color.FromArgb(128, 128, 0);
            public static Color color17 = Color.FromArgb(0, 255, 0);
            public static Color color18 = Color.FromArgb(255, 192, 203);
            public static Color color19 = Color.FromArgb(0, 255, 255);
            public static Color color20 = Color.FromArgb(255, 20, 147);
            public static Color color21 = Color.FromArgb(255, 140, 0);
            public static Color color22 = Color.FromArgb(255, 0, 255);
            public static Color color23 = Color.FromArgb(192, 192, 192);
            public static Color color24 = Color.FromArgb(255, 215, 0);
            public static Color color25 = Color.FromArgb(0, 255, 127);
            public static Color color26 = Color.FromArgb(75, 0, 130);
            public static Color color27 = Color.FromArgb(255, 69, 0);
            public static Color color28 = Color.FromArgb(0, 128, 128);

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

        public void OpenChildForm(Form childForm)
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
            OpenChildForm(new FormHome());
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
            panelDetail.Hide();
            OpenChildForm(new FormSetting());
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
            this.WindowState = WindowSizeCtrl.MinimizeForm(this.WindowState);
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
                HideMenuIcon.Text = "";
                Home.Text = "";
                Tables.Text = "";
                User.Text = "";
                UserManagement.Text = "";
                MenuManagement.Text = "";
                TablesManagement.Text = "";
                Setting.Text = "";

                panelSidebarMenu.Width -= 5;
                if (panelSidebarMenu.Width <= 50)
                {
                    flowLayoutPanelMenu.Width = panelSidebarMenu.Width;

                    btnHome.Size = new Size(24, 24);
                    btnHome.Padding = new Padding(0, 0, 0, 0);
                    btnHome.Dock = DockStyle.Fill;

                    Home.Width = panelSidebarMenu.Width;
                    Tables.Width = panelSidebarMenu.Width;
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
                btnHome.SizeMode = PictureBoxSizeMode.Zoom;
                btnHome.SizeMode = PictureBoxSizeMode.StretchImage;

                panelSidebarMenu.Width += 5;

                Home.Width = panelSidebarMenu.Width;
                Tables.Width = panelSidebarMenu.Width;
                User.Width = panelSidebarMenu.Width;
                UserManagement.Width = panelSidebarMenu.Width;
                MenuManagement.Width = panelSidebarMenu.Width;
                TablesManagement.Width = panelSidebarMenu.Width;
                Setting.Width = panelSidebarMenu.Width;

                if (panelSidebarMenu.Width >= 229)
                {
                    flowLayoutPanelMenu.Width = panelSidebarMenu.Width;

                    btnHome.Padding = new Padding(80, 40, 80, 40);
                    btnHome.Dock = DockStyle.Fill;

                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    HideMenuIcon.Text = tempHideIconMenuText;
                    Home.Text = tempHomeText;
                    Tables.Text = tempTablesText;
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
                UserManagement.Show();
                MenuManagement.Show();
                TablesManagement.Show();
                Setting.Show();
                User.Hide();
                Bills.Show();
            }
            else
            {
                Home.Show();
                Tables.Show();
                UserManagement.Hide();
                MenuManagement.Hide();
                TablesManagement.Hide();
                Setting.Show();
                User.Show();
                Bills.Show();
            }
        }

        private void iconButtonBill_Click(object sender, EventArgs e)
        {
            ActivateButton(Bills, RGBColor.color10);
            panelDetail.Hide();
            OpenChildForm(new BillsManager());
        }
    }
}
