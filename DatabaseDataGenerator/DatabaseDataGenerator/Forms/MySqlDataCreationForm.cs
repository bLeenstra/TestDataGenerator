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
            using (MySqlDataReader dataReader = _database.ReadData("SELECT * FROM INFORMATION_SCHEMA.TABLES where TABLE_SCHEMA = @schema", new MySqlParameter("@schema", _database.SelectedSchema)))
            {
                gridControlData.DataSource = dataReader.ToDataTable();
            }
        }

        private void barButtonItemClear_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void CleanValues()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }
    }
}