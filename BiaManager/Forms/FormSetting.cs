using BiaManager.Script;
using System.Windows.Forms;

namespace BiaManager.Forms
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        private void toggleButtonMuteSound_CheckedChanged(object sender, System.EventArgs e)
        {
            if (toggleButtonMuteSound.Checked)
            {
            }
            else
            {
            }
        }

        private void ButtonSignOut_Click(object sender, System.EventArgs e)
        {
            DialogResult result = MessageFuctionConstans.WarningOKCancell("Would you like to log out of this account?");
            if (result == DialogResult.OK)
            {
                HomePage.Instance.Close();
                FormLogin formLogin = new FormLogin();
                formLogin.Show();
            }
        }
    }
}
