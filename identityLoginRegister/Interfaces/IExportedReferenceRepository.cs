using identityLoginRegister.Models;

namespace identityLoginRegister.Interfaces
{
    public interface IExportedReferenceRepository
    {
        ICollection<ExportedReference> GetReferences();
        ExportedReference GetReference(string id);
        bool exportedReferenceExists(string id);
        bool updateExportedReference(ExportedReference exportedReference);
        bool deleteExportedReference(ExportedReference exportedReference);
        bool save();


    }
}
