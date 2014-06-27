using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metadata.Gaph.Model
{
   public class MainframePartition
    {
        public string PartitionName  { get; set; }
        public IEnumerable<DB2Subsystem>  DB2SubSystems{ get; set; }
    }
}
