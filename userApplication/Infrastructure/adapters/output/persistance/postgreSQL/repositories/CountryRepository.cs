using Npgsql;
using userApplication.Domain;

namespace userApplication.Infrastructure.adapters.output.persistance.postgreSQL.repositories
{
    public class CountryRepository : ICountryRepository
    {
        private readonly string _connectionString;

        public CountryRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("postgreSQLConnection");
        }
        public async Task<int> insertConuntry(Country country)
        {
            try
            {
                await using var connection = new NpgsqlConnection(_connectionString);
                await connection.OpenAsync();

                using var command = new NpgsqlCommand("SELECT insert_country(@p_name)", connection);
                command.Parameters.AddWithValue("p_name", country.name);

                var newCountryId = await command.ExecuteScalarAsync();

                return Convert.ToInt32(newCountryId); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return -1;
            }
        }
    }
}
