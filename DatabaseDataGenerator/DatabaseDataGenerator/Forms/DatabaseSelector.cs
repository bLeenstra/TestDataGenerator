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

namespace DatabaseDataGenerator.Forms
{
    public partial class DatabaseSelector : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DatabaseSelector()
        {
            InitializeComponent();
        }

        private bool ValidateSettings()
        {
            string address = textEditAddress.Text;
            ushort port = Convert.ToUInt16(calcEditPort.EditValue);

            string username = textEditUsername.Text;
            string password = textEditPassword.Text;

            switch (comboBoxEditType.SelectedIndex)
            {
                case 1:
                    return MySqlDatabase.TestConnection(address, port, username, password);
                default:
                    return false;
            }
        }

        private void barButtonItemNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            comboBoxEditType.SelectedIndex = 0;
            textEditAddress.Text = "";
            calcEditPort.Value = 0;
            textEditUsername.Text = "";
            textEditPassword.Text = "";
        }

        private void barButtonItemSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateSettings())
            {
                
            }
        }
    }
}
