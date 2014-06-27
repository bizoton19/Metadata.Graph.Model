using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata.Gaph.Model
{
    public class Mainframe 
    {
        public IEnumerable<MainframePartition> Partitions { get; set; }
        public string Location { get; set; }
        public string MachineName { get; set; }
        
    }
}
