using AutoMapper;
using identityLoginRegister.Dtos.Account;
using identityLoginRegister.Dtos.References;
using identityLoginRegister.Models;

namespace identityLoginRegister.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<ReferenceDocument, referenceDocumentDto>();
            CreateMap<referenceDocumentDto, ReferenceDocument>();
            CreateMap<UserDto, User>();
            CreateMap<User, UserDto>();

        }
    }
}
