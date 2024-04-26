using Microsoft.AspNetCore.Identity;

namespace identityLoginRegister.Models
{
    public class User : IdentityUser
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public ICollection<ReferenceDocument> referenceDocuments { get; set; }
        


    }
}
