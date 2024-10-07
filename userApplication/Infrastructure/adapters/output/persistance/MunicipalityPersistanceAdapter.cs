using userApplication.Application.ports.output;
using userApplication.Domain;
using userApplication.Infrastructure.adapters.output.persistance.postgreSQL.repositories;

namespace userApplication.Infrastructure.adapters.output.persistance
{
    public class MunicipalityPersistanceAdapter:MunicipalityPersistencePort
    {
        private IMunicipalityRepository repository;

        public MunicipalityPersistanceAdapter(IMunicipalityRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Municipality> saveMunicipalityDB(Municipality municipality)
        {
            int id = await repository.insertMunicipality(municipality);
            municipality.id = id;
            return municipality;
        }
    }
}
