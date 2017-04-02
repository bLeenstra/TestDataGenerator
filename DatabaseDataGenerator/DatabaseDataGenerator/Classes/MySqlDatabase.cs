using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars.Utils;
using MySql.Data.MySqlClient;

namespace DatabaseDataGenerator.Classes
{
    public static class MySqlDatabase
    {


        public static bool TestConnection(string address, ushort port, string username, string password)
        {
            MySqlConnectionStringBuilder connStringBuilder = new MySqlConnectionStringBuilder()
            {
                Server = address,
                Port = port,
                UserID = username,
                Password = password
            };
            using (MySqlConnection conn = CreateConnection(connStringBuilder))
            {
                return OpenConnection(conn);
            }
        }

        public static MySqlConnection CreateConnection(MySqlConnectionStringBuilder connStringBuilder)
        {
            return new MySqlConnection(connStringBuilder.ConnectionString);
        }

        public static bool OpenConnection(MySqlConnection conn)
        {
            try
            {
                conn.Open();
            }
            catch (MySqlException)
            {
                throw;
            }
            return conn.State == ConnectionState.Open;
        }
    }
}
