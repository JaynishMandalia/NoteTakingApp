using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTakingClient.Forms
{
    public partial class DeleteNote : Form
    {
        public DeleteNote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.NoteTakingServiceClient nt = new ServiceReference1.NoteTakingServiceClient("WSHttpBinding_INoteTakingService");
            if (nt.DeleteNote(int.Parse(textBox1.Text)))
                MessageBox.Show("Note is Deleted Successfully!!!");
            else
                MessageBox.Show("Sorry check out again.");
        }
    }
}
