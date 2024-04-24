using BiaManager.Contants;
using System.Windows.Forms;

namespace BiaManager.Script
{
    public static class MessageFuctionConstans
    {
        public static void WarningOK(string content)
        {
            MessageBox.Show(content, MessageNameContants.Warning, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static DialogResult WarningOKCancell(string content)
        {
            return MessageBox.Show(content, "Confirm",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        public static void SuccessOK(string content)
        {
            MessageBox.Show(content, MessageNameContants.Notification, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
