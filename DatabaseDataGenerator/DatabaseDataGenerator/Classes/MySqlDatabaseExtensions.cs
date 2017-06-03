using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DatabaseDataGenerator.Classes
{
    public static class MySqlDatabaseExtensions
    {
        public static DataTable ToDataTable(this MySqlDataReader dataReader)
        {
            DataTable dt = new DataTable();
            using (DataSet ds = new DataSet())
            {
                ds.EnforceConstraints = false;
                ds.Tables.Add(dt);
                dt.Load(dataReader, LoadOption.OverwriteChanges);
                ds.Tables.Remove(dt);
            }
            return dt;
        }
    }
}
