using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfBook
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService3" in both code and config file together.
    [ServiceContract(Namespace = "ServiceThree")]
    public interface IService3
    {
        [OperationContract]
        string DoWork();
    }
}
