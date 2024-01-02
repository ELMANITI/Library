using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain.Entities;

namespace User.Application.Role
{
    public class RoleSerevice : IRoleService
    {
        public readonly IRoleRepository _roleRepository;
        //Constructor Dependency Injection
        public RoleSerevice(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public RoleEntity CreateRole(RoleEntity role)
        {
            _roleRepository.CreateRole(role);
            return role;
        }

        public List<RoleEntity> GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public List<RoleEntity> GetRoleEntities()
        {
            var roles = _roleRepository.GetRoleEntities();
            return roles;
        }

    }
}
