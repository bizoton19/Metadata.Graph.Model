using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metadata.Gaph.Model
{
   public class DB2Subsystem
    {
        public string SubsystemName  { get; set; }
        public string SubsystemNetworkAddress  { get; set; }
        public bool isDataSharing { get; set; }
        public string MainframePartition { get; set; }
        public IEnumerable<Database> Databases { get; set; }
        public string GetFullyQualifiedName()
        {
            return string.Concat(MainframePartition, ".", SubsystemName);
        }
    }
}
