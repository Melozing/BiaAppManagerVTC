using BiaManager.Script;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BiaManager.Forms.AdminForm.Tables
{
    public partial class TableTypeManager : Form
    {
        DatabaseService databaseService = new DatabaseService();
        private string tempID;
        private string tempName;
        public TableTypeManager()
        {
            InitializeComponent();
            ResetSubmitButton();
            LoadDataTable();
        }
        private void ResetSubmitButton()
        {
            ButtonUpdateTableTypeManager.Hide();
            ButtonDeleteTableTypeManager.Hide();
            ButtonCreateTableTypeManager.Show();
        }
        private void ResetFormInput()
        {
            textBoxTableName.ResetText();
            textBoxTablePrice.ResetText();
        }
        private void LoadDataTable()
        {
            string queryStaffInfo = "SELECT * FROM table_type";
            dataGridViewTableTypeInfo.DataSource = DatabaseService.Instance.LoadDataTable(queryStaffInfo);
            ResetSubmitButton();
        }
        private void CheckSubmitButton()
        {
            if (!ButtonCreateTableTypeManager.Visible && ButtonUpdateTableTypeManager.Visible)
            {
                ButtonUpdateTableTypeManager.PerformClick();
            }
            else if (ButtonCreateTableTypeManager.Visible && !ButtonUpdateTableTypeManager.Visible)
            {
                ButtonCreateTableTypeManager.PerformClick();
            }
        }
        private bool CheckInputTableType()
        {
            if (string.IsNullOrWhiteSpace(textBoxTableName.Text))
            {
                MessageFuctionConstans.WarningOK("Please enter a valid name!");
                return false;
            }

            if (!int.TryParse(textBoxTablePrice.Text, out int price) || price < 0)
            {
                MessageFuctionConstans.WarningOK("Please enter a reasonable price level!");
                return false;
            }


            string queryCheckPhone = "SELECT * FROM table_type WHERE TableType_Name = '" + textBoxTableName.Text + "'";
            DataTable checkQuery = DatabaseService.Instance.LoadDataTable(queryCheckPhone);

            if (checkQuery.Rows.Count > 0)
            {
                MessageFuctionConstans.WarningOK("This TableType name already exists. Please enter another name.");
                return false;
            }
            return true;
        }
        private string GrenateNewID()
        {
            // Tạo một UUID bằng cách sử dụng hàm NEWID() trong SQL Server
            string queryGetUUID = "SELECT NEWID() AS UUID";
            string uuid = DatabaseService.Instance.ExecuteScalar<string>(queryGetUUID);

            // Chỉ lấy 8 ký tự đầu của UUID để làm ID
            string newId = "TBT" + uuid.Substring(0, 7);

            // Kiểm tra xem ID đã tồn tại trong cơ sở dữ liệu chưa
            string queryCheckExist = "SELECT COUNT(*) FROM table_type WHERE IdTableType = '" + newId + "'";
            int count = DatabaseService.Instance.ExecuteScalar<int>(queryCheckExist);

            // Nếu ID đã tồn tại, thử lại đến khi tạo ra một ID mới và duy nhất
            while (count > 0)
            {
                uuid = DatabaseService.Instance.ExecuteScalar<string>(queryGetUUID);
                newId = "TBT" + uuid.Substring(0, 7);
                count = DatabaseService.Instance.ExecuteScalar<int>(queryCheckExist);
            }

            return newId;
        }
        private void textBoxTableName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckSubmitButton();
            }

        }

        private void textBoxTablePrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckSubmitButton();
            }
        }

        private void ButtonUpdateTableTypeManager_Click(object sender, System.EventArgs e)
        {
            if (!CheckInputTableType()) return;
            string updateQuery = @"
                       UPDATE table_type 
                       SET TableType_Name = '" + textBoxTableName.Text + "'," +
                       "TableType_Price = '" + textBoxTablePrice.Text + "' " +
                       "WHERE IdTableType = '" + tempID + "';";
            databaseService.ExecuteNonQuery(updateQuery);

            MessageFuctionConstans.SuccessOK("Category updated successfully.");
            ResetMouseEventArgs();
            LoadDataTable();
        }

        private void ButtonDeleteTableTypeManager_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageFuctionConstans.WarningOKCancell("Confirm deletion of this category?");
            if (result == DialogResult.OK)
            {
                string deleteQuery = @"
                     DELETE FROM table_type WHERE IdTableType = '" + tempID + "';";

                databaseService.ExecuteNonQuery(deleteQuery);

                MessageFuctionConstans.SuccessOK("Type of Table deleted successfully.");

                ResetFormInput();
                LoadDataTable();
            }
        }

        private void ButtonCreateTableTypeManager_Click(object sender, System.EventArgs e)
        {
            if (!CheckInputTableType()) return;

            string idTableType = GrenateNewID();
            string insertQuery = @"
                      INSERT INTO table_type (IdTableType, TableType_Name,TableType_Price) VALUES ('" + idTableType + "','" + textBoxTableName.Text + "','" + textBoxTablePrice.Text + "'); ";
            databaseService.ExecuteNonQuery(insertQuery);

            MessageFuctionConstans.SuccessOK("Table Type created successfully.");
            ResetFormInput();
            LoadDataTable();
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iconButtonSearch.PerformClick();
            }
        }

        private void iconButtonSearch_Click(object sender, System.EventArgs e)
        {
            string searchQuery = @"
            SELECT * FROM table_type 
            WHERE  IdTableType LIKE '%" + textBoxSearch.Text + @"%' OR
            TableType_Name LIKE '%" + textBoxSearch.Text + @"%' OR 
            TableType_Price LIKE '%" + textBoxSearch.Text + @"%';";

            // Sử dụng phương thức LoadDataTable để lấy dữ liệu từ câu truy vấn search
            DataTable searchResult = databaseService.LoadDataTable(searchQuery);

            // Hiển thị kết quả tìm kiếm trên giao diện người dùng, ví dụ: trong DataGridView
            dataGridViewTableTypeInfo.DataSource = searchResult;
        }

        private void dataGridViewTableTypeInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tempID = dataGridViewTableTypeInfo.CurrentRow.Cells[0].Value.ToString();
            tempName = dataGridViewTableTypeInfo.CurrentRow.Cells[1].Value.ToString();
            textBoxTableName.Text = tempName;
            textBoxTablePrice.Text = dataGridViewTableTypeInfo.CurrentRow.Cells[2].Value.ToString();
            ButtonUpdateTableTypeManager.Show();
            ButtonDeleteTableTypeManager.Show();
            ButtonUpdateTableTypeManager.Location = ButtonCreateTableTypeManager.Location;
            ButtonDeleteTableTypeManager.Location = ButtonUpdateTableTypeManager.Location;
            ButtonDeleteTableTypeManager.Location = new Point(ButtonDeleteTableTypeManager.Location.X, ButtonDeleteTableTypeManager.Location.Y + 70);
            ButtonCreateTableTypeManager.Hide();
        }

        private void textBoxTablePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }
    }
}
