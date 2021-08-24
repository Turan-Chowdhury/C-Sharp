using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateWebApp
{
    public partial class HomeUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            ViewState["name"] = name;
            nameTextBox.Text = "";
        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = ViewState["name"].ToString();
        }
    }
}