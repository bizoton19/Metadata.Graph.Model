using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metadata.Gaph.Model
{
    public abstract class Key
    {
        public string KeyName { get; set; }
        public IEnumerable<Column> KeyColumns { get; set; }
        
    }
}
