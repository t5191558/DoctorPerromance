using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule.Config
{
    public class ExcelConfig
    {
        public string Name { get; set; } = "";
        public IEnumerable<SheetConfig>? Sheets { get; set; } 
    }

    public class SheetConfig
    {
        public string Title { get; set; } = "";//优先使用title
        public int Index { get; set; }
        public int StartRow { get; set; }
        public IEnumerable<ColumnConfig> ColumnConfigs { get; set; } = null!;
    }

    public class ColumnConfig
    {
        public int Index { get; set; }
        public string ColumnName { get; set; } = null!; 
        public string ColumnType { get; set; } = "string";
        public bool IsNull { get; set; } = false;
        public string? ObjectName { get;set; }
        public int? Length { get; set; }
    }
    




}
