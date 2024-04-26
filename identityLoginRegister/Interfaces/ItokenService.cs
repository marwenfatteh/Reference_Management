using identityLoginRegister.Models;

namespace identityLoginRegister.Interfaces
{
    public interface ItokenService
    {
        string CreateToken(User user);
    }
}
