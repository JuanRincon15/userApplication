using userApplication.Domain;

namespace userApplication.Application.ports.output
{
    public interface CountryPersistencePort
    {
        public Country saveCountryBD(Country country);
        
    }
}
