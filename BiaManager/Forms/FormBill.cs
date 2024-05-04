using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BiaManager.Forms
{
    public partial class FormBill : Form
    {
        private Size formBillSize;

        private Rectangle iconButtonPayRectangle;
        private Rectangle iconButtonCancelBillRectangle;

        private Size iconButtonPaySize;
        private Size iconButtonCancelBillSize;

        bool sidebarExpand = true;

        public FormBill()
        {
            InitializeComponent();

            iconButtonPaySize = iconButtonPay.Size;
            iconButtonCancelBillSize = iconButtonCancelBill.Size;

            //this.Resize += FormBill_Resize;
            formBillSize = this.Size;
        }
        private void FormBill_Resize(object sender, EventArgs e)
        {
            resize_Control(iconButtonPay, iconButtonPayRectangle);
            resize_Control(iconButtonCancelBill, iconButtonCancelBillRectangle);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(formBillSize.Width);
            float yRatio = (float)(this.Height) / (float)(formBillSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            if (newHeight >= 60)
            {
                c.Location = r.Location;
                c.Size = r.Size;
                iconButtonPay.Size = iconButtonPaySize;
                iconButtonCancelBill.Size = iconButtonCancelBillSize;
            }
            else
            {
                c.Location = new Point(newX, newY);
                c.Size = new Size(newWidth, newHeight);
            }
        }
        public void LoadDataGridView(DataTable data)
        {
            dataGridViewBill.DataSource = data;
        }

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            HomePage.Instance.HidePanelDetail();
        }

        private void iconButtonMinimize_Click(object sender, EventArgs e)
        {
            timerMinimize.Start();
        }

        private void timerMinimize_Tick(object sender, EventArgs e)
        {
            int currentSize;
            if (sidebarExpand)
            {
                currentSize = HomePage.Instance.ResizePanelDetail(-5);
                if (currentSize <= 50)
                {
                    dataGridViewBill.Visible = false;
                    iconButtonPay.Visible = false;
                    iconButtonCancelBill.Visible = false;
                    iconButtonClose.Visible = false;
                    sidebarExpand = false;
                    timerMinimize.Stop();
                }
            }
            else
            {
                currentSize = HomePage.Instance.ResizePanelDetail(5);
                if (currentSize >= 400)
                {
                    dataGridViewBill.Visible = true;
                    iconButtonPay.Visible = true;
                    iconButtonCancelBill.Visible = true;
                    iconButtonClose.Visible = true;
                    sidebarExpand = true;
                    timerMinimize.Stop();
                }
            }
        }
    }
}
