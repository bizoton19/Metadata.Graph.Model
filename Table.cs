using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metadata.Gaph.Model
{
    public class Table
    {
        /// <summary>
        ///<TABLE_CATALOG>DB_25297_hdwih1</TABLE_CATALOG>

//<TABLE_SCHEMA>dbo</TABLE_SCHEMA>

//<TABLE_NAME>Confirmation</TABLE_NAME>

//<TABLE_TYPE>BASE TABLE</TABLE_TYPE>
        /// </summary>
        public string  TableCatalog { get; set; }
        public string TableName { get; set; }
        public string Creator { get; set; }
        /// <summary>
        /// Type of table- Can be a View, Base Table, MQT, MV
        /// </summary>
        public string TableType { get; set; }
        public IEnumerable<Column> Column { get; set; }
        public IEnumerable<Key> Keys { get; set; }
    }
}
