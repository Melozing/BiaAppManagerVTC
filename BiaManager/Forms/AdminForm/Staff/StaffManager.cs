using BiaManager.Script;
using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BiaManager.Forms.AdminForm.Staff
{
    internal partial class StaffManager : Form
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

        private string tempID;
        private string tempPhone;

        public StaffManager()
        {
            InitializeComponent();
            ResetSubmitButton();

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
            ButtonStaffManagerSize = ButtonCreateStaffManager.Size;

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

            ButtonStaffManagerRectangle = new Rectangle(ButtonCreateStaffManager.Location, ButtonCreateStaffManager.Size);
            LoadStaff();
        }

        private void ResetSubmitButton()
        {
            ButtonUpdateStaffManager.Hide();
            ButtonDeleteStaffManager.Hide();
            ButtonCreateStaffManager.Show();
        }

        private void LoadStaff()
        {
            string queryStaffInfo = "SELECT user_account.idUser, user_account.UserName, " +
                "user_account.UserPassword, " +
                "user_info.User_FullName, user_info.User_Phone, " +
                "user_info.User_BankAccountNumber, " +
                "user_info.User_BankName " +
                "FROM user_account JOIN user_info " +
                "ON user_account.idUser = user_info.idUser;";

            dataGridViewStaffInfo.DataSource = DatabaseService.Instance.LoadDataTable(queryStaffInfo);

            dataGridViewStaffInfo.Columns["idUser"].HeaderText = "User ID";
            dataGridViewStaffInfo.Columns["Username"].HeaderText = "Username";
            dataGridViewStaffInfo.Columns["UserPassword"].HeaderText = "Password";
            dataGridViewStaffInfo.Columns["User_FullName"].HeaderText = "Full Name";
            dataGridViewStaffInfo.Columns["User_Phone"].HeaderText = "Phone";
            dataGridViewStaffInfo.Columns["User_BankAccountNumber"].HeaderText = "Bank Account Number";
            dataGridViewStaffInfo.Columns["User_BankName"].HeaderText = "Bank Name";
            ResetSubmitButton();
        }

        private void AddStaff_Resize(object sender, EventArgs e)
        {
            //if (panelAddContainer.Height > 400) return;
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

            resize_Control(ButtonCreateStaffManager, ButtonStaffManagerRectangle);
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
                ButtonCreateStaffManager.Size = ButtonStaffManagerSize;
                ButtonCreateStaffManager.Location = new Point(textBoxBankName.Location.X, textBoxBankName.Location.Y + 40);
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

        private void ResetFormAddStaff()
        {
            textBoxUsername.ResetText();
            textBoxPassword.ResetText();
            textBoxConfirmPassword.ResetText();
            textBoxFullname.ResetText();
            textBoxPhone.ResetText();
            textBoxBankNumber.ResetText();
            textBoxBankName.ResetText();
        }

        private void textBoxUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckSubmitButton();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckSubmitButton();
            }
        }

        private void textBoxConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckSubmitButton();
            }
        }

        private void textBoxFullname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckSubmitButton();
            }
        }

        private void textBoxPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckSubmitButton();
            }
        }

        private void textBoxBankNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckSubmitButton();
            }
        }

        private void textBoxBankName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckSubmitButton();
            }
        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                iconButtonSearch.PerformClick();
            }
        }

        private void CheckSubmitButton()
        {
            if (!ButtonCreateStaffManager.Visible && ButtonUpdateStaffManager.Visible)
            {
                ButtonUpdateStaffManager.PerformClick();
            }
            else if (ButtonCreateStaffManager.Visible && !ButtonUpdateStaffManager.Visible)
            {
                ButtonCreateStaffManager.PerformClick();
            }
        }

        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = @"
            SELECT ua.UserName, ui.User_FullName, ui.User_Phone, ui.User_BankAccountNumber, ui.User_BankName
            FROM user_account ua
            JOIN user_info ui ON ua.IdUser = ui.IdUser
            WHERE ua.UserName LIKE '%" + textBoxSearch.Text + @"%' OR
              ui.User_FullName LIKE '%" + textBoxSearch.Text + @"%' OR
              ui.User_Phone LIKE '%" + textBoxSearch.Text + @"%' OR
              ui.User_BankAccountNumber LIKE '%" + textBoxSearch.Text + @"%' OR
              ui.User_BankName LIKE '%" + textBoxSearch.Text + @"%';";

            // Sử dụng phương thức LoadDataTable để lấy dữ liệu từ câu truy vấn search
            DataTable searchResult = databaseService.LoadDataTable(searchQuery);

            // Hiển thị kết quả tìm kiếm trên giao diện người dùng, ví dụ: trong DataGridView
            dataGridViewStaffInfo.DataSource = searchResult;
        }


        private void ButtonStaffManager_Click(object sender, EventArgs e)
        {
            if (!CheckUserInputCreate()) return;

            string idUser = GrenateNewID();
            // Thực hiện truy vấn INSERT cho bảng user_account và user_info
            string insertQuery = @"DECLARE @idUser INT;
                      INSERT INTO user_account (IdUser, UserName, UserPassword, UserRole) VALUES ('" + idUser + "', '" + textBoxUsername.Text + "', '" + textBoxPassword.Text + "', 1); " +
                                 "SET @idUser = SCOPE_IDENTITY();" +
                                 "INSERT INTO user_info (idUser, User_FullName, User_Phone, User_BankAccountNumber, User_BankName) VALUES ('" + idUser + "', '" + textBoxFullname.Text + "', '" + textBoxPhone.Text + "', '" + textBoxBankNumber.Text + "', '" + textBoxBankName.Text + "')";

            databaseService.ExecuteNonQuery(insertQuery);

            MessageFuctionConstans.SuccessOK("Account created successfully.");
            ResetFormAddStaff();
            LoadStaff();
        }

        private string GrenateNewID()
        {
            // Tạo một UUID bằng cách sử dụng hàm NEWID() trong SQL Server
            string queryGetUUID = "SELECT NEWID() AS UUID";
            string uuid = DatabaseService.Instance.ExecuteScalar<string>(queryGetUUID);

            // Chỉ lấy 8 ký tự đầu của UUID để làm ID
            string newId = "U" + uuid.Substring(0, 7);

            // Kiểm tra xem ID đã tồn tại trong cơ sở dữ liệu chưa
            string queryCheckExist = "SELECT COUNT(*) FROM user_info WHERE idUser = '" + newId + "'";
            int count = DatabaseService.Instance.ExecuteScalar<int>(queryCheckExist);

            // Nếu ID đã tồn tại, thử lại đến khi tạo ra một ID mới và duy nhất
            while (count > 0)
            {
                uuid = DatabaseService.Instance.ExecuteScalar<string>(queryGetUUID);
                newId = "U" + uuid.Substring(0, 7);
                count = DatabaseService.Instance.ExecuteScalar<int>(queryCheckExist);
            }

            return newId;
        }

        private bool CheckUserInputUpdate()
        {
            // Kiểm tra tính hợp lệ của tên đăng nhập và mật khẩu
            if (!CheckAccount(textBoxUsername.Text) || !CheckAccount(textBoxPassword.Text))
            {
                MessageFuctionConstans.WarningOK("Please enter a valid username and password. They should be 6-24 characters long and should not contain any special characters!");
                return false;
            }

            // Kiểm tra xác nhận mật khẩu
            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageFuctionConstans.WarningOK("The password and the confirmation password do not match.");
                return false;
            }

            // Kiểm tra số điện thoại đã tồn tại trong cơ sở dữ liệu hay chưa
            string queryCheckPhone = "SELECT * FROM user_info WHERE User_Phone = '" + textBoxPhone.Text + "' AND '" + tempPhone + "' != '" + textBoxPhone.Text + "'";
            DataTable checkQuery = DatabaseService.Instance.LoadDataTable(queryCheckPhone);

            if (checkQuery.Rows.Count > 0)
            {
                MessageFuctionConstans.WarningOK("This phone number already exists. Please enter another number.");
                return false;
            }
            return true;
        }
        private bool CheckUserInputCreate()
        {
            // Kiểm tra tính hợp lệ của tên đăng nhập và mật khẩu
            if (!CheckAccount(textBoxUsername.Text) || !CheckAccount(textBoxPassword.Text))
            {
                MessageFuctionConstans.WarningOK("Please enter a valid username and password. They should be 6-24 characters long and should not contain any special characters!");
                return false;
            }

            // Kiểm tra xác nhận mật khẩu
            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageFuctionConstans.WarningOK("The password and the confirmation password do not match.");
                return false;
            }

            // Kiểm tra số điện thoại đã tồn tại trong cơ sở dữ liệu hay chưa
            string queryCheckPhone = "SELECT * FROM user_info WHERE User_Phone = '" + textBoxPhone.Text + "'";
            DataTable checkQuery = DatabaseService.Instance.LoadDataTable(queryCheckPhone);

            if (checkQuery.Rows.Count > 0)
            {
                MessageFuctionConstans.WarningOK("This phone number already exists. Please enter another number.");
                return false;
            }
            return true;
        }


        private void dataGridViewStaffInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tempID = dataGridViewStaffInfo.CurrentRow.Cells[0].Value.ToString();
            textBoxUsername.Text = dataGridViewStaffInfo.CurrentRow.Cells[1].Value.ToString();
            textBoxPassword.Text = dataGridViewStaffInfo.CurrentRow.Cells[2].Value.ToString();
            textBoxConfirmPassword.Text = dataGridViewStaffInfo.CurrentRow.Cells[2].Value.ToString();
            textBoxFullname.Text = dataGridViewStaffInfo.CurrentRow.Cells[3].Value.ToString();
            textBoxPhone.Text = dataGridViewStaffInfo.CurrentRow.Cells[4].Value.ToString();
            tempPhone = dataGridViewStaffInfo.CurrentRow.Cells[4].Value.ToString();
            textBoxBankNumber.Text = dataGridViewStaffInfo.CurrentRow.Cells[5].Value.ToString();
            textBoxBankName.Text = dataGridViewStaffInfo.CurrentRow.Cells[6].Value.ToString();
            ButtonUpdateStaffManager.Show();
            ButtonDeleteStaffManager.Show();
            ButtonUpdateStaffManager.Location = ButtonCreateStaffManager.Location;
            ButtonDeleteStaffManager.Location = ButtonUpdateStaffManager.Location;
            ButtonDeleteStaffManager.Location = new Point(ButtonDeleteStaffManager.Location.X, ButtonDeleteStaffManager.Location.Y + 70);
            ButtonCreateStaffManager.Hide();
        }

        private void ButtonUpdateStaffManager_Click(object sender, EventArgs e)
        {
            if (!CheckUserInputUpdate()) return;
            string updateQuery = @"
                       UPDATE user_account 
                       SET UserName = '" + textBoxUsername.Text + "', " +
                           "UserPassword = '" + textBoxPassword.Text + "' " +
                       "WHERE idUser = '" + tempID +
                       "';UPDATE user_info SET User_FullName = '" + textBoxFullname.Text +
                       "', " +
                           "User_Phone = '" + textBoxPhone.Text + "', " +
                           "User_BankAccountNumber = '" + textBoxBankNumber.Text + "', " +
                           "User_BankName = '" + textBoxBankName.Text + "' " +
                       "WHERE idUser = '" + tempID + "';";


            databaseService.ExecuteNonQuery(updateQuery);

            MessageFuctionConstans.SuccessOK("Account updated successfully.");
            ResetFormAddStaff();
            LoadStaff();
        }

        private void ButtonDeleteStaffManager_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageFuctionConstans.WarningOKCancell("Confirm deletion of this account?");
            if (result == DialogResult.OK)
            {
                string deleteQuery = @"
                     DELETE FROM user_info WHERE idUser = '" + tempID + "';" +
                    "DELETE FROM user_account WHERE idUser = '" + tempID + "';";

                databaseService.ExecuteNonQuery(deleteQuery);

                MessageFuctionConstans.SuccessOK("Account deleted successfully.");

                ResetFormAddStaff();
                LoadStaff();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            iconButtonSearch.PerformClick();
        }
    }
}
