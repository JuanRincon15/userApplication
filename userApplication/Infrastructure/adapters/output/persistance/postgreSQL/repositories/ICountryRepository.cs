using userApplication.Domain;

namespace userApplication.Infrastructure.adapters.output.persistance.postgreSQL.repositories
{
    public interface ICountryRepository
    {
        Task<int> insertConuntry(Country country);
    }
}
