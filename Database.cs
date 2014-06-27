using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metadata.Gaph.Model
{
   public class Database
    {
        public string DatabaseName { get; set; }
        public DateTime CreateDate { get; set; }
        public IEnumerable<DatabaseObjects> DatabaseObjects { get; set; }
        public IEnumerable<TableSpace> TableSpaces{ get; set; }
        public string DatabaseType { get; set; }

    }
}
