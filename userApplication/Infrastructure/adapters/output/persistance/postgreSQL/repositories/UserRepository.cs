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

        public Task<bool> insertUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
