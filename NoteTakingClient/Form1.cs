using NoteTakingApp;
using System;
using System.Data;
using System.Windows.Forms;

namespace NoteTakingClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Add
        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.NoteTakingServiceClient nt = new ServiceReference1.NoteTakingServiceClient("WSHttpBinding_INoteTakingService");
            NoteTaking noteTaking = new NoteTaking();
            noteTaking.Name = textBox2.Text;
            noteTaking.Notes = textBox3.Text;
            if (nt.AddNote(noteTaking))
                MessageBox.Show("Note is Added!!!");
            else
                MessageBox.Show("Sorry check out again.");
        }

        //Delete
        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.NoteTakingServiceClient nt = new ServiceReference1.NoteTakingServiceClient("WSHttpBinding_INoteTakingService");
            if (nt.DeleteNote(int.Parse(textBox1.Text)))
                MessageBox.Show("Note is Deleted Successfully!!!");
            else
                MessageBox.Show("Sorry check out again.");
        }

        //Show
        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.NoteTakingServiceClient nt = new ServiceReference1.NoteTakingServiceClient("WSHttpBinding_INoteTakingService");
            DataSet ds = nt.GetNotes(int.Parse(textBox1.Text));
            checkedListBox1.DataSource = ds.Tables[0].DefaultView;
            checkedListBox1.DisplayMember = "LastNote";
            nt.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ServiceReference1.NoteTakingServiceClient nt = new ServiceReference1.NoteTakingServiceClient("WSHttpBinding_INoteTakingService");
            NoteTaking noteTaking= new NoteTaking();
            noteTaking.ID = int.Parse(textBox1.Text);
            noteTaking.Name = textBox2.Text;
            noteTaking.Notes = textBox3.Text;
            if(nt.UpdateNote(noteTaking))
                MessageBox.Show("Updation Done...!!");
        }
    }
}
