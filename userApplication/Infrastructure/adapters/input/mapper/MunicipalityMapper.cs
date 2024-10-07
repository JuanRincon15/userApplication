using AutoMapper;
using userApplication.Domain;
using userApplication.Infrastructure.adapters.input.model.request;
using userApplication.Infrastructure.adapters.input.model.response;

namespace userApplication.Infrastructure.adapters.input.mapper
{
    public class MunicipalityMapper: Profile
    {
        public MunicipalityMapper() {
            CreateMap<MunicipalityCreateRequest, Municipality>();
            CreateMap<Municipality, MunicipalityCreateResponse>();
        }
    }
}
