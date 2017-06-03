using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseDataGenerator.Forms;

namespace DatabaseDataGenerator.Classes
{
    public abstract class BaseDatabase
    {
        public string SelectedSchema{ get; protected set; }

        public abstract void SelectSchema();
        protected abstract List<string> GetSchemaList();
        protected abstract IDbConnection OpenConnection(IDbConnection conn);
    }
}
