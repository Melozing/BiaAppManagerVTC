﻿using BiaManager.Components;
using BiaManager.Script;
using System;
using System.Data;
using System.Windows.Forms;

namespace BiaManager.Forms
{
    public partial class FormTables : Form
    {
        public FormTables()
        {
            InitializeComponent();
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormTables_Load(object sender, EventArgs e)
        {
            string queryInfo = "SELECT table_detail.IdTable, table_detail.TableNumber, " +
               "table_detail.Status, " +
               "table_detail.IdTableType, " +
               "table_type.TableType_Name, " +
               "table_type.TableType_Price " +
               "FROM table_detail JOIN table_type " +
               "ON table_detail.IdTableType = table_type.IdTableType ORDER BY table_detail.TableNumber;";
            DataTable table = DatabaseService.Instance.LoadDataTable(queryInfo);
            foreach (DataRow row in table.Rows)
            {
                TableWidget tableWidget = new TableWidget();
                string idTable = row["IdTable"].ToString();
                string tableNumber = row["TableNumber"].ToString();
                string IdTableType = row["IdTableType"].ToString();
                int status = Convert.ToInt32(row["Status"]);
                tableWidget.SetTableData(tableNumber, status, idTable, IdTableType);
                flowLayoutPanelTables.Controls.Add(tableWidget);
            }
        }
    }
}
