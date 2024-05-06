using BiaManager.Components;
using BiaManager.Model;
using BiaManager.Script;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BiaManager.Forms
{
    public partial class FormMenu : Form
    {
        DatabaseService databaseService = new DatabaseService();
        public FormMenu()
        {
            InitializeComponent();
            LoadItem();
        }

        private void TypeFoodBtn_Click(object sender, EventArgs e)
        {
            ShowFoodTransition.Start();
        }

        private void LoadItem()
        {
            List<Item> items = new List<Item>();

            // Thực hiện truy vấn SQL để lấy dữ liệu từ cơ sở dữ liệu
            string query = @"
               SELECT items_menu.IdItem, items_menu.item_Name,
                      items_menu.item_Price,
                      items_menu.item_image, 
                      items_category.ItemCategory_Name
                 FROM items_menu 
                 JOIN items_category ON items_menu.IdItemCategory = items_category.IdItemCategory;";

            // Đọc dữ liệu từ cơ sở dữ liệu và thêm vào danh sách
            items = databaseService.GetData(query, (reader) =>
            {
                Item item = new Item();
                item.IdItem = reader.GetString(0);
                item.ItemName = reader.GetString(1);
                item.ItemPrice = reader.GetInt32(2);
                // Đọc hình ảnh nếu có
                if (!reader.IsDBNull(3))
                {
                    // Chuyển đổi dữ liệu hình ảnh thành mảng byte
                    byte[] imageData = (byte[])reader.GetValue(3);
                    // Gán dữ liệu hình ảnh vào thuộc tính ItemImage
                    item.ItemImage = imageData;
                }
                item.CategoryName = reader.GetString(4);

                return item;
            });

            // Hiển thị thông tin mặt hàng
            foreach (var item in items)
            {
                // Nếu có hình ảnh, bạn có thể hiển thị nó bằng cách gán cho một PictureBox hoặc hiển thị trong các điều khiển khác
                if (item.ItemImage != null)
                {
                    FoodTabWidget foodTabWidget = new FoodTabWidget();
                    this.Controls.Add(foodTabWidget);
                    foodTabWidget.Dock = DockStyle.Top;
                    foodTabWidget.AutoSize = false;
                    foodTabWidget.SetFoodTabInfo(item.CategoryName, 0);
                    if (string.IsNullOrWhiteSpace(item.ItemName))
                    {
                        FoodWidget foodWidget = new FoodWidget();
                        foodWidget.SetFoodInfo(item.ItemName, item.ItemPrice, item.ItemImage);
                        foodTabWidget.AddFood(foodWidget);
                    }
                }
            }
        }
    }
}
