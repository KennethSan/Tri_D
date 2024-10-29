using System;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Engines;
using System.Data.Common;

namespace Tri_D
{
    public static class DatabaseHelper
    {
        static string server = "localhost";
        static string port = "3306";
        static string username = "root";
        static string password = "";
        static string database = "trid_db";

        static string connectionString = $"server={server};port={port};username={username};password={password};database={database};";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            try { 
                    mySqlConnection.Open();
                    return mySqlConnection; 
            }
            catch(Exception ex) {
                Console.WriteLine($"Connection failed: {ex.Message}");
                return null;
            }
        }

    }
}