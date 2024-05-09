using BiaManager.Components;
using BiaManager.Script;
using System;
using System.Data;
using System.Windows.Forms;

namespace BiaManager.Forms
{
    public partial class FormExportBill : Form
    {
        private static FormExportBill instance;

        private string query;
        public static FormExportBill Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormExportBill();
                }
                return instance;
            }
        }
        public FormExportBill()
        {
            InitializeComponent();
        }

        public void SetPagePrint()
        {
            this.Text = string.Empty;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public void SetTittleBill(string tableName, string date)
        {
            labelTableName.Text = tableName;
            labelTime.Text = date;
        }
        public void SetPriceBill(string money)
        {
            if (decimal.TryParse(money, out decimal amountExportBill))
            {
                MoneyQuantity.Text = amountExportBill.ToString("N0");
            }
        }
        public void GetQuery(string queryItem)
        {
            query = queryItem;
        }
        public void GetQueryItem()
        {
            foreach (Control control in panelContentContainer.Controls)
            {
                panelContentContainer.Controls.Remove(control);
            }
            DataTable invoiceTable = DatabaseService.Instance.LoadDataTable(query);
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
                AddItemToInvoice(billDetailItems, numItem);
            }
        }
        private void AddItemToInvoice(BillDetailItems item, int index)
        {
            panelContentContainer.Controls.Add(item);
            item.TabIndex = index;
            item.Dock = DockStyle.Top;
        }
    }
}
