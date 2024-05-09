using BiaManager.Script;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BiaManager.Forms.AdminForm.Items
{
    public partial class AddItems : Form
    {
        private readonly DatabaseService databaseService = DatabaseService.Instance;
        private readonly Dictionary<string, string> itemCategoryDictionary = new Dictionary<string, string>();
        private string tempName;
        private string tempID;
        private string tempIDItemCategory;
        private string tempNameItemCategory;
        private Image tempImg;

        public AddItems()
        {
            InitializeComponent();
            LoadDataTable();
        }

        private void LoadDataTable()
        {
            string queryStaffInfo = @"
                SELECT 
                    items_menu.IdItem, 
                    items_menu.item_Name, 
                    items_menu.item_Price, 
                    items_category.ItemCategory_Name 
                FROM 
                    items_menu 
                JOIN 
                    items_category ON items_menu.IdItemCategory = items_category.IdItemCategory
                WHERE items_menu.IdItem != 'IHour' 
                AND items_menu.ItemStatus != 1;";
            DataTable table = databaseService.LoadDataTable(queryStaffInfo);

            dataGridViewAddItem.DataSource = table;
            dataGridViewAddItem.Columns["IdItem"].HeaderText = "Item ID";
            dataGridViewAddItem.Columns["item_Name"].HeaderText = "Item Name";
            dataGridViewAddItem.Columns["item_Price"].HeaderText = "Item Price";
            dataGridViewAddItem.Columns["ItemCategory_Name"].HeaderText = "Item Category Name";
            ResetSubmitButton();
        }

        private void textBoxItemPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);
        }

        private void ResetSubmitButton()
        {
            ButtonUpdate.Hide();
            ButtonDelete.Hide();
            ButtonCreate.Show();
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

        private bool CheckInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxItemName.Text) && comboBoxItemCategory.Text != tempNameItemCategory)
            {
                MessageFuctionConstans.WarningOK("Please enter a valid name!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(comboBoxItemCategory.Text))
            {
                MessageFuctionConstans.WarningOK("Please enter a valid type of Item!");
                return false;
            }

            if (!int.TryParse(textBoxItemPrice.Text, out int price) || price < 0)
            {
                MessageFuctionConstans.WarningOK("Please enter a reasonable price level!");
                return false;
            }

            if (pictureBoxItem.Image == null && tempImg == null)
            {
                MessageFuctionConstans.WarningOK("Please enter an image!");
                return false;
            }

            string queryCheck = "SELECT item_Name FROM items_menu WHERE item_Name = '" + textBoxItemName.Text + "' AND ItemStatus != 1";
            DataTable checkQuery = databaseService.LoadDataTable(queryCheck);
            if (checkQuery.Rows.Count > 0 && tempName != textBoxItemName.Text)
            {
                MessageFuctionConstans.WarningOK("This Item already exists. Please enter another name.");
                return false;
            }

            return true;
        }

        private string GrenateNewID()
        {
            string queryGetUUID = "SELECT NEWID() AS UUID";
            string uuid = databaseService.ExecuteScalar<string>(queryGetUUID);

            string newId = "I" + uuid.Substring(0, 7);

            string queryCheckExist = "SELECT COUNT(*) FROM table_detail WHERE TableID = '" + newId + "'";
            int count = databaseService.ExecuteScalar<int>(queryCheckExist);

            while (count > 0)
            {
                uuid = databaseService.ExecuteScalar<string>(queryGetUUID);
                newId = "I" + uuid.Substring(0, 7);
                count = databaseService.ExecuteScalar<int>(queryCheckExist);
            }

            return newId;
        }

        private void ResetFormInput()
        {
            textBoxItemName.ResetText();
            textBoxItemPrice.ResetText();
            pictureBoxItem.Image = null;
            comboBoxItemCategory.ResetText();
        }

        private void textBoxItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckSubmitButton();
            }
        }

        private void comboBoxItemCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempNameItemCategory = comboBoxItemCategory.SelectedItem.ToString();
            tempIDItemCategory = itemCategoryDictionary.FirstOrDefault(x => x.Value == tempNameItemCategory).Key;
        }

        private void textBoxItemPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckSubmitButton();
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;

            string updateQuery;
            if (pictureBoxItem.Image != tempImg)
            {
                byte[] imageData = ImageToByteArray(pictureBoxItem.Image);
                string imageHex = BitConverter.ToString(imageData).Replace("-", "");

                updateQuery = @"
                    UPDATE items_menu 
                    SET 
                        item_Name = '" + textBoxItemName.Text + "'," +
                        "IdItemCategory = '" + tempIDItemCategory + "', " +
                        "item_Price = '" + textBoxItemPrice.Text + "', " +
                        "item_image = CONVERT(varbinary(MAX), 0x" + imageHex + ") " +
                    "WHERE IdItem = '" + tempID + "'; ";
            }
            else
            {
                updateQuery = @"
                    UPDATE items_menu 
                    SET 
                        item_Name = '" + textBoxItemName.Text + "'," +
                        "IdItemCategory = '" + tempIDItemCategory + "', " +
                        "item_Price = '" + textBoxItemPrice.Text + "' " +
                    "WHERE IdItem = '" + tempID + "'; ";
            }

            databaseService.ExecuteNonQuery(updateQuery);

            MessageFuctionConstans.SuccessOK("Category updated successfully.");
            ResetFormInput();
            LoadDataTable();
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;

            byte[] imageData = ImageToByteArray(pictureBoxItem.Image);

            string TableIDType = GrenateNewID();
            string insertQuery = @"
                INSERT INTO items_menu (IdItem, item_Name, IdItemCategory, item_Price, item_image) 
                VALUES ('" + TableIDType + "','" + textBoxItemName.Text + "','" + tempIDItemCategory + "','" + textBoxItemPrice.Text + "', @ImageData);";

            databaseService.InsertImageData(insertQuery, imageData);

            MessageFuctionConstans.SuccessOK("Table Type created successfully.");
            ResetFormInput();
            LoadDataTable();
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (tempID == "IHour")
            {
                MessageFuctionConstans.WarningOK("You can't delete default table types.");
                return;
            }

            DialogResult result = MessageFuctionConstans.OKCancel("Confirm deletion of this item?");
            if (result == DialogResult.OK)
            {
                string deleteQuery = @"
                    UPDATE items_menu 
                    SET ItemStatus = 1 WHERE IdItem = '" + tempID + "';";

                databaseService.ExecuteNonQuery(deleteQuery);

                MessageFuctionConstans.SuccessOK("Type of item deleted successfully.");

                ResetFormInput();
                LoadDataTable();
            }
        }

        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text;
            string searchQuery = @"
                SELECT 
                    items_menu.IdItem, 
                    items_menu.item_Name,
                    items_menu.item_Price,
                    items_category.ItemCategory_Name
                FROM 
                    items_menu 
                JOIN 
                    items_category ON items_menu.IdItemCategory = items_category.IdItemCategory
                WHERE 
                    items_menu.IdItem LIKE '%" + searchText + @"%' OR
                    items_menu.item_Name LIKE '%" + searchText + @"%' OR
                    CONVERT(VARCHAR, items_menu.item_Price) LIKE '%" + searchText + @"%' OR 
                    items_category.ItemCategory_Name LIKE '%" + searchText + @"%' 
                    AND items_menu.ItemStatus != 1 AND items_menu.IdItem != 'IHour';";

            DataTable searchResult = databaseService.LoadDataTable(searchQuery);

            dataGridViewAddItem.DataSource = searchResult;
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iconButtonSearch.PerformClick();
            }
        }

        private void iconButtonUploadItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;

                Image image = Image.FromFile(imagePath);

                pictureBoxItem.Image = image;

                pictureBoxItem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void dataGridViewAddItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tempID = dataGridViewAddItem.CurrentRow.Cells[0].Value.ToString();
            tempName = dataGridViewAddItem.CurrentRow.Cells[1].Value.ToString();
            textBoxItemName.Text = tempName;
            textBoxItemPrice.Text = dataGridViewAddItem.CurrentRow.Cells[2].Value.ToString();
            string selectedTableType = dataGridViewAddItem.CurrentRow.Cells[3].Value.ToString();
            comboBoxItemCategory.SelectedItem = selectedTableType;

            string query = "SELECT IdItemCategory FROM items_category WHERE ItemCategory_Name ='" + selectedTableType + "' AND ItemCategoryStatus != 1;";
            DataTable tableTypeData = databaseService.LoadDataTable(query);

            if (tableTypeData.Rows.Count > 0)
            {
                tempIDItemCategory = tableTypeData.Rows[0]["IdItemCategory"].ToString();
            }

            ButtonUpdate.Show();
            ButtonDelete.Show();
            ButtonUpdate.Location = ButtonCreate.Location;
            ButtonDelete.Location = ButtonUpdate.Location;
            ButtonDelete.Location = new Point(ButtonDelete.Location.X, ButtonDelete.Location.Y + 70);
            ButtonCreate.Hide();

            string imageQuery = "SELECT item_image FROM items_menu WHERE IdItem ='" + tempID + "'";
            DataTable imageData = databaseService.LoadDataTable(imageQuery);

            if (imageData.Rows.Count > 0 && imageData.Rows[0]["Item_Image"] != DBNull.Value)
            {
                byte[] imageDataBytes = (byte[])imageData.Rows[0]["Item_Image"];
                using (MemoryStream ms = new MemoryStream(imageDataBytes))
                {
                    pictureBoxItem.Image = Image.FromStream(ms);
                    tempImg = pictureBoxItem.Image;
                    pictureBoxItem.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else
            {
                pictureBoxItem.Image = null; // Nếu không có dữ liệu hình ảnh, set pictureBoxItem.Image thành null
            }
        }


        private void AddItems_Load(object sender, EventArgs e)
        {
            comboBoxItemCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            string query = "SELECT IdItemCategory,ItemCategory_Name FROM items_category WHERE ItemCategoryStatus != 1";
            DataTable tableTypeData = databaseService.LoadDataTable(query);

            comboBoxItemCategory.Items.Clear();

            foreach (DataRow row in tableTypeData.Rows)
            {
                string Name = row["ItemCategory_Name"].ToString();
                string ID = row["IdItemCategory"].ToString();
                comboBoxItemCategory.Items.Add(Name);

                itemCategoryDictionary.Add(ID, Name);
            }

            if (comboBoxItemCategory.Items.Count > 0)
            {
                comboBoxItemCategory.SelectedIndex = 0;
            }
        }

        private void dataGridViewAddItem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.Value != null && dataGridViewAddItem.Columns[e.ColumnIndex].Name == "item_image")
            //{
            //    if (e.Value != null && e.Value.GetType() == typeof(byte[]))
            //    {
            //        byte[] imageData = (byte[])e.Value;
            //        using (MemoryStream ms = new MemoryStream(imageData))
            //        {
            //            Image image = Image.FromStream(ms);
            //            int desiredWidth = 50;
            //            int desiredHeight = 50;
            //            Image resizedImage = ResizeImage(image, desiredWidth, desiredHeight);
            //            e.Value = resizedImage;
            //        }
            //    }
            //}
        }

        private Image ResizeImage(Image originalImage, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(originalImage, 0, 0, width, height);
            }
            return resizedImage;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            iconButtonSearch.PerformClick();
        }
    }
}
