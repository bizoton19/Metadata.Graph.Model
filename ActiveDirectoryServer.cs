using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Metadata.Gaph.Model
{
    public class ActiveDirectoryServer: IDirectoryServer
    {
        public IEnumerable<ActiveDirectoryForest> ActiveDirectoryForest
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
