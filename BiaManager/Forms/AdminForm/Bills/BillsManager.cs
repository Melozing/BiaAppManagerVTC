using BiaManager.Script;
using System.Data;
using System.Windows.Forms;

namespace BiaManager.Forms.AdminForm.Bills
{
    public partial class BillsManager : Form
    {
        DatabaseService databaseService = DatabaseService.Instance;
        public BillsManager()
        {
            InitializeComponent();
        }

        private void textBoxSearch_TextChanged(object sender, System.EventArgs e)
        {
            iconButtonSearch.PerformClick();
        }

        private void iconButtonSearch_Click(object sender, System.EventArgs e)
        {
            string textBoxSearchText = textBoxSearch.Text; // Lấy nội dung từ textBoxSearch

            string searchQuery = "SELECT " +
                "inv.IdInvoice AS 'Invoice ID', " +
                "inv.Invoice_time AS 'Invoice Time', " +
                "inv.Invoice_Status AS 'Invoice Status', " +
                "SUM(CASE " +
                "WHEN item.IdItem = 'IHour' THEN inv_det.Invoice_TotalAmount * tbl_typ.TableType_Price " +
                "ELSE item.item_Price * inv_det.Invoice_TotalAmount END) AS TotalAmount, " +
                "inv.TableID AS TableID, " +
                "tbl_typ.TableType_Name AS TableTypeName, " +
                "tbl_det.TableNumber AS TableNumber " +
                "FROM invoice AS inv " +
                "JOIN invoice_detail AS inv_det ON inv.IdInvoice = inv_det.IdInvoice " +
                "JOIN items_menu AS item ON inv_det.IdItem = item.IdItem " +
                "JOIN table_detail AS tbl_det ON inv.TableID = tbl_det.TableID " +
                "JOIN table_type AS tbl_typ ON tbl_det.TableIDType = tbl_typ.TableIDType " +
                "WHERE " +
                "inv.IdInvoice LIKE '%" + textBoxSearchText + "%' OR " +
                "CONVERT(varchar, inv.Invoice_time, 103) LIKE '%" + textBoxSearchText + "%' OR " +
                "inv.Invoice_Status LIKE '%" + textBoxSearchText + "%' OR " +
                "CONVERT(varchar, Invoice_TotalAmount) LIKE '%" + textBoxSearchText + "%' OR " +
                "inv.TableID LIKE '%" + textBoxSearchText + "%' OR " +
                "tbl_typ.TableType_Name LIKE '%" + textBoxSearchText + "%' OR " +
                "tbl_det.TableNumber LIKE '%" + textBoxSearchText + "%' " +
                "GROUP BY inv.IdInvoice, inv.Invoice_time, inv.Invoice_Status, inv.TableID, tbl_typ.TableType_Name, tbl_det.TableNumber;";

            DataTable amoutDue = DatabaseService.Instance.LoadDataTable(searchQuery);
            dataGridViewBills.DataSource = amoutDue;
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iconButtonSearch.PerformClick();
            }
        }

        private void BillsManager_Load(object sender, System.EventArgs e)
        {
            string query = "SELECT " +
            "inv.IdInvoice AS 'Invoice ID', " +
            "inv.Invoice_time AS 'Invoice Time', " +
            "inv.Invoice_Status AS 'Invoice Status', " +
            "SUM(CASE " +
            "WHEN item.IdItem = 'IHour' THEN inv_det.Invoice_TotalAmount * tbl_typ.TableType_Price " +
            "ELSE item.item_Price * inv_det.Invoice_TotalAmount END) AS TotalAmount, " +
            "inv.TableID AS TableID, " +
            "tbl_typ.TableType_Name AS TableTypeName, " +
            "tbl_det.TableNumber AS TableNumber " +
            "FROM invoice AS inv " +
            "JOIN invoice_detail AS inv_det ON inv.IdInvoice = inv_det.IdInvoice " +
            "JOIN items_menu AS item ON inv_det.IdItem = item.IdItem " +
            "JOIN table_detail AS tbl_det ON inv.TableID = tbl_det.TableID " +
            "JOIN table_type AS tbl_typ ON tbl_det.TableIDType = tbl_typ.TableIDType " +
            "GROUP BY inv.IdInvoice, inv.Invoice_time, inv.Invoice_Status, inv.TableID, tbl_typ.TableType_Name, tbl_det.TableNumber;";
            DataTable amoutDue = DatabaseService.Instance.LoadDataTable(query);
            dataGridViewBills.DataSource = amoutDue;

        }
    }
}
