using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Validated
{
    public class Logger
    {
        public void LogFile(string FileName, string log) {
            File.WriteAllText(FileName, log);
        }

        public string BuildLog(string information)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Date:");
            sb.Append(DateTime.Now);
            sb.Append("Information:");
            sb.Append(information);

            return sb.ToString();
        }
    }
}
