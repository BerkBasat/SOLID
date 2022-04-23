using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Single_Responsibility
{
    public class Logger
    {
        public void LogFile(string stringPath, string log)
        {
            File.WriteAllText(stringPath, log);
        }

        public string BuildLog(string userInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("User Details: ");
            sb.Append(userInfo);
            return sb.ToString();
        }
    }
}
