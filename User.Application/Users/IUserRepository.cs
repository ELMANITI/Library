using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain.Entities;

namespace User.Application.Users
{
    public interface IUserRepository 
    {
        void CreateUser(UserEntity user);
        object GetUserEntities();
        List<UserEntity> GetUsers();
    }
}
