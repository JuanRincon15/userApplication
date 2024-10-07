using userApplication.Domain;

namespace userApplication.Application.ports.output
{
    public interface MunicipalityPersistencePort
    {
        public Task<Municipality> saveMunicipalityDB(Municipality municipality);
    }
}
