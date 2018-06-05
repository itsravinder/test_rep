using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "Iwcf" in both code and config file together.
    [ServiceContract]
    public interface Iwcf
    {
      
        [OperationContract]
         int add( int a, int b);
    }
}
