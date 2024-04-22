using System.Data.SqlClient;

namespace BiaManager.Script
{
    class ConnectDatabase
    {
        private static string stringConnection = @"Data Source=DESKTOP-G0D14LK;Initial Catalog=db_biamanager;Integrated Security=True";

        public static SqlConnection GetqlConnession()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
