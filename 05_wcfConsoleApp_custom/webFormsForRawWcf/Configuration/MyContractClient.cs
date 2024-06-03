using Microsoft.Ajax.Utilities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using System.Web;
using webFormsForRawWcf.ServiceReference1;

namespace webFormsForRawWcf.Configuration
{
    class MyContractClient : ClientBase<IMyContract>, IMyContract
    {
        public MyContractClient()
        { }
        public MyContractClient(string endpointName) : base(endpointName)
        { }
        public MyContractClient(Binding binding, EndpointAddress remoteAddress) :
        base(binding, remoteAddress)
        { }
        /* Additional constructors */
        public string MyMethod(string data)
        {
            return Channel.MyMethod(data);
        }

        public Task<string> MyMethodAsync(string data)
        {
            return Task.FromResult(Channel.MyMethod(data));
        }
    }
}