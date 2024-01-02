using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Application.Role;
using User.Domain.Entities;

namespace User.Application.UserRole
{
    public class UserRoleService : IUsersRoleService
    {
        public readonly IUsersRoleService _usersRoleRepository;
        public UserRoleService(IUsersRoleService usersRoleRepository)
        {
            _usersRoleRepository = usersRoleRepository;
        }

        public UsersRoleEntity CreateUsersRole(UsersRoleEntity usersRole)
        {
            _usersRoleRepository.CreateUsersRole(usersRole);
            return usersRole;
        }

        public List<UsersRoleEntity> GetAllUsersRoles()
        {
            throw new NotImplementedException();
        }

        public List<RoleEntity> GetUsersRoleEntities()
        {
            var usersRoles = _usersRoleRepository.GetUsersRoleEntities();
            return usersRoles;
        }

        void IUsersRoleService.CreateUsersRole(UsersRoleEntity usersRole)
        {
            throw new NotImplementedException();
        }
    }
}
