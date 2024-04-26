using System.ComponentModel.DataAnnotations.Schema;

namespace identityLoginRegister.Models
{
    public class ExportedReference
    {
        public int Id { get; set; }
        public string Project { get; set; }
        public string Client { get; set; } 
        public string Tech { get; set; }
        public string Contact { get; set; }
        public string Team { get; set; }
       public string referenceDocumentId { get; set; }
        public ReferenceDocument referenceDocument { get; set; }

    }
}
