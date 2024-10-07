using AutoMapper;
using userApplication.Domain;
using userApplication.Infrastructure.adapters.input.model.request;
using userApplication.Infrastructure.adapters.input.model.response;

namespace userApplication.Infrastructure.adapters.input.mapper
{
    public class CountryMapper : Profile
    {
        public CountryMapper() 
        {
            CreateMap<CountryCreateRequest, Country>();
            CreateMap<Country, CountryCreateResponse>();
        }
    }
}
