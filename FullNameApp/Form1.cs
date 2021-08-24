using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullNameApp
{
    public partial class FullNameUI : Form
    {
        public FullNameUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            fullNameTextBox.Text = firstNameTextBox.Text + " " + lastNameTextBox.Text;
        }
    }
}
