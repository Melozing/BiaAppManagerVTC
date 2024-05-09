using System.Data.SqlClient;

namespace BiaManager.Script
{
    class ConnectDatabase
    {
        //DESKTOP-NQD44KU\MYMSSQLSERVER
        //DESKTOP-G0D14LK
        //Status = 0 = Default = No Deleted
        //Status = 1 = Deleted
        public static string stringConnection = @"Data Source=DESKTOP-G0D14LK;Initial Catalog=db_biamanager;Integrated Security=True";

        public static SqlConnection GetqlConnession()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
