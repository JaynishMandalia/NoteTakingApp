using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NoteTakingApp
{
    [ServiceContract]
    public interface INoteTakingService
    {
        [OperationContract]
        bool AddNote(NoteTaking nt);
        [OperationContract]
        bool DeleteNote(int PersonID);
        [OperationContract]
        DataSet GetNotes(int PersonID);

        [OperationContract]
        bool UpdateNote(NoteTaking nt);
    }
}
