using BiaManager.Model;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BiaManager.Script
{
    class Modify
    {
        SqlCommand sqlCommand;
        SqlDataReader dataReader;

        public Modify()
        {
        }

        public List<Account> Accounts(string query)
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection sqlConnection = ConnectDatabase.GetqlConnession())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    accounts.Add(new Account(dataReader.GetString(1), dataReader.GetString(2)));
                }

                sqlConnection.Close();
            }
            return accounts;
        }
    }
}
