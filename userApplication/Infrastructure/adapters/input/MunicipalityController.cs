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
    public class MunicipalityController : ControllerBase
    {
        private readonly IMapper _mapper;
        private MunicipalityServicePort _port;

        public MunicipalityController(IMapper mapper, MunicipalityServicePort port)
        {
            _mapper = mapper;
            _port = port;
        }
        [HttpPost("create")]
        public async Task<IActionResult> createMunicipality([FromBody] MunicipalityCreateRequest request)
        {
            return StatusCode(201, _mapper.Map<MunicipalityCreateResponse>(await _port.saveMunicipality(_mapper.Map<Municipality>(request))));
        }
    }
}
