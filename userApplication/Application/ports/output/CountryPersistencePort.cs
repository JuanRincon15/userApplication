using userApplication.Domain;

namespace userApplication.Application.ports.output
{
    public interface CountryPersistencePort
    {
        public Task<Country> saveCountryBD(Country country);
        
    }
}
