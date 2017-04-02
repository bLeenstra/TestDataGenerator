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

namespace DatabaseDataGenerator.Forms
{
    public partial class MySqlDataCreationForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private MySqlDatabase _database;

        public MySqlDataCreationForm(MySqlDatabase database)
        {
            InitializeComponent();
            _database = database;
        }
    }
}