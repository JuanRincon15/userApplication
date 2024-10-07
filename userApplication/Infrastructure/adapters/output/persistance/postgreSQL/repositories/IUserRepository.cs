using userApplication.Domain;

namespace userApplication.Infrastructure.adapters.output.persistance.postgreSQL.repositories
{
    public interface IUserRepository
    {
        Task<bool> insertUser(User user);
    }
}
