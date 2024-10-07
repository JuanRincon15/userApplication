using userApplication.Application.ports.input;
using userApplication.Application.ports.output;
using userApplication.Domain;

namespace userApplication.Application.service
{
    public class MunicipalityService : MunicipalityServicePort
    {
        private MunicipalityPersistencePort persistenceport;

        public MunicipalityService(MunicipalityPersistencePort persistenceport)
        {
            this.persistenceport = persistenceport;
        }

        public Task<Municipality> saveMunicipality(Municipality municipality)
        {
            return persistenceport.saveMunicipalityDB(municipality);
        }
    }
}
