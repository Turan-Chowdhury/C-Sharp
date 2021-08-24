using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldInWindowsFormApp
{
    public partial class HelloWorldShowUI : Form
    {
        public HelloWorldShowUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World", "Show Hello World", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
