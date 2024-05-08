using MetroFramework.Controls;
using System;
using System.Windows.Forms;

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

        public string TableStatus
        {
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

            switch (TableStatus)
            {
                case "empty":
                    //picture_table.Image = Properties;
                    picture_table.SizeMode = PictureBoxSizeMode.Zoom;
                    statusPic.Image = Properties.Resources.Status_Empty;
                    statusPic.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "playing":
                    //picture_table.Image = Properties.Resources.bida2;
                    picture_table.SizeMode = PictureBoxSizeMode.Zoom;
                    statusPic.Image = Properties.Resources.Status_Playing;
                    statusPic.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
                case "repair":
                    //picture_table.Image = Properties.Resources.bida3;
                    picture_table.SizeMode = PictureBoxSizeMode.Zoom;
                    statusPic.Image = Properties.Resources.Status_Repair;
                    statusPic.SizeMode = PictureBoxSizeMode.Zoom;
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

        private void StartTable_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void pic_table_MouseHover(object sender, EventArgs e)
        {
            //phat trien them loai ban va tinh trang bang tooltip


            // em lam truoc hien trang thai
            string statusttooltip = " Status :" + TableStatus + "\nType Table :"; // them loai ban
            myTip.SetToolTip(pic_table,statusttooltip);
            

        }

        private void pic_table_MouseLeave(object sender, EventArgs e)
        {
            myTip.Hide(pic_table);
        }
    }
}
