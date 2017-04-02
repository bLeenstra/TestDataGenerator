using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseDataGenerator.Forms;

namespace DatabaseDataGenerator.Classes
{
    public abstract class BaseDatabase
    {
        protected string SelectedSchema;

        public abstract void SelectSchema();
        protected abstract List<string> GetSchemaList();
    }
}
