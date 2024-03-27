using System.Data.SqlClient;
using System;
using System.Data;

namespace ASMUD
{
    internal class DBConnector
    {
        private static string ServerName = "ROMASHKA\\SQLEXPRESS";
        private static string DatabaseName = "TechAnalysis";
        private static string ConnectionString = "Data Source=ROMASHKA\\SQLEXPRESS;Initial Catalog=TechAnalysis;Integrated Security=True";

        public static SqlConnection CreateConnection()
        {
            new DBConnector();
            // Создание подключения
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                // Открываем подключение
                connection.Open();
                Console.WriteLine("Подключение открыто");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return connection;
        }

        public static void CloseConnection(SqlConnection connection)
        {
            // если подключение открыто
            if (connection.State == ConnectionState.Open)
            {
                // закрываем подключение
                connection.Close();
            }

        }
    }
}

