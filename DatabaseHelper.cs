using System;
using System.Data;
using System.Data.OleDb;

namespace CafeSurveyApp
{
    public static class DatabaseHelper
    {
        private static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DatabaseCafe.accdb;";

        public static DataTable ExecuteQuery(string query)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ошибка выполнения запроса: {ex.Message}");
                }
            }
        }

        public static int ExecuteNonQuery(string commandText)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(commandText, connection);
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ошибка выполнения команды: {ex.Message}");
                }
            }
        }

        public static object ExecuteScalar(string query)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(query, connection);
                    return command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ошибка выполнения скалярного запроса: {ex.Message}");
                }
            }
        }
    }
}