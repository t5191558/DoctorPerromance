using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Job
{
    public class OwnerJob : IJob
    {
        public static IConfigBuilder? JobConfigBuild { get; set; }
        public static readonly JobKey Key = new JobKey("excel","owner"); 
        public string? Version { get; set; }
        public async Task Execute(IJobExecutionContext context)
        {
            try
            {
                if (JobConfigBuild == null)
                    return;
                var config = JobConfigBuild.BuildJobConfig();
                //Todo

                //change job
                if(Version != config.Version)
                {
                    if (Schedule.GlobalSchedule == null)
                        throw new Exception("Global Schedule not Init");
                    var oldjob = await Schedule.GlobalSchedule.GetJobDetail(Key);
                    if (oldjob == null)
                        throw new Exception($" can't find job:{Key.Name}  {Key.Group} ");
                    var newjob = oldjob.GetJobBuilder().UsingJobData("Version", config.Version).Build();
                    await Schedule.GlobalSchedule.AddJob(newjob,true);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
