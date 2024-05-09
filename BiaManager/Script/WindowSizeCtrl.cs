using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BiaManager.Script
{
    public static class WindowSizeCtrl
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern void ReleaseCapture();

        public static void MoveWindow(IntPtr handle)
        {
            ReleaseCapture();
            SendMessage(handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        public static FormWindowState MinimizeAndScale(FormWindowState windowState)
        {
            if (windowState == FormWindowState.Normal)
            {
                return FormWindowState.Maximized;
            }
            else
            {
                return FormWindowState.Normal;
            }
        }

        public static FormWindowState MinimizeForm(FormWindowState windowState)
        {
            return FormWindowState.Minimized;
        }
    }
}
