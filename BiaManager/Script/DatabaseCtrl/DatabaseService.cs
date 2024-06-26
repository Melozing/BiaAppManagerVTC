﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BiaManager.Script
{
    class DatabaseService
    {
        private static DatabaseService instance;
        private string connectionString;

        public DatabaseService()
        {
            this.connectionString = ConnectDatabase.stringConnection;
        }
        public static DatabaseService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseService();
                }
                return instance;
            }
        }

        public List<T> GetData<T>(string query, Func<SqlDataReader, T> mapper)
        {
            List<T> dataList = new List<T>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T data = mapper(reader);
                            dataList.Add(data);
                        }
                    }
                }
            }

            return dataList;
        }

        public DataTable LoadDataTable(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            connection.Close();
            return data;
        }

        public void ExecuteNonQuery(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public T ExecuteScalar<T>(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result == DBNull.Value)
                    {
                        return default(T);
                    }
                    else if (typeof(T) == typeof(string))
                    {
                        return (T)(object)result.ToString();
                    }
                    else
                    {
                        return (T)Convert.ChangeType(result, typeof(T));
                    }
                }
            }
        }

        public void InsertImageData(string query, byte[] imageData)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ImageData", imageData);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
