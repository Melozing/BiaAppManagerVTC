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
    public partial class Table_Items : MetroUserControl
    {

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
        public Table_Items()
        {
            InitializeComponent();
            InitializeControl();
        }

        private void InitializeControl()
        {
            
            this.Size = new Size(242, 229);

            
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Properties.Resources.bida1;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.Controls.Add(pictureBox);

            
            Label statusLabel = new Label();
            statusLabel.Text = "Status : ";
            this.Controls.Add(statusLabel);

            
            Button actionButton = new Button();
            actionButton.Click += ActionButton_Click;
            this.Controls.Add(actionButton);
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            
            switch (TableStatus)
            {
                case "empty":
                    MessageBox.Show("Play");
                    break;
                case "playing":
                    MessageBox.Show("Pay");
                    break;
                case "repair":
                    MessageBox.Show("Repair");
                    break;
                default:
                    break;
            }
        }

        private void UpdateStatusTable()
        {
            
            PictureBox pictureBox = this.Controls[0] as PictureBox;
            Button actionButton = this.Controls[2] as Button;
            Label statusLabel = this.Controls[1] as Label;

            switch (TableStatus)
            {
                case "empty":
                    pictureBox.Image = Properties.Resources.bida1;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    actionButton.Text = "Play";
                    statusLabel.Text = "Statu : Empty";
                    break;
                case "playing":
                    pictureBox.Image = Properties.Resources.bida2;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    actionButton.Text = "Pay";
                    statusLabel.Text = "Statu : Playing";
                    break;
                case "repair":
                    pictureBox.Image = Properties.Resources.bida3;
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    actionButton.Text = "Repair";
                    statusLabel.Text = "Statu : Repairing";
                    break;
                default:
                    break;
            }
        }


    }
}
