using System;
using System.Data;
using System.Data.SqlClient;

namespace BiaManager.Script
{
    internal class ConnectDatabase
    {
        SqlConnection conn;
        public ConnectDatabase()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-G0D14LK;Initial Catalog=db_biamanager;Integrated Security=True";
        }
        public void Open()
        {
            if (this.conn.State == ConnectionState.Closed)
                this.conn.Open();
        }
        public void Close()
        {
            if (this.conn.State == ConnectionState.Open)
                this.conn.Close();
        }
        /// <summary>
        /// SQL:Select
        /// </summary>
        /// <param name="SQL">Select * .. Form..</param>
        /// <returns>DataTable</returns>
        public DataTable GetDataTable(String SQL)
        {
            DataTable tb = new DataTable();
            this.Open();
            SqlDataAdapter adp = new SqlDataAdapter(SQL, this.conn);
            adp.Fill(tb);
            this.Close();
            return tb;
        }
        /// <summary>
        /// SQL : Inser Into, Update, Delete
        /// 
        /// </summary>
        /// <param name="SQL"> Inser Into, Update, Delete</param>
        /// <returns>Int</returns>
        public int ThucThiSQL(String SQL)
        {
            int k = 0;
            this.Open();
            SqlCommand cmd = new SqlCommand(SQL, this.conn);
            k = cmd.ExecuteNonQuery();
            this.Close();
            return k;
        }

    }
}
