using userApplication.Domain;

namespace userApplication.Application.ports.output
{
    public interface MunicipalityPersistencePort
    {
        public Municipality saveMunicipalityDB(Municipality municipality);
    }
}
