using identityLoginRegister.Data;
using identityLoginRegister.Interfaces;
using identityLoginRegister.Models;

namespace identityLoginRegister.Repository
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDBContext _context;
        public UserRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public bool DeleteUser(User user)
        {
            _context.Remove(user);
            return save();
        }

        public User GetUser(string userId)
        {
            return _context.Users.Where(u => u.Id == userId).FirstOrDefault();
        }

        public ICollection<User> GetUsers()
        {
            return _context.Users.OrderBy(x => x.Id).ToList();
        }

        public bool save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UserExists(string userId)
        {
            return _context.Users.Any(u => u.Id == userId);
        }
    }
}
