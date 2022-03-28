using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingClient
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Email.Text == "JDGroup@gmail.com" && password.Text == "Admin123")
            {
                Form2 f2 = new Form2();
                f2.Show();

            }
            else
            {
                MessageBox.Show("Please Enter Proper Credentials");
            }
        }
    }
}
