using Npgsql;
using System.Diagnostics.Metrics;
using userApplication.Domain;

namespace userApplication.Infrastructure.adapters.output.persistance.postgreSQL.repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly string _connectionString;

        public DepartmentRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("postgreSQLConnection");
        }
        public async Task<int> insertdepartment(Department department)
        {
            try
            {
                await using var connection = new NpgsqlConnection(_connectionString);
                await connection.OpenAsync();

                using var command = new NpgsqlCommand("SELECT insert_department(@p_name,@c_id);", connection);
                Console.WriteLine(department.country);
                command.Parameters.AddWithValue("p_name", department.name);
                command.Parameters.AddWithValue("c_id", department.country);
                
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
