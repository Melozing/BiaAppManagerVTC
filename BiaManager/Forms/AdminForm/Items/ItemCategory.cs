﻿using BiaManager.Script;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BiaManager.Forms.AdminForm.Items
{
    public partial class ItemCategory : Form
    {
        DatabaseService databaseService = new DatabaseService();
        private string tempID;
        private string tempName;
        public ItemCategory()
        {
            InitializeComponent();
            ResetSubmitButton();
            LoadCategory();
        }
        private void ResetSubmitButton()
        {
            ButtonUpdateItemCategoryManager.Hide();
            ButtonDeleteItemCategoryManager.Hide();
            ButtonCreateItemCategoryManager.Show();
        }
        private void CheckSubmitButton()
        {
            if (!ButtonCreateItemCategoryManager.Visible && ButtonUpdateItemCategoryManager.Visible)
            {
                ButtonUpdateItemCategoryManager.PerformClick();
            }
            else if (ButtonCreateItemCategoryManager.Visible && !ButtonUpdateItemCategoryManager.Visible)
            {
                ButtonCreateItemCategoryManager.PerformClick();
            }
        }
        private bool CheckInputCategory()
        {
            if (string.IsNullOrWhiteSpace(textBoxItemCategoryName.Text))
            {
                MessageFuctionConstans.WarningOK("Please enter a valid name!");
                return false;
            }

            string queryCheckPhone = "SELECT * FROM items_category WHERE ItemCategory_Name = '" + textBoxItemCategoryName.Text + "'";
            DataTable checkQuery = DatabaseService.Instance.LoadDataTable(queryCheckPhone);

            if (checkQuery.Rows.Count > 0)
            {
                MessageFuctionConstans.WarningOK("This Category name already exists. Please enter another name.");
                return false;
            }
            return true;
        }
        private void LoadCategory()
        {
            string queryStaffInfo = "SELECT * " +
                "FROM items_category";
            dataGridViewItemsCategory.DataSource = DatabaseService.Instance.LoadDataTable(queryStaffInfo);
            ResetSubmitButton();
        }
        private string GrenateNewIDCategory()
        {
            string idUser;
            string queryGetQuantity = "SELECT * FROM items_category";
            DataTable GetQuantity = DatabaseService.Instance.LoadDataTable(queryGetQuantity);
            int num = GetQuantity.Rows.Count + 1;
            string timestamp = DateTime.Now.ToString("yyMMdd");
            idUser = "IC" + num + timestamp;
            return idUser;
        }
        private void ResetFormAddCategory()
        {
            textBoxItemCategoryName.ResetText();
        }
        private void ButtonUpdateItemCategoryManager_Click(object sender, EventArgs e)
        {
            if (!CheckInputCategory()) return;
            string updateQuery = @"
                       UPDATE items_category 
                       SET ItemCategory_Name = '" + textBoxItemCategoryName.Text + "'" +
                       "WHERE IdItemCategory = '" + tempID + "';";


            databaseService.ExecuteNonQuery(updateQuery);

            MessageFuctionConstans.SuccessOK("Category updated successfully.");
            ResetMouseEventArgs();
            LoadCategory();
        }

        private void ButtonCreateItemCategoryManager_Click(object sender, EventArgs e)
        {
            if (!CheckInputCategory()) return;

            string idCategory = GrenateNewIDCategory();
            string insertQuery = @"
                      INSERT INTO items_category (IdItemCategory, ItemCategory_Name) VALUES ('" + idCategory + "','" + textBoxItemCategoryName.Text + "'); ";
            databaseService.ExecuteNonQuery(insertQuery);

            MessageFuctionConstans.SuccessOK("Category created successfully.");
            ResetFormAddCategory();
            LoadCategory();
        }

        private void ButtonDeleteItemCategoryManager_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageFuctionConstans.WarningOKCancell("Confirm deletion of this category?");
            if (result == DialogResult.OK)
            {
                string deleteQuery = @"
                     DELETE FROM items_category WHERE IdItemCategory = '" + tempID + "';";

                databaseService.ExecuteNonQuery(deleteQuery);

                MessageFuctionConstans.SuccessOK("Category deleted successfully.");

                ResetFormAddCategory();
                LoadCategory();
            }
        }

        private void textBoxItemCategoryName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckSubmitButton();
            }
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iconButtonSearch.PerformClick();
            }
        }

        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = @"
        SELECT ItemCategory_Name FROM items_category 
        WHERE ItemCategory_Name LIKE '%" + textBoxSearch.Text + "';";

            // Sử dụng phương thức LoadDataTable để lấy dữ liệu từ câu truy vấn search
            DataTable searchResult = databaseService.LoadDataTable(searchQuery);

            // Hiển thị kết quả tìm kiếm trên giao diện người dùng, ví dụ: trong DataGridView
            dataGridViewItemsCategory.DataSource = searchResult;
        }

        private void dataGridViewItemsCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tempID = dataGridViewItemsCategory.CurrentRow.Cells[0].Value.ToString();
            tempName = dataGridViewItemsCategory.CurrentRow.Cells[1].Value.ToString();
            textBoxItemCategoryName.Text = tempName;
            ButtonUpdateItemCategoryManager.Show();
            ButtonDeleteItemCategoryManager.Show();
            ButtonUpdateItemCategoryManager.Location = ButtonCreateItemCategoryManager.Location;
            ButtonDeleteItemCategoryManager.Location = ButtonUpdateItemCategoryManager.Location;
            ButtonDeleteItemCategoryManager.Location = new Point(ButtonDeleteItemCategoryManager.Location.X, ButtonDeleteItemCategoryManager.Location.Y + 70);
            ButtonCreateItemCategoryManager.Hide();
        }
    }
}