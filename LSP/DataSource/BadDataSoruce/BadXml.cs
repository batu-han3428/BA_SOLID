using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.DataSource.BadDataSoruce
{
    public class Xml : BadData
    {
        public override void GetAllData()
        {
            Console.WriteLine("Xml GellAllData()");
        }

        public override void Save()
        {
            Console.WriteLine("Xml GellAllData()");
        }
    }
}
