using userApplication.Application.ports.input;
using userApplication.Application.ports.output;
using userApplication.Domain;

namespace userApplication.Application.service
{
    public class countryService : CountyServicePort
    {
        CountryPersistencePort persistenceport { get; set; }

        public countryService(CountryPersistencePort persistenceport)
        {
            this.persistenceport = persistenceport;
        }

        public async Task<Country> saveCountry(Country country)
        {
            return await persistenceport.saveCountryBD(country);
        }
    }
}
