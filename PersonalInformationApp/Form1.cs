using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformationApp
{
    public partial class PersonalInformationUI : Form
    {
        Person aPerson = new Person();
        public PersonalInformationUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            aPerson.firstName = fisrtNameTextBox.Text;
            aPerson.lastName = lastNameTextBox.Text;
            aPerson.motherName = motherNameTextBox.Text;
            aPerson.fatherName = fatherNameTextBox.Text;
            aPerson.address = AddressTextBox.Text;
            MessageBox.Show("Your information has been saved successfully", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Clear();
        }

        private void Clear()
        {
            fisrtNameTextBox.Clear();
            lastNameTextBox.Clear();
            motherNameTextBox.Clear();
            fatherNameTextBox.Clear();
            AddressTextBox.Clear();
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            Clear();
            fisrtNameTextBox.Text = aPerson.firstName;
            lastNameTextBox.Text = aPerson.lastName;
        }

        private void parentNameButton_Click(object sender, EventArgs e)
        {
            Clear();
            motherNameTextBox.Text = aPerson.motherName;
            fatherNameTextBox.Text = aPerson.fatherName;
        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            Clear();
            AddressTextBox.Text = aPerson.address;
        }

        private void showAllInformationButton_Click(object sender, EventArgs e)
        {
            Clear();
            fisrtNameTextBox.Text = aPerson.firstName;
            lastNameTextBox.Text = aPerson.lastName;
            motherNameTextBox.Text = aPerson.motherName;
            fatherNameTextBox.Text = aPerson.fatherName;
            AddressTextBox.Text = aPerson.address;
        }
    }
}
