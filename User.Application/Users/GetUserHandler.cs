using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Application.UserRole;
using User.Domain;
using User.Domain.Entities;

namespace User.Application.Users
{
    public class GetUserHandler : IRequestHandler<GetUserQuery, List<UserEntity>>
    {
        private readonly IUserRepository _userRepository;
        public GetUserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<List<UserEntity>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        /* public Task<List<UserEntity>> Handle(GetUserQuery request, CancellationToken cancellationToken)
{
   return Task.FromResult(_userRepository.GetUserEntities());
}*/
    }
}
