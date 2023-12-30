using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Application.Users;
using User.Domain.Entities;

namespace User.Application.Role
{
    public class GetRoleHandler : IRequestHandler<GetRoleQuery, List<RoleEntity>>
    {
        private readonly IRoleRepository _roleRepository;
        public GetRoleHandler(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public Task<List<RoleEntity>> Handle(GetRoleQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_roleRepository.GetRoleEntities());
        }
    }
}
