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
        DatabaseService databaseService = new DatabaseService();
        Dictionary<string, string> itemCategoryDictionary = new Dictionary<string, string>();
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
            string queryStaffInfo = "SELECT items_menu.IdItem, items_menu.item_Name, " +
             "items_menu.item_Price, " +
             "items_menu.item_image, " +
             "items_category.ItemCategory_Name " +
             "FROM items_menu JOIN items_category " +
             "ON items_menu.IdItemCategory = items_category.IdItemCategory;";
            DataTable table = DatabaseService.Instance.LoadDataTable(queryStaffInfo);

            dataGridViewAddItem.DataSource = table;
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

            string queryCheck = "SELECT item_Name FROM items_menu WHERE item_Name = '" + textBoxItemName.Text + "'";
            DataTable checkQuery = DatabaseService.Instance.LoadDataTable(queryCheck);
            if (checkQuery.Rows.Count > 0 && tempName != textBoxItemName.Text)
            {
                MessageFuctionConstans.WarningOK("This Item already exists. Please enter another name.");
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
            string newId = "I" + uuid.Substring(0, 7);

            // Kiểm tra xem ID đã tồn tại trong cơ sở dữ liệu chưa
            string queryCheckExist = "SELECT COUNT(*) FROM table_detail WHERE IdTable = '" + newId + "'";
            int count = DatabaseService.Instance.ExecuteScalar<int>(queryCheckExist);

            // Nếu ID đã tồn tại, thử lại đến khi tạo ra một ID mới và duy nhất
            while (count > 0)
            {
                uuid = DatabaseService.Instance.ExecuteScalar<string>(queryGetUUID);
                newId = "I" + uuid.Substring(0, 7);
                count = DatabaseService.Instance.ExecuteScalar<int>(queryCheckExist);
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

        private void comboBoxItemCategory_SelectedIndexChanged(object sender, System.EventArgs e)
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

        private void ButtonUpdate_Click(object sender, System.EventArgs e)
        {
            if (!CheckInput()) return;

            string updateQuery;
            if (pictureBoxItem.Image != tempImg)
            {
                byte[] imageData = ImageToByteArray(pictureBoxItem.Image);
                string imageHex = BitConverter.ToString(imageData).Replace("-", "");

                updateQuery = @"
            UPDATE items_menu 
            SET item_Name = '" + textBoxItemName.Text + "'," +
                        "IdItemCategory = '" + tempIDItemCategory + "', " +
                        "item_Price = '" + textBoxItemPrice.Text + "', " +
                        "item_image = CONVERT(varbinary(MAX), 0x" + imageHex + ") " + // Sử dụng CONVERT function để chèn dữ liệu varbinary
                    "WHERE IdItem = '" + tempID + "';";
            }
            else
            {
                updateQuery = @"
                UPDATE items_menu 
                SET item_Name = '" + textBoxItemName.Text + "'," +
                       "IdItemCategory = '" + tempIDItemCategory + "', " +
                       "item_Price = '" + textBoxItemPrice.Text + "' " +
                    "WHERE IdItem = '" + tempID + "';";
            }

            databaseService.ExecuteNonQuery(updateQuery);

            MessageFuctionConstans.SuccessOK("Category updated successfully.");
            ResetFormInput();
            LoadDataTable();
        }

        private void ButtonCreate_Click(object sender, System.EventArgs e)
        {
            if (!CheckInput()) return;

            // Đọc dữ liệu hình ảnh từ PictureBox
            byte[] imageData = ImageToByteArray(pictureBoxItem.Image);

            string idTableType = GrenateNewID();
            string insertQuery = @"
              INSERT INTO items_menu (IdItem, item_Name, IdItemCategory, item_Price, item_image) 
              VALUES ('" + idTableType + "','" + textBoxItemName.Text + "','" + tempIDItemCategory + "','" + textBoxItemPrice.Text + "', @ImageData);";

            // Thực hiện thêm dữ liệu vào cơ sở dữ liệu với mảng byte[] làm tham số
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

        private void ButtonDelete_Click(object sender, System.EventArgs e)
        {
            if (tempID == "IHour")
            {
                MessageFuctionConstans.WarningOK("You can't delete default table types.");
                return;
            }
            DialogResult result = MessageFuctionConstans.WarningOKCancell("Confirm deletion of this item?");
            if (result == DialogResult.OK)
            {
                string deleteQuery = @"
                     DELETE FROM items_menu WHERE IdItem = '" + tempID + "';";

                databaseService.ExecuteNonQuery(deleteQuery);

                MessageFuctionConstans.SuccessOK("Type of item deleted successfully.");

                ResetFormInput();
                LoadDataTable();
            }
        }

        private void iconButtonSearch_Click(object sender, System.EventArgs e)
        {
            string searchText = textBoxSearch.Text;
            string searchQuery = @"
             SELECT items_menu.IdItem, items_menu.item_Name,
              items_menu.item_Price,
              items_menu.item_image, 
              items_category.ItemCategory_Name, 
            FROM items_menu 
            JOIN items_category ON items_menu.IdItemCategory = items_category.IdItemCategory
            WHERE items_menu.IdItem LIKE '%" + searchText + @"%' OR
              items_menu.item_Name LIKE '%" + searchText + @"%' OR
              CONVERT(VARCHAR, items_menu.item_Price) LIKE '%" + searchText + @"%' OR 
              items_category.ItemCategory_Name LIKE '%" + searchText + @"%';";

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
        private void iconButtonUploadItem_Click(object sender, System.EventArgs e)
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

            if ((byte[])dataGridViewAddItem.CurrentRow.Cells[3].Value != null)
            {
                byte[] imageData = (byte[])dataGridViewAddItem.CurrentRow.Cells[3].Value;
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    pictureBoxItem.Image = Image.FromStream(ms);
                    tempImg = pictureBoxItem.Image;
                    pictureBoxItem.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

            string selectedTableType = dataGridViewAddItem.CurrentRow.Cells[4].Value.ToString();
            comboBoxItemCategory.SelectedItem = selectedTableType;

            string query = "SELECT IdItemCategory FROM items_category WHERE ItemCategory_Name ='" + selectedTableType + "';";
            DataTable tableTypeData = DatabaseService.Instance.LoadDataTable(query);

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
        }

        private void AddItems_Load(object sender, System.EventArgs e)
        {
            comboBoxItemCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            string query = "SELECT IdItemCategory,ItemCategory_Name FROM items_category";
            DataTable tableTypeData = DatabaseService.Instance.LoadDataTable(query);

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
            // Chỉ áp dụng cho cột chứa hình ảnh
            if (e.Value != null && dataGridViewAddItem.Columns[e.ColumnIndex].Name != "item_image")
            {
                // Kiểm tra nếu giá trị của ô không rỗng và là mảng byte
                if (e.Value != null && e.Value.GetType() == typeof(byte[]))
                {
                    // Đọc dữ liệu hình ảnh từ mảng byte
                    byte[] imageData = (byte[])e.Value;

                    // Tạo hình ảnh từ dữ liệu mảng byte
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);

                        // Đặt kích thước hiển thị cho hình ảnh
                        int desiredWidth = 50; // Đặt chiều rộng mong muốn
                        int desiredHeight = 50; // Đặt chiều cao mong muốn
                        Image resizedImage = ResizeImage(image, desiredWidth, desiredHeight);

                        // Đặt giá trị hiển thị cho ô dữ liệu
                        e.Value = resizedImage;
                    }
                }
            }
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
    }
}
