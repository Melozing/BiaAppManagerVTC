using System.Data.SqlClient;

namespace BiaManager.Script
{
    class ConnectDatabase
    {
        //DESKTOP-NQD44KU\MYMSSQLSERVER
<<<<<<< HEAD
        public static string stringConnection = @"Data Source=LAGANIME;Initial Catalog=db_biamanager;Integrated Security=True";
=======
        //DESKTOP-G0D14LK
        public static string stringConnection = @"Data Source=DESKTOP-G0D14LK;Initial Catalog=db_biamanager;Integrated Security=True";
>>>>>>> main

        public static SqlConnection GetqlConnession()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
