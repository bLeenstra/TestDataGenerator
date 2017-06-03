using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseDataGenerator.Forms;
using DevExpress.XtraBars.Utils;
using MySql.Data.MySqlClient;

namespace DatabaseDataGenerator.Classes
{
    public class MySqlDatabase : BaseDatabase
    {
        public MySqlConnectionStringBuilder ConnString { get; set; }

        public MySqlDatabase(string address, ushort port, string username, string password) : this(new MySqlConnectionStringBuilder() { Server = address, Port = port, UserID = username, Password = password }) { }

        public MySqlDatabase(MySqlConnectionStringBuilder mySqlConnStringBuilder)
        {
            ConnString = mySqlConnStringBuilder;
        }

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

        public MySqlConnection CreateConnection()
        {
            return new MySqlConnection(ConnString.ConnectionString);
        }

        public static MySqlConnection CreateConnection(MySqlConnectionStringBuilder connStringBuilder)
        {
            return new MySqlConnection(connStringBuilder.ConnectionString);
        }

        public override void SelectSchema()
        {
            List<string> availableSchema = GetSchemaList();
            using (SchemaSelector schemaSelectorDialog = new SchemaSelector(availableSchema))
            {
                if (schemaSelectorDialog.ShowDialog() == DialogResult.OK)                  
                {
                    base.SelectedSchema = schemaSelectorDialog.SelectedSchema;
                }
            }
        }

        protected override List<string> GetSchemaList()
        {
            using (MySqlDataReader dataReader = ReadData("SELECT SCHEMA_NAME AS `Database` FROM INFORMATION_SCHEMA.SCHEMATA"))
            {
                List<string> list = new List<string>();
                while (dataReader.Read())
                {
                    list.Add(dataReader.GetString(0));
                }
                return list;
            }
        }

        protected override IDbConnection OpenConnection(IDbConnection conn)
        {
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                return conn;
            }
            throw new Exception($"Connection state is not open. Current state is {conn.State}");
        }

        public MySqlDataReader ReadData(string query, params MySqlParameter[] parameters)
        {
            MySqlConnection conn = CreateConnection();
            OpenConnection(conn);
            using (MySqlCommand cmd = CreateCommand(conn, query, parameters))
            {
                return cmd.ExecuteReader();
            }
        }

        private MySqlCommand CreateCommand(MySqlConnection conn, string query, MySqlParameter[] parameters)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddRange(parameters);
            return cmd;
        }
    }
}
