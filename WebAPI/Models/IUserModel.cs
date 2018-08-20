using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public interface IUserModel
    {
        void CreateUser(User user);
        void DeleteUser(User user);
        void UpdateUser(User user);
        User GetUser(int id);
        List<User> GetUser();
    }
}
