using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfADD
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "wcfaDD" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select wcfaDD.svc or wcfaDD.svc.cs at the Solution Explorer and start debugging.
    public class wcfaDD : IwcfaDD
    {
        public int add( int x, int y)
        {
            return x + y;
        }
    }
}
