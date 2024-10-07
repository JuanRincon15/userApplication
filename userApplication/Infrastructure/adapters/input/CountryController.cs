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
    public class CountryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private CountyServicePort serviceport;

        public CountryController(IMapper mapper, CountyServicePort serviceport)
        {
            _mapper = mapper;
            this.serviceport = serviceport;
        }

        [HttpPost("create")]
        public async Task<IActionResult> createcountry([FromBody] CountryCreateRequest request)
        {
            return StatusCode(201,_mapper.Map<CountryCreateResponse>( await serviceport.saveCountry(_mapper.Map<Country>(request))));
        }

    }
}
