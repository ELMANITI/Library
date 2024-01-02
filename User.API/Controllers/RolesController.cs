using MediatR;
using Microsoft.AspNetCore.Mvc;
using User.Application.Role;
using User.Domain.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace User.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RolesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<RolesRepository>
        [HttpGet]
        public async Task<List<RoleEntity>> Get()
        {
            return await _mediator.Send(new GetRoleQuery());
        }
        

        // GET api/<RolesRepository>/5
        [HttpGet("{id}")]
        public async Task<List<RoleEntity>> Get(int id)
        {
            return await _mediator.Send(new GetRoleQuery());
        }
        

      

        // PUT api/<RolesRepository>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RolesRepository>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
