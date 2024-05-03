using BiaManager.Script;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BiaManager.Components
{
    public partial class TableWidget : UserControl
    {
        DatabaseService databaseService = new DatabaseService();
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
               UPDATE table_detail 
               SET Status = 1 " +
                       "WHERE IdTable = '" + IconButtonOrder.Tag + "';";
            string insertQuery = @"
              INSERT INTO invoice (IdInvoice, TableID, Invoice_time, Invoice_Status) VALUES ('" + newIDInvoice + "','" + IconButtonOrder.Tag + "','" + formattedTime + "','0'); ";
            string insertQueryDetail = @"
              INSERT INTO invoice_detail (IdInvoice, IdItem) VALUES ('" + newIDInvoice + "','" + IconButtonOrder.Tag + "','" + formattedTime + "','0'); ";
            databaseService.ExecuteNonQuery(query);
            SetActiveOrder();
            //HomePage.Instance.ShowDetailPanel();
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

        }
        void SetIconButtonTags(string tagId)
        {
            IconButtonStartTable.Tag = tagId;
            IconButtonOrder.Tag = tagId;
        }

        public void SetTableData(string idTable, int status, string tagId, string IdTableType)
        {
            LabelTableName.Text = "Table " + idTable;
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
            if (IdTableType == "TBT01")
            {
                PictureBoxTable.Image = Properties.Resources.caromBilliards;
            }
            else if (IdTableType == "TBT02")
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

        }

        private void TableWidget_DoubleClick(object sender, System.EventArgs e)
        {

        }

        private void PanelTableName_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBoxTable_Click(object sender, System.EventArgs e)
        {

        }

        private void PanelTableMain_Click(object sender, System.EventArgs e)
        {

        }
    }
}
