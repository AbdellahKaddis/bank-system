using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK_DataAccess
{
    public static class clsLogger
    {
       public static void WriteLogToFile(string Message)
        {
            string LogPath = ConfigurationManager.AppSettings["logpath"];
            using (StreamWriter writer = new StreamWriter(LogPath, true))
            {
                writer.WriteLine(DateTime.Now.ToString() + " : " + Message);
            }
        }
        public static void WriteLog(string Message)
        {
            string SourceName = "Bank";
            if (!EventLog.SourceExists(SourceName))
            {
                EventLog.CreateEventSource(SourceName, "Application");
            }

            EventLog.WriteEntry(SourceName,Message, EventLogEntryType.Error);
        }
    }
}
