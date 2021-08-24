using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserDefineTypeApp
{
    public partial class HomeUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            List<Person> persons = new List<Person>();
            Person aPerson = new Person();
            aPerson.firstName = firstNameTextBox.Text;
            aPerson.middleName = middleNameTextBox.Text;
            aPerson.lastName = lastNameTextBox.Text;

            if(ViewState["persons"] != null)
            {
                persons = (List<Person>)ViewState["persons"];
            }
            persons.Add(aPerson);
            ViewState["persons"] = persons;

            firstNameTextBox.Text = string.Empty;
            middleNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
        }

        protected void getAllFullNameButton_Click(object sender, EventArgs e)
        {
            List<Person> persons = (List<Person>)ViewState["persons"];
            foreach(var person in persons)
            {
                string fullName = person.GetFullName();
                nameListBox.Items.Add(fullName);
            }
        }
    }
}