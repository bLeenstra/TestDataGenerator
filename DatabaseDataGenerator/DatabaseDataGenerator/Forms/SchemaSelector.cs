using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace DatabaseDataGenerator.Forms
{
    public partial class SchemaSelector : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string SelectedSchema;

        public SchemaSelector(List<string> availableSchemaList)
        {
            InitializeComponent();

            GetDataSources(availableSchemaList);
        }

        private void GetDataSources(List<string> availableSchemaList)
        {
            comboBoxEditSchema.Properties.Items.AddRange(availableSchemaList);
        }

        private void barButtonItemOk_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void barButtonItemCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}