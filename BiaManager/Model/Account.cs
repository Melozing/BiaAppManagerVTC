namespace BiaManager.Model
{
    class Account
    {
        private string username;
        private string password;
        private string userRole;
        private string idUser;
        private string user_FullName;
        private string user_Phone;
        private string user_BankAccountNumber;

        public Account()
        {
        }

        public Account(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string UserRole { get => userRole; set => userRole = value; }
        public string IdUser { get => idUser; set => idUser = value; }
        public string User_FullName { get => user_FullName; set => user_FullName = value; }
        public string User_Phone { get => user_Phone; set => user_Phone = value; }
        public string User_BankAccountNumber { get => user_BankAccountNumber; set => user_BankAccountNumber = value; }
    }
}
