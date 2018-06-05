using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "wcf" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select wcf.svc or wcf.svc.cs at the Solution Explorer and start debugging.
    public class wcf : Iwcf
    {
        public int add(int a , int b)
        {
            return a + b;
        }
    }
}
