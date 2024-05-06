using System;
using System.Windows.Forms;

namespace BiaManager.Forms
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void TypeFoodBtn_Click(object sender, EventArgs e)
        {
            ShowFoodTransition.Start();
        }
    }
}
