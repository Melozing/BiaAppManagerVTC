using BiaManager.Script;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BiaManager.Components
{
    public partial class FoodWidget : UserControl
    {
        DatabaseService databaseService = DatabaseService.Instance;
        public FoodWidget()
        {
            InitializeComponent();
            pictureBoxMinus.Hide();
        }
        public void SetFoodInfo(string name, int price, byte[] imageData)
        {
            FoodNameLabel.Text = name;
            MoneyQuantity.Text = price.ToString();

            using (MemoryStream ms = new MemoryStream(imageData))
            {
                pictureBoxFood.Image = Image.FromStream(ms);
            }
        }

        private void pictureBoxAdd_Click(object sender, System.EventArgs e)
        {
            string idItem = pictureBoxAdd.Tag.ToString();
            string idTable = pictureBoxFood.Tag.ToString();
            OrderItem(idItem, idTable);
            TableWidget tableWidget = new TableWidget();
            tableWidget.SetIconButtonTags(idTable);
            tableWidget.ShowBill();
        }

        public void SetIDItem(string idItem, string idTable)
        {
            pictureBoxAdd.Tag = idItem;
            pictureBoxFood.Tag = idTable;
            CheckItemOrdered(idItem, idTable);
        }

        private void FoodWidget_Load(object sender, System.EventArgs e)
        {
            pictureBoxAdd.BackColor = Color.Transparent;
        }
        private void OrderItem(string itemId, string tableId)
        {
            // Kiểm tra xem đã có đơn hàng cho mặt hàng này và bàn này chưa
            string checkOrderQuery = @"
            SELECT IdInvoice, Invoice_TotalAmount
            FROM invoice_detail
            WHERE IdItem = '" + itemId + "' AND IdInvoice IN (SELECT IdInvoice FROM invoice WHERE TableID = '" + tableId + "' AND Invoice_Status = 0);";

            DataTable result = databaseService.LoadDataTable(checkOrderQuery);

            if (result.Rows.Count > 0)
            {
                // Nếu đã có đơn hàng, tăng Invoice_TotalAmount lên 1 đơn vị
                string updateQuery = @"
            UPDATE invoice_detail
            SET Invoice_TotalAmount = Invoice_TotalAmount + 1
            WHERE IdItem = '" + itemId + "' AND IdInvoice IN (SELECT IdInvoice FROM invoice WHERE TableID = '" + tableId + "' AND Invoice_Status = 0);";

                databaseService.ExecuteNonQuery(updateQuery);
            }
            else
            {
                // Nếu chưa có đơn hàng, tạo mới một hàng trong invoice_detail
                string insertQuery = @"
            INSERT INTO invoice_detail (IdInvoice, IdItem, Invoice_TotalAmount)
            VALUES ((SELECT TOP 1 IdInvoice FROM invoice WHERE TableID = '" + tableId + "' ORDER BY Invoice_time DESC), '" + itemId + "', 1);";

                databaseService.ExecuteNonQuery(insertQuery);
            }
            pictureBoxMinus.Show();
        }

        private void pictureBoxMinus_Click(object sender, System.EventArgs e)
        {
            string itemId = pictureBoxAdd.Tag.ToString();
            string tableId = pictureBoxFood.Tag.ToString();

            // Kiểm tra xem đã có đơn hàng cho mặt hàng này và bàn này chưa
            string checkOrderQuery = @"
        SELECT IdInvoice, Invoice_TotalAmount
        FROM invoice_detail
        WHERE IdItem = '" + itemId + "' AND IdInvoice IN (SELECT IdInvoice FROM invoice WHERE TableID = '" + tableId + "' AND Invoice_Status = 0);";

            DataTable result = databaseService.LoadDataTable(checkOrderQuery);

            if (result.Rows.Count > 0)
            {
                int totalAmount = (int)result.Rows[0]["Invoice_TotalAmount"];

                // Nếu số lượng đặt hàng lớn hơn 1, giảm đi 1 đơn vị
                if (totalAmount > 1)
                {
                    string updateQuery = @"
                UPDATE invoice_detail
                SET Invoice_TotalAmount = Invoice_TotalAmount - 1
                WHERE IdItem = '" + itemId + "' AND IdInvoice IN (SELECT IdInvoice FROM invoice WHERE TableID = '" + tableId + "' AND Invoice_Status = 0);";

                    databaseService.ExecuteNonQuery(updateQuery);
                }
                // Nếu số lượng đặt hàng chỉ còn 1, xóa hàng đó khỏi đơn hàng
                else
                {
                    string deleteQuery = @"
                DELETE FROM invoice_detail
                WHERE IdItem = '" + itemId + "' AND IdInvoice IN (SELECT IdInvoice FROM invoice WHERE TableID = '" + tableId + "' AND Invoice_Status = 0);";

                    databaseService.ExecuteNonQuery(deleteQuery);
                    pictureBoxMinus.Hide(); // Ẩn nút pictureBoxMinus khi không còn hàng nào trong đơn hàng
                }
                TableWidget tableWidget = new TableWidget();
                tableWidget.SetIconButtonTags(tableId);
                tableWidget.ShowBill();
            }
        }
        private void CheckItemOrdered(string itemId, string tableId)
        {
            // Kiểm tra xem đã có đơn hàng cho mặt hàng này và bàn này chưa
            string checkOrderQuery = @"
        SELECT IdInvoice, Invoice_TotalAmount
        FROM invoice_detail
        WHERE IdItem = '" + itemId + "' AND IdInvoice IN (SELECT IdInvoice FROM invoice WHERE TableID = '" + tableId + "' AND Invoice_Status = 0);";

            DataTable result = databaseService.LoadDataTable(checkOrderQuery);

            if (result.Rows.Count > 0)
            {
                pictureBoxMinus.Show();
            }
            else
            {
                pictureBoxMinus.Hide();
            }
        }
    }
}
