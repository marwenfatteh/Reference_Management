using identityLoginRegister.Models;
using Microsoft.Build.Utilities;
using System.IO;
using System.Threading.Tasks;

namespace identityLoginRegister.Interfaces
{
    public interface IReferenceDocumentRepository
    {
        ICollection<ReferenceDocument> GetReferenceDocuments();
        Task<(FileStream,string)> GetReferenceDocument(string Id);
        bool CreateReferenceDocument(ReferenceDocument referenceDocument);
        bool ReferenceDocumentExists(string id);
        bool deleteReferenceDocument(ReferenceDocument referenceDocument);
        bool save();
    }
}
