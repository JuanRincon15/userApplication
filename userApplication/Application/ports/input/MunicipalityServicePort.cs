using userApplication.Domain;

namespace userApplication.Application.ports.input
{
    public interface MunicipalityServicePort
    {
        Municipality saveMunicipality(Municipality municipality);
    }
}
