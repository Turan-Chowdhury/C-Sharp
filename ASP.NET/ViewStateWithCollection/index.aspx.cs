using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateWithCollection
{
    public partial class index : System.Web.UI.Page
    {
        List<string> names = new List<string>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            if(ViewState["names"] != null){
                names = (List<string>)ViewState["names"];
            }

            string name = nameTextBox.Text;
            names.Add(name);
            ViewState["names"] = names;
            nameTextBox.Text = "";
        }

        protected void showAllButton_Click(object sender, EventArgs e)
        {
            names = (List<string>) ViewState["names"];
            nameListBox.Items.Clear();
            foreach(var item in names)
            {
                nameListBox.Items.Add(item);
            }
        }
    }
}