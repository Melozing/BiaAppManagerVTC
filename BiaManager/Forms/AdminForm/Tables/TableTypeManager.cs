using BiaManager.Script;
using System;
using System.Data;
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
        private void LoadDataTable()
        {
            string queryStaffInfo = "SELECT table_detail.IdTable, table_detail.TableNumber, " +
                "table_type.TableType_Name, " +
                "table_type.TableType_Price " +
                "FROM table_detail JOIN table_type " +
                "ON table_detail.IdTableType = table_type.IdTableType;";

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
                ButtonUpdateTableTypeManager.PerformClick();
            }
        }
        private bool CheckInputTableType()
        {
            if (string.IsNullOrWhiteSpace(textBoxTableName.Text))
            {
                MessageFuctionConstans.WarningOK("Please enter a valid name!");
                return false;
            }

            if (!int.TryParse(textBoxTableName.Text, out int price) || price < 0)
            {
                MessageFuctionConstans.WarningOK("Please enter a reasonable price level.!");
                return false;
            }


            string queryCheckPhone = "SELECT * FROM items_category WHERE ItemCategory_Name = '" + textBoxTableName.Text + "'";
            DataTable checkQuery = DatabaseService.Instance.LoadDataTable(queryCheckPhone);

            if (checkQuery.Rows.Count > 0)
            {
                MessageFuctionConstans.WarningOK("This Category name already exists. Please enter another name.");
                return false;
            }
            return true;
        }
        private string GrenateNewIDCategory()
        {
            string IdTableType;
            string queryGetQuantity = "SELECT * FROM table_type";
            DataTable GetQuantity = DatabaseService.Instance.LoadDataTable(queryGetQuantity);
            int num = GetQuantity.Rows.Count + 1;
            string timestamp = DateTime.Now.ToString("yyMMdd");
            IdTableType = "TBT" + num + timestamp;
            return IdTableType;
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

        }

        private void ButtonDeleteTableTypeManager_Click(object sender, System.EventArgs e)
        {

        }

        private void ButtonCreateTableTypeManager_Click(object sender, System.EventArgs e)
        {
            if (!CheckInputTableType()) return;

            string idCategory = GrenateNewIDCategory();
            string insertQuery = @"
                      INSERT INTO items_category (IdItemCategory, ItemCategory_Name) VALUES ('" + idCategory + "','" + textBoxItemCategoryName.Text + "'); ";
            databaseService.ExecuteNonQuery(insertQuery);

            MessageFuctionConstans.SuccessOK("Category created successfully.");
            ResetSubmitButton();
            LoadDataTable();
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void iconButtonSearch_Click(object sender, System.EventArgs e)
        {

        }

        private void dataGridViewTableTypeInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxTablePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }
    }
}
