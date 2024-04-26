using identityLoginRegister.Data;
using identityLoginRegister.Interfaces;
using identityLoginRegister.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Net.Mail;
using static System.Net.WebRequestMethods;

namespace identityLoginRegister.Repository
{
    public class ReferenceDocumentRepository : IReferenceDocumentRepository
    {
        private ApplicationDBContext _context;
        public ReferenceDocumentRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public bool CreateReferenceDocument(ReferenceDocument referenceDocument)
        {
            _context.Add(referenceDocument);
            return save();
        }

        public bool deleteReferenceDocument(ReferenceDocument referenceDocument)
        {
            throw new NotImplementedException();
        }

        

        public ICollection<ReferenceDocument> GetReferenceDocuments()
        {
            throw new NotImplementedException();
        }

        public bool ReferenceDocumentExists(string id)
        {
            throw new NotImplementedException();
        }

        public bool save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public async Task<(FileStream,string)> GetReferenceDocument(string Id)
        {

            var fileEntity = await _context.ReferenceDocuments.FindAsync(Id);
            if (fileEntity == null)
                return (null,null);

            string tempFilePath = Path.GetTempFileName();

            System.IO.File.WriteAllBytes(tempFilePath, fileEntity.referenceDocument);

            FileStream stream = new FileStream(tempFilePath, FileMode.Open, FileAccess.Read);

            return (stream,fileEntity.Title);


        }
        

        
    }
}
