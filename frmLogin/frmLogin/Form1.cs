﻿using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace frmLogin
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát chương trình !", "Xác nhận",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Cancel)

            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(this.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(this.Width - radius * 2, this.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, this.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseAllFigures();
            this.Region = new Region(path);

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Gọi hàm ReleaseCapture để giải phóng con trỏ chuột
                ReleaseCapture();
                // Gửi một thông điệp tới form cha để di chuyển cửa sổ
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbusername.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập !");
                tbusername.Focus();
                return;
            }
            else if (tbpassword.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu !");
                tbpassword.Focus();
                return;
            }

            MessageBox.Show("đã login");
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            tbpassword.UseSystemPasswordChar = false;
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            tbpassword.UseSystemPasswordChar = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của hình ảnh đã chọn
                string imagePath = openFileDialog.FileName;

                // Tạo một đối tượng Image từ đường dẫn
                Image image = Image.FromFile(imagePath);

                // Thiết lập hình ảnh làm hình nền của PictureBox
                pictureBox3.Image = image;

                // Giữ hình ảnh tỷ lệ và điều chỉnh kích thước PictureBox
                pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}