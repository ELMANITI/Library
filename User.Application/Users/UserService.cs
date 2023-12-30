using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Application.Role;
using User.Domain.Entities;

namespace User.Application.Users
{
    public class UserService: IUserService
    {
        public readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserEntity CreateUser(UserEntity user)
        {
            _userRepository.CreateUser(user);
            return user;
        }

        public List<UserEntity> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public List<UserEntity> GetUserEntities()
        {
            var users = _userRepository.GetUserEntities();
            return (List<UserEntity>)users;
        }


    }
}
