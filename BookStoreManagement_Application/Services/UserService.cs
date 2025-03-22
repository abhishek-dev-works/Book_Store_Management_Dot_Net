using System.Collections.Generic;
using System.Linq;
using BookStoreManagement_Db_Context.DataContext;
using BookStoreManagement_Application.Interfaces;

namespace BookStoreManagement_Application.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}
