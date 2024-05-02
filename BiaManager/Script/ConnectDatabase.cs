using System.Data.SqlClient;

namespace BiaManager.Script
{
    class ConnectDatabase
    {
        //DESKTOP-NQD44KU\MYMSSQLSERVER
        public static string stringConnection = @"Data Source=DESKTOP-NQD44KU\MYMSSQLSERVER;Initial Catalog=db_biamanager;Integrated Security=True";

        public static SqlConnection GetqlConnession()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
