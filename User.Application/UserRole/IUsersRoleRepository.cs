using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain.Entities;

namespace User.Application.UserRole
{
    public interface IUsersRoleRepository
    {
        List<UsersRoleEntity> GetUsersRoleEntities();
        List<UsersRoleEntity> GetUsersRoles();
    }
}
