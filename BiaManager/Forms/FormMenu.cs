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
        private readonly DatabaseService databaseService = DatabaseService.Instance;
        private FoodTabWidget foodTabWidget;

        public FormMenu()
        {
            InitializeComponent();
            foodTabWidget = new FoodTabWidget();
        }

        private void TypeFoodBtn_Click(object sender, EventArgs e)
        {
            ShowFoodTransition.Start();
        }

        public void GetIDTable(string idTable)
        {
            foodTabWidget.Tag = idTable;
            LoadItem();
        }

        private void LoadItem()
        {
            // Lấy danh sách các mặt hàng
            List<Item> items = GetItems();

            // Lấy danh sách các danh mục mặt hàng
            List<ItemCategory> itemCategories = GetItemCategories();

            // Lấy danh sách các chi tiết hóa đơn

            string idTable = foodTabWidget.Tag.ToString();

            // Hiển thị thông tin mặt hàng theo từng danh mục
            foreach (var category in itemCategories)
            {
                FoodTabWidget foodTabWidgetNew = new FoodTabWidget();
                this.Controls.Add(foodTabWidgetNew);
                foodTabWidgetNew.Dock = DockStyle.Top;
                foodTabWidgetNew.AutoSize = false;


                foodTabWidgetNew.SetFoodTabInfo(category.CategoryName);
                foreach (var item in items)
                {
                    if (item.ItemImage != null && category.CategoryName == item.CategoryName)
                    {
                        if (!string.IsNullOrWhiteSpace(item.ItemName))
                        {
                            List<InvoiceDetailItem> invoiceDetailItems = GetInvoiceDetailItems(item.ItemName);
                            // Đếm số lượng mặt hàng thuộc danh mục hiện tại
                            int itemCount = CountItemsByCategory(invoiceDetailItems, item.ItemName);

                            FoodWidget foodWidget = new FoodWidget();
                            foodWidget.SetIDItem(item.IdItem, idTable);
                            foodWidget.SetFoodInfo(item.ItemName, item.ItemPrice, item.ItemImage);
                            foodTabWidgetNew.AddFood(foodWidget);
                            foodWidget.SetFoodInfoNum(itemCount);
                        }
                    }
                }
            }
        }

        // Hàm lấy danh sách các mặt hàng từ cơ sở dữ liệu
        private List<Item> GetItems()
        {
            string queryItem = @"
               SELECT items_menu.IdItem, items_menu.item_Name,
                      items_menu.item_Price,
                      items_menu.item_image, 
                      items_category.ItemCategory_Name
                 FROM items_menu 
                 JOIN items_category ON items_menu.IdItemCategory = items_category.IdItemCategory;";

            return databaseService.GetData(queryItem, (reader) =>
            {
                Item item = new Item();
                item.IdItem = reader.GetString(0);
                item.ItemName = reader.GetString(1);
                item.ItemPrice = reader.GetInt32(2);
                if (!reader.IsDBNull(3))
                {
                    byte[] imageData = (byte[])reader.GetValue(3);
                    item.ItemImage = imageData;
                }
                item.CategoryName = reader.GetString(4);

                return item;
            });
        }

        // Hàm lấy danh sách các danh mục mặt hàng từ cơ sở dữ liệu
        private List<ItemCategory> GetItemCategories()
        {
            string query = @"
               SELECT ItemCategory_Name, IdItemCategory
                 FROM items_category ORDER BY IdItemCategory DESC;";

            return databaseService.GetData(query, (reader) =>
            {
                ItemCategory category = new ItemCategory();
                category.CategoryName = reader.GetString(0);
                return category;
            });
        }

        // Hàm lấy danh sách các chi tiết hóa đơn từ cơ sở dữ liệu
        private List<InvoiceDetailItem> GetInvoiceDetailItems(string itemName)
        {
            string idTable = foodTabWidget.Tag.ToString();

            string queryDetail = @"SELECT 
                inv.IdInvoice,
                inv.TableID,
                inv.Invoice_time,
                inv.Invoice_Status,
                inv_det.IdItem,
                inv_det.Invoice_TotalAmount,
                itm.item_Name,
                itm.item_Price,
                tbl_det.IdTable,
                tbl_det.Status AS TableStatus,
                itm_cat.ItemCategory_Name,
                itm_cat.IdItemCategory
            FROM 
                invoice AS inv
            JOIN 
                invoice_detail AS inv_det ON inv.IdInvoice = inv_det.IdInvoice
            JOIN 
                items_menu AS itm ON inv_det.IdItem = itm.IdItem
            JOIN 
                table_detail AS tbl_det ON inv.TableID = tbl_det.IdTable
            JOIN
                items_category AS itm_cat ON itm.IdItemCategory = itm_cat.IdItemCategory
            WHERE inv.Invoice_Status = 0 AND inv.TableID ='" + idTable + "' " +
            "AND itm.item_Name = '" + itemName + "'" +
            "AND itm.IdItem != 'IHour';";

            return databaseService.GetData(queryDetail, (reader) =>
            {
                InvoiceDetailItem invoiceDetail = new InvoiceDetailItem();
                invoiceDetail.IdInvoice = reader.GetString(0);
                invoiceDetail.TableID = reader.GetString(1);
                invoiceDetail.InvoiceTime = reader.GetDateTime(2);
                invoiceDetail.InvoiceStatus = reader.GetInt32(3);
                invoiceDetail.IdItem = reader.GetString(4);
                invoiceDetail.InvoiceTotalAmount = reader.GetInt32(5);
                invoiceDetail.ItemName = reader.GetString(6);
                invoiceDetail.ItemPrice = reader.GetInt32(7);
                invoiceDetail.IdTable = reader.GetString(8);
                invoiceDetail.TableStatus = reader.GetInt32(9);
                invoiceDetail.ItemCategoryName = reader.GetString(10);
                return invoiceDetail;
            });
        }

        // Hàm đếm số lượng mặt hàng thuộc một danh mục
        private int CountItemsByCategory(List<InvoiceDetailItem> invoiceDetailItems, string itemName)
        {
            int count = 0;
            foreach (var itemDetail in invoiceDetailItems)
            {
                if (itemDetail.ItemName == itemName)
                {
                    count += itemDetail.InvoiceTotalAmount; // Sử dụng số lượng đã đặt của mỗi mặt hàng
                }
            }
            return count;
        }

    }
}
