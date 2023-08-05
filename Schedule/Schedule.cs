using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule
{
    public static class Schedule
    {
        public static IScheduler? GlobalSchedule { get; set; } 
        public static void InitSchecule()
        {
            //读取配置文件初始化Schedule

        }

    }
}
