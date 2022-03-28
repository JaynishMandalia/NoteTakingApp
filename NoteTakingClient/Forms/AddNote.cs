using NoteTakingApp;
using System;
using System.Windows.Forms;

namespace NoteTakingClient.Forms
{
    public partial class AddNote : Form
    {
        public AddNote()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            ServiceReference1.NoteTakingServiceClient nt = new ServiceReference1.NoteTakingServiceClient("WSHttpBinding_INoteTakingService");
            NoteTaking noteTaking = new NoteTaking();
            noteTaking.Name = textBox1.Text;
            noteTaking.Notes = textBox2.Text;
            if (nt.AddNote(noteTaking))
                MessageBox.Show("Note is Added!!!");
            else
                MessageBox.Show("Sorry check out again.");
        }
    }
}
