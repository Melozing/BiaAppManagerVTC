using BiaManager.Model;
using BiaManager.Script;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;


namespace BiaManager.Forms
{
    public partial class FormLogin : Form
    {
        DatabaseService databaseService = DatabaseService.Instance;

        public FormLogin()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


            string directoryPath = @"\BiaAppManagerVTC\BiaManager\Resources\loading login";

            var imagePaths = Directory.GetFiles(directoryPath, "anhlogin*.jpg");

            if (imagePaths.Length > 0)
            {
                Random random = new Random();
                string randomImagePath = imagePaths[random.Next(imagePaths.Length)];
                pictureBox1.ImageLocation = randomImagePath;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.anhlogin;
            }

            timer.Interval = 120;
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void btclose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageFuctionConstans.OKCancel("Bạn muốn thoát chương trình !");
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void MaximizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = WindowSizeCtrl.MinimizeAndScale(this.WindowState);
        }
        private void MinimizeIconButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 15;
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(this.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(this.Width - radius * 2, this.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, this.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseAllFigures();
            this.Region = new Region(path);
        }


        private void Loginbtn_Click(object sender, EventArgs e)
        {
            if (textbox_username.Text == "")
            {
                MessageFuctionConstans.WarningOK("Bạn chưa nhập tên đăng nhập !");
                textbox_username.Focus();
                return;
            }
            else if (textbox_pass.Text == "")
            {
                MessageFuctionConstans.WarningOK("Bạn chưa nhập mật khẩu !");
                textbox_pass.Focus();
                return;
            }
            else
            {
                string query = "Select * from user_account where UserName = '" + textbox_username.Text + "'and UserPassword ='" + textbox_pass.Text + "'";
                List<Account> accounts = databaseService.GetData(query, (reader) =>
                {
                    Account account = new Account();
                    account.Username = reader.GetString(0);
                    account.Password = reader.GetString(1);
                    account.UserRole = reader.GetInt32(3);
                    return account;
                });

                if (accounts.Count > 0)
                {
                    OnLoginSuccessfully(accounts[0]);
                }
                else
                {
                    MessageFuctionConstans.WarningOK("The account you entered does not exist.");
                }
            }
        }

        private void OnLoginSuccessfully(Account account)
        {
            MessageFuctionConstans.WarningOK("Login Successfully!");
            this.Hide();
            HomePage homePage = HomePage.Instance;
            if (homePage != null && !homePage.IsDisposed)
            {
                homePage.GetUserRole(account.UserRole);
                homePage.Show();
            }
            else
            {
                HomePage_FormClosed(this, new FormClosedEventArgs(CloseReason.None));
            }
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (HomePage.Instance == null || HomePage.Instance.IsDisposed)
            {
                HomePage newInstance = new HomePage();
                newInstance.Show();
                this.Hide();
            }
        }


        private void HidePassword_MouseDown(object sender, MouseEventArgs e)
        {
            textbox_pass.UseSystemPasswordChar = false;
        }

        private void HidePassword_MouseUp(object sender, MouseEventArgs e)
        {
            textbox_pass.UseSystemPasswordChar = true;
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
                pictureBox1.Image = image;

                // Giữ hình ảnh tỷ lệ và điều chỉnh kích thước PictureBox
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void PanelTaskbarLogin_MouseDown(object sender, MouseEventArgs e)
        {
            WindowSizeCtrl.MoveWindow(this.Handle);
        }

        private void tbusername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin.PerformClick();
            }
        }

        private void tbpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin.PerformClick();
            }
        }

        private void panelLogin_Click(object sender, EventArgs e)
        {
            textbox_username.Focus();
        }

        private void PanelLoginContent_Click(object sender, EventArgs e)
        {
            textbox_username.Focus();
        }

        private void AvatarGif_Click(object sender, EventArgs e)
        {
            textbox_username.Focus();
        }

        private Timer timer = new Timer();
        private int currentPosition = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Di chuyển chữ chạy
            currentPosition += 10; // Điều chỉnh tốc độ chạy tại đây (ví dụ: 5 pixel mỗi lần cập nhật)

            // Nếu chữ di chuyển ra khỏi khung của label, đặt lại vị trí cho nó
            if (currentPosition > label1.Width)
            {
                currentPosition = -label1.Width;
            }

            // Cập nhật vị trí của label
            label1.Location = new System.Drawing.Point(currentPosition, label1.Location.Y);
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageFuctionConstans.WarningOKCancell("Bạn muốn thoát chương trình !");
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đăng ký đang tạm khóa!", "Bảo trì tính năng", MessageBoxButtons.OK);
            return;

        }

        private void showpass_Click(object sender, EventArgs e)
        {
                textbox_pass.PasswordChar = '\0';
                showpass.Text = "show";
            
            
        }
    }
}
