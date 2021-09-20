using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP.DataSource.BadDataSoruce
{
    public class DataSourceProcess
    {
        public void SaveAll(List<BadData> sourceList)
        {
            foreach (var item in sourceList)
            {
                item.Save();
            }
        }
    }
}
