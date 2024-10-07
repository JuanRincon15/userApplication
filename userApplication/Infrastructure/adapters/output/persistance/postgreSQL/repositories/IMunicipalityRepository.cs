using userApplication.Domain;

namespace userApplication.Infrastructure.adapters.output.persistance.postgreSQL.repositories
{
    public interface IMunicipalityRepository
    {
        Task<int> insertMunicipality(Municipality municipality);
    }
}
