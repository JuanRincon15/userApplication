using userApplication.Domain;

namespace userApplication.Application.ports.input
{
    public interface CountyServicePort
    {
        public Task<Country> saveCountry(Country country);
    }
}
