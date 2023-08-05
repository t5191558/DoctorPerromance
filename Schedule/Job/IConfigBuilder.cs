using Schedule.Config;

namespace Schedule.Job
{
    public interface IConfigBuilder
    {

        public ExcelConfig BuildExcelConfig();  
        public JobConfigure BuildJobConfig();
    }
}
