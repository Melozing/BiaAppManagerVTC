using BiaManager.Script;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BiaManager.Forms
{
    public partial class FormBill : Form
    {
        DatabaseService databaseService = DatabaseService.Instance;
        private Size formBillSize;

        private Rectangle iconButtonPayRectangle;
        private Rectangle iconButtonCancelBillRectangle;

        private Size iconButtonPaySize;
        private Size iconButtonCancelBillSize;

        bool sidebarExpand = true;

        private string tableID;

        private FormExportBill panelPrint;
        public FormBill()
        {
            InitializeComponent();

            iconButtonPaySize = iconButtonPay.Size;
            iconButtonCancelBillSize = iconButtonCancelBill.Size;

            sidebarExpand = false;
            timerMinimize.Start();
            formBillSize = this.Size;
        }
        private void FormBill_Resize(object sender, EventArgs e)
        {
            resize_Control(iconButtonPay, iconButtonPayRectangle);
            resize_Control(iconButtonCancelBill, iconButtonCancelBillRectangle);
        }
        public void SetTittleBill(string tableName, string time)
        {
            labelTableName.Text = tableName;
            labelTime.Text = time;
        }

        public void SetInvoiceInfo(string TableID)
        {
            tableID = TableID;
        }
        public void SetTotalDueText(string total)
        {
            if (decimal.TryParse(total, out decimal amount))
            {
                MoneyQuantity.Text = amount.ToString("N0");
            }
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
                    labelTableName.Visible = false;
                    labelTime.Visible = false;
                    panelTotalMoney.Visible = false;
                    flowLayoutPanelTopControl.Height = 140;
                    flowLayoutPanelTopControl.FlowDirection = FlowDirection.TopDown;
                    sidebarExpand = false;
                    timerMinimize.Stop();
                    timerMinimize.Dispose();
                }
            }
            else
            {
                currentSize = HomePage.Instance.ResizePanelDetail(5);
                if (currentSize >= 400)
                {
                    HomePage.Instance.SetPanelDetailWidth(400);
                    dataGridViewBill.Visible = true;
                    iconButtonPay.Visible = true;
                    iconButtonCancelBill.Visible = true;
                    labelTableName.Visible = true;
                    labelTime.Visible = true;
                    panelTotalMoney.Visible = true;
                    flowLayoutPanelTopControl.Height = 35;
                    flowLayoutPanelTopControl.FlowDirection = FlowDirection.RightToLeft;
                    sidebarExpand = true;
                    timerMinimize.Stop();
                    timerMinimize.Dispose();
                }
            }
        }

        private void iconButtonPay_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageFuctionConstans.OKCancel("Confirm payment for this bill?");
            if (result == DialogResult.OK)
            {
                DialogResult resultExportBill = MessageFuctionConstans.YesNoCancel("Do you want to generate an invoice?");
                if (resultExportBill == DialogResult.Yes)
                {
                    ExportAndPrintInvoice();
                    UpdateInvoiceAndTableStatus();
                    PaySuccessful();
                }
                else if (resultExportBill == DialogResult.No)
                {
                    UpdateInvoiceAndTableStatus();
                    PaySuccessful();
                }
            }
        }
        private void ExportAndPrintInvoice()
        {
            FormExportBill.Instance.Show();
            FormExportBill.Instance.BringToFront();
            FormExportBill.Instance.SetPagePrint();
            FormExportBill.Instance.GetQueryItem();
            panelPrint = FormExportBill.Instance;
            GetPrintArea(FormExportBill.Instance);
            printPreviewDialogBill.Document = printDocumentBill;
            printDocumentBill.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocumentBill_PrintPage);
            printPreviewDialogBill.ShowDialog();
        }
        private Bitmap memoryImg;
        private void GetPrintArea(FormExportBill pnl)
        {
            memoryImg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryImg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        private void UpdateInvoiceAndTableStatus()
        {
            string queryPay = @"
            UPDATE inv
            SET inv.Invoice_Status = 1
            FROM invoice AS inv
            INNER JOIN invoice_detail AS inv_det ON inv.IdInvoice = inv_det.IdInvoice
            INNER JOIN table_detail AS tbl_det ON inv.TableID = tbl_det.TableID
            WHERE inv.TableID = '" + tableID + "' AND inv.Invoice_Status = 0;" +
            "UPDATE table_detail SET Status = 0 WHERE TableID = '" + tableID + "'; ";
            databaseService.ExecuteNonQuery(queryPay);
        }
        private void PaySuccessful()
        {
            this.Close();
            FormTables formTables = new FormTables();
            HomePage.Instance.OpenChildForm(formTables);
            HomePage.Instance.HidePanelDetail();
            MessageFuctionConstans.SuccessOK("Payment successful!");
        }

        private void iconButtonCancelBill_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageFuctionConstans.OKCancel("Do you want to cancel this bill?");
            if (result == DialogResult.OK)
            {
                DialogResult resultExportBill = MessageFuctionConstans.OKCancel("The data after canceling the bill cannot be modified, do you still want to proceed with the confirmation?");
                if (resultExportBill == DialogResult.OK)
                {
                    string queryPay = @"
                    UPDATE inv
                    SET inv.Invoice_Status = 2
                    FROM invoice AS inv
                    INNER JOIN invoice_detail AS inv_det ON inv.IdInvoice = inv_det.IdInvoice
                    INNER JOIN table_detail AS tbl_det ON inv.TableID = tbl_det.TableID
                    WHERE inv.TableID = '" + tableID + "' AND inv.Invoice_Status = 0;" +
                   "UPDATE table_detail SET Status = 0 WHERE TableID = '" + tableID + "'; ";

                    databaseService.ExecuteNonQuery(queryPay);
                    this.Close();
                    FormTables formTables = new FormTables();
                    HomePage.Instance.OpenChildForm(formTables);
                    HomePage.Instance.HidePanelDetail();
                    MessageFuctionConstans.SuccessOK("Cancel bill successfully!");
                }
            }
        }

        private void printDocumentBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            e.Graphics.DrawImage(memoryImg, (pageArea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }
    }
}
