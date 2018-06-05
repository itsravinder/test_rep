using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FirsWCFWebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HelloWorldservice" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HelloWorldservice.svc or HelloWorldservice.svc.cs at the Solution Explorer and start debugging.
    public class HelloWorldservice : IHelloWorldservice
    {

        public string Message()
        {

            return "Hello world , this is my first webservice";
        }

       
    

        public int add(int x, int y)
        {
            return x + y;
        }

}
}
