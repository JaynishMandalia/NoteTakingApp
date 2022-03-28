using NoteTakingApp;
using System;
using System.Data;
using System.Windows.Forms;

namespace NoteTakingClient.Forms
{
    public partial class UpdateNote : Form
    {
        public UpdateNote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.NoteTakingServiceClient nt = new ServiceReference1.NoteTakingServiceClient("WSHttpBinding_INoteTakingService");
            NoteTaking noteTaking = new NoteTaking();
            noteTaking.ID = int.Parse(textBox1.Text);
            noteTaking.Name = textBox2.Text;
            noteTaking.Notes = textBox3.Text;
            if (nt.UpdateNote(noteTaking))
                MessageBox.Show("Updation Done...!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.NoteTakingServiceClient nt = new ServiceReference1.NoteTakingServiceClient("WSHttpBinding_INoteTakingService");
            DataSet ds = nt.GetNotes(int.Parse(textBox1.Text));
            checkedListBox1.DataSource = ds.Tables[0].DefaultView;
            checkedListBox1.DisplayMember = "LastNote";
            nt.Close();
        }
    }
}
