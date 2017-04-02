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

        public MySqlDatabase()
        {
            
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
                return OpenConnection(conn);
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

        public override void SelectSchema()
        {
            List<string> availableSchema = GetSchemaList();
            using (SchemaSelector schemaSelectorDialog = new SchemaSelector(availableSchema))
            {
                schemaSelectorDialog.ShowDialog();
                if (schemaSelectorDialog.DialogResult == DialogResult.OK)
                {
                    base.SelectedSchema = schemaSelectorDialog.SelectedSchema;
                }
            }
        }

        protected override List<string> GetSchemaList()
        {
            throw new NotImplementedException();
        }
    }
}
