using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApp
{
    public class NoteTakingService : INoteTakingService
    {
        
        public bool AddNote(NoteTaking nt)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=NorthWind;Integrated Security=True;Pooling=False");
            SqlDataAdapter adapter = new SqlDataAdapter();
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Note (Name, LastNote) VALUES (@Name, @LastNote)", con);
            cmd.Parameters.Add("@Name", nt.Name);
            cmd.Parameters.Add("@LastNote", nt.Notes);
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public bool DeleteNote(int PersonID)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=NorthWind;Integrated Security=True;Pooling=False");
            SqlDataAdapter adapter = new SqlDataAdapter ();
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Note WHERE PersonID = @PersonID", con);
            cmd.Parameters.Add("@PersonID", PersonID);
            adapter.DeleteCommand = cmd;
            adapter.DeleteCommand.ExecuteNonQuery();
            return true;
        }
        public bool UpdateNote(NoteTaking nt)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=NorthWind;Integrated Security=True;Pooling=False");
            SqlDataAdapter adapter = new SqlDataAdapter();
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Note SET Name = @Name, LastNote = @Note WHERE PersonID = @PersonID", con);
            cmd.Parameters.Add("@PersonID", nt.ID);
            cmd.Parameters.Add("@Name", nt.Name);
            cmd.Parameters.Add("@Note", nt.Notes);
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.ExecuteNonQuery();
            con.Close();
            return true;
        }

        public DataSet GetNotes(int PersonID)
        {
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=NorthWind;Integrated Security=True;Pooling=False");
            SqlDataAdapter adapter;
            DataSet ds = new DataSet();
            string cmd = "SELECT LastNote FROM Note WHERE PersonID = " + PersonID;
            con.Open();
            adapter = new SqlDataAdapter(cmd, con);
            adapter.Fill(ds);
            return ds;
        }

        
    }
}
