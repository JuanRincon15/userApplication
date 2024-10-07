using userApplication.Application.ports.output;
using userApplication.Domain;
using userApplication.Infrastructure.adapters.output.persistance.postgreSQL.repositories;

namespace userApplication.Infrastructure.adapters.output.persistance
{
    public class CountryPersistanceAdapter : CountryPersistencePort
    {
        private ICountryRepository countryrepository;

        public CountryPersistanceAdapter(ICountryRepository countryrepository)
        {
            this.countryrepository = countryrepository;
        }

        public async Task<Country> saveCountryBD(Country country)
        {
            int id = await countryrepository.insertConuntry(country);
            country.id = id;
            return country;
        }
    }
}
