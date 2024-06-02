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
            return $"You sent: {data}";
        }

        public int AnotherMethod(int number)
        {
            return number * 2;
        }
    }
}
