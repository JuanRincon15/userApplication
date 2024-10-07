using AutoMapper;
using userApplication.Domain;
using userApplication.Infrastructure.adapters.input.model.request;
using userApplication.Infrastructure.adapters.input.model.response;

namespace userApplication.Infrastructure.adapters.input.mapper
{
    public class DepartmentMapper : Profile
    {
        
        public DepartmentMapper()
        {
            CreateMap<DepartmentCreateRequest, Department>();
            CreateMap<Department, DepartmentCreateResponse>();
        }    
    }
}
