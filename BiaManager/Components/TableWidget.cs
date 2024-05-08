using BiaManager.Forms;
using BiaManager.Script;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BiaManager.Components
{
    public partial class TableWidget : UserControl
    {
        DatabaseService databaseService = DatabaseService.Instance;

        public TableWidget()
        {
            InitializeComponent();
        }

        private void IconButtonStartTable_Click(object sender, System.EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            string newIDInvoice = GrenateNewID("invoice", "IV");
            string formattedTime = currentTime.ToString("yyyy-MM-dd HH:mm:ss"); // Định dạng thời gian theo format của cột datetime trong database
            string query = @"
            BEGIN TRANSACTION;
            UPDATE table_detail 
            SET Status = 1 
            WHERE TableID = '" + IconButtonOrder.Tag + "';" +
            "DECLARE @NewIDInvoice VARCHAR(10);" +
                   "SET @NewIDInvoice = '" + newIDInvoice + "';" +
                   "DECLARE @FormattedTime DATETIME;" +
                   "SET @FormattedTime = '" + formattedTime + "';" +
                   "INSERT INTO invoice(IdInvoice, TableID, Invoice_time, Invoice_Status)" +
                   "VALUES(@NewIDInvoice, '" + IconButtonOrder.Tag + "', @FormattedTime, '0');" +
                   "INSERT INTO invoice_detail(IdInvoice, IdItem, Invoice_TotalAmount)" +
                   "VALUES(@NewIDInvoice, 'IHour', 1);" +
                   "COMMIT TRANSACTION;";
            databaseService.ExecuteNonQuery(query);
            SetActiveOrder();
            ShowBillDetail();
        }
        public void ShowBill()
        {
            ShowBillDetail();
        }
        private void ShowBillDetail()
        {
            if (!CheckTableStatus(IconButtonOrder.Tag.ToString()))
            {
                HomePage.Instance.HidePanelDetail();
                return;
            }
            string updateHourStartQuery = @"
            UPDATE invoice_detail 
            SET Invoice_TotalAmount = 1 " +
            "WHERE IdItem = 'IHour' AND IdInvoice IN (" +
              "SELECT inv.IdInvoice " +
              "FROM invoice inv " +
              "JOIN invoice_detail inv_det ON inv.IdInvoice = inv_det.IdInvoice " +
              "WHERE inv.TableID = '" + IconButtonOrder.Tag + "' AND inv.Invoice_Status = 0" +
            ");";

            databaseService.ExecuteNonQuery(updateHourStartQuery);
            // Lấy thời gian hiện tại
            DateTime currentTime = DateTime.Now;

            // Lấy thời gian khởi tạo hóa đơn từ database
            DateTime invoiceTime = GetInvoiceTimeFromDatabase();

            // Tính khoảng cách thời gian giữa thời gian khởi tạo và thời gian hiện tại
            TimeSpan timeDifference = currentTime - invoiceTime;

            // Tính số lượng tăng của Invoice_TotalAmount (ví dụ: mỗi giờ tăng 1)
            int increaseAmount = (int)(timeDifference.TotalHours);

            // Thực hiện cập nhật Invoice_TotalAmount của item có id IHour
            string updateInvoiceTotalAmountQuery = @"
            UPDATE invoice_detail 
            SET Invoice_TotalAmount = Invoice_TotalAmount + " + increaseAmount + @"
            WHERE IdItem = 'IHour' AND IdInvoice IN (
                SELECT inv.IdInvoice 
                FROM invoice inv 
                JOIN invoice_detail inv_det ON inv.IdInvoice = inv_det.IdInvoice 
                WHERE inv.TableID = '" + IconButtonOrder.Tag + @"' AND inv.Invoice_Status = 0
            );";

            // Thực hiện truy vấn để cập nhật Invoice_TotalAmount
            databaseService.ExecuteNonQuery(updateInvoiceTotalAmountQuery);

            string updateHour = "UPDATE it_mn " +
            "SET it_mn.item_Price = tbt.TableType_Price " +
            "FROM items_menu AS it_mn " +
            "JOIN invoice_detail AS inv_dt ON inv_dt.IdItem = it_mn.IdItem " +
            "JOIN invoice AS inv ON inv.IdInvoice = inv_dt.IdInvoice " +
            "JOIN table_detail AS tb_dt ON tb_dt.TableID = inv.TableID " +
            "JOIN table_type AS tbt ON tbt.TableIDType = tb_dt.TableIDType " +
            "WHERE inv.TableID = '" + IconButtonOrder.Tag + "';";

            databaseService.ExecuteNonQuery(updateHour);

            string queryInvoice = "SELECT " +
            "inv_det.Invoice_TotalAmount, " +
            "tbl_iv.Invoice_time, " +
            "tbl_item.item_Price, " +
            "tbl_item.item_Name " +
            "FROM invoice inv JOIN " +
            "invoice_detail inv_det ON inv.IdInvoice = inv_det.IdInvoice " +
            "JOIN table_detail tbl_det ON inv.TableID = tbl_det.TableID " +
            "JOIN invoice tbl_iv ON inv_det.IdInvoice = tbl_iv.IdInvoice " +
            "JOIN items_menu tbl_item ON inv_det.IdItem = tbl_item.IdItem " +
            "JOIN table_type tbl_typ ON tbl_det.TableIDType = tbl_typ.TableIDType " +
            "WHERE tbl_iv.TableID = '" + IconButtonOrder.Tag + "' " +
            "AND tbl_iv.Invoice_Status = 0;";

            HomePage.Instance.ShowDetailPanel(queryInvoice, IconButtonOrder.Tag.ToString());
        }
        private bool CheckTableStatus(string TableID)
        {
            // Thực hiện truy vấn để lấy trường Status từ bảng table_detail
            string query = "SELECT Status FROM table_detail WHERE TableID = '" + TableID + "';";

            // Thực hiện truy vấn và lấy dữ liệu từ cơ sở dữ liệu
            DataTable result = DatabaseService.Instance.LoadDataTable(query);

            // Kiểm tra xem có dữ liệu trả về không
            if (result.Rows.Count > 0)
            {
                // Lấy giá trị của trường Status từ dòng đầu tiên của kết quả trả về
                int status = Convert.ToInt32(result.Rows[0]["Status"]);

                // Trả về true nếu status = 1, ngược lại trả về false
                return status == 1;
            }
            else
            {
                // Nếu không có dữ liệu trả về, mặc định trả về false
                return false;
            }
        }
        private DateTime GetInvoiceTimeFromDatabase()
        {
            // Tạo truy vấn SQL để lấy thời gian khởi tạo của hóa đơn từ cơ sở dữ liệu
            string query = "SELECT Invoice_time FROM invoice WHERE TableID = '" + IconButtonOrder.Tag + "' AND Invoice_Status = 0;";

            // Thực hiện truy vấn để lấy dữ liệu từ cơ sở dữ liệu
            DataTable result = databaseService.LoadDataTable(query);

            // Kiểm tra xem có dữ liệu trả về không
            if (result.Rows.Count > 0)
            {
                // Lấy thời gian khởi tạo của hóa đơn từ dòng đầu tiên của kết quả trả về
                DateTime invoiceTime = Convert.ToDateTime(result.Rows[0]["Invoice_time"]);
                return invoiceTime;
            }
            else
            {
                // Nếu không có dữ liệu trả về, trả về thời gian mặc định
                return DateTime.MinValue; // Hoặc giá trị thích hợp tùy theo yêu cầu của bạn
            }
        }


        private string GrenateNewID(string tableName, string tableIDKey)
        {
            // Tạo một UUID bằng cách sử dụng hàm NEWID() trong SQL Server
            string queryGetUUID = "SELECT NEWID() AS UUID";
            string uuid = DatabaseService.Instance.ExecuteScalar<string>(queryGetUUID);

            // Chỉ lấy 8 ký tự đầu của UUID để làm ID
            string newId = tableIDKey + uuid.Substring(0, 7);

            // Kiểm tra xem ID đã tồn tại trong cơ sở dữ liệu chưa
            string queryCheckExist = "SELECT COUNT(*) FROM " + tableName + " WHERE IdInvoice = '" + newId + "'";
            int count = DatabaseService.Instance.ExecuteScalar<int>(queryCheckExist);

            // Nếu ID đã tồn tại, thử lại đến khi tạo ra một ID mới và duy nhất
            while (count > 0)
            {
                uuid = DatabaseService.Instance.ExecuteScalar<string>(queryGetUUID);
                newId = tableIDKey + uuid.Substring(0, 7);
                count = DatabaseService.Instance.ExecuteScalar<int>(queryCheckExist);
            }

            return newId;
        }
        private void SetActiveOrder()
        {
            pictureBoxStatus.Image = Properties.Resources.Status_Playing;
            PanelTableMain.BackColor = Color.IndianRed;
            PanelTableName.BackColor = Color.Firebrick;
            PictureBoxTable.BackColor = Color.IndianRed;
            IconButtonStartTable.Hide();
            IconButtonOrder.Show();
        }
        private void SetInactiveOrder()
        {
            pictureBoxStatus.Image = Properties.Resources.Status_Empty;
            PanelTableMain.BackColor = Color.ForestGreen;
            PanelTableName.BackColor = Color.DarkGreen;
            PictureBoxTable.BackColor = Color.ForestGreen;
            IconButtonStartTable.Show();
            IconButtonOrder.Hide();
        }

        private void IconButtonOrder_Click(object sender, System.EventArgs e)
        {
            ReloadOrderPage();
        }
        public void ReloadOrderPage()
        {
            ShowBillDetail();
            FormMenu formMenu = new FormMenu();
            HomePage.Instance.OpenChildForm(formMenu);
            HomePage.Instance.ShowPanelDetail();
            formMenu.GetTableID(IconButtonOrder.Tag.ToString());
        }
        public void SetIconButtonTags(string tagId)
        {
            IconButtonStartTable.Tag = tagId;
            IconButtonOrder.Tag = tagId;
        }

        public void SetTableData(string TableID, int status, string tagId, string TableIDType)
        {
            LabelTableName.Text = "Table " + TableID;
            if (status > 0)
            {
                SetIconButtonTags(tagId);
                SetActiveOrder();
            }
            else
            {
                SetIconButtonTags(tagId);
                SetInactiveOrder();
            }
            if (TableIDType == "TBT01")
            {
                PictureBoxTable.Image = Properties.Resources.caromBilliards;
            }
            else if (TableIDType == "TBT02")
            {
                PictureBoxTable.Image = Properties.Resources.pocketBilliards;
            }
            else
            {
                PictureBoxTable.Image = Properties.Resources.defaultTable;
            }
        }

        private void TableWidget_Click(object sender, System.EventArgs e)
        {
            ShowBillDetail();
        }

        private void TableWidget_DoubleClick(object sender, System.EventArgs e)
        {
            ShowBillDetail();
        }

        private void PictureBoxTable_Click(object sender, System.EventArgs e)
        {
            ShowBillDetail();
        }

        private void PanelTableMain_Click(object sender, System.EventArgs e)
        {
            ShowBillDetail();
        }

        private void PanelTableName_Click(object sender, EventArgs e)
        {
            ShowBillDetail();
        }

        private void pictureBoxStatus_Click(object sender, EventArgs e)
        {
            ShowBillDetail();
        }

        private void LabelTableName_Click(object sender, EventArgs e)
        {
            ShowBillDetail();
        }
    }
}
