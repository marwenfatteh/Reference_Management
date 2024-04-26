using System.ComponentModel.DataAnnotations.Schema;

namespace identityLoginRegister.Dtos.References
{
    public class referenceDocumentDto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Title { get; set; }
        public string userId { get; set; }
        public byte[] referenceDocument { get; set; }

    }
}
