using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webFormsForRawWcf.Configuration;

namespace webFormsForRawWcf
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

           
        }

        protected void btnCallMyMethod_Click(object sender, EventArgs e)
        {
            using (MyContractClient proxy = new MyContractClient("WSHttpBinding_IMyContract"))
            {
                string data = "";

                if (TextBox1.Text == null)
                {
                     data = proxy.MyMethod("Default value");
                }
                
                data = proxy.MyMethod(TextBox1.Text);
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