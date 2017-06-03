using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseDataGenerator.Classes;
using DevExpress.Data.Helpers;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;

namespace DatabaseDataGenerator.Forms
{
    public partial class DatabaseSelector : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DatabaseSelector()
        {
            InitializeComponent();
        }

        private void ValidateSettings()
        {
            List<string> availableSchema = new List<string>();
            string address = textEditAddress.Text;
            ushort port = Convert.ToUInt16(calcEditPort.EditValue);

            string username = textEditUsername.Text;
            string password = textEditPassword.Text;

            switch (comboBoxEditType.SelectedIndex)
            {
                case 1:
                    if (!MySqlDatabase.TestConnection(address, port, username, password)) break;
                    MySqlDatabase database = new MySqlDatabase(address, port, username, password);
                    database.SelectSchema();
                    using (MySqlDataCreationForm generateData = new MySqlDataCreationForm(database))
                    {
                        generateData.ShowDialog(this);
                    }
                    

                    return;
            }
            XtraMessageBox.Show("There was an issue with the entered database credentials");

        }

        private void barButtonItemNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CleanValues();
        }

        private void CleanValues()
        {
            comboBoxEditType.SelectedIndex = 0;
            textEditAddress.Text = "";
            calcEditPort.Value = 0;
            textEditUsername.Text = "";
            textEditPassword.Text = "";
        }

        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ValidateSettings();
        }

        private void barButtonItemLoad_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
