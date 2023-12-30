using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Application.Role;
using User.Application.Users;
using User.Domain.Entities;

namespace User.Application.UserRole
{
    public class GetUsersRoleHandler : IRequestHandler<GetUsersRoleQuery, List<UsersRoleEntity>>
    {
        private readonly IUsersRoleRepository _usersRoleRepository;
        public GetUsersRoleHandler(IUsersRoleRepository usersRoleRepository)
        {
            _usersRoleRepository = usersRoleRepository;
        }
        public Task<List<UsersRoleEntity>> Handle(GetUsersRoleQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_usersRoleRepository.GetUsersRoleEntities());
        }
    }
}
