using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace BiaManager.Forms.item
{
    public partial class table_item : MetroUserControl
    {
        public table_item()
        {
            InitializeComponent();
            myTip = new ToolTip();
            myTip.AutoPopDelay = 5000;
            myTip.InitialDelay = 1000;
            myTip.ReshowDelay = 500;
            myTip.ShowAlways = true;
        }

        private ToolTip myTip;

        private string tableStatus;

        public string TableStatus{
            get { return tableStatus; }
            set
            {
                tableStatus = value;
                UpdateStatusTable();
            }
        }
        
        

        private void PicBoxStatus_MouseHover(object sender, EventArgs e)
        {
            string statusText = GetStatusText();
            myTip.SetToolTip(pic_status, $"Status: {statusText}");
        }

        private string GetStatusText()
        {
            
            switch (TableStatus)
            {
                case "empty":
                    return "Online";
                case "playing":
                    return "Playing";
                case "repair":
                    return "Repair";
                default:
                    return "";
            }
        }

        private void UpdateStatusTable()
        {
            PictureBox picture_table = this.pic_table;
            Button actionButton = this.Btn_Click_Table;
            PictureBox picture_status = this.pic_status;

            switch (TableStatus)
            {
                case "empty":
                    picture_table.Image = Properties.Resources.bida1;
                    picture_table.SizeMode = PictureBoxSizeMode.Zoom;
                    actionButton.Text = "Order";
                    picture_status.Image = Properties.Resources.Status_Empty;
                    picture_status.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "playing":
                    picture_table.Image = Properties.Resources.bida2;
                    picture_table.SizeMode = PictureBoxSizeMode.Zoom;
                    actionButton.Text = "Pay";
                    picture_status.Image = Properties.Resources.Status_Playing;
                    picture_status.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "repair":
                    picture_table.Image = Properties.Resources.bida3;
                    picture_table.SizeMode = PictureBoxSizeMode.Zoom;
                    actionButton.Text = "Repairing";
                    picture_status.Image = Properties.Resources.Status_Repair;
                    picture_status.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                default:
                    break;
            }
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            switch (TableStatus)
            {
                case "empty":
                    MessageBox.Show("Play");
                    //phat trien them
                    break;
                case "playing":
                    MessageBox.Show("Pay");
                    //phat trien them
                    break;
                case "repair":
                    
                    MessageBox.Show("Bable is under repair, cannot play!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    break;
            }
        }

    }
}
