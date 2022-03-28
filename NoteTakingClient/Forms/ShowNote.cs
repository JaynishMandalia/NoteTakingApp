using System;
using System.Data;
using System.Windows.Forms;

namespace NoteTakingClient.Forms
{
    public partial class ShowNote : Form
    {
        public ShowNote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.NoteTakingServiceClient nt = new ServiceReference1.NoteTakingServiceClient("WSHttpBinding_INoteTakingService");
            DataSet ds = nt.GetNotes(int.Parse(textBox1.Text));
            checkedListBox1.DataSource = ds.Tables[0].DefaultView;
            checkedListBox1.DisplayMember = "LastNote";
            nt.Close();
        }
    }
}
