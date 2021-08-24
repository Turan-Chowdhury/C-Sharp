using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeveralControlsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dayName = comboBox1.SelectedItem.ToString();
            MessageBox.Show(dayName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("turan");
            comboBox1.Items.Add("zia");
            comboBox1.Items.Add("tareq");
        }
    }
}
