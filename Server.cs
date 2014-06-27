using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metadata.Gaph.Model
{
    public class Server
    {
        /// <summary>
        /// Server_Host_Database
        /// </summary>
        public IEnumerable<Database> Database
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public ActiveDirectoryDomain DomainName
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
