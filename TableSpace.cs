using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metadata.Gaph.Model
{
    public class TableSpace
    {
        public IEnumerable<Space> Space { get; set; }
        public IEnumerable<Table> Tables { get; set; }
        public IEnumerable<Index> Indexes { get; set; }

    }
}
