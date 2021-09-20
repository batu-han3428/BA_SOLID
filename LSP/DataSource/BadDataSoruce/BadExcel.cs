using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.DataSource.BadDataSoruce
{
    public class Excel : BadData
    {
        public override void GetAllData()
        {
            Console.WriteLine("Excell GellAllData()");
        }

        public override void Save()
        {
            Console.WriteLine("Excel Save()");
        }
    }
}
