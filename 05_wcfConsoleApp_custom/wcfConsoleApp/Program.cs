using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using wcfConsoleApp.Services;

namespace wcfConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create the ServiceHost for the MyService type.
            using (ServiceHost host = new ServiceHost(typeof(MyService)))
            {
                // Create bindings
                WSHttpBinding wsBinding = new WSHttpBinding();
                NetTcpBinding tcpBinding = new NetTcpBinding();

                // Add service endpoints
                host.AddServiceEndpoint(typeof(IMyContract), wsBinding, "http://localhost:8000/MyService");
                //host.AddServiceEndpoint(typeof(IMyContract), tcpBinding, "net.tcp://localhost:8001/MyService");
                //host.AddServiceEndpoint(typeof(IMyOtherContract), tcpBinding, "net.tcp://localhost:8002/MyService");

                // Enable metadata exchange
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.HttpGetUrl = new Uri("http://localhost:8000/MyService");

                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

                // Open the ServiceHost to start listening for messages.
                host.Open();

                Console.WriteLine("The service is ready at http://localhost:8000/MyService");
                //Console.WriteLine("The service is ready at net.tcp://localhost:8001/MyService");
                //Console.WriteLine("The service is ready at net.tcp://localhost:8002/MyService");
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }
    }
}
