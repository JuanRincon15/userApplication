using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using userApplication.Application.ports.input;
using userApplication.Domain;
using userApplication.Infrastructure.adapters.input.model.request;
using userApplication.Infrastructure.adapters.input.model.response;

namespace userApplication.Infrastructure.adapters.input
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IMapper _mapper;
        private DepartmentServicePort _serviceport;

        public DepartmentController(IMapper mapper, DepartmentServicePort serviceport)
        {
            _mapper = mapper;
            _serviceport = serviceport;
        }

        [HttpPost("create")]
        public async Task<IActionResult> createdepartment([FromBody] DepartmentCreateRequest request)
        {
            return StatusCode(201, _mapper.Map<DepartmentCreateResponse>(await _serviceport.saveDepartment(_mapper.Map<Department>(request))));
        }
    }
}
