using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Data.SqlClient;

namespace BiaManager.Script
{
    class ConnectDatabase
    {
        private static string stringConnection = @"Data Source=DESKTOP-G0D14LK;Initial Catalog=db_biamanager;Integrated Security=True";
       
        private IFirebaseConfig firebaseConfig = new FirebaseConfig()
        {
            AuthSecret = "41Rmtw0Qltxh9d27BhTqCCmAVF8QcWadDcZk9KPE",
            BasePath = "https://biilardmanager-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient firebaseClient;

        public static SqlConnection GetqlConnession()
        {
            return new SqlConnection(stringConnection);
        }
        public ConnectDatabase()
        {
            try
            {
                firebaseClient = new FireSharp.FirebaseClient(firebaseConfig);
                MessageFuctionConstans.WarningOK("Connect Successful!");
            }
            catch(Exception ex)
            {
                MessageFuctionConstans.WarningOK(ex.Message);
            }
        }
    }
}
