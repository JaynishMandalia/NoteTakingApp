using System;
using System.ServiceModel;
using System.Windows.Forms;

namespace NoteTakingHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ServiceHost sh = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            sh = new ServiceHost(typeof(NoteTakingApp.NoteTakingService));
            sh.Open();
            label1.Text = "Service Running....!!!";
        }
        private void Form1_FormClosing(object sender, FormClosedEventArgs e)
        {
            sh.Close();
        }
    }
}
