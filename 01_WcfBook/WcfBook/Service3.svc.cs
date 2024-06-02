using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfBook
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service3" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service3.svc or Service3.svc.cs at the Solution Explorer and start debugging.
    public class Service3 : IService3
    {
        public string DoWork()
        {
            return "working";
        }
    }
}
