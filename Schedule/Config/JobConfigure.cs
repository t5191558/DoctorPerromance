using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Config
{
    public class JobConfigure
    {
        public string Version { get; set; }
        public IEnumerable<string> Cron { get; set; }
        public JobConfigure() { 
            Version = "";
            Cron = new List<string>() { "0 0/1 * * *" };
        }

        public JobConfigure(string version)
        {
            Version = version;
            Cron = new List<string>() { "0 0/1 * * *" };
        }

        public JobConfigure(string version, IEnumerable<string> cron)
        {
            Version = version;
            Cron = cron;
        }



    }
}
