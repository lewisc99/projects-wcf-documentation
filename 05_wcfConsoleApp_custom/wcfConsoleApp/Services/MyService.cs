using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace wcfConsoleApp.Services
{
    public class MyService : IMyContract, IMyOtherContract
    {
        public string MyMethod(string data)
        {
            return $"This data result is modified by the Server: {data}";
        }

        public int AnotherMethod(int number)
        {
            return number * 2;
        }

        public static void Configure(ServiceConfiguration config)
        {
            Binding wsBinding = new WSHttpBinding();
            config.AddServiceEndpoint(typeof(IMyContract), wsBinding,
            new Uri("http://localhost:8001/MyService"));
        }

    }
}
