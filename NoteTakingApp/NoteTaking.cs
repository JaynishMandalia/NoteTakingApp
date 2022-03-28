using System;
using System.Runtime.Serialization;

namespace NoteTakingApp
{
    [DataContract]
    public class NoteTaking
    {
        int id;
        string name;
        string notes;

        [DataMember]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        public string Notes
        {
            get { return notes;}
            set { notes = value; }
        }
    }
}
