using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace BiaManager.Forms
{
    public partial class FormTables : MetroForm
    {
        public FormTables()
        {
            InitializeComponent();


            this.MouseUp += FormTables_MouseUp;


            addTablesToolStripMenuItem.Click += AddTableToolStripMenuItem_Click;
            checkToolStripMenuItem.Click += CheckTableToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
        }

        private void FormTables_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {

                metroContextMenu1.Show(this, e.Location);
            }
        }

        private void AddTableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CheckTableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Thực hiện hành động khi click vào Exit
            Application.Exit();
        }
    }
}
