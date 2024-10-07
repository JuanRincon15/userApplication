using Microsoft.Extensions.Configuration;
using Npgsql;
using userApplication.Domain;

namespace userApplication.Infrastructure.adapters.output.persistance.postgreSQL.repositories
{
    public class MunicipalityRepository : IMunicipalityRepository
    {
        private readonly string _connectionString;

        public MunicipalityRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("postgreSQLConnection"); ;
        }

        public async Task<int> insertMunicipality(Municipality municipality)
        {
            try
            {
                await using var connection = new NpgsqlConnection(_connectionString);
                await connection.OpenAsync();

                using var command = new NpgsqlCommand("SELECT insert_municipality(@p_name,@d_id);", connection);
                command.Parameters.AddWithValue("p_name", municipality.name);
                command.Parameters.AddWithValue("d_id", municipality.idepartment);

                var newDepartmentId = await command.ExecuteScalarAsync();

                return Convert.ToInt32(newDepartmentId);
            }
            catch (Exception ex) {
                Console.WriteLine($"Error: {ex.Message}");
                return -1;
            }
        }
    }
}
