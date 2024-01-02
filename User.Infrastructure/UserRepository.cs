using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Application.Users;
using User.Domain.Entities;

namespace User.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        public void CreateUser(UserEntity user)
        {
            throw new NotImplementedException();
        }

        public object GetUserEntities()
        {
            throw new NotImplementedException();
        }

        public List<UserEntity> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
