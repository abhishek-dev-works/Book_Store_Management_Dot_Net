using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagement_Application.Interfaces
{
    public interface IUserService
    {
        User GetUserById(int id);
        List<User> GetAllUsers();
        void CreateUser(User user);
    }
}
