using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WcfBook
{
    public class Service2: IService2
    {
        public string GetData(int value)
        {
            return "value: " + value;
        }
    }
}
