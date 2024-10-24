using MySql.Data.MySqlClient;
using System.DirectoryServices;

namespace RegistruReparatii
{
    public static class Queries
    {
        public static string connectionString;
        public static MySqlConnection globalConnection;
        public static string password;
        public static string username;
        public static string database;
        public static string ip;
        public static MySqlConnection setConnection(string Username, string Password)
        {
            connectionString = $"Server=185.108.182.63;Database=reparatii;User ID={Username};Password={Password};";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    globalConnection = conn;
                    globalConnection.Open();
                    return globalConnection;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    return null;
                }
            }
        }
    }
}
