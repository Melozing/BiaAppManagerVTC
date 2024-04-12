using FontAwesome.Sharp;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BiaManager
{
    public partial class HomePage : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public HomePage()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Struct Color

        private struct RGBColor
        {
            public static Color color1 = Color.FromArgb(172, 126, 176);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();
                currentBtn = (IconButton)sender;
                currentBtn.BackColor = Color.FromArgb(38, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y + panelLogo.Size.Height);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (iconCurrentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            tittleOfChildForm.Text = childForm.Text;
        }

        private void Home_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColor.color1);
        }

        private void Tables_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColor.color2);
        }

        private void Menu_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColor.color3);
        }

        private void Bills_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColor.color4);
        }

        private void User_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColor.color5);
        }

        private void Setting_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColor.color6);
        }

        private void btnHome_Click(object sender, System.EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
        }

        //Drag Form
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTittleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void HomePage_Load(object sender, System.EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizeBtn_Click(object sender, System.EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void iconButton1_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
