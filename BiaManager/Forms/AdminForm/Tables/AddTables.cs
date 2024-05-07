using BiaManager.Script;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BiaManager.Forms.AdminForm.Tables
{
    public partial class AddTables : Form
    {
        DatabaseService databaseService = DatabaseService.Instance;
        Dictionary<string, string> tableTypeDictionary = new Dictionary<string, string>();
        private string tempName;
        private string tempID;
        private string tempIDTypeTable;
        private string tempNameTypeTable;
        public AddTables()
        {
            InitializeComponent();
            LoadDataTable();
        }

        private void comboBoxTableType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            tempNameTypeTable = comboBoxTableType.SelectedItem.ToString();

            tempIDTypeTable = tableTypeDictionary.FirstOrDefault(x => x.Value == tempNameTypeTable).Key;
        }

        private void AddTables_Load(object sender, System.EventArgs e)
        {
            comboBoxTableType.DropDownStyle = ComboBoxStyle.DropDownList;
            string query = "SELECT IdTableType,TableType_Name FROM table_type";
            DataTable tableTypeData = DatabaseService.Instance.LoadDataTable(query);

            comboBoxTableType.Items.Clear();

            foreach (DataRow row in tableTypeData.Rows)
            {
                string tableName = row["TableType_Name"].ToString();
                string tableTypeId = row["IdTableType"].ToString();
                comboBoxTableType.Items.Add(tableName);

                tableTypeDictionary.Add(tableTypeId, tableName);
            }

            if (comboBoxTableType.Items.Count > 0)
            {
                comboBoxTableType.SelectedIndex = 0;
            }
        }
        private void CheckSubmitButton()
        {
            if (!ButtonCreate.Visible && ButtonUpdate.Visible)
            {
                ButtonUpdate.PerformClick();
            }
            else if (ButtonCreate.Visible && !ButtonUpdate.Visible)
            {
                ButtonCreate.PerformClick();
            }
        }
        private void ResetSubmitButton()
        {
            ButtonUpdate.Hide();
            ButtonDelete.Hide();
            ButtonCreate.Show();
        }
        private void LoadDataTable()
        {
            string queryStaffInfo = "SELECT table_detail.IdTable, table_detail.TableNumber, " +
                "table_detail.Status," +
                "table_type.TableType_Name, " +
                "table_type.TableType_Price " +
                "FROM table_detail JOIN table_type " +
                "ON table_detail.IdTableType = table_type.IdTableType;";
            dataGridViewTablesAdd.DataSource = DatabaseService.Instance.LoadDataTable(queryStaffInfo);

            dataGridViewTablesAdd.Columns["IdTable"].HeaderText = "Mã bàn";
            dataGridViewTablesAdd.Columns["TableNumber"].HeaderText = "Số bàn";
            dataGridViewTablesAdd.Columns["TableType_Name"].HeaderText = "Loại bàn";
            dataGridViewTablesAdd.Columns["TableType_Price"].HeaderText = "Giá";
            dataGridViewTablesAdd.Columns["Status"].HeaderText = "Tình trạng";
            ResetSubmitButton();
        }
        private string GrenateNewID()
        {
            // Tạo một UUID bằng cách sử dụng hàm NEWID() trong SQL Server
            string queryGetUUID = "SELECT NEWID() AS UUID";
            string uuid = DatabaseService.Instance.ExecuteScalar<string>(queryGetUUID);

            // Chỉ lấy 8 ký tự đầu của UUID để làm ID
            string newId = "TBD" + uuid.Substring(0, 7);

            // Kiểm tra xem ID đã tồn tại trong cơ sở dữ liệu chưa
            string queryCheckExist = "SELECT COUNT(*) FROM table_detail WHERE IdTable = '" + newId + "'";
            int count = DatabaseService.Instance.ExecuteScalar<int>(queryCheckExist);

            // Nếu ID đã tồn tại, thử lại đến khi tạo ra một ID mới và duy nhất
            while (count > 0)
            {
                uuid = DatabaseService.Instance.ExecuteScalar<string>(queryGetUUID);
                newId = "TBD" + uuid.Substring(0, 7);
                count = DatabaseService.Instance.ExecuteScalar<int>(queryCheckExist);
            }

            return newId;
        }
        private bool CheckInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxTableName.Text) && comboBoxTableType.Text != tempNameTypeTable)
            {
                MessageFuctionConstans.WarningOK("Please enter a valid name!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(comboBoxTableType.Text))
            {
                MessageFuctionConstans.WarningOK("Please enter a valid type of table!");
                return false;
            }

            string queryCheck = "SELECT TableNumber FROM table_detail WHERE TableNumber = '" + textBoxTableName.Text + "'";
            DataTable checkQuery = DatabaseService.Instance.LoadDataTable(queryCheck);
            if (checkQuery.Rows.Count > 0 && tempName != textBoxTableName.Text)
            {
                MessageFuctionConstans.WarningOK("This Table already exists. Please enter another name.");
                return false;
            }
            return true;
        }
        private void ResetFormInput()
        {
            textBoxTableName.ResetText();
            comboBoxTableType.ResetText();
        }
        private void textBoxTableName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void dataGridViewTablesAdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tempID = dataGridViewTablesAdd.CurrentRow.Cells[0].Value.ToString();
            tempName = dataGridViewTablesAdd.CurrentRow.Cells[1].Value.ToString();
            textBoxTableName.Text = tempName;

            string selectedTableType = dataGridViewTablesAdd.CurrentRow.Cells[2].Value.ToString();
            tempNameTypeTable = selectedTableType;
            comboBoxTableType.SelectedItem = selectedTableType;

            ButtonUpdate.Show();
            ButtonDelete.Show();
            ButtonUpdate.Location = ButtonCreate.Location;
            ButtonDelete.Location = ButtonUpdate.Location;
            ButtonDelete.Location = new Point(ButtonDelete.Location.X, ButtonDelete.Location.Y + 70);
            ButtonCreate.Hide();
        }

        private void ButtonUpdateTableTypeManager_Click(object sender, System.EventArgs e)
        {
            if (!CheckInput()) return;
            string updateQuery = @"
                       UPDATE table_detail 
                       SET TableNumber = '" + textBoxTableName.Text + "'," +
                       "IdTableType = '" + tempIDTypeTable + "' " +
                       "WHERE IdTable = '" + tempID + "';";
            databaseService.ExecuteNonQuery(updateQuery);

            MessageFuctionConstans.SuccessOK("Category updated successfully.");
            ResetFormInput();
            LoadDataTable();
        }

        private void ButtonDeleteTableTypeManager_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageFuctionConstans.WarningOKCancell("Confirm deletion of this category?");
            if (result == DialogResult.OK)
            {
                string deleteQuery = @"
                     DELETE FROM table_detail WHERE IdTable = '" + tempID + "';";

                databaseService.ExecuteNonQuery(deleteQuery);

                MessageFuctionConstans.SuccessOK("Type of Table deleted successfully.");

                ResetFormInput();
                LoadDataTable();
            }
        }

        private void ButtonCreateTableTypeManager_Click(object sender, System.EventArgs e)
        {
            if (!CheckInput()) return;

            string idTableType = GrenateNewID();
            string insertQuery = @"
                      INSERT INTO table_detail (IdTable, TableNumber,IdTableType) VALUES ('" + idTableType + "','" + textBoxTableName.Text + "','" + tempIDTypeTable + "'); ";
            databaseService.ExecuteNonQuery(insertQuery);

            MessageFuctionConstans.SuccessOK("Table Type created successfully.");
            ResetFormInput();
            LoadDataTable();
        }

        private void iconButtonSearch_Click(object sender, System.EventArgs e)
        {
            string searchText = textBoxSearch.Text;
            string searchQuery = @"
            SELECT table_detail.IdTable, table_detail.TableNumber, 
                   table_type.TableType_Name, 
                   table_type.TableType_Price 
            FROM table_detail 
            JOIN table_type ON table_detail.IdTableType = table_type.IdTableType
            WHERE table_detail.IdTable LIKE '%" + searchText + @"%' OR
              table_detail.TableNumber LIKE '%" + searchText + @"%' OR
              CONVERT(VARCHAR, table_detail.TableNumber) LIKE '%" + searchText + @"%' OR 
              table_type.TableType_Name LIKE '%" + searchText + @"%' OR 
              CONVERT(VARCHAR, table_type.TableType_Price) LIKE '%" + searchText + @"%';";

            DataTable searchResult = databaseService.LoadDataTable(searchQuery);

            dataGridViewTablesAdd.DataSource = searchResult;
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iconButtonSearch.PerformClick();
            }
        }

        private void textBoxTableName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckSubmitButton();
            }
        }

        private void dataGridViewTablesAdd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewTablesAdd.Columns[2].Index)
            {
                if (e.Value != null && e.Value.GetType() == typeof(int))
                {
                    int status = Convert.ToInt32(e.Value);
                    switch (status)
                    {
                        case 0:

                            e.Value = "empty";
                            break;
                        case 1:
                            e.Value = "playing";
                            break;
                        case 2:
                            e.Value = "repairing";
                            break;
                        default:
                            e.Value = "unknown";
                            break;
                    }
                    e.FormattingApplied = true;
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            iconButtonSearch.PerformClick();
        }
    }
}
