using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Application.Role;
using User.Domain.Entities;

namespace User.Infrastructure
{
    public class RoleRepository : IRoleRepository
    {
        private readonly DBC _roleDBC;
        public RoleRepository(DBC roleDBC)
        {
            _roleDBC = roleDBC;
        }

        public RoleEntity CreateRole (RoleEntity role)
        {
            _roleDBC.Roles.Add (role);
            _roleDBC.SaveChanges();
            return role;
        }

        public List<RoleEntity> GetRoleEntities()
        {
            throw new NotImplementedException();
        }

        public List<RoleEntity> GetRoles()
        {
           return _roleDBC.Roles.ToList();
        }

        void IRoleRepository.CreateRole(RoleEntity role)
        {
            throw new NotImplementedException();
        }
    };
       
       
        
    
}
