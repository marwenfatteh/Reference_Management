using identityLoginRegister.Models;

namespace identityLoginRegister.Interfaces
{
    public interface IUserRepository
    {
        ICollection<User> GetUsers();
        User GetUser(string userId);
        bool UserExists(string userId);
        bool DeleteUser(User user);
        bool save();
    }
}
