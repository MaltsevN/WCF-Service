using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var aValue = int.Parse(TextBox1.Text);
            var bValue = int.Parse(TextBox2.Text);

            var client = new CalcService.SummatorServiceClient("BasicHttpBinding_ISummatorService");

            Label1.Text = client.GetSum(aValue, bValue).ToString();
            client.Close();

        }
    }
}