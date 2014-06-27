using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metadata.Gaph.Model
{

    /// <summary>
    /// 
    /// </summary>
   public class Column
    {
       public string Owner { get; set; }
       public string  TableName { get; set; }
       public string ColumnName {get;set;}
       public decimal ColumnId { get; set; }
       public string DataType { get; set; }
       public decimal Length { get; set; }
       public decimal Precision { get; set; }
       public decimal Scale { get; set; }
       public bool Nullable { get; set; }

    }
}
