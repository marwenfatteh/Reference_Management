using System.ComponentModel.DataAnnotations.Schema;

namespace identityLoginRegister.Models
{
    public class ReferenceDocument
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Title { get; set; }
        public string userId { get; set; }
        public User user { get; set; }
       
        public ExportedReference exportedReference {  get; set; }

        public byte[] referenceDocument { get; set; }
    }
}
