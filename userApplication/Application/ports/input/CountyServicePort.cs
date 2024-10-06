using userApplication.Domain;

namespace userApplication.Application.ports.input
{
    public interface CountyServicePort
    {
        public Country saveCountry(Country country);
    }
}
