using Npgsql;
using userApplication.Domain;

namespace userApplication.Infrastructure.adapters.output.persistance.postgreSQL.repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public UserRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("postgreSQLConnection");
        }

        public async Task<int> insertUser(User user)
        {
            try
            {
                await using var connection = new NpgsqlConnection(_connectionString);
                await connection.OpenAsync();

                using var command = new NpgsqlCommand("SELECT insert_user(@p_name,@p_phone,@p_address,@m_id);", connection);
                command.Parameters.AddWithValue("p_name", user.name);
                command.Parameters.AddWithValue("p_phone", user.phone);
                command.Parameters.AddWithValue("p_address", user.address);
                command.Parameters.AddWithValue("m_id", user.idMunicipality);

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
