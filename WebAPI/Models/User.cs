using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Core;
using WebAPI.Core.Interfaces;

namespace WebAPI.Models
{
    public class User : BaseModel, IModel<User>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Create(User model)
        {
            throw new NotImplementedException();
        }

        public void Delete(User model)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }

        public void Update(User model)
        {
            throw new NotImplementedException();
        }
    }
}
