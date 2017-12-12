using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseDataGenerator.Classes;
using DevExpress.XtraBars;
using MySql.Data.MySqlClient;

namespace DatabaseDataGenerator.Forms
{
    public partial class MySqlDataCreationForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private MySqlDatabase _database;

        public MySqlDataCreationForm(MySqlDatabase database)
        {
            InitializeComponent();
            _database = database;
            ribbonPage1.Text = database.SelectedSchema;
            LoadData();
        }

        private void LoadData()
        {
            using (MySqlDataReader dataReader = _database.ReadData("SELECT TABLE_NAME, TABLE_ROWS, 0 `RowsToAdd` FROM INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = @schema", new MySqlParameter("@schema", _database.SelectedSchema)))
            {
                gridControlData.DataSource = dataReader.ToDataTable();
            }
        }

        private void barButtonItemClear_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void barButtonItemClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void barButtonItemGenerate_ItemClick(object sender, ItemClickEventArgs e)
        {
            GenerateData();
        }

        private void GenerateData()
        {
            gridViewData.PostEditor();
            DataTable dt = (DataTable)gridControlData.DataSource;
            if (dt != null)
            {

                foreach (DataRow dataRow in dt.Rows)
                {
                    string tableName = (string)dataRow["TABLE_NAME"];
                    int rowsToAdd = (int)dataRow["RowsToAdd"];

                    using (MySqlDataReader dataReader = _database.ReadData("SELECT COLUMN_NAME, IS_NULLABLE, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, COLUMN_KEY, EXTRA FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @table", new MySqlParameter("@table", tableName)))
                    {
                        while (dataReader.Read())
                        {
                            var columnname = dataReader.GetString(0);
                            var nullable = dataReader.GetBoolean(1);
                            var dataType = dataReader.GetString(2);
                            var maxDataLength = dataReader.GetInt64(3);
                            var keyType = dataReader.GetString(4);
                            var extraInfo = dataReader.GetString(5);
                        }


                        gridControlData.DataSource = dataReader.ToDataTable();
                    }



                    //_database.InsertData();
                }    
            }
        }
    }
}