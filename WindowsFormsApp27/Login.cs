using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp27
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="carlitos"&&textBox2.Text==("1234"))
            {
                Menu form1 = new Menu();
                form1.Show();
            }
            else
            {
                MessageBox.Show("eisai blakas");
            }
        }
    }
}
