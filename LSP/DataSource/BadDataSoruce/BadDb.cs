using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.DataSource.BadDataSoruce
{
    public class Db : BadData
    {
        public override void GetAllData()
        {
            Console.WriteLine("Database GellAllData()");
        }

        public override void Save()
        {
            Console.WriteLine("Database Save()");
        }
    }
}
