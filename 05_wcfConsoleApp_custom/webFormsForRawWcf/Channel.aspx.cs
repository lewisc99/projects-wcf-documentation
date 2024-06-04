using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webFormsForRawWcf
{
    public partial class Channel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCallMyMethod_Click(object sender, EventArgs e)
        {
            UsingChannel();
        }

        private void UsingChannel()
        {
            Binding binding = new WSHttpBinding();
            EndpointAddress address = new EndpointAddress("http://localhost:8000/MyService");

            ChannelFactory<ServiceReference1.IMyContract> factory = new ChannelFactory<ServiceReference1.IMyContract>(binding, address);
            ServiceReference1.IMyContract proxy = factory.CreateChannel();

            using (proxy as IDisposable)
            {
                string data = "";

                if (TextBox1.Text == null)
                    data = proxy.MyMethod("Default value");

                data = proxy.MyMethod(TextBox1.Text + "By Channel");
                lblResult.Text = data;

                IDisposable disposable = proxy as IDisposable;
                if (disposable != null)
                {
                    disposable.Dispose();
                }
            }
        }

    }
}