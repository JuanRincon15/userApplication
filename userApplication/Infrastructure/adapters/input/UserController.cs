using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using userApplication.Application.ports.input;
using userApplication.Application.service;
using userApplication.Domain;
using userApplication.Infrastructure.adapters.input.model.request;
using userApplication.Infrastructure.adapters.input.model.response;

namespace userApplication.Infrastructure.adapters.input
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private UserServicePort serviceport;

        public UserController(IMapper mapper, UserServicePort serviceport)
        {
            _mapper = mapper;
            this.serviceport = serviceport;
        }

        [HttpPost("create")]
        public async Task<IActionResult> createUser([FromBody] UserCreateRequest request)
        {
            return StatusCode(201, _mapper.Map<UserCreateResponse>( await serviceport.saveUser(_mapper.Map<User>(request))));

        }
    }
}
