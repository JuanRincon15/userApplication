using userApplication.Domain;

namespace userApplication.Application.ports.input
{
    public interface MunicipalityServicePort
    {
        Task<Municipality> saveMunicipality(Municipality municipality);
    }
}
