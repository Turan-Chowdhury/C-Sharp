using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorldWebApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void showButton_Click(object sender, EventArgs e)
        {
            //Response.Write("Hello");
            string name = nameTextBox.Text;
            messageLabel.Text = "Hello " + name;
        }
    }
}