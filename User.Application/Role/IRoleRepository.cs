using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain.Entities;

namespace User.Application.Role
{
    public interface IRoleRepository
    {

        void CreateRole(RoleEntity role);
        List<RoleEntity> GetRoleEntities();


    }
    
}
