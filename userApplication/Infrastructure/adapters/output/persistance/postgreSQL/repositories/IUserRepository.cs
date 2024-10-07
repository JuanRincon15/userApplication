using userApplication.Domain;

namespace userApplication.Infrastructure.adapters.output.persistance.postgreSQL.repositories
{
    public interface IUserRepository
    {
        Task<int> insertUser(User user);
    }
}
