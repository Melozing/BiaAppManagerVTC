using BiaManager.Script;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BiaManager.Forms.AdminForm.Staff
{
    internal partial class AddStaff : Form
    {
        DatabaseService databaseService = new DatabaseService();

        private Size addStaffFormSize;
        private Rectangle usernameLabelRectangle;
        private Rectangle usernameTextBoxRectangle;

        private Rectangle passwordLabelRectangle;
        private Rectangle passwordTextBoxRectangle;

        private Rectangle passwordConfirmLabelRectangle;
        private Rectangle passwordConfirmTextBoxRectangle;

        private Rectangle fullnameLabelRectangle;
        private Rectangle fullnameTextBoxRectangle;

        private Rectangle phoneLabelRectangle;
        private Rectangle phoneTextBoxRectangle;

        private Rectangle bankAccountNumbereLabelRectangle;
        private Rectangle bankAccountNumberTextBoxRectangle;

        private Rectangle bankAccountNameLabelRectangle;
        private Rectangle bankAccountNameTextBoxRectangle;

        private Rectangle SearchTextBoxRectangle;
        private Rectangle SearchIconBoxRectangle;

        private Rectangle ButtonStaffManagerRectangle;

        private Size UsernameLabelSize;
        private Size textBoxUsernameSize;
        private Size PasswordLabelSize;
        private Size textBoxPasswordSize;
        private Size labelConfirmPasswordSize;
        private Size textBoxConfirmPasswordSize;
        private Size FullnameLabelSize;
        private Size textBoxFullnameSize;
        private Size PhoneLabelSize;
        private Size textBoxPhoneSize;
        private Size BankNumberLabelSize;
        private Size textBoxBankNumberSize;
        private Size BankNameLabelSize;
        private Size textBoxBankNameSize;
        private Size textBoxSearchSize;
        private Size iconButtonSearchSize;
        private Size ButtonStaffManagerSize;

        public AddStaff()
        {
            InitializeComponent();

            UsernameLabelSize = UsernameLabel.Size;
            textBoxUsernameSize = textBoxUsername.Size;
            PasswordLabelSize = PasswordLabel.Size;
            textBoxPasswordSize = textBoxPassword.Size;
            labelConfirmPasswordSize = labelConfirmPassword.Size;
            textBoxConfirmPasswordSize = textBoxConfirmPassword.Size;
            FullnameLabelSize = FullnameLabel.Size;
            textBoxFullnameSize = textBoxFullname.Size;
            PhoneLabelSize = PhoneLabel.Size;
            textBoxPhoneSize = textBoxPhone.Size;
            BankNumberLabelSize = BankNumberLabel.Size;
            textBoxBankNumberSize = textBoxBankNumber.Size;
            BankNameLabelSize = BankNameLabel.Size;
            textBoxBankNameSize = textBoxBankName.Size;
            textBoxSearchSize = textBoxSearch.Size;
            iconButtonSearchSize = iconButtonSearch.Size;
            ButtonStaffManagerSize = ButtonStaffManager.Size;

            this.Resize += AddStaff_Resize;
            addStaffFormSize = this.Size;

            usernameLabelRectangle = new Rectangle(UsernameLabel.Location, UsernameLabel.Size);
            usernameTextBoxRectangle = new Rectangle(textBoxUsername.Location, textBoxUsername.Size);

            passwordLabelRectangle = new Rectangle(PasswordLabel.Location, PasswordLabel.Size);
            passwordTextBoxRectangle = new Rectangle(textBoxPassword.Location, textBoxPassword.Size);

            passwordConfirmLabelRectangle = new Rectangle(labelConfirmPassword.Location, labelConfirmPassword.Size);
            passwordConfirmTextBoxRectangle = new Rectangle(textBoxConfirmPassword.Location, textBoxConfirmPassword.Size);

            fullnameLabelRectangle = new Rectangle(FullnameLabel.Location, FullnameLabel.Size);
            fullnameTextBoxRectangle = new Rectangle(textBoxFullname.Location, textBoxFullname.Size);

            phoneLabelRectangle = new Rectangle(PhoneLabel.Location, PhoneLabel.Size);
            phoneTextBoxRectangle = new Rectangle(textBoxPhone.Location, textBoxPhone.Size);

            bankAccountNumbereLabelRectangle = new Rectangle(BankNumberLabel.Location, BankNumberLabel.Size);
            bankAccountNumberTextBoxRectangle = new Rectangle(textBoxBankNumber.Location, textBoxBankNumber.Size);

            bankAccountNameLabelRectangle = new Rectangle(BankNameLabel.Location, BankNameLabel.Size);
            bankAccountNameTextBoxRectangle = new Rectangle(textBoxBankName.Location, textBoxBankName.Size);

            SearchTextBoxRectangle = new Rectangle(textBoxSearch.Location, textBoxSearch.Size);
            SearchIconBoxRectangle = new Rectangle(iconButtonSearch.Location, iconButtonSearch.Size);

            ButtonStaffManagerRectangle = new Rectangle(ButtonStaffManager.Location, ButtonStaffManager.Size);
            LoadStaff();
        }

        private void LoadStaff()
        {
            string queryStaffInfo = "SELECT * FROM user_account JOIN user_info ON user_account.idUser = user_info.idUser";

            dataGridViewStaffInfo.DataSource = DatabaseService.Instance.LoadDataTable(queryStaffInfo);
        }

        private void AddStaff_Resize(object sender, EventArgs e)
        {
            resize_Control(UsernameLabel, usernameLabelRectangle);
            resize_Control(textBoxUsername, usernameTextBoxRectangle);

            resize_Control(PasswordLabel, passwordLabelRectangle);
            resize_Control(textBoxPassword, passwordTextBoxRectangle);

            resize_Control(labelConfirmPassword, passwordConfirmLabelRectangle);
            resize_Control(textBoxConfirmPassword, passwordConfirmTextBoxRectangle);

            resize_Control(FullnameLabel, fullnameLabelRectangle);
            resize_Control(textBoxFullname, fullnameTextBoxRectangle);

            resize_Control(PhoneLabel, phoneLabelRectangle);
            resize_Control(textBoxPhone, phoneTextBoxRectangle);

            resize_Control(BankNumberLabel, bankAccountNumbereLabelRectangle);
            resize_Control(textBoxBankNumber, bankAccountNumberTextBoxRectangle);

            resize_Control(BankNameLabel, bankAccountNameLabelRectangle);
            resize_Control(textBoxBankName, bankAccountNameTextBoxRectangle);

            resize_Control(textBoxSearch, SearchTextBoxRectangle);
            resize_Control(iconButtonSearch, SearchIconBoxRectangle);

            resize_Control(ButtonStaffManager, ButtonStaffManagerRectangle);
        }

        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(addStaffFormSize.Width);
            float yRatio = (float)(this.Height) / (float)(addStaffFormSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            if (newHeight >= 40)
            {
                c.Location = r.Location;
                c.Size = r.Size;
                UsernameLabel.Size = UsernameLabelSize;
                textBoxUsername.Size = textBoxUsernameSize;
                PasswordLabel.Size = PasswordLabelSize;
                textBoxPassword.Size = textBoxPasswordSize;
                labelConfirmPassword.Size = labelConfirmPasswordSize;
                textBoxConfirmPassword.Size = textBoxConfirmPasswordSize;
                FullnameLabel.Size = FullnameLabelSize;
                textBoxFullname.Size = textBoxFullnameSize;
                PhoneLabel.Size = PhoneLabelSize;
                textBoxPhone.Size = textBoxPhoneSize;
                BankNumberLabel.Size = BankNumberLabelSize;
                textBoxBankNumber.Size = textBoxBankNumberSize;
                BankNameLabel.Size = BankNameLabelSize;
                textBoxBankName.Size = textBoxBankNameSize;
                textBoxSearch.Size = textBoxSearchSize;
                iconButtonSearch.Size = iconButtonSearchSize;
                ButtonStaffManager.Size = ButtonStaffManagerSize;
            }
            else
            {
                c.Location = new Point(newX, newY);
                c.Size = new Size(newWidth, newHeight);
            }
        }

        public bool CheckAccount(string username)
        {
            return Regex.IsMatch(username, "^[a-zA-Z0-9]{6,24}");
        }

        private void ButtonStaffManager_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string passwordConfirm = textBoxConfirmPassword.Text;
            string fullName = textBoxFullname.Text;
            string phone = textBoxPhone.Text;
            string bankNum = textBoxBankNumber.Text;
            string bankName = textBoxBankName.Text;
            string idUser;
            // Kiểm tra tính hợp lệ của tên đăng nhập và mật khẩu
            if (!CheckAccount(username) || !CheckAccount(password))
            {
                MessageFuctionConstans.WarningOK("Please enter a valid username and password. They should be 6-24 characters long and should not contain any special characters!");
                return;
            }

            // Kiểm tra xác nhận mật khẩu
            if (password != passwordConfirm)
            {
                MessageFuctionConstans.WarningOK("The password and the confirmation password do not match.");
                return;
            }

            // Kiểm tra số điện thoại đã tồn tại trong cơ sở dữ liệu hay chưa
            string queryCheckPhone = "SELECT * FROM user_info WHERE User_Phone = '" + phone + "'";
            DataTable checkQuery = DatabaseService.Instance.LoadDataTable(queryCheckPhone);

            if (checkQuery.Rows.Count > 0)
            {
                MessageFuctionConstans.WarningOK("This phone number already exists. Please enter another number.");
                return;
            }

            string queryGetQuantity = "SELECT * FROM user_info";
            DataTable GetQuantity = DatabaseService.Instance.LoadDataTable(queryGetQuantity);
            int num = GetQuantity.Rows.Count + 1;
            string timestamp = DateTime.Now.ToString("yyMMdd");
            idUser = "U" + num + timestamp;

            // Thực hiện truy vấn INSERT cho bảng user_account và user_info
            string insertQuery = @"DECLARE @idUser INT;
                      INSERT INTO user_account (IdUser, UserName, UserPassword, UserRole) VALUES ('" + idUser + "', '" + username + "', '" + password + "', 1); " +
                                 "SET @idUser = SCOPE_IDENTITY();" +
                                 "INSERT INTO user_info (idUser, User_FullName, User_Phone, User_BankAccountNumber, User_BankName) VALUES ('" + idUser + "', '" + fullName + "', '" + phone + "', '" + bankNum + "', '" + bankName + "')";

            databaseService.ExecuteNonQuery(insertQuery);

            MessageFuctionConstans.SuccessOK("Account created successfully.");
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmPassword.Text = "";
            textBoxFullname.Text = "";
            textBoxPhone.Text = "";
            textBoxBankNumber.Text = "";
            textBoxBankName.Text = "";
            LoadStaff();
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonStaffManager.PerformClick();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonStaffManager.PerformClick();
            }
        }

        private void textBoxConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonStaffManager.PerformClick();
            }
        }

        private void textBoxFullname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonStaffManager.PerformClick();
            }
        }

        private void textBoxPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonStaffManager.PerformClick();
            }
        }

        private void textBoxBankNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonStaffManager.PerformClick();
            }
        }

        private void textBoxBankName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonStaffManager.PerformClick();
            }
        }
    }
}
