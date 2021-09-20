using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.DataSource.BadDataSoruce
{
    public abstract class BadData
    {
        public abstract void GetAllData();
        public abstract void Save();
    }
}
